using System.Net;

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
        _logger.LogError($"An exception occoured at {context.GetEndpoint().DisplayName}. Exception: {ex.Message}. Stacktrace: {ex.StackTrace}.");

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
    }
}