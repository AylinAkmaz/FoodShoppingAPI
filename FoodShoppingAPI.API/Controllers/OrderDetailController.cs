using AutoMapper;
using FoodShoppingAPI.Business.Abstract;
using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.Entity.DTO.OrderDetailDTO;
using FoodShoppingAPI.Entity.DTO.StoreOrderDetailDTO;
using FoodShoppingAPI.Entity.Poco;
using FoodShoppingAPI.Entity.Result;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FoodShoppingAPI.API.Controllers
{
    [ApiController]
    [Route("FoodShoppingAPI/[action]")]
    public class OrderDetailController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IOrderService _orderService;

        public OrderDetailController(IMapper mapper, IOrderDetailService orderDetailService, IOrderService orderService)
        {

            _mapper = mapper;
            _orderDetailService = orderDetailService;
            _orderService = orderService;
        }






        [HttpGet("/OrderDetails")]
        [ProducesResponseType(typeof(Sonuç<List<OrderDetailDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetOrderDetails()
        {
            var orderDetails = await _orderDetailService.GetAllAsync(q => q.IsActive == true && q.IsDeleted == false, "Order");
            if (orderDetails != null)
            {
                List<OrderDetailDTOResponse> orderDetailDtoResponseList = new List<OrderDetailDTOResponse>();
                foreach (var orderDetail in orderDetails)
                {
                    orderDetailDtoResponseList.Add(_mapper.Map<OrderDetailDTOResponse>(orderDetail));
                }


                return Ok(Sonuç<List<OrderDetailDTOResponse>>.SuccessWithData(orderDetailDtoResponseList));
            }
            else
            {
                return NotFound(Sonuç<List<OrderDetailDTOResponse>>.SuccessNoDataFound());

            }

        }


        [HttpGet("/OrderDetail/{guid}")]
        [ProducesResponseType(typeof(Sonuç<List<OrderDetailDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetOrderDetailByGUID(Guid guid)
        {
            var orderDetail = await _orderDetailService.GetAsync(q => q.Guid == guid, "Order");
            if (orderDetail != null)
            {
                OrderDetailDTOResponse orderDetailDtoResponse = _mapper.Map<OrderDetailDTOResponse>(orderDetail);


                return Ok(Sonuç<OrderDetailDTOResponse>.SuccessWithData(orderDetailDtoResponse));
            }
            else
            {
                return NotFound(Sonuç<List<OrderDetailDTOResponse>>.SuccessNoDataFound());

            }

        }




        [HttpPost("/AddOrderDetail")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddOrderDetail(OrderDetailDTORequest orderDetailDTORequest)
        {
            var order = await _orderService.GetAsync(q => q.Guid == orderDetailDTORequest.OrderGuid);


            OrderDetail orderDetail = _mapper.Map<OrderDetail>(orderDetailDTORequest);
            orderDetail.Order = order;



            await _orderDetailService.AddAsync(orderDetail);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }



        [HttpPost("/UpdateOrderDetail")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateOrderDetail(OrderDetailDTOUpdateResponse orderDetailDTOUpdateResponse)
        {

            OrderDetail orderDetail = await _orderDetailService.GetAsync(q => q.Guid == orderDetailDTOUpdateResponse.Guid);

            var order = await _orderDetailService.GetAsync(q => q.Guid == orderDetailDTOUpdateResponse.OrderGuid);

            _mapper.Map<OrderDetail>(orderDetailDTOUpdateResponse);



            await _orderDetailService.UpdateAsync(orderDetail);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }



        [HttpPost("/RemoveOrderDetail/{orderDetailGuid}")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> RemoveOrderDetail(Guid orderDetailGuid)
        {
            OrderDetail orderDetail = await _orderDetailService.GetAsync(q => q.Guid == orderDetailGuid);

            orderDetail.IsActive = false;
            orderDetail.IsDeleted = true;
            await _orderDetailService.UpdateAsync(orderDetail);
            return Ok(Sonuç<bool>.SuccessWithData(true));
        }

    }
}
