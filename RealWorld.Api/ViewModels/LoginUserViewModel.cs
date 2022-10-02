using System.ComponentModel.DataAnnotations;

namespace RealWorld.Api.ViewModels;

public class LoginUserViewModel
{
    [Required]
    public string Email { get; init; }

    [Required]
    public string Password { get; init; }
}
