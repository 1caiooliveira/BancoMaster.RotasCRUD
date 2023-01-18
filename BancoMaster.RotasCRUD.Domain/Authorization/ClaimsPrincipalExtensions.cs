using System.Security.Claims;

namespace BancoMaster.RotasCRUD.Domain.Authorization;

public static class ClaimsPrincipalExtensions
{
    public static string? GetUsuarioId(this ClaimsPrincipal principal)
       => principal.FindFirstValue(ClaimTypes.NameIdentifier);

    public static string? GetUsuarioNome(this ClaimsPrincipal principal)
        => principal?.FindFirstValue(ClaimTypes.Name);

    private static string? FindFirstValue(this ClaimsPrincipal principal, string claimType) =>
        principal is null
            ? throw new ArgumentNullException(nameof(principal))
            : principal.FindFirst(claimType)?.Value;
}
