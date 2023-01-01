using RealWorld.Api.DTOs;
using RealWorld.Api.Models;

namespace RealWorld.Api.Services.Abstraction;

public interface IArticleService
{
    Task<List<ArticleModel>> GetArticlesAsync(ArticleSearchParamsDTO searchParams);
    Task<List<ArticleModel>> GetFeedArticlesAsync(UserModel loggedUser, int limit, int offset);
    Task<ArticleModel> GetArticleBySlug(string slug);
    Task<ArticleModel> CreateAsync(UserModel author, 
        string articleBody, 
        string articleDescription, 
        string articleTitle, 
        ICollection<TagModel> tags);

    Task<ArticleModel> UpdateAsync(UserModel loggedUser, string slug, string title, string description, string body);
    Task DeleteAsync(UserModel loggedUser, string slug);
    Task<CommentModel> AddCommentToArticleAsync(UserModel loggedUser, string slug, string commentBody);
    Task<List<CommentModel>> GetCommentsBySlugAsync(string slug);
    Task DeleteCommentAsync(UserModel loggedUser, string slug, int commentId);
    Task<ArticleModel> FavoriteArticleAsync(UserModel loggedUser, string slug);
    Task<ArticleModel> UnfavoriteArticleAsync(UserModel loggedUser, string slug);
}