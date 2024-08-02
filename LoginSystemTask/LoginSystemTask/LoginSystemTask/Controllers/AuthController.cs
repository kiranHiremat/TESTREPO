using Amazon.CognitoIdentityProvider.Model;
using Auth0.ManagementApi.Models.Rules;
using LoginSystemTask.Models;
using LoginSystemTask.ServiceLayer;
using Microsoft.AspNetCore.Mvc;

namespace LoginSystemTask.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    namespace YourNamespace.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class AuthController : ControllerBase
        {
            private readonly IUserService _userService;

            public AuthController(IUserService userService)
            {
                _userService = userService;
            }

            [HttpPost("login")]
            public IActionResult Login([FromBody] LoginRequest request)
            {
                var user = _userService.Authenticate(request.Username, request.Password);
                if (user == null)
                    return Unauthorized();

                // Generate JWT token here

                return Ok(new { token = "dummy-token", role = user.Role });
            }

            [HttpPost("register")]
            public IActionResult Register([FromBody] RegisterRequest request)
            {
                var user = new User
                {
                    Username = request.Username,
                    Password = request.Password,
                    Email = request.Email,
                    Role = request.Role
                };

                _userService.Register(user);

                return Ok();
            }

            [HttpPost("forgot-password")]
            public IActionResult ForgotPassword([FromBody] ForgotPasswordRequest request)
            {
                var user = _userService.ResetPassword(request.Email);
                if (user == null)
                    return NotFound();

                // Implement email sending logic here

                return Ok();
            }
        }
    }

}
