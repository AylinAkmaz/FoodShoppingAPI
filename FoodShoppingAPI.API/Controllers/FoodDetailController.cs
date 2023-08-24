using AutoMapper;
using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.Entity.DTO.FoodDetailDTO;
using FoodShoppingAPI.Entity.DTO.StoreDetailDTO;
using FoodShoppingAPI.Entity.Poco;
using FoodShoppingAPI.Entity.Result;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FoodShoppingAPI.API.Controllers
{
    [ApiController]
    [Route("FoodShoppingAPI/[action]")]
    public class FoodDetailController : Controller
	{
        private readonly IMapper _mapper;
        private readonly IFoodDetailService _foodDetailService;
        private readonly IRoleService _roleService;
        private readonly IFoodCategoryService _foodCategoryService;

        public FoodDetailController(IMapper mapper, IFoodDetailService foodDetailService, IRoleService role, IFoodCategoryService foodCategoryService)
        {
            _mapper = mapper;
            _foodDetailService = foodDetailService;
            _roleService = role;
            _foodCategoryService = foodCategoryService;
        }



        [HttpGet("/FoodDetails")]
        [ProducesResponseType(typeof(Sonuç<List<FoodDetailDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetFoodDetail()
        {
            var foodDetails = await _foodDetailService.GetAllAsync(q => q.IsActive == true && q.IsDeleted == false, "FoodCategory", "Role");
            if (foodDetails != null)
            {
                List<FoodDetailDTOResponse> foodDetailDtoResponseList = new List<FoodDetailDTOResponse>();
                foreach (var foodDetail in foodDetails)
                {
                    foodDetailDtoResponseList.Add(_mapper.Map<FoodDetailDTOResponse>(foodDetail));
                }


                return Ok(Sonuç<List<FoodDetailDTOResponse>>.SuccessWithData(foodDetailDtoResponseList));
            }
            else
            {
                return NotFound(Sonuç<List<FoodDetailDTOResponse>>.SuccessNoDataFound());

            }

        }


        [HttpGet("/FoodDetail/{guid}")]
        [ProducesResponseType(typeof(Sonuç<List<FoodDetailDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetFoodDetailByGUID(Guid guid)
        {
            var foodDetail = await _foodDetailService.GetAsync(q => q.Guid == guid, "FoodCategory", "Role");
            if (foodDetail != null)
            {
                FoodDetailDTOResponse foodDetailDtoResponse = _mapper.Map<FoodDetailDTOResponse>(foodDetail);


                return Ok(Sonuç<FoodDetailDTOResponse>.SuccessWithData(foodDetailDtoResponse));
            }
            else
            {
                return NotFound(Sonuç<List<FoodDetailDTOResponse>>.SuccessNoDataFound());

            }

        }




        [HttpPost("/AddFoodDetail")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddFoodDetail(FoodDetailDTORequest foodDetailDTORequest)
        {
            var foodCategory = await _foodCategoryService.GetAsync(q => q.Guid == foodDetailDTORequest.FoodCategoryGuid);
            var role = await _roleService.GetAsync(q => q.Guid == foodDetailDTORequest.RoleGuid);



            FoodDetail foodDetail = _mapper.Map<FoodDetail>(foodDetailDTORequest);
            foodDetail.FoodCategory = foodCategory;
            foodDetail.Role = role;


            await _foodDetailService.AddAsync(foodDetail);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }


        [HttpPost("/UpdateFoodDetail")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateFoodDetail(FoodDetailDTOUpdateResponse foodDetailDTOUpdateResponse)
        {

            FoodDetail foodDetail = await _foodDetailService.GetAsync(q => q.Guid == foodDetailDTOUpdateResponse.Guid);

            var foodCategory = await _foodCategoryService.GetAsync(q => q.Name == foodDetailDTOUpdateResponse.FoodCategoryName);
            var role = await _roleService.GetAsync(q => q.Name == foodDetailDTOUpdateResponse.RoleName);


             _mapper.Map<FoodDetail>(foodDetailDTOUpdateResponse);

            

            await _foodDetailService.UpdateAsync(foodDetail);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }



        [HttpPost("/RemoveFoodDetail/{foodDetailGuid}")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> RemoveFoodDetail(Guid foodDetailGuid)
        {
            FoodDetail foodDetail = await _foodDetailService.GetAsync(q => q.Guid == foodDetailGuid);

            foodDetail.IsActive = false;
            foodDetail.IsDeleted = true;
            await _foodDetailService.UpdateAsync(foodDetail);
            return Ok(Sonuç<bool>.SuccessWithData(true));
        }



    }
}
