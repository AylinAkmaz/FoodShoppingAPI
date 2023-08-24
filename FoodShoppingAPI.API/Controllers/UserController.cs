using AutoMapper;
using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.Entity.Poco;
using FoodShoppingAPI.Entity.Result;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using FoodShoppingAPI.Entity.DTO.UserDTO;
using FoodShoppingAPI.API.Validation.FluentValidation;

namespace FoodShoppingAPI.API.Controllers
{
    [ApiController]
    [Route("[action]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet("/Users")]
        [ProducesResponseType(typeof(Sonuç<List<UserDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllAsync();

            List<UserDTOResponse> userDTOList = new();

            foreach (var user in users)
            {
                userDTOList.Add(_mapper.Map<UserDTOResponse>(user));

            }

            return Ok(Sonuç<List<UserDTOResponse>>.SuccessWithData(userDTOList));
        }

        [HttpGet("/User/{id}")]
        [ProducesResponseType(typeof(Sonuç<UserDTOResponse>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userService.GetAsync(q => q.ID == id);

            if (user != null)
            {
                UserDTOResponse userDTO = _mapper.Map<UserDTOResponse>(user);

                return Ok(Sonuç<UserDTOResponse>.SuccessWithData(userDTO));
            }
            return NotFound(Sonuç<UserDTOResponse>.SuccessNoDataFound("Kullanıcı Bulunamadı"));

        }

        // [ValidationFilter(typeof(UserRegisterValidator))]
        [HttpPost("/AddUser")]
        [ProducesResponseType(typeof(Sonuç<UserDTOResponse>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddUser(UserDTORequest userRequestDTO)
        {
            UserRegisterValidator userRegisterValidation = new UserRegisterValidator();


            User user = _mapper.Map<User>(userRequestDTO);

            await _userService.AddAsync(user);

            UserDTOResponse userResponseDTO = _mapper.Map<UserDTOResponse>(user);

            return Ok(Sonuç<UserDTOResponse>.SuccessWithData(userResponseDTO));

        }
    }
}
