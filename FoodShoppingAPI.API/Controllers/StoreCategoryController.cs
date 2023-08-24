using AutoMapper;
using FoodShoppingAPI.API.Validation.FluentValidation;
using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.Entity.DTO.StoreCategoryDTO;
using FoodShoppingAPI.Entity.DTO.StoreProductDTO;
using FoodShoppingAPI.Entity.Poco;
using FoodShoppingAPI.Entity.Result;
using FoodShoppingAPI.Helper.CustomException;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FoodShoppingAPI.API.Controllers
{
    [ApiController]
    [Route("FoodShoppingAPI/[action]")]
    public class StoreCategoryController : Controller
    {
        private readonly IStoreCategoryService _storeCategoryService;
        private readonly IMapper _mapper;


        public StoreCategoryController(IStoreCategoryService storeCategoryService, IMapper mapper)
        {
            _storeCategoryService = storeCategoryService;
            _mapper = mapper;

        }


        [HttpGet("/StoreCategory/{guid}")]
        [ProducesResponseType(typeof(Sonuç<StoreCategoryDTOResponse>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetStoreCategoryByGUID(Guid guid)
        {
            var storeCategory = await _storeCategoryService.GetAsync(q => q.Guid == guid);

            if (storeCategory != null)
            {

                StoreCategoryDTOResponse storeCategoryDTOResponse = _mapper.Map<StoreCategoryDTOResponse>(storeCategory);

                return Ok(Sonuç<StoreCategoryDTOResponse>.SuccessWithData(storeCategoryDTOResponse));
            }
            else
            {
                return NotFound(Sonuç<List<StoreCategoryDTOResponse>>.SuccessNoDataFound());
            }

        }



        [HttpPost("/AddStoreCategory")]
        [ProducesResponseType(typeof(Sonuç<StoreCategoryDTOResponse>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> AddStoreCategory(StoreCategoryDTORequest storeCategoryDTORequest)
        {
            StoreCategoryValidator storeCategoryValidator = new StoreCategoryValidator();

            if (storeCategoryValidator.Validate(storeCategoryDTORequest).IsValid)
            {

                StoreCategory storeCategory = _mapper.Map<StoreCategory>(storeCategoryDTORequest);

                await _storeCategoryService.AddAsync(storeCategory);
                StoreCategoryDTOResponse storeCategoryDTOResponse = _mapper.Map<StoreCategoryDTOResponse>(storeCategory);

                return Ok(Sonuç<StoreCategoryDTOResponse>.SuccessWithData(storeCategoryDTOResponse));
            }
            else
            {
                List<string> validationMessages = new();
                for (int i = 0; i < storeCategoryValidator.Validate(storeCategoryDTORequest).Errors.Count; i++)
                {
                    validationMessages.Add(storeCategoryValidator.Validate(storeCategoryDTORequest).Errors[i].ErrorMessage);
                }

                

                throw new FieldValidationException(validationMessages);
            }

        }


        [HttpGet("/StoreCategories")]
        [ProducesResponseType(typeof(Sonuç<List<StoreCategoryDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetStoreCategories()
        {
            var storeCategories = await _storeCategoryService.GetAllAsync();
            if (storeCategories != null)
            {
                List<StoreCategoryDTOResponse> storeCategoryDtoResponseList = new List<StoreCategoryDTOResponse>();
                foreach (var storeCategory in storeCategories)
                {
                    storeCategoryDtoResponseList.Add(_mapper.Map<StoreCategoryDTOResponse>(storeCategory));
                }


                return Ok(Sonuç<List<StoreCategoryDTOResponse>>.SuccessWithData(storeCategoryDtoResponseList));
            }
            else
            {
                return NotFound(Sonuç<List<StoreCategoryDTOResponse>>.SuccessNoDataFound());

            }

        }


        [HttpPost("/UpdateStoreCategory")]
        public async Task<IActionResult> UpdateStoreCategory(StoreCategoryDTOUpdateResponse storeCategoryUpdateDTOResponse)
        {
            StoreCategory storeCategory = await _storeCategoryService.GetAsync(q => q.Guid == storeCategoryUpdateDTOResponse.Guid);

            storeCategory.Name = storeCategoryUpdateDTOResponse.Name;
            storeCategory.IsActive = storeCategoryUpdateDTOResponse.IsActive != null ? storeCategoryUpdateDTOResponse.IsActive : storeCategory.IsActive;

            await _storeCategoryService.UpdateAsync(storeCategory);

            return Ok(Sonuç<StoreCategoryDTOResponse>.SuccessWithoutData());
        }

        [HttpPost("/RemoveStoreCategory/{storeCategoryGUID}")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> RemoveStoreCategory(Guid storeCategoryGUID)

        {

            StoreCategory storeCategory = await _storeCategoryService.GetAsync(q => q.Guid == storeCategoryGUID);

            storeCategory.IsActive = false;
            storeCategory.IsDeleted = true;

            await _storeCategoryService.UpdateAsync(storeCategory);

            return Ok(Sonuç<bool>.SuccessWithData(true));

        }

    }
}
