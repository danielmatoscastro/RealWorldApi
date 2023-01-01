using RealWorld.Api.Exceptions;
using RealWorld.Api.Models;
using RealWorld.Api.Queries;
using RealWorld.Api.Repositories;
using RealWorld.Api.Services.Abstraction;
using SlugGenerator;

namespace RealWorld.Api.Services;

public class ArticleService : IArticleService
{
    private readonly IArticleRepository _articleRepo;
    private readonly ICommentRepository _commentRepo;

    public ArticleService(IArticleRepository articleRepo, ICommentRepository commentRepo)
    {
        _articleRepo = articleRepo;
        _commentRepo = commentRepo;
    }
    
    public Task<List<ArticleModel>> SearchAsync(ArticleQuery query) => _articleRepo.SearchAsync(query);
    public Task<List<ArticleModel>> GetFeedArticlesAsync(UserModel loggedUser, int limit, int offset) => 
        _articleRepo.GetFeedArticlesAsync(loggedUser, limit, offset);

    public Task<ArticleModel> GetArticleBySlug(string slug) => _articleRepo.GetArticleBySlug(slug);
    public async Task<ArticleModel> CreateAsync(UserModel author, string articleBody, string articleDescription, string articleTitle, ICollection<TagModel> tags)
    {
        var articleModel = new ArticleModel
        {
            Author = author,
            Body = articleBody,
            Description = articleDescription,
            Slug = articleTitle.GenerateSlug(),
            Title = articleTitle,
            UpdatedAt = DateTimeOffset.Now,
            CreatedAt = DateTimeOffset.Now,
            Tags = tags,
        };
        
        await _articleRepo.CreateAsync(articleModel);

        return articleModel;
    }

    public async Task<ArticleModel> UpdateAsync(UserModel loggedUser, string slug, string title, string description, string body)
    {
        var articleModelDb = await _articleRepo.GetArticleBySlug(slug);
        if (articleModelDb == null)
        {
            throw new EntityNotFoundException("Article");
        }

        if (articleModelDb.Author.Id != loggedUser.Id)
        {
            throw new ForbiddenOperation(nameof(UpdateAsync));
        }
        
        if (!string.IsNullOrEmpty(title))
        {
            articleModelDb.Title = title;
            articleModelDb.Slug = title.GenerateSlug();
        }
        if (!string.IsNullOrEmpty(description))
        {
            articleModelDb.Description = description;
        }
        if (!string.IsNullOrEmpty(body))
        {
            articleModelDb.Body = body;
        }
        
        await _articleRepo.UpdateAsync(articleModelDb);

        return articleModelDb;
    }

    public async Task DeleteAsync(UserModel loggedUser, string slug)
    {
        var article = await _articleRepo.GetArticleBySlug(slug);
        if (article == null)
        {
            throw new EntityNotFoundException("Article");
        }

        if (article.Author.Id != loggedUser.Id)
        {
            throw new ForbiddenOperation(nameof(DeleteAsync));
        }

        await _articleRepo.DeleteArticle(article);
    }

    public async Task<CommentModel> AddCommentToArticleAsync(UserModel loggedUser, string slug, string commentBody)
    {
        var article = await _articleRepo.GetArticleBySlug(slug);
        if (article == null)
        {
            throw new EntityNotFoundException("Article");
        }

        var comment = new CommentModel
        {
            Author = loggedUser,
            Article = article,
            Body = commentBody,
            CreatedAt = DateTimeOffset.Now,
            UpdatedAt = DateTimeOffset.Now,
        };

        await _commentRepo.AddCommentAsync(comment);

        return comment;
    }

    public async Task<List<CommentModel>> GetCommentsBySlugAsync(string slug)
    {
        var comments = await _commentRepo.GetCommentsBySlugAsync(slug);
        if (comments == null)
        {
            throw new EntityNotFoundException("Comments of article");
        }

        return comments;
    }

    public async Task DeleteCommentAsync(UserModel loggedUser, string slug, int commentId)
    {
        var comment = await _commentRepo.GetCommentByIdAsync(commentId);
        if (comment == null)
        {
            throw new EntityNotFoundException("Comment");
        }

        if (comment.Author.Id != loggedUser.Id)
        {
            throw new ForbiddenOperation(nameof(DeleteCommentAsync));
        }

        if (comment.Article.Slug != slug)
        {
            throw new BusinessRuleViolationException("Slug","doesn't match comment article slug.");
        }

        await _commentRepo.DeleteAsync(comment);
    }

    public async Task<ArticleModel> FavoriteArticleAsync(UserModel loggedUser, string slug)
    {
        var article = await _articleRepo.GetArticleBySlug(slug);
        if (article == null)
        {
            throw new EntityNotFoundException("Article");
        }

        if (article.FavoritedBy.Contains(loggedUser))
        {
            throw new BusinessRuleViolationException("Article","is already favorited by logged user");
        }

        article.FavoritedBy.Add(loggedUser);
        
        await _articleRepo.UpdateAsync(article);

        return article;
    }

    public async Task<ArticleModel> UnfavoriteArticleAsync(UserModel loggedUser, string slug)
    {
        var article = await _articleRepo.GetArticleBySlug(slug);
        if (article == null)
        {
            throw new EntityNotFoundException("Article");
        }

        if (!article.FavoritedBy.Contains(loggedUser))
        {
            throw new BusinessRuleViolationException("Article","isn't favorited by logged user");
        }

        article.FavoritedBy.Remove(loggedUser);

        await _articleRepo.UpdateAsync(article);

        return article;
    }
}