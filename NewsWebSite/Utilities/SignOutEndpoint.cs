using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace NewsWebSite.Utilities
{
    public static class SignOutEndpoint
    {
        public static IEndpointConventionBuilder MapSignOutEndpoint(this IEndpointRouteBuilder builder)
        {
            ArgumentNullException.ThrowIfNull(builder);
            var accountGroup = builder.MapGroup("/Account");
            return accountGroup.MapPost("/Logout", Manage);
        }

        private static async Task<RedirectHttpResult> Manage(ClaimsPrincipal user, SignInManager<IdentityUser> signInManager)
        {
            await signInManager.SignOutAsync();
            return TypedResults.LocalRedirect("/");
        }
    }
}
