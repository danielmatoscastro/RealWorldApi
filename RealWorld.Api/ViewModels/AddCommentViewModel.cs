using System.ComponentModel.DataAnnotations;

namespace RealWorld.Api.ViewModels;

public class AddCommentViewModel
{
    [Required]
    public AddCommentCommentViewModel Comment { get; set; }
}