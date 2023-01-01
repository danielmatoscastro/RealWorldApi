using RealWorld.Api.Models;

namespace RealWorld.Api.Services.Abstraction;

public interface ITokenService
{
    string GenerateToken(UserModel user);
}