using Microsoft.AspNetCore.Http;
using System.Security.Claims;

#nullable disable

namespace BancoMaster.RotasCRUD.Domain.Authorization;

public class AppUsuario : IAppUsuario
{
    private readonly IHttpContextAccessor _accessor;
    public string Nome => _accessor.HttpContext.User.Identity.Name;

    public AppUsuario(IHttpContextAccessor accessor)
    {
        _accessor = accessor;
    }

    public IEnumerable<Claim> GetClaimsIdentity()
    {
        return _accessor.HttpContext.User.Claims;
    }

    public string GetUsuarioId()
    {
        return IsAuthenticated() ? _accessor.HttpContext.User.GetUsuarioId() : "";
    }

    public bool IsAuthenticated()
    {
        var isAuthenticated = _accessor?.HttpContext?.User?.Identity?.IsAuthenticated;
        return isAuthenticated ?? false;
    }
}
