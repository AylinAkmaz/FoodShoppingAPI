using AutoMapper;
using FluentValidation;
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
    public class FoodProductController : Controller
    {
        private readonly IFoodProductService _foodProductService;
        private readonly IMapper _mapper;




        public FoodProductController(IFoodProductService foodProductService, IMapper mapper)
        {
            _foodProductService = foodProductService;
            _mapper = mapper;

        }



        [HttpPost("/AddFoodProduct")]
        [ProducesResponseType(typeof(Sonuç<FoodProductDTOResponse>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> AddFoodProduct(FoodProductDTORequest foodProductDTORequest)
        {
            FoodProductValidator foodProductValidator = new FoodProductValidator();

            if (foodProductValidator.Validate(foodProductDTORequest).IsValid)
            {

                FoodProduct foodProduct = _mapper.Map<FoodProduct>(foodProductDTORequest);

                await _foodProductService.AddAsync(foodProduct);
                FoodProductDTOResponse foodProductDTOResponse = _mapper.Map<FoodProductDTOResponse>(foodProduct);

                return Ok(Sonuç<FoodProductDTOResponse>.SuccessWithData(foodProductDTOResponse));
            }
            else
            {
                List<string> validationMessages = new();
                for (int i = 0; i < foodProductValidator.Validate(foodProductDTORequest).Errors.Count; i++)
                {
                    validationMessages.Add(foodProductValidator.Validate(foodProductDTORequest).Errors[i].ErrorMessage);
                }

                throw new FieldValidationException(validationMessages);
            }
        }
        [HttpGet("/FoodProducts")]
        [ProducesResponseType(typeof(Sonuç<List<FoodProductDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllFoodProducts()
        {
            var foodProducts = await _foodProductService.GetAllAsync();

            List<FoodProductDTOResponse> foodProductDTOList = new();

            foreach (var foodProduct in foodProducts)
            {
                foodProductDTOList.Add(_mapper.Map<FoodProductDTOResponse>(foodProduct));

            }

            return Ok(Sonuç<List<FoodProductDTOResponse>>.SuccessWithData(foodProductDTOList));
        }


        [HttpGet("/FoodProduct/{guid}")]
        [ProducesResponseType(typeof(Sonuç<FoodProductDTOResponse>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetFoodProductByGUID(Guid guid)
        {
            var foodProduct = await _foodProductService.GetAsync(q => q.Guid == guid);

            if (foodProduct != null)
            {

                FoodProductDTOResponse foodProductDTOResponse = _mapper.Map<FoodProductDTOResponse>(foodProduct);

                return Ok(Sonuç<FoodProductDTOResponse>.SuccessWithData(foodProductDTOResponse));
            }
            else
            {
                return NotFound(Sonuç<List<FoodProductDTOResponse>>.SuccessNoDataFound());
            }

        }




        [HttpPost("/UpdateFoodProduct")]
        public async Task<IActionResult> UpdateFoodProduct(FoodProductDTOUpdateResponse foodProductDTOUpdateResponse)
        {
            FoodProduct foodProduct = await _foodProductService.GetAsync(q => q.Guid == foodProductDTOUpdateResponse.Guid);

            foodProduct.Name = foodProductDTOUpdateResponse.Name;
            foodProduct.IsActive = foodProductDTOUpdateResponse.IsActive != null ? foodProductDTOUpdateResponse.IsActive : foodProduct.IsActive;

            await _foodProductService.UpdateAsync(foodProduct);

            return Ok(Sonuç<FoodProductDTOResponse>.SuccessWithoutData());
        }




        [HttpPost("/RemoveFoodProduct/{FoodProductGuid}")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> RemoveFoodProduct(Guid FoodProductGuid)

        {

            FoodProduct foodProduct = await _foodProductService.GetAsync(q => q.Guid == FoodProductGuid);

            foodProduct.IsActive = false;
            foodProduct.IsDeleted = true;

            await _foodProductService.UpdateAsync(foodProduct);

            return Ok(Sonuç<bool>.SuccessWithData(true));

        }




    }
}
