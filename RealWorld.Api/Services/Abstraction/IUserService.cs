using RealWorld.Api.Models;

namespace RealWorld.Api.Services.Abstraction;

public interface IUserService
{
    Task<UserModel> GetLoggedUserAsync(int? loggedUserId);
}