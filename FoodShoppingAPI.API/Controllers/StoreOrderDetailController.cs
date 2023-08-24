using AutoMapper;
using FoodShoppingAPI.Business.Abstract;
using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.DAL.Abstract;
using FoodShoppingAPI.Entity.DTO.ProductDTO;
using FoodShoppingAPI.Entity.DTO.StoreOrderDetailDTO;
using FoodShoppingAPI.Entity.Poco;
using FoodShoppingAPI.Entity.Result;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FoodShoppingAPI.API.Controllers
{
    [ApiController]
    [Route("FoodShoppingAPI/[action]")]
    public class StoreOrderDetailController : Controller
    {

        private readonly IMapper _mapper;
        private readonly IStoreOrderDetailService _storeOrderDetailService;
        private readonly IStoreOrderService _storeOrderService;

        public StoreOrderDetailController(IStoreOrderDetailService storeOrderDetailService, IMapper mapper, IStoreOrderService storeOrderService)
        {
            _storeOrderDetailService = storeOrderDetailService;
            _mapper = mapper;
            _storeOrderService = storeOrderService;
        }






        [HttpGet("/StoreOrderDetails")]
        [ProducesResponseType(typeof(Sonuç<List<StoreOrderDetailDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetStoreOrderDetails()
        {
            var storeOrderDetails = await _storeOrderDetailService.GetAllAsync(q => q.IsActive == true && q.IsDeleted == false, "StoreOrder");
            if (storeOrderDetails != null)
            {
                List<StoreOrderDetailDTOResponse> storeOrderDetailDtoResponseList = new List<StoreOrderDetailDTOResponse>();
                foreach (var storeOrderDetail in storeOrderDetails)
                {
                    storeOrderDetailDtoResponseList.Add(_mapper.Map<StoreOrderDetailDTOResponse>(storeOrderDetail));
                }


                return Ok(Sonuç<List<StoreOrderDetailDTOResponse>>.SuccessWithData(storeOrderDetailDtoResponseList));
            }
            else
            {
                return NotFound(Sonuç<List<StoreOrderDetailDTOResponse>>.SuccessNoDataFound());

            }

        }


        [HttpGet("/StoreOrderDetail/{guid}")]
        [ProducesResponseType(typeof(Sonuç<List<StoreOrderDetailDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetStoreOrderDetailByGUID(Guid guid)
        {
            var storeOrderDetail = await _storeOrderDetailService.GetAsync(q => q.Guid == guid, "StoreOrder");
            if (storeOrderDetail != null)
            {
                StoreOrderDetailDTOResponse storeOrderDetailDtoResponse = _mapper.Map<StoreOrderDetailDTOResponse>(storeOrderDetail);


                return Ok(Sonuç<StoreOrderDetailDTOResponse>.SuccessWithData(storeOrderDetailDtoResponse));
            }
            else
            {
                return NotFound(Sonuç<List<StoreOrderDetailDTOResponse>>.SuccessNoDataFound());

            }

        }




        [HttpPost("/AddStoreOrderDetail")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddStoreOrderDetail(StoreOrderDetailDTORequest storeOrderDetailDTORequest)
        {
            var storeOrder = await _storeOrderService.GetAsync(q => q.Guid == storeOrderDetailDTORequest.StoreOrderGuid);


            StoreOrderDetail storeOrderDetail = _mapper.Map<StoreOrderDetail>(storeOrderDetailDTORequest);
            storeOrderDetail.StoreOrder = storeOrder;



            await _storeOrderDetailService.AddAsync(storeOrderDetail);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }



        [HttpPost("/UpdateStoreOrderDetail")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateStoreOrderDetail(StoreOrderDetailDTOUpdateResponse storeOrderDetailDTOUpdateResponse)
        {

            StoreOrderDetail storeOrderDetail = await _storeOrderDetailService.GetAsync(q => q.Guid == storeOrderDetailDTOUpdateResponse.Guid);

            var storeOrder = await _storeOrderDetailService.GetAsync(q => q.Guid == storeOrderDetailDTOUpdateResponse.StoreOrderGuid);

            _mapper.Map<StoreOrderDetail>(storeOrderDetailDTOUpdateResponse);



            await _storeOrderDetailService.UpdateAsync(storeOrderDetail);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }



        [HttpPost("/RemoveStoreOrderDetail/{storeOrderDetailGuid}")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> RemoveStoreOrderDetail(Guid storeOrderDetailGuid)
        {
            StoreOrderDetail storeOrderDetail = await _storeOrderDetailService.GetAsync(q => q.Guid == storeOrderDetailGuid);

            storeOrderDetail.IsActive = false;
            storeOrderDetail.IsDeleted = true;
            await _storeOrderDetailService.UpdateAsync(storeOrderDetail);
            return Ok(Sonuç<bool>.SuccessWithData(true));
        }


    }
}
