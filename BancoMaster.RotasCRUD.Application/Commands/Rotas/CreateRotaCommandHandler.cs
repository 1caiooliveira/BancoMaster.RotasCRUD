using AutoMapper;
using BancoMaster.RotasCRUD.Domain.Contexts;
using BancoMaster.RotasCRUD.Domain.Entities;
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
    public class CreateRotaCommandHandler : IRequestHandler<CreateRotaRequest, Guid?>
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        private readonly INotificador _notificador;

        public CreateRotaCommandHandler(AppDbContext db, IMapper mapper, INotificador notificador)
        {
            _db = db;
            _mapper = mapper;
            _notificador = notificador;
        }
        public async Task<Guid?> Handle(CreateRotaRequest request, CancellationToken cancellationToken)
        {
            #region Validações
            var localOrigem = await _db.Locais.Where(l => l.Nome == request.LocalOrigem).SingleOrDefaultAsync();
            if (localOrigem is null)
            {
                _notificador.Handle(new Notificacao("O Local de origem informado não existe."));
                return null;
            }

            var localDestino = await _db.Locais.Where(l => l.Nome == request.LocalDestino).SingleOrDefaultAsync();
            if (localDestino is null)
            {
                _notificador.Handle(new Notificacao("O Local de destino informado não existe."));
                return null;
            }

            var rotaExiste = await _db.Rotas.AnyAsync(r => r.LocalDestinoId == localDestino.Id && r.LocalOrigemId == localOrigem.Id);
            if (rotaExiste)
            {
                _notificador.Handle(new Notificacao("Já existe uma rota cadastrada com esses dados."));
                return null;
            }
            #endregion

            Rota newRota = new Rota
            {
                LocalOrigemId = localOrigem.Id,
                LocalDestinoId = localDestino.Id,
                Valor = (decimal)request.Valor,
                Ativo = true,
                DataCadastro = DateTime.Now
            };

            _db.Rotas.Add(newRota);
            await _db.SaveChangesAsync();

            return newRota.Id;            
        }
    }
}
