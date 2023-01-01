using FluentAssertions;
using RealWorld.Api.Models;
using RealWorld.Api.Services;
using RealWorld.Api.Tests.Fakes;

namespace RealWorld.Api.Tests.Services;

public class UserServiceTests
{
    [Fact]
    public async Task GetLoggedUser_ShouldReturnTheUser_WhenIdIsInRepository()
    {
        var fakeRepo = new FakeUserRepository(new UserModel { Id = 5 });
        var service = new UserService(fakeRepo);

        var loggedUser = await service.GetLoggedUserAsync(5);

        loggedUser.Should().NotBeNull();
        loggedUser.Id.Should().Be(5);
    }
    
    [Fact]
    public async Task GetLoggedUser_ShouldReturnNull_WhenIdIsNotInRepository()
    {
        var fakeRepo = new FakeUserRepository();
        var service = new UserService(fakeRepo);

        var loggedUser = await service.GetLoggedUserAsync(5);

        loggedUser.Should().BeNull();
    }
    
    [Fact]
    public async Task GetLoggedUser_ShouldReturnNull_WhenIdIsNull()
    {
        var fakeRepo = new FakeUserRepository(new UserModel { Id = 5 });
        var service = new UserService(fakeRepo);

        var loggedUser = await service.GetLoggedUserAsync(null);

        loggedUser.Should().BeNull();
    }
}