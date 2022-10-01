namespace RealWorld.Api.Models;

public class ArticleModel
{
    public string Slug { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Body { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public UserModel Author { get; set; }
    public IEnumerable<TagModel> Tags { get; set; }
    public IEnumerable<UserModel> FavoritedBy { get; set; }
    public IEnumerable<CommentModel> Comments { get; set; }
}