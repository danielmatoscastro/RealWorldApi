using System.Security.Claims;

namespace RealWorld.Api;

public static class ClaimsPrincipalExtensions
{
    public static int? GetLoggedUserId(this ClaimsPrincipal user)
    {
        if (user.Identity?.IsAuthenticated ?? false)
        {
            var claim = user.FindFirst("user_id");
            if (claim != null)
            {
                return Convert.ToInt32(claim.Value);
            }
        }

        return null;
    }
}