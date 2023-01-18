using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BancoMaster.RotasCRUD.Application;
using BancoMaster.RotasCRUD.Application.Authenticate.Services;
using BancoMaster.RotasCRUD.Application.Queries.Login;
using BancoMaster.RotasCRUD.Domain.Contexts;
using BancoMaster.RotasCRUD.Domain.Entities;
using BancoMaster.RotasCRUD.Domain.Notifications;

namespace BancoMaster.RotasCRUD.Application.Queries.Login;
#nullable disable
public class LoginRequestHandler : IRequestHandler<LoginRequest, LoginResponse>
{
    private readonly AppDbContext _db;
    private readonly INotificador _notificador;
    private readonly IGeneratorToken _generatorToken;
    private readonly IConfiguration _config;

    public LoginRequestHandler(AppDbContext db, 
        INotificador notificador,
        IGeneratorToken generatorToken,
        IConfiguration config)
    {
        _db = db;
        _notificador = notificador;
        _generatorToken = generatorToken;
        _config = config;
    }

    public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
    {
        var usuario = new Usuario
        {
            Login = _config.GetValue<string>("Login:login"),
            Senha = _config.GetValue<string>("Login:senha")
        };

        if (usuario.Login != request.Username || usuario.Senha != request.Password)
        {
            _notificador.Handle(new Notificacao("Login e/ou Senha inválido(s)"));
            return null;
        }

        var loginResponse = _generatorToken.GeraJwtToken(usuario);
        return loginResponse;
    }
}
