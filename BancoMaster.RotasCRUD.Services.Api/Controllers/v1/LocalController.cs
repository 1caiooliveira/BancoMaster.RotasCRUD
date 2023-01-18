using BancoMaster.RotasCRUD.Application.Queries;
using BancoMaster.RotasCRUD.Domain.Authorization;
using BancoMaster.RotasCRUD.Domain.Notifications;
using BancoMaster.RotasCRUD.Services.Api.Extensions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BancoMaster.RotasCRUD.Services.Api.Controllers.v1
{

    [Authorize]
    public class LocalController : MainController
    {
        private readonly IMediator _mediator;

        public LocalController(INotificador notificador, IAppUsuario appUsuario, IMediator mediator) : base(notificador, appUsuario)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Método para listar todos os locais ativos
        /// </summary>
        /// <returns>Lista de objeto Local</returns>
        /// <response code="200">Lista de objeto Local</response>
        /// <response code="400">A requisição foi mal formada</response>
        /// <response code="401">Usuário não passou por autenticação ou não enviou o Token de acesso</response>
        /// <response code="403">Usuário não possui acesso ao recurso solicitado</response>
        [HttpGet]
        [OperationOrder(2)]
        public async Task<IActionResult> Get()
        {
            var response = await _mediator.Send(new GetAllLocaisQuery());

            return CustomResponse(response);
        }


    }
}
