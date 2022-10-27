using Microsoft.AspNetCore.Mvc;
using RealWorld.Api.Repositories;
using RealWorld.Api.ViewModels;

namespace RealWorld.Api.Controllers;

[Route("api/profiles")]
[ApiController]
public class ProfileController : ControllerBase
{
    private readonly IUserRepository _repository;

    public ProfileController(IUserRepository repository) => _repository = repository;

    [Route("{username}")]
    public async Task<IActionResult> GetProfile([FromRoute] string username)
    {
        var userId = User.GetLoggedUserId();

        var userModelDb = await _repository.FindByUsernameWithFollowersAsync(username);
        if (userModelDb == null)
        {
            return NotFound();
        }

        var profileResponse = new ProfileResponseViewModel
        {
            Username = userModelDb.Username,
            Bio = userModelDb.Bio,
            Image = userModelDb.Image,
            Following = userModelDb.Followers.Any(f => f.Id == userId)
        };

        return profileResponse == null ? NotFound() : Ok(new
        {
            Profile = profileResponse
        });
    }
}