using System.ComponentModel.DataAnnotations;

namespace RealWorld.Api.ViewModels;

public class UpdateUserViewModel
{
    [Required]
    public UpdateUserUserViewModel User { get; init; }
}