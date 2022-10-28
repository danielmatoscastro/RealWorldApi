namespace RealWorld.Api.ViewModels;

public class ArticleResponseViewModel
{
    public string Slug { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Body { get; set; }
    public IEnumerable<string> TagList { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public bool Favorited { get; set; }
    public int FavoritesCount { get; set; }
    public AuthorViewModel Author { get; set; }
}