using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using BancoMaster.RotasCRUD.Domain.Authorization;
using BancoMaster.RotasCRUD.Domain.Notifications;

namespace BancoMaster.RotasCRUD.Services.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces("application/json")]
[Authorize]
public class MainController : ControllerBase
{
    private readonly INotificador _notificador;
    public readonly IAppUsuario _appUsuario;
    protected string appUsuarioId;
    protected string appUsuarioEmail;
    protected string appUsuarioNome;
    protected bool UsuarioAutenticado;
    protected int StatusCodeCustom = 0;
    protected string[]? MensagensErroCustom;

    public MainController(INotificador notificador, IAppUsuario appUsuario)
    {
        _notificador = notificador;
        _appUsuario = appUsuario;

        if (appUsuario.IsAuthenticated())
        {
            UsuarioAutenticado = appUsuario.IsAuthenticated();  
        }
    }

    protected bool IsOperacaoValida()
    {
        return !_notificador.HasNotificacao();
    }

    protected IActionResult CustomResponse(object? result = null)
    {
        if (StatusCodeCustom > 0)
        {
            return StatusCode(StatusCodeCustom, new
            {
                success = false,
                errors = MensagensErroCustom
            });
        }

        if (IsOperacaoValida())
        {
            return Ok(result);
        }

        return BadRequest(_notificador.GetNotificacoes().Select(n => n.Mensagem));
    }

    protected IActionResult CustomResponse(ModelStateDictionary modelState)
    {
        if (!modelState.IsValid) NotificarErroModelInvalida(modelState);
        return CustomResponse();
    }

    protected void NotificarErroModelInvalida(ModelStateDictionary modelState)
    {
        var erros = modelState.Values.SelectMany(e => e.Errors);

        foreach (var erro in erros)
        {
            var errorMessage = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
            NotificarErro(errorMessage);
        }
    }

    protected void NotificarErro(string mensagem)
    {
        _notificador.Handle(new Notificacao(mensagem));
    }
    protected string ipAddress()
    {
        if (Request.Headers.ContainsKey("X-Forwarded-For"))
            return Request.Headers["X-Forwarded-For"];
        else
            return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
    }

}
