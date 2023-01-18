using BancoMaster.RotasCRUD.Application.Commands.Rotas;
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
    public class RotaController : MainController
    {
        private readonly IMediator _mediator;

        public RotaController(INotificador notificador, IAppUsuario appUsuario, IMediator mediator) : base(notificador, appUsuario)
        {
            _mediator = mediator;
        }
        
        /// <summary>
        /// Método para trazer a melhor rota de um local para o outro
        /// </summary>
        /// <returns>Objeto Rota Ideal</returns>
        /// <response code="200">objeto Rota Ideal</response>
        /// <response code="400">A requisição foi mal formada</response>
        /// <response code="401">Usuário não passou por autenticação ou não enviou o Token de acesso</response>
        /// <response code="403">Usuário não possui acesso ao recurso solicitado</response>
        [HttpGet("rota-ideal")]
        [OperationOrder(75)]
        public async Task<IActionResult> GetRotaIdeal(string origem, string destino)
        {
            var response = await _mediator.Send(new GetRotaIdealRequest{ Destino = destino, Origem = origem });

            return CustomResponse(response);
        }

        /// <summary>
        /// Método para listar todas as rotas ativa
        /// </summary>
        /// <returns>Lista de objeto Rotas</returns>
        /// <response code="200">Lista de objeto Rotas</response>
        /// <response code="400">A requisição foi mal formada</response>
        /// <response code="401">Usuário não passou por autenticação ou não enviou o Token de acesso</response>
        /// <response code="403">Usuário não possui acesso ao recurso solicitado</response>
        [HttpGet]
        [OperationOrder(35)]
        public async Task<IActionResult> Get()
        {
            var response = await _mediator.Send(new GetAllRotasQuery());

            return CustomResponse(response);
        }

        /// <summary>
        /// Método para alterar uma rota ativa
        /// </summary>
        /// <returns>Mensagem de sucesso</returns>
        /// <response code="200">Rota alterada com sucesso</response>
        /// <response code="400">A requisição foi mal formada</response>
        /// <response code="401">Usuário não passou por autenticação ou não enviou o Token de acesso</response>
        /// <response code="403">Usuário não possui acesso ao recurso solicitado</response>
        [HttpPost("alterar-rota")]
        [OperationOrder(50)]
        public async Task<IActionResult> Update(UpdateRotaRequest request)
        {
            var response = await _mediator.Send(request);

            return CustomResponse(response);
        }

        /// <summary>
        /// Método para criar uma nova rota 
        /// </summary>
        /// <returns>Mensagem de sucesso</returns>
        /// <response code="200">Id da rota criada</response>
        /// <response code="400">A requisição foi mal formada</response>
        /// <response code="401">Usuário não passou por autenticação ou não enviou o Token de acesso</response>
        /// <response code="403">Usuário não possui acesso ao recurso solicitado</response>
        [HttpPost("adicionar-rota")]
        [OperationOrder(65)]
        public async Task<IActionResult> Post(CreateRotaRequest request)
        {
            var response = await _mediator.Send(request);

            return CustomResponse(response);
        }

        
    }
}
