using System.ComponentModel.DataAnnotations;

namespace RealWorld.Api.ViewModels;

public class CreateUserViewModel
{
    [Required]
    public CreateUserUserViewModel User { get; init; }
}