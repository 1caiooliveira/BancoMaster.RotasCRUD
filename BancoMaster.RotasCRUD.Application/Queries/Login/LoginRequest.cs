using MediatR;

namespace BancoMaster.RotasCRUD.Application.Queries.Login;

public class LoginRequest : IRequest<LoginResponse>
{
    public string? Username { get; set; }
    public string? Password { get; set; }

}
