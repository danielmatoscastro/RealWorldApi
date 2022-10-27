using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealWorld.Api.Models;
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
    [HttpGet]
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

    [Route("{username}/follow")]
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> FollowUser([FromRoute] string username)
    {
        var userId = User.GetLoggedUserId();
        if (userId == null)
        {
            return BadRequest();
        }

        var loggedUserModelDb = await _repository.FindByIdAsync(userId.Value);
        if (loggedUserModelDb == null)
        {
            return NotFound();
        }

        var userToFollow = await _repository.FindByUsernameWithFollowersAsync(username);
        if (userToFollow == null)
        {
            return NotFound();
        }

        if (LoggedUserIsFollower(loggedUserModelDb, userToFollow))
        {
            return BadRequest();
        }

        userToFollow.Followers.Add(loggedUserModelDb);
        await _repository.UpdateAsync(userToFollow);

        var profileResponse = new ProfileResponseViewModel
        {
            Username = userToFollow.Username,
            Bio = userToFollow.Bio,
            Image = userToFollow.Image,
            Following = true
        };

        return Ok(new { Profile = profileResponse });
    }

    private bool LoggedUserIsFollower(UserModel loggedUser, UserModel userToFollow) =>
        userToFollow.Followers.Any(x => x.Id == loggedUser.Id);

    [Route("{username}/follow")]
    [Authorize]
    [HttpDelete]
    public async Task<IActionResult> UnfollowUser([FromRoute] string username)
    {
        var userId = User.GetLoggedUserId();
        if (userId == null)
        {
            return BadRequest();
        }

        var loggedUserModelDb = await _repository.FindByIdAsync(userId.Value);
        if (loggedUserModelDb == null)
        {
            return NotFound();
        }

        var userToUnfollow = await _repository.FindByUsernameWithFollowersAsync(username);
        if (userToUnfollow == null)
        {
            return NotFound();
        }

        if (!LoggedUserIsFollower(loggedUserModelDb, userToUnfollow))
        {
            return BadRequest();
        }

        userToUnfollow.Followers.Remove(loggedUserModelDb);
        await _repository.UpdateAsync(userToUnfollow);

        var profileResponse = new ProfileResponseViewModel
        {
            Username = userToUnfollow.Username,
            Bio = userToUnfollow.Bio,
            Image = userToUnfollow.Image,
            Following = false
        };

        return Ok(new { Profile = profileResponse });
    }
}