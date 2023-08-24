using AutoMapper;
using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.Entity.DTO.OrderDTO;
using FoodShoppingAPI.Entity.Poco;
using FoodShoppingAPI.Entity.Result;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FoodShoppingAPI.API.Controllers
{
    [ApiController]
    [Route("FoodShoppingAPI/[action]")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IFoodDetailService _foodDetailService;

        public OrderController(IOrderService orderService, IMapper mapper, IUserService userService, IFoodDetailService foodDetailService)
        {
            _orderService = orderService;
            _mapper = mapper;
            _userService = userService;
            _foodDetailService = foodDetailService;
        }

        

        [HttpGet("/Orders")]
        [ProducesResponseType(typeof(Sonuç<List<OrderDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetOrders()
        {
            var orders = await _orderService.GetAllAsync(q => q.IsActive == true && q.IsDeleted == false, "User", "FoodDetail");
            if (orders != null)
            {
                List<OrderDTOResponse> orderDtoResponseList = new List<OrderDTOResponse>();
                foreach (var order in orders)
                {
                    orderDtoResponseList.Add(_mapper.Map<OrderDTOResponse>(order));
                }


                return Ok(Sonuç<List<OrderDTOResponse>>.SuccessWithData(orderDtoResponseList));
            }
            else
            {
                return NotFound(Sonuç<List<OrderDTOResponse>>.SuccessNoDataFound());

            }

        }


        [HttpGet("/Order/{guid}")]
        [ProducesResponseType(typeof(Sonuç<List<OrderDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetOrderByGUID(Guid guid)
        {
            var order = await _orderService.GetAsync(q => q.Guid == guid, "User", "FoodDetail");
            if (order != null)
            {
                OrderDTOResponse orderDtoResponse = _mapper.Map<OrderDTOResponse>(order);


                return Ok(Sonuç<OrderDTOResponse>.SuccessWithData(orderDtoResponse));
            }
            else
            {
                return NotFound(Sonuç<List<OrderDTOResponse>>.SuccessNoDataFound());

            }

        }




        [HttpPost("/AddOrder")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddOrder(OrderDTORequest orderDTORequest)
        {
            var user = await _userService.GetAsync(q => q.Guid == orderDTORequest.UserGuid);
            var foodDetail = await _foodDetailService.GetAsync(q => q.Guid == orderDTORequest.FoodDetailGuid);



            Order order = _mapper.Map<Order>(orderDTORequest);
            order.User = user;
            order.FoodDetail = foodDetail;


            await _orderService.AddAsync(order);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }


        [HttpPost("/UpdateOrder")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateOrder(OrderDTOUpdateResponse orderDTOUpdateResponse)
        {

            Order order = await _orderService.GetAsync(q => q.Guid == orderDTOUpdateResponse.Guid);

            var user = await _userService.GetAsync(q => q.Username == orderDTOUpdateResponse.UserName);
            var foodDetail = await _foodDetailService.GetAsync(q => q.Name == orderDTOUpdateResponse.FoodDetailName);


            order.User = user;
            order.FoodDetail = foodDetail;

            order.IsActive = orderDTOUpdateResponse.IsActive != null ? orderDTOUpdateResponse.IsActive : order.IsActive;

            await _orderService.UpdateAsync(order);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }



        [HttpPost("/RemoveOrder/{orderGuid}")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> RemoveOrder(Guid orderGuid)
        {
            Order order = await _orderService.GetAsync(q => q.Guid == orderGuid);

            order.IsActive = false;
            order.IsDeleted = true;
            await _orderService.UpdateAsync(order);
            return Ok(Sonuç<bool>.SuccessWithData(true));
        }


    }
}
