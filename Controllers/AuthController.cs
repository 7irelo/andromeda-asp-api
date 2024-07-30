using Microsoft.AspNetCore.Mvc;
using Andromeda.Dtos;
using Andromeda.Models;
using Andromeda.Services;

namespace Andromeda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public ActionResult<string> Login(LoginDto loginDto)
        {
            var user = _authService.Authenticate(loginDto.Username, loginDto.Password);

            if (user == null)
                return Unauthorized();

            var token = _authService.GenerateJwtToken(user);
            return Ok(token);
        }
    }
}
