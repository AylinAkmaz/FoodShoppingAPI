using AutoMapper;
using FoodShoppingAPI.API.Validation.FluentValidation;
using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.Entity.Poco;
using FoodShoppingAPI.Entity.Result;
using FoodShoppingAPI.Helper.CustomException;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using FoodShoppingAPI.Entity.DTO.StoreProductDTO;
using FoodShoppingAPI.Entity.DTO.UserDTO;
using FoodShoppingAPI.Entity.DTO.StoreDetailDTO;

namespace FoodShoppingAPI.API.Controllers
{
    [ApiController]
    [Route("FoodShoppingAPI/[action]")]
    public class StoreProductController : Controller
    {
        private readonly IStoreProductService _storeProductService;
        private readonly IStoreDetailService _storeDetailService;
        private readonly IMapper _mapper;




        public StoreProductController(IStoreProductService storeProductService, IMapper mapper, IStoreDetailService storeDetailService)
        {
            _storeProductService = storeProductService;
            _mapper = mapper;
            _storeDetailService = storeDetailService;
        }
       
        [HttpGet("/StoreProducts")]
        [ProducesResponseType(typeof(Sonuç<List<StoreProductDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllStoreProducts()
        {
            var storeProducts = await _storeProductService.GetAllAsync(q => q.IsActive == true && q.IsDeleted == false, "StoreDetail");

            if (storeProducts != null)
            {
                List<StoreProductDTOResponse> storeProductDtoResponseList = new List<StoreProductDTOResponse>();
                foreach (var storeProduct in storeProducts)
                {
                    storeProductDtoResponseList.Add(_mapper.Map<StoreProductDTOResponse>(storeProduct));
                }


                return Ok(Sonuç<List<StoreProductDTOResponse>>.SuccessWithData(storeProductDtoResponseList));
            }
            else
            {
                return NotFound(Sonuç<List<StoreProductDTOResponse>>.SuccessNoDataFound());

            }
        }



        [HttpGet("/StoreProduct/{guid}")]
        [ProducesResponseType(typeof(Sonuç<List<StoreProductDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetStoreProductByGUID(Guid guid)
        {
            var storeProduct = await _storeProductService.GetAsync(q => q.Guid == guid, "StoreDetail");
            if (storeProduct != null)
            {
                StoreProductDTOResponse storeProductDtoResponse = _mapper.Map<StoreProductDTOResponse>(storeProduct);


                return Ok(Sonuç<StoreProductDTOResponse>.SuccessWithData(storeProductDtoResponse));
            }
            else
            {
                return NotFound(Sonuç<List<StoreProductDTOResponse>>.SuccessNoDataFound());

            }

        }

        [HttpPost("/AddStoreProduct")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddStoreProduct(StoreProductDTORequest storeProductDTORequest)
        {
            var storeDetail = await _storeDetailService.GetAsync(q => q.Guid == storeProductDTORequest.StoreDetailGuid);



            StoreProduct storeProduct = _mapper.Map<StoreProduct>(storeProductDTORequest);
            storeProduct.StoreDetail = storeDetail;


            await _storeProductService.AddAsync(storeProduct);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }


        [HttpPost("/UpdateStoreProduct")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateStoreProduct(StoreProductUpdateDTOResponse storeProductUpdateDTOResponse)
        {

            StoreProduct storeProduct = await _storeProductService.GetAsync(q => q.Guid == storeProductUpdateDTOResponse.Guid);

            var storeDetail = await _storeDetailService.GetAsync(q => q.Guid == storeProductUpdateDTOResponse.StoreDetailGuid);


            _mapper.Map<StoreProduct>(storeProductUpdateDTOResponse);


            await _storeProductService.UpdateAsync(storeProduct);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }



        [HttpPost("/RemoveStoreProduct/{StoreProductGuid}")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> RemoveStoreProduct(Guid StoreProductGuid)

        {

            StoreProduct storeProduct = await _storeProductService.GetAsync(q => q.Guid == StoreProductGuid);

            storeProduct.IsActive = false;
            storeProduct.IsDeleted = true;

            await _storeProductService.UpdateAsync(storeProduct);

            return Ok(Sonuç<bool>.SuccessWithData(true));

        }


    }
}

