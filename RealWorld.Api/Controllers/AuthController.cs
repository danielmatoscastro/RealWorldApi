using Microsoft.AspNetCore.Mvc;

namespace RealWorld.Api.Controllers;

[ApiController]
[Route("api/users")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login()
    {
        return Ok();
    }
}