using AutoMapper;
using FoodShoppingAPI.Business.Abstract;
using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.Entity.DTO.FoodDetailDTO;
using FoodShoppingAPI.Entity.DTO.StoreOrderDTO;
using FoodShoppingAPI.Entity.Poco;
using FoodShoppingAPI.Entity.Result;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FoodShoppingAPI.API.Controllers
{
    [ApiController]
    [Route("FoodShoppingAPI/[action]")]
    public class StoreOrderController : Controller
    {

        private readonly IStoreOrderService _storeOrderService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IStoreProductService _storeProductService;

        public StoreOrderController(IStoreProductService storeProductService, IUserService userService, IMapper mapper, IStoreOrderService storeOrderService)
        {
            _storeProductService = storeProductService;
            _userService = userService;
            _mapper = mapper;
            _storeOrderService = storeOrderService;
        }

        [HttpGet("/StoreOrders")]
        [ProducesResponseType(typeof(Sonuç<List<StoreOrderDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetStoreOrders()
        {
            var storeOrders = await _storeOrderService.GetAllAsync(q => q.IsActive == true && q.IsDeleted == false, "User", "StoreProduct");
            if (storeOrders != null)
            {
                List<StoreOrderDTOResponse> storeOrderDtoResponseList = new List<StoreOrderDTOResponse>();
                foreach (var storeOrder in storeOrders)
                {
                    storeOrderDtoResponseList.Add(_mapper.Map<StoreOrderDTOResponse>(storeOrder));
                }


                return Ok(Sonuç<List<StoreOrderDTOResponse>>.SuccessWithData(storeOrderDtoResponseList));
            }
            else
            {
                return NotFound(Sonuç<List<StoreOrderDTOResponse>>.SuccessNoDataFound());

            }

        }


        [HttpGet("/StoreOrder/{guid}")]
        [ProducesResponseType(typeof(Sonuç<List<StoreOrderDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetStoreOrderByGUID(Guid guid)
        {
            var storeOrder = await _storeOrderService.GetAsync(q => q.Guid == guid, "User", "StoreProduct");
            if (storeOrder != null)
            {
                StoreOrderDTOResponse storeOrderDtoResponse = _mapper.Map<StoreOrderDTOResponse>(storeOrder);


                return Ok(Sonuç<StoreOrderDTOResponse>.SuccessWithData(storeOrderDtoResponse));
            }
            else
            {
                return NotFound(Sonuç<List<StoreOrderDTOResponse>>.SuccessNoDataFound());

            }

        }




        [HttpPost("/AddStoreOrder")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddStoreOrder(StoreOrderDTORequest storeOrderDTORequest)
        {
            var user = await _userService.GetAsync(q => q.Guid == storeOrderDTORequest.UserGuid);
            var storeProduct = await _storeProductService.GetAsync(q => q.Guid == storeOrderDTORequest.StoreProductGuid);



            StoreOrder storeOrder = _mapper.Map<StoreOrder>(storeOrderDTORequest);
            storeOrder.User = user;
            storeOrder.StoreProduct = storeProduct;


            await _storeOrderService.AddAsync(storeOrder);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }




        [HttpPost("/UpdateStoreOrder")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateStoreOrder(StoreOrderDTOUpdateResponse storeOrderDTOUpdateResponse)
        {

            StoreOrder storeOrder = await _storeOrderService.GetAsync(q => q.Guid == storeOrderDTOUpdateResponse.Guid);

            var user = await _userService.GetAsync(q => q.Guid == storeOrderDTOUpdateResponse.UserGuid);
            var storeProduct = await _storeProductService.GetAsync(q => q.Guid == storeOrderDTOUpdateResponse.StoreProductGuid);


            _mapper.Map<StoreOrder>(storeOrderDTOUpdateResponse);

            await _storeOrderService.UpdateAsync(storeOrder);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }



        [HttpPost("/RemoveStoreOrder/{storeOrderGuid}")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> RemoveStoreOrder(Guid storeOrderGuid)
        {
            StoreOrder storeOrder = await _storeOrderService.GetAsync(q => q.Guid == storeOrderGuid);

            storeOrder.IsActive = false;
            storeOrder.IsDeleted = true;
            await _storeOrderService.UpdateAsync(storeOrder);
            return Ok(Sonuç<bool>.SuccessWithData(true));
        }

    }
}
