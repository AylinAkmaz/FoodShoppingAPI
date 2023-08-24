using AutoMapper;
using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.Business.Abstract;
using FoodShoppingAPI.Entity.DTO.ProductDTO;
using FoodShoppingAPI.Entity.Poco;
using FoodShoppingAPI.Entity.Result;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using FoodShoppingAPI.Entity.DTO.StoresDTO;
using FoodShoppingAPI.Entity.DTO.StoreDetailDTO;

namespace FoodShoppingAPI.API.Controllers
{
    [ApiController]
    [Route("FoodShoppingAPI/[action]")]
    public class StoresController : Controller
    {

        private readonly IStoresService _storesService;
        private readonly IMapper _mapper;
        private readonly IStoreCategoryService _storeCategoryService;
        public StoresController(IStoresService storesService, IMapper mapper, IStoreCategoryService storeCategoryService)
        {
            _storesService = storesService;
            _mapper = mapper;
            _storeCategoryService = storeCategoryService;
        }



        [HttpGet("/Stores")]
        [ProducesResponseType(typeof(Sonuç<List<StoresDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetStores()
        {
            var storess = await _storesService.GetAllAsync(q => q.IsActive == true && q.IsDeleted == false, "StoreCategory");
            if (storess != null)
            {
                List<StoresDTOResponse> storesDtoResponseList = new List<StoresDTOResponse>();
                foreach (var stores in storess)
                {
                    storesDtoResponseList.Add(_mapper.Map<StoresDTOResponse>(stores));
                }


                return Ok(Sonuç<List<StoresDTOResponse>>.SuccessWithData(storesDtoResponseList));
            }
            else
            {
                return NotFound(Sonuç<List<StoresDTOResponse>>.SuccessNoDataFound());
            }
        }




        [HttpGet("/Stores/{StoresGuid}")]
        [ProducesResponseType(typeof(Sonuç<List<StoresDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetStoresByGUID(Guid StoresGuid)
        {
            var stores = await _storesService.GetAsync(q => q.Guid == StoresGuid, "StoreCategory");

            if (stores != null)
            {
                StoresDTOResponse storesDtoResponse = _mapper.Map<StoresDTOResponse>(stores);


                return Ok(Sonuç<StoresDTOResponse>.SuccessWithData(storesDtoResponse));
            }
            else
            {
                return NotFound(Sonuç<List<StoresDTOResponse>>.SuccessNoDataFound());
            }
        }

       




        [HttpPost("/AddStores")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddStores(StoresDTORequest storesDTORequest)
        {
            var storeCategory = await _storeCategoryService.GetAsync(q => q.Guid == storesDTORequest.StoreCategoryGuid);


            Stores stores = _mapper.Map<Stores>(storesDTORequest);
            stores.StoreCategory = storeCategory;


            await _storesService.AddAsync(stores);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }

    }

}

