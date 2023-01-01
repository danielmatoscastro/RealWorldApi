using RealWorld.Api.Exceptions;
using RealWorld.Api.Models;
using RealWorld.Api.Repositories;
using RealWorld.Api.Services.Abstraction;
using SecureIdentity.Password;

namespace RealWorld.Api.Services;

public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepo;
    private readonly ITokenService _tokenService;

    public AuthService(IUserRepository userRepo, ITokenService tokenService)
    {
        _userRepo = userRepo;
        _tokenService = tokenService;
    }
    
    public async Task<(UserModel userModelDb, string token)> LoginAsync(string email, string password)
    {
        var userModelDb = await _userRepo.FindByEmailAsync(email);
        if (userModelDb == null)
        {
            throw new EntityNotFoundException("User");
        }

        if (!PasswordHasher.Verify(userModelDb.PasswordHash, password))
        {
            throw new UnauthorizedOperationException(nameof(LoginAsync));
        }

        var token = _tokenService.GenerateToken(userModelDb);

        return (userModelDb, token);
    }
}