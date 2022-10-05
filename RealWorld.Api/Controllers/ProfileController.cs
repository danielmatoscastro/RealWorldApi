using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealWorld.Api.Data;
using RealWorld.Api.ViewModels;

namespace RealWorld.Api.Controllers;

[Route("api/profiles")]
[ApiController]
public class ProfileController : ControllerBase
{
    private readonly RealWorldDataContext _context;

    public ProfileController(RealWorldDataContext context) => _context = context;

    [Route("{username:string}")]
    public async Task<IActionResult> GetProfile([FromRoute] string username)
    {
        var userId = User.GetLoggedUserId();

        var profileResponse = await _context.Users
            .Include(u => u.Followers)
            .Where(u => u.Username == username)
            .Select(u => new ProfileResponseViewModel
            {
                Username = u.Username,
                Bio = u.Bio,
                Image = u.Image,
                Following = userId != null
                    ? u.Followers.Any(f => f.Id == userId)
                    : false,
            })
            .AsNoTracking()
            .FirstOrDefaultAsync();

        return profileResponse == null ? NotFound() : Ok(new { Profile = profileResponse });
    }
}