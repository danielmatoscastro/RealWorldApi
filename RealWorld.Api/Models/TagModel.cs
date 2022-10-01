namespace RealWorld.Api.Models;

public class TagModel
{
    public string Name { get; set; }
    public IEnumerable<ArticleModel> Articles { get; set; }
}
