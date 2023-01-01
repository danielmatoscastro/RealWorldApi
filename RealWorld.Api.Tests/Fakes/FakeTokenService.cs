using RealWorld.Api.Models;
using RealWorld.Api.Services.Abstraction;

namespace RealWorld.Api.Tests.Fakes;

public class FakeTokenService : ITokenService
{
    public string GenerateToken(UserModel user) => Guid.NewGuid().ToString();
}