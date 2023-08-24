using AutoMapper;
using FoodShoppingAPI.Business.Abstract;
using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.Entity.DTO.MenuDTO;
using FoodShoppingAPI.Entity.DTO.StoreDetailDTO;
using FoodShoppingAPI.Entity.Poco;
using FoodShoppingAPI.Entity.Result;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FoodShoppingAPI.API.Controllers
{
    [ApiController]
    [Route("FoodShoppingAPI/[action]")]
    public class MenuController : Controller
	{
		private readonly IMapper _mapper;
        private readonly IMenuService _menuService;
        private readonly IFoodDetailService _foodDetailService;
        private readonly IFoodProductService _foodProductService;

        public MenuController(IFoodProductService foodProductService, IFoodDetailService foodDetailService, IMenuService menuService, IMapper mapper)
        {
            _foodProductService = foodProductService;
            _foodDetailService = foodDetailService;
            _menuService = menuService;
            _mapper = mapper;
        }




        [HttpGet("/Menus")]
        [ProducesResponseType(typeof(Sonuç<List<MenuDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetMenus()
        {
            var menus = await _menuService.GetAllAsync(q => q.IsActive == true && q.IsDeleted == false, "FoodDetail", "FoodProduct");
            if (menus != null)
            {
                List<MenuDTOResponse> menuDtoResponseList = new List<MenuDTOResponse>();
                foreach (var menu in menus)
                {
                    menuDtoResponseList.Add(_mapper.Map<MenuDTOResponse>(menu));
                }


                return Ok(Sonuç<List<MenuDTOResponse>>.SuccessWithData(menuDtoResponseList));
            }
            else
            {
                return NotFound(Sonuç<List<MenuDTOResponse>>.SuccessNoDataFound());

            }

        }


        [HttpGet("/Menu/{guid}")]
        [ProducesResponseType(typeof(Sonuç<List<MenuDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetMenuByGUID(Guid guid)
        {
            var menu = await _menuService.GetAsync(q => q.Guid == guid, "FoodDetail", "FoodProduct");
            if (menu != null)
            {
                MenuDTOResponse menuDtoResponse = _mapper.Map<MenuDTOResponse>(menu);


                return Ok(Sonuç<MenuDTOResponse>.SuccessWithData(menuDtoResponse));
            }
            else
            {
                return NotFound(Sonuç<List<MenuDTOResponse>>.SuccessNoDataFound());

            }

        }




        [HttpPost("/AddMenu")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddMenu(MenuDTORequest menuDTORequest)
        {
            var foodDetail = await _foodDetailService.GetAsync(q => q.Guid == menuDTORequest.FoodDetailGUID);
            var foodProduct = await _foodProductService.GetAsync(q => q.Guid == menuDTORequest.FoodProductGuid);



            Menu menu = _mapper.Map<Menu>(menuDTORequest);
            menu.FoodDetail = foodDetail;
            menu.FoodProduct = foodProduct;


            await _menuService.AddAsync(menu);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }


        [HttpPost("/UpdateMenu")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateMenu(MenuDTOUpdateResponse menuDTOUpdateResponse)
        {

            Menu menu = await _menuService.GetAsync(q => q.Guid == menuDTOUpdateResponse.Guid);

            var foodDetail = await _foodDetailService.GetAsync(q => q.Name == menuDTOUpdateResponse.FoodDetailName);
            var foodProduct = await _foodProductService.GetAsync(q => q.Name == menuDTOUpdateResponse.FoodProductName);

            menu.FoodProduct = foodProduct;
            menu.FoodDetail = foodDetail;

            menu.IsActive =menuDTOUpdateResponse.IsActive != null ? menuDTOUpdateResponse.IsActive : menu.IsActive;

            await _menuService.UpdateAsync(menu);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }



        [HttpPost("/RemoveMenu/{menuGuid}")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> RemoveMenu(Guid menuGUID)
        {
            Menu menu = await _menuService.GetAsync(q => q.Guid == menuGUID);

            menu.IsActive = false;
            menu.IsDeleted = true;
            await _menuService.UpdateAsync(menu);
            return Ok(Sonuç<bool>.SuccessWithData(true));
        }





    }
}
