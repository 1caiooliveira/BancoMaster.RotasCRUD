using AutoMapper;
using BancoMaster.RotasCRUD.Domain.Contexts;
using BancoMaster.RotasCRUD.Domain.Notifications;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMaster.RotasCRUD.Application.Commands.Rotas
{
    public class UpdateRotaCommandHandler : IRequestHandler<UpdateRotaRequest, string>
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        private readonly INotificador _notificador;

        public UpdateRotaCommandHandler(AppDbContext db, IMapper mapper, INotificador notificador)
        {
            _db = db;
            _mapper = mapper;
            _notificador = notificador;
        }

        public async Task<string> Handle(UpdateRotaRequest request, CancellationToken cancellationToken)
        {
            #region Validações
            var rota = await _db.Rotas.Where(r => r.Id == request.Id).SingleOrDefaultAsync();

            if(rota is null)
            {
                _notificador.Handle(new Notificacao("A rota informada não existe."));
                return "";
            }

            var localOrigem = await _db.Locais.Where(l => l.Nome == request.NovoLocalOrigem).SingleOrDefaultAsync();

            if(localOrigem is null)
            {
                _notificador.Handle(new Notificacao("O Local de origem informado não existe."));
                return null;
            }

            var localDestino = await _db.Locais.Where(l => l.Nome == request.NovoLocalDestino).SingleOrDefaultAsync();

            if (localDestino is null)
            {
                _notificador.Handle(new Notificacao("O Local de destino informado não existe."));
                return null;
            }

            var rotaExiste = await _db.Rotas.AnyAsync(r => r.LocalDestinoId == localDestino.Id && r.LocalOrigemId == localOrigem.Id);

            if(rotaExiste)
            {
                _notificador.Handle(new Notificacao("Já existe uma rota cadastrada com esses dados."));
                return null;
            }
            #endregion

            rota.LocalOrigemId = localOrigem.Id;
            rota.LocalDestinoId = localDestino.Id;
            
            if(request.Valor is not null)
            {
                rota.Valor = (decimal)request.Valor;
            }

            await _db.SaveChangesAsync();

            return "Rota alterada com sucesso.";
        }
    }
}
