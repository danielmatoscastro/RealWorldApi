using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealWorld.Api.Extensions;
using RealWorld.Api.Models;
using RealWorld.Api.Repositories;
using RealWorld.Api.ViewModels;

namespace RealWorld.Api.Controllers;

[Route("api/profiles")]
[ApiController]
public class ProfileController : ControllerBase
{
    private readonly IUserRepository _userRepo;

    public ProfileController(IUserRepository userRepo) => _userRepo = userRepo;

    [Route("{username}")]
    [HttpGet]
    public async Task<IActionResult> GetProfile([FromRoute] string username)
    {
        var userId = User.GetLoggedUserId();

        var userModelDb = await _userRepo.FindByUsernameAsync(username);
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
        var loggedUserModelDb = await GetLoggedUser();
        if (loggedUserModelDb == null)
        {
            return NotFound();
        }

        var userToFollow = await _userRepo.FindByUsernameAsync(username);
        if (userToFollow == null)
        {
            return NotFound();
        }

        if (LoggedUserIsFollower(loggedUserModelDb, userToFollow))
        {
            return BadRequest();
        }

        userToFollow.Followers.Add(loggedUserModelDb);
        await _userRepo.UpdateAsync(userToFollow);

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
        var loggedUserModelDb = await GetLoggedUser();
        if (loggedUserModelDb == null)
        {
            return NotFound();
        }

        var userToUnfollow = await _userRepo.FindByUsernameAsync(username);
        if (userToUnfollow == null)
        {
            return NotFound();
        }

        if (!LoggedUserIsFollower(loggedUserModelDb, userToUnfollow))
        {
            return BadRequest();
        }

        userToUnfollow.Followers.Remove(loggedUserModelDb);
        await _userRepo.UpdateAsync(userToUnfollow);

        var profileResponse = new ProfileResponseViewModel
        {
            Username = userToUnfollow.Username,
            Bio = userToUnfollow.Bio,
            Image = userToUnfollow.Image,
            Following = false
        };

        return Ok(new { Profile = profileResponse });
    }

    private async Task<UserModel> GetLoggedUser() =>
        User.Identity.IsAuthenticated && User.GetLoggedUserId() != null
            ? await _userRepo.FindByIdAsync(User.GetLoggedUserId().Value)
            : null;
}