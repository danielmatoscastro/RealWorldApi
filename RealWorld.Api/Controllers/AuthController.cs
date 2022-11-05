using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealWorld.Api.Extensions;
using RealWorld.Api.Models;
using RealWorld.Api.Repositories;
using RealWorld.Api.Services;
using RealWorld.Api.ViewModels;
using SecureIdentity.Password;
using System.IO;

namespace RealWorld.Api.Controllers;

[ApiController]
[Route("api")]
public class AuthController : ControllerBase
{
    private readonly IUserRepository _userRepo;
    private readonly TokenService _tokenService;

    public AuthController(IUserRepository userRepo, TokenService tokenService)
    {
        _userRepo = userRepo;
        _tokenService = tokenService;
    }

    [HttpPost("users/login")]
    public async Task<IActionResult> Login([FromBody] LoginViewModel payload)
    {
        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState.ToErrorsResponseViewModel());
        }

        var userModelDb = await _userRepo.FindByEmailAsync(payload.User.Email);
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

        await _userRepo.CreateAsync(userModel);

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
        var userModelDb = await GetLoggedUser();
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

        var userModelDb = await GetLoggedUser();
        if (userModelDb == null)
        {
            return NotFound();
        }

        userModelDb.Username = payload.User.Username;
        userModelDb.Bio = payload.User.Bio;
        userModelDb.Email = payload.User.Email;
        userModelDb.PasswordHash = PasswordHasher.Hash(payload.User.Password);
        await _userRepo.UpdateAsync(userModelDb);

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
    public async Task<IActionResult> UploadUserImage([FromBody] UploadUserImageViewModel payload)
    {
        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState.ToErrorsResponseViewModel());
        }

        var loggedUser = await GetLoggedUser();
        if (loggedUser == null)
        {
            return Unauthorized();
        }

        var imageName = $"{Guid.NewGuid().ToString()}.jpg";
        var data = new Regex(@"data:image\/[a-z]*;base64,").Replace(payload.User.Image, string.Empty);
        var dataInBytes = Convert.FromBase64String(data);

        var imagePath = Path.Combine("wwwroot", "images", imageName);
        await System.IO.File.WriteAllBytesAsync(imagePath, dataInBytes);

        loggedUser.Image = imagePath;
        await _userRepo.UpdateAsync(loggedUser);

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

    private async Task<UserModel> GetLoggedUser() =>
        User.Identity.IsAuthenticated && User.GetLoggedUserId() != null
            ? await _userRepo.FindByIdAsync(User.GetLoggedUserId().Value)
            : null;
}