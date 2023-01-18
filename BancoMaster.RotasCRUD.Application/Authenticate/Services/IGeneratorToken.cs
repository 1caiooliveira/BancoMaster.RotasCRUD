using BancoMaster.RotasCRUD.Domain.Entities;

namespace BancoMaster.RotasCRUD.Application.Authenticate.Services;

public interface IGeneratorToken
{
    LoginResponse GeraJwtToken(Usuario usuario);
}
