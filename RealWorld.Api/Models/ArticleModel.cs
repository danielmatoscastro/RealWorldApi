namespace RealWorld.Api.Models;

public class ArticleModel
{
    public int Id { get; set; }
    public string Slug { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Body { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public UserModel Author { get; set; }
    public ICollection<TagModel> Tags { get; set; } = new List<TagModel>();
    public ICollection<UserModel> FavoritedBy { get; set; } = new List<UserModel>();
    public ICollection<CommentModel> Comments { get; set; } = new List<CommentModel>();
}