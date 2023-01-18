using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BancoMaster.RotasCRUD.Application.Queries.Login;
using BancoMaster.RotasCRUD.Domain.Authorization;
using BancoMaster.RotasCRUD.Domain.Notifications;
using BancoMaster.RotasCRUD.Services.Api.Extensions;

namespace BancoMaster.RotasCRUD.Services.Api.Controllers.v1;

public class LoginController : MainController
{
    private readonly IMediator _mediator;
    public LoginController(INotificador notificador, 
        IAppUsuario appUsuario,
        IMediator mediator) : base(notificador, appUsuario)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Método para realizar o login na API para acesso aos demais métodos
    /// </summary>
    /// <param name="request">Objeto com login e senha</param>
    /// <returns>Retorna o objeto com o token de acesso</returns>
    [HttpPost]
    [AllowAnonymous]
    [OperationOrder(1)]
    public async Task<IActionResult> Post([FromForm] LoginRequest request)
    {
        var response = await _mediator.Send(request);

        return CustomResponse(response);
    }
}
