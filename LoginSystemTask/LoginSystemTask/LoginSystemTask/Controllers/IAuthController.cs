using Amazon.CognitoIdentityProvider.Model;
using Auth0.ManagementApi.Models.Rules;
using Microsoft.AspNetCore.Mvc;

namespace LoginSystemTask.Controllers
{
    public interface IAuthController
    {
        IActionResult ForgotPassword([FromBody] ForgotPasswordRequest request);
        IActionResult Login([FromBody] LoginRequest request);
        IActionResult Register([FromBody] RegisterRequest request);
    }
}