using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealWorld.Api.Data;
using RealWorld.Api.Models;
using RealWorld.Api.Services;
using RealWorld.Api.ViewModels;
using SecureIdentity.Password;

namespace RealWorld.Api.Controllers;

[ApiController]
[Route("api")]
public class AuthController : ControllerBase
{
    private readonly RealWorldDataContext _context;
    private readonly TokenService _tokenService;

    public AuthController(RealWorldDataContext context, TokenService tokenService)
    {
        _context = context;
        _tokenService = tokenService;
    }

    [HttpPost("users/login")]
    public async Task<IActionResult> Login([FromBody] LoginViewModel payload)
    {
        var userModelDb = await _context.Users.FirstOrDefaultAsync(x => x.Email == payload.User.Email);
        if (userModelDb == null)
        {
            return StatusCode(401);
        }

        if (!PasswordHasher.Verify(userModelDb.PasswordHash, payload.User.Password))
        {
            return StatusCode(401);
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
        var userModel = new UserModel
        {
            Username = payload.User.Username,
            Email = payload.User.Email,
            PasswordHash = PasswordHasher.Hash(payload.User.Password),
        };

        await _context.Users.AddAsync(userModel);
        await _context.SaveChangesAsync();

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
        var userId = User.FindFirst("user_id").Value;

        var userModelDb = await _context.Users.FirstOrDefaultAsync(x => x.Id == Convert.ToInt32(userId));
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
        var userId = User.FindFirst("user_id").Value;

        var userModelDb = await _context.Users.FirstOrDefaultAsync(x => x.Id == Convert.ToInt32(userId));
        if (userModelDb == null)
        {
            return NotFound();
        }

        userModelDb.Username = payload.User.Username;
        userModelDb.Bio = payload.User.Bio;
        userModelDb.Email = payload.User.Email;
        userModelDb.PasswordHash = PasswordHasher.Hash(payload.User.Password);

        _context.Users.Update(userModelDb);
        await _context.SaveChangesAsync();

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