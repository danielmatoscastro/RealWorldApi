using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealWorld.Api.Extensions;
using RealWorld.Api.Models;
using RealWorld.Api.Repositories;
using RealWorld.Api.Services;
using RealWorld.Api.ViewModels;
using SecureIdentity.Password;

namespace RealWorld.Api.Controllers;

[ApiController]
[Route("api")]
public class AuthController : ControllerBase
{
    private readonly IUserRepository _repository;
    private readonly TokenService _tokenService;

    public AuthController(IUserRepository repository, TokenService tokenService)
    {
        _repository = repository;
        _tokenService = tokenService;
    }

    [HttpPost("users/login")]
    public async Task<IActionResult> Login([FromBody] LoginViewModel payload)
    {
        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState.ToErrorsResponseViewModel());
        }

        var userModelDb = await _repository.FindByEmailAsync(payload.User.Email);
        if (userModelDb == null)
        {
            return NotFound();
        }

        if (!PasswordHasher.Verify(userModelDb.PasswordHash, payload.User.Password))
        {
            return Unauthorized();
        }

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

    [HttpPost("users")]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserViewModel payload)
    {
        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState.ToErrorsResponseViewModel());
        }

        var userModel = new UserModel
        {
            Username = payload.User.Username,
            Email = payload.User.Email,
            PasswordHash = PasswordHasher.Hash(payload.User.Password),
        };

        await _repository.CreateAsync(userModel);

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
    public async Task<IActionResult> GetUser()
    {
        var userId = User.GetLoggedUserId();
        if (userId == null)
        {
            return BadRequest();
        }

        var userModelDb = await _repository.FindByIdAsync(userId.Value);
        if (userModelDb == null)
        {
            return NotFound();
        }

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
    [HttpPut("user")]
    public async Task<IActionResult> UpdateUser([FromBody] UpdateUserViewModel payload)
    {
        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState.ToErrorsResponseViewModel());
        }

        var userId = User.GetLoggedUserId();
        if (userId == null)
        {
            return BadRequest();
        }

        var userModelDb = await _repository.FindByIdAsync(userId.Value);
        if (userModelDb == null)
        {
            return NotFound();
        }

        userModelDb.Username = payload.User.Username;
        userModelDb.Bio = payload.User.Bio;
        userModelDb.Email = payload.User.Email;
        userModelDb.PasswordHash = PasswordHasher.Hash(payload.User.Password);
        await _repository.UpdateAsync(userModelDb);

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
}