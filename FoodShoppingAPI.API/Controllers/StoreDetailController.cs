using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.Entity.Result;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using FoodShoppingAPI.Entity.DTO.StoreDetailDTO;
using FoodShoppingAPI.Entity.Poco;
using FoodShoppingAPI.Entity.DTO.StoreProductDTO;
using FoodShoppingAPI.Entity.DTO.FoodDetailDTO;

namespace FoodShoppingAPI.API.Controllers
{
    [ApiController]
    [Route("FoodShoppingAPI/[action]")]
    public class StoreDetailController : Controller
    {

        private readonly IStoreDetailService _storeDetailService;
        private readonly IMapper _mapper;
        private readonly IStoreCategoryService _storeCategoryService;


        public StoreDetailController(IStoreDetailService storeDetailService, IMapper mapper, IStoreCategoryService storeCategoryService)
        {
            _storeDetailService = storeDetailService;
            _mapper = mapper;
            _storeCategoryService = storeCategoryService;
        }


        [HttpGet("/StoreDetail")]
        [ProducesResponseType(typeof(Sonuç<List<StoreDetailDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllStoreDetail()
        {
            var storeDetails = await _storeDetailService.GetAllAsync(q => q.IsActive == true && q.IsDeleted == false, "StoreCategory");
            if (storeDetails != null)
            {
                List<StoreDetailDTOResponse> storeDetailDtoResponseList = new List<StoreDetailDTOResponse>();
                foreach (var storeDetail in storeDetails)
                {
                    storeDetailDtoResponseList.Add(_mapper.Map<StoreDetailDTOResponse>(storeDetail));
                }


                return Ok(Sonuç<List<StoreDetailDTOResponse>>.SuccessWithData(storeDetailDtoResponseList));
            }
            else
            {
                return NotFound(Sonuç<List<StoreDetailDTOResponse>>.SuccessNoDataFound());

            }

        }


        [HttpGet("/StoreDetail/{guid}")]
        [ProducesResponseType(typeof(Sonuç<List<StoreDetailDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetStoreDetailByGUID(Guid guid)
        {
            var storeDetail = await _storeDetailService.GetAsync(q => q.Guid == guid, "StoreCategory");
            if (storeDetail != null)
            {
                StoreDetailDTOResponse storeDetailDtoResponse = _mapper.Map<StoreDetailDTOResponse>(storeDetail);


                return Ok(Sonuç<StoreDetailDTOResponse>.SuccessWithData(storeDetailDtoResponse));
            }
            else
            {
                return NotFound(Sonuç<List<StoreDetailDTOResponse>>.SuccessNoDataFound());

            }

        }




        [HttpPost("/AddStoreDetail")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddStoreDetail(StoreDetailDTORequest storeDetailDTORequest)
        {
            var storeCategory = await _storeCategoryService.GetAsync(q => q.Guid == storeDetailDTORequest.StoreCategoryGuid);



            StoreDetail storeDetail = _mapper.Map<StoreDetail>(storeDetailDTORequest);
            storeDetail.StoreCategory = storeCategory;


            await _storeDetailService.AddAsync(storeDetail);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }


        [HttpPost("/UpdateStoreDetail")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateStoreDetail(StoreDetailDTOUpdateResponse storeDetailDTOUpdateResponse)
        {

            StoreDetail storeDetail = await _storeDetailService.GetAsync(q => q.Guid == storeDetailDTOUpdateResponse.Guid);

            var storeCategory = await _storeCategoryService.GetAsync(q => q.Name == storeDetailDTOUpdateResponse.StoreCategoryName);


            _mapper.Map<StoreDetail>(storeDetailDTOUpdateResponse);

            
            await _storeDetailService.UpdateAsync(storeDetail);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }

        

        [HttpPost("/RemoveStoreDetail/{storeDetailGuid}")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> RemoveStoreDetail(Guid storeDetailGuid)
        {
            StoreDetail storeDetail = await _storeDetailService.GetAsync(q => q.Guid == storeDetailGuid);

            storeDetail.IsActive = false;
            storeDetail.IsDeleted = true;
            await _storeDetailService.UpdateAsync(storeDetail);
            return Ok(Sonuç<bool>.SuccessWithData(true));
        }
       


    }
}
