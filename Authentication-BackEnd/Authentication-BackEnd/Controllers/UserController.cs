using Authentication_BackEnd.DTOs.RequestDTO;
using Authentication_BackEnd.DTOs.ResponseDTO;
using Authentication_BackEnd.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Authentication_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add-user")]

        public async Task<IActionResult> AddUser([FromForm] UserRequestDTO request)
        {
            try
            {
                var userData = await _userService.AddUser(request);
                return Ok(userData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]

        public async Task<IActionResult> Login(LoginRequestDTO request)
        {
            try
            {
                var userDetails = await _userService.Login(request);
                return Ok(userDetails);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
