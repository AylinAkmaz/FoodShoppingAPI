using AutoMapper;
using FoodShoppingAPI.API.Validation.FluentValidation;
using FoodShoppingAPI.Business.Abstract;
using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.Entity.DTO.FoodCategoryDTO;
using FoodShoppingAPI.Entity.DTO.FoodProductDTO;
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
    public class FoodCategoryController : Controller
    {
        private readonly IFoodCategoryService _foodCategoryService;
        private readonly IMapper _mapper;




        public FoodCategoryController(IMapper mapper, IFoodCategoryService foodCategoryService)
        {

            _mapper = mapper;
            _foodCategoryService = foodCategoryService;
        }



        [HttpPost("/AddFoodCategory")]
        [ProducesResponseType(typeof(Sonuç<FoodCategoryDTOResponse>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> AddFoodCategory(FoodCategoryDTORequest foodCategoryDTORequest)
        {
            FoodCategoryValidator foodCategoryValidator = new FoodCategoryValidator();

            if (foodCategoryValidator.Validate(foodCategoryDTORequest).IsValid)
            {

                FoodCategory foodCategory = _mapper.Map<FoodCategory>(foodCategoryDTORequest);

                await _foodCategoryService.AddAsync(foodCategory);
                FoodCategoryDTOResponse foodCategoryDTOResponse = _mapper.Map<FoodCategoryDTOResponse>(foodCategory);

                return Ok(Sonuç<FoodCategoryDTOResponse>.SuccessWithData(foodCategoryDTOResponse));
            }
            else
            {
                List<string> validationMessages = new();
                for (int i = 0; i < foodCategoryValidator.Validate(foodCategoryDTORequest).Errors.Count; i++)
                {
                    validationMessages.Add(foodCategoryValidator.Validate(foodCategoryDTORequest).Errors[i].ErrorMessage);
                }

                throw new FieldValidationException(validationMessages);
            }
        }

        [HttpGet("/FoodCategories")]
        [ProducesResponseType(typeof(Sonuç<List<FoodCategoryDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllFoodCategories()
        {
            var foodCategorys = await _foodCategoryService.GetAllAsync();

            List<FoodCategoryDTOResponse> foodCategoryDTOList = new();

            foreach (var foodCategory in foodCategorys)
            {
                foodCategoryDTOList.Add(_mapper.Map<FoodCategoryDTOResponse>(foodCategory));

            }

            return Ok(Sonuç<List<FoodCategoryDTOResponse>>.SuccessWithData(foodCategoryDTOList));
        }



        [HttpGet("/FoodCategory/{guid}")]
        [ProducesResponseType(typeof(Sonuç<FoodCategoryDTOResponse>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetFoodCategoryByGUID(Guid guid)
        {
            var foodCategory = await _foodCategoryService.GetAsync(q => q.Guid == guid);

            if (foodCategory != null)
            {

                FoodCategoryDTOResponse foodCategoryDTOResponse = _mapper.Map<FoodCategoryDTOResponse>(foodCategory);

                return Ok(Sonuç<FoodCategoryDTOResponse>.SuccessWithData(foodCategoryDTOResponse));
            }
            else
            {
                return NotFound(Sonuç<List<FoodCategoryDTOResponse>>.SuccessNoDataFound());
            }

        }




        [HttpPost("/UpdateFoodCategory")]
        public async Task<IActionResult> UpdateFoodCategory(FoodCategoryUpdateDTOResponse foodCategoryUpdateDTOResponse)
        {
            FoodCategory foodCategory = await _foodCategoryService.GetAsync(q => q.Guid == foodCategoryUpdateDTOResponse.Guid);

            foodCategory.Name = foodCategoryUpdateDTOResponse.Name;
            foodCategory.IsActive = foodCategoryUpdateDTOResponse.IsActive != null ? foodCategoryUpdateDTOResponse.IsActive : foodCategory.IsActive;

            await _foodCategoryService.UpdateAsync(foodCategory);

            return Ok(Sonuç<FoodCategoryDTOResponse>.SuccessWithoutData());
        }




        [HttpPost("/RemoveFoodCategory/{FoodCategoryGuid}")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> RemoveFoodCategory(Guid FoodCategoryGuid)

        {

            FoodCategory foodCategory = await _foodCategoryService.GetAsync(q => q.Guid == FoodCategoryGuid);

            foodCategory.IsActive = false;
            foodCategory.IsDeleted = true;

            await _foodCategoryService.UpdateAsync(foodCategory);

            return Ok(Sonuç<bool>.SuccessWithData(true));

        }




    }
}
