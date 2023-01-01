using RealWorld.Api.Models;
using RealWorld.Api.Repositories;
using RealWorld.Api.Services.Abstraction;

namespace RealWorld.Api.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepo;

    public UserService(IUserRepository userRepo)
    {
        _userRepo = userRepo;
    }
    
    public async Task<UserModel> GetLoggedUser(int? loggedUserId) => 
        loggedUserId.HasValue ? await _userRepo.FindByIdAsync(loggedUserId.Value) : null;
}