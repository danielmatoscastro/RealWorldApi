using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealWorld.Api.Extensions;
using RealWorld.Api.Models;
using RealWorld.Api.Repositories;
using RealWorld.Api.ViewModels;
using RealWorld.Api.Services.Abstraction;

namespace RealWorld.Api.Controllers;

[ApiController]
[Route("api")]
public class UserController : ControllerBase
{
    private readonly ITokenService _tokenService;
    private readonly IUserService _userService;

    public UserController(ITokenService tokenService, IUserService userService)
    {
        _tokenService = tokenService;
        _userService = userService;
    }

    [HttpPost("users/login")]
    public async Task<IActionResult> LoginAsync([FromBody] LoginViewModel payload)
    {
        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState.ToErrorsResponseViewModel());
        }

        (UserModel userModel, string token) = await _userService.LoginAsync(payload.User.Email, payload.User.Password);
        
        var userResponse = new UserResponseViewModel
        {
            Email = userModel.Email,
            Username = userModel.Username,
            Token = token,
            Bio = userModel.Bio,
            Image = userModel.Image,
        };

        return Ok(new { User = userResponse });
    }

    [HttpPost("users")]
    public async Task<IActionResult> CreateUserAsync([FromBody] CreateUserViewModel payload)
    {
        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState.ToErrorsResponseViewModel());
        }

        var userModel = await _userService.CreateUserAsync(
            payload.User.Username, 
            payload.User.Email, 
            payload.User.Password);
        
        var token = _tokenService.GenerateToken(userModel);
        
        var userResponse = new UserResponseViewModel
        {
            Email = userModel.Email,
            Username = userModel.Username,
            Token = token,
        };

        return Ok(new { User = userResponse });
    }

    [Authorize]
    [HttpGet("user")]
    public async Task<IActionResult> GetLoggedUserAsync()
    {
        var loggedUser = await _userService.GetLoggedUserAsync(User.GetLoggedUserId());
        if (loggedUser == null)
        {
            return NotFound();
        }

        var token = _tokenService.GenerateToken(loggedUser);

        var userResponse = new UserResponseViewModel
        {
            Email = loggedUser.Email,
            Username = loggedUser.Username,
            Token = token,
            Bio = loggedUser.Bio,
            Image = loggedUser.Image,
        };

        return Ok(new { User = userResponse });
    }

    [Authorize]
    [HttpPut("user")]
    public async Task<IActionResult> UpdateUser([FromBody] UpdateUserViewModel payload)
    {
        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState.ToErrorsResponseViewModel());
        }

        var userModelDb = await _userService.UpdateUserAsync(
            User.GetLoggedUserId(),
            payload.User.Username,
            payload.User.Bio,
            payload.User.Email,
            payload.User.Password);

        var token = _tokenService.GenerateToken(userModelDb);

        var userResponse = new UserResponseViewModel
        {
            Email = userModelDb.Email,
            Username = userModelDb.Username,
            Token = token,
            Bio = userModelDb.Bio,
            Image = userModelDb.Image,
        };

        return Ok(new { User = userResponse });
    }

    [Authorize]
    [HttpPost("user/image-upload")]
    public async Task<IActionResult> UploadUserImageAsync([FromBody] UploadUserImageViewModel payload)
    {
        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState.ToErrorsResponseViewModel());
        }

        var loggedUser = await _userService.UploadUserImageAsync(User.GetLoggedUserId(), payload.User.Image);

        var token = _tokenService.GenerateToken(loggedUser);
        var userResponse = new UserResponseViewModel
        {
            Email = loggedUser.Email,
            Username = loggedUser.Username,
            Token = token,
            Bio = loggedUser.Bio,
            Image = loggedUser.Image,
        };

        return Ok(new { User = userResponse });
    }
}