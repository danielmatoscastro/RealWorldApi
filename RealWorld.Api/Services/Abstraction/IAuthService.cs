using RealWorld.Api.Models;

namespace RealWorld.Api.Services.Abstraction;

public interface IAuthService
{
    Task<(UserModel userModelDb, string token)> LoginAsync(string email, string password);
}