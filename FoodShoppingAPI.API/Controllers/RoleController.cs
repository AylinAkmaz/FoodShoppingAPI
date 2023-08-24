using AutoMapper;
using FluentValidation;
using FoodShoppingAPI.API.Validation.FluentValidation;
using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.Entity.DTO.RoleDTO;
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
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;




        public RoleController(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;

        }



        [HttpPost("/AddRole")]
        [ProducesResponseType(typeof(Sonuç<RoleDTOResponse>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> AddRole(RoleDTORequest roleDTORequest)
        {
            RoleValidator roleValidator = new RoleValidator();

            if (roleValidator.Validate(roleDTORequest).IsValid)
            {

                Role role = _mapper.Map<Role>(roleDTORequest);

                await _roleService.AddAsync(role);
                RoleDTOResponse roleDTOResponse = _mapper.Map<RoleDTOResponse>(role);

                return Ok(Sonuç<RoleDTOResponse>.SuccessWithData(roleDTOResponse));
            }
            else
            {
                List<string> validationMessages = new();
                for (int i = 0; i < roleValidator.Validate(roleDTORequest).Errors.Count; i++)
                {
                    validationMessages.Add(roleValidator.Validate(roleDTORequest).Errors[i].ErrorMessage);
                }

                throw new FieldValidationException(validationMessages);
            }
        }

        [HttpGet("/Rols")]
        [ProducesResponseType(typeof(Sonuç<List<RoleDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllRole()
        {
            var rols = await _roleService.GetAllAsync();

            List<RoleDTOResponse> roleDTOList = new();

            foreach (var role in rols)
            {
                roleDTOList.Add(_mapper.Map<RoleDTOResponse>(role));

            }

            return Ok(Sonuç<List<RoleDTOResponse>>.SuccessWithData(roleDTOList));
        }



        [HttpGet("/Role/{guid}")]
        [ProducesResponseType(typeof(Sonuç<RoleDTOResponse>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetRoleByGUID(Guid guid)
        {
            var role = await _roleService.GetAsync(q => q.Guid == guid);

            if (role != null)
            {

                RoleDTOResponse roleDTOResponse = _mapper.Map<RoleDTOResponse>(role);

                return Ok(Sonuç<RoleDTOResponse>.SuccessWithData(roleDTOResponse));
            }
            else
            {
                return NotFound(Sonuç<List<RoleDTOResponse>>.SuccessNoDataFound());
            }

        }




        [HttpPost("/UpdateRole")]
        public async Task<IActionResult> UpdateRole(RoleUpdateDTOResponse roleUpdateDTOResponse)
        {
            Role role = await _roleService.GetAsync(q => q.Guid == roleUpdateDTOResponse.Guid);

            role.Name = roleUpdateDTOResponse.Name;
            role.IsActive = roleUpdateDTOResponse.IsActive != null ? roleUpdateDTOResponse.IsActive : role.IsActive;

            await _roleService.UpdateAsync(role);

            return Ok(Sonuç<RoleDTOResponse>.SuccessWithoutData());
        }


        [HttpPost("/RemoveRole/{RoleGuid}")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> RemoveRole(Guid RoleGuid)

        {

            Role role = await _roleService.GetAsync(q => q.Guid == RoleGuid);

            role.IsActive = false;
            role.IsDeleted = true;

            await _roleService.UpdateAsync(role);

            return Ok(Sonuç<bool>.SuccessWithData(true));

        }





    }
}
