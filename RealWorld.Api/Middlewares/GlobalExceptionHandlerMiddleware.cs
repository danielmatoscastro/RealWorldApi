using System.Net;
using System.Text.Json;
using RealWorld.Api.Exceptions;
using RealWorld.Api.Extensions;

namespace RealWorld.Api.Middlewares;

public class GlobalExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger _logger;

    public GlobalExceptionHandlerMiddleware(RequestDelegate next, ILogger<GlobalExceptionHandlerMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            HandleExceptionAsync(context, ex);
        }
    }

    private void HandleExceptionAsync(HttpContext context, Exception ex)
    {
        _logger.LogError($"An exception occurred at {context.GetEndpoint()?.DisplayName}. Exception: {ex.Message}. Stacktrace: {ex.StackTrace}.");

        context.Response.ContentType = "application/json";

        switch (ex)
        {
            case EntityNotFoundException:
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                break;
            case ForbiddenOperation:
                context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                break;
            case UnauthorizedOperationException:
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                break;
            case BusinessRuleViolationException exBusiness:
                context.Response.StatusCode = (int)HttpStatusCode.UnprocessableEntity;
                context.Response.Body =
                    new MemoryStream(JsonSerializer.SerializeToUtf8Bytes(exBusiness.ToErrorsResponseViewModel()));
                break;
            default:
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                break;
        }
    }
}