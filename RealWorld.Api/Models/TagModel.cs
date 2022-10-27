namespace RealWorld.Api.Models;

public class TagModel
{
    public string Name { get; set; }
    public ICollection<ArticleModel> Articles { get; set; }
}
