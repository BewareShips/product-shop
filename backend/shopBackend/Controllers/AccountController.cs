using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shopBackend.Models.Dto;
using shopBackend.Services.Interfaces;

namespace shopBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register( RegisterDto model)
        {
            try
            {
                await _userService.Register(
                    model.FirstName,
                    model.LastName,
                    model.Email,
                    model.Password,
                    model.Address,
                    model.PhoneNumber,
                    model.Role
                );
               var token = await _userService.Login(model.Email, model.Password);
                return Ok(new
                {
                    token,
                    message = "User registered successfully"
                }) ;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto model)
        {
            try
            {
                var token = await _userService.Login(model.Email, model.Password);
                return Ok(new { token });
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
