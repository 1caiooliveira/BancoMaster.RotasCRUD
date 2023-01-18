using System.Security.Claims;

namespace BancoMaster.RotasCRUD.Domain.Authorization;

public interface IAppUsuario
{
    string Nome { get; }
    string GetUsuarioId();
    bool IsAuthenticated();
    IEnumerable<Claim> GetClaimsIdentity();
}
