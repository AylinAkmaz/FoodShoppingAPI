using AutoMapper;
using FoodShoppingAPI.Business.Abstract;
using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.Entity.DTO.CatetgoryDTO;
using FoodShoppingAPI.Entity.DTO.StoresDTO;
using FoodShoppingAPI.Entity.Poco;
using FoodShoppingAPI.Entity.Result;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FoodShoppingAPI.API.Controllers
{
    [ApiController]
    [Route("FoodShoppingAPI/[action]")]
    public class CategoryController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        private readonly IFoodCategoryService _foodCategoryService;

        public CategoryController(IMapper mapper, ICategoryService categoryService, IFoodCategoryService foodCategoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
            _foodCategoryService = foodCategoryService;
        }

        [HttpGet("/Categories")]
        [ProducesResponseType(typeof(Sonuç<List<CategoryDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetCategories()
        {
            var categorys = await _categoryService.GetAllAsync(q => q.IsActive == true && q.IsDeleted == false, "FoodCategory");
            if (categorys != null)
            {
                List<CategoryDTOResponse> categoryDtoResponseList = new List<CategoryDTOResponse>();
                foreach (var category in categorys)
                {
                    categoryDtoResponseList.Add(_mapper.Map<CategoryDTOResponse>(category));
                }


                return Ok(Sonuç<List<CategoryDTOResponse>>.SuccessWithData(categoryDtoResponseList));
            }
            else
            {
                return NotFound(Sonuç<List<CategoryDTOResponse>>.SuccessNoDataFound());
            }
        }




        [HttpGet("/Category/{CategoryGuid}")]
        [ProducesResponseType(typeof(Sonuç<List<CategoryDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetCategoryByGUID(Guid CategoryGuid)
        {
            var category = await _categoryService.GetAsync(q => q.Guid == CategoryGuid, "FoodCategory");

            if (category != null)
            {
                CategoryDTOResponse categoryDtoResponse = _mapper.Map<CategoryDTOResponse>(category);


                return Ok(Sonuç<CategoryDTOResponse>.SuccessWithData(categoryDtoResponse));
            }
            else
            {
                return NotFound(Sonuç<List<CategoryDTOResponse>>.SuccessNoDataFound());
            }
        }






        [HttpPost("/AddCategory")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddCategory(CategoryDTORequest categoryDTORequest)
        {
            var foodCategory = await _foodCategoryService.GetAsync(q => q.Guid == categoryDTORequest.FoodCategoryGuid);


            Category category = _mapper.Map<Category>(categoryDTORequest);
            category.FoodCategory = foodCategory;


            await _categoryService.AddAsync(category);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }





    }
}
