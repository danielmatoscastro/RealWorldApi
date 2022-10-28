using System.ComponentModel.DataAnnotations;

namespace RealWorld.Api.ViewModels;

public class CreateArticleArticleViewModel
{
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string Body { get; set; }
    public IEnumerable<string> TagList { get; set; }
}
