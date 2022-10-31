using System.ComponentModel.DataAnnotations;

namespace RealWorld.Api.ViewModels;

public class AddCommentCommentViewModel
{
    [Required]
    public string Body { get; set; }
}