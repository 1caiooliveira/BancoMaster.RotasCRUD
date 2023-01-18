using AutoMapper;
using BancoMaster.RotasCRUD.Application.DTOs;
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
    public class GetRotaIdealCommandHandler : IRequestHandler<GetRotaIdealRequest, string>
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        private readonly INotificador _notificador;

        public GetRotaIdealCommandHandler(AppDbContext db, IMapper mapper, INotificador notificador)
        {
            _db = db;
            _mapper = mapper;
            _notificador = notificador;
        }

        public async Task<string> Handle(GetRotaIdealRequest request, CancellationToken cancellationToken)
        {
            #region Validações
            var localOrigem = await _db.Locais
                .Include(lo => lo.RotasOrigem)
                .Where(l => l.Nome == request.Origem).SingleOrDefaultAsync();

            if (localOrigem is null)
            {
                _notificador.Handle(new Notificacao("O Local de origem informado não existe."));
                return null;
            }

            var localDestino = await _db.Locais
                .Include(lo => lo.RotasDestino)
                .Where(l => l.Nome == request.Destino).SingleOrDefaultAsync();

            if (localDestino is null)
            {
                _notificador.Handle(new Notificacao("O Local de destino informado não existe."));
                return null;
            }

            var existeDestino = await _db.Rotas.AnyAsync(r => r.LocalDestinoId == localDestino.Id);
            if (!existeDestino)
            {
                _notificador.Handle(new Notificacao("Não existe nenhuma rota com esse destino."));
                return null;
            }

            var existeOrigem = await _db.Rotas.AnyAsync(r => r.LocalOrigemId == localOrigem.Id);
            if (!existeOrigem)
            {
                _notificador.Handle(new Notificacao("Não existe nenhuma rota com esse origem."));
                return null;
            }
            #endregion

            List<RotaIdealDto> aux = new List<RotaIdealDto>();

            var rotas = await _db.Rotas
                        .Include(r => r.LocalDestino)
                        .ThenInclude(ld => ld.RotasDestino)
                        .Include(r => r.LocalOrigem)
                        .ThenInclude(lo => lo.RotasOrigem)
                        .Where(r => r.LocalOrigemId == localOrigem.Id)
                        .ToListAsync();

            var listRotas = _db.Rotas
                  .Include(r => r.LocalDestino)
                  .ThenInclude(ld => ld.RotasDestino)
                  .Include(r => r.LocalDestino)
                  .ThenInclude(ld => ld.RotasOrigem)
                  .Include(r => r.LocalOrigem)
                  .ThenInclude(ld => ld.RotasDestino)
                  .Include(r => r.LocalOrigem)
                  .ThenInclude(ld => ld.RotasOrigem)
              .ToList();

            #region ForAntigo

            //foreach (var rota in rotasOrigem)
            //{
            //    var r = rotasDestino.Where(rd => rd.Id == rota.Id).SingleOrDefault();

            //    if(r is not null)
            //    {
            //        aux.Add(new RotaIdealDto
            //        {
            //            Rotas = $"{rota.LocalOrigem.Nome} - {rota.LocalDestino.Nome}",
            //            ValorTotal = rota.Valor
            //        });

            //        continue;
            //    }

            //    if(rotasDestino.Find(rd => rd.LocalOrigemId == rota.LocalDestinoId) is not null)
            //    {
            //        aux.Add(new RotaIdealDto
            //        {
            //            Rotas = $"{rota.LocalOrigem.Nome} - {rota.LocalDestino.Nome} - {rotasDestino.Find(rd => rd.LocalOrigemId == rota.LocalDestinoId).LocalDestino.Nome}",
            //            ValorTotal = (rota.Valor + rotasDestino.Find(rd => rd.LocalOrigemId == rota.LocalDestinoId).Valor)
            //        });

            //        continue;
            //    }

            //    var auxRotas3escala = rotas.Find(rs => rs.LocalOrigem.RotasDestino.Any(ord => ord.LocalOrigemId == rota.LocalOrigemId));

            //    if()


            //    continue;

            //}
            #endregion

            foreach (var rt in rotas)
            {
                if (rt.LocalDestinoId == localDestino.Id)
                {
                    aux.Add(new RotaIdealDto
                    {
                        Rotas = $"{rt.LocalOrigem.Nome} - {rt.LocalDestino.Nome}",
                        ValorTotal = rt.Valor
                    });

                    continue;
                }

                var result = localDestino.RotasDestino.Where(rd => rd.LocalOrigemId == rt.LocalDestinoId).FirstOrDefault();

                if (result is not null)
                {
                    aux.Add(new RotaIdealDto
                    {
                        Rotas = $"{rt.LocalOrigem.Nome} - {rt.LocalDestino.Nome} - {result.LocalDestino.Nome}",
                        ValorTotal = (rt.Valor + result.Valor)
                    });

                    continue;
                }


                result = listRotas.Find(lr => lr.LocalOrigemId == rt.LocalDestinoId && lr.LocalOrigem.RotasOrigem.Any(ro => ro.LocalDestino.RotasOrigem.Any(roo => roo.LocalDestinoId == localDestino.Id)));

                if (result is not null)
                {
                    var resultAux = listRotas.Find(r => r.LocalDestinoId == localDestino.Id && r.LocalOrigemId == result.LocalDestinoId);

                    if (resultAux is not null)
                    {
                        aux.Add(new RotaIdealDto
                        {
                            Rotas = $"{rt.LocalOrigem.Nome} - {rt.LocalDestino.Nome} - {result.LocalDestino.Nome} - {resultAux.LocalDestino.Nome}",
                            ValorTotal = (rt.Valor + result.Valor + resultAux.Valor)
                        });

                        continue;
                    }
                }


                result = listRotas.Find(lr => lr.LocalOrigem.RotasOrigem.Any(lrr => lrr.LocalDestino.RotasOrigem.Any(lrrr => lrrr.LocalDestino.RotasDestino.Any(le => le.LocalDestinoId == localDestino.Id))));

                if (result is not null)
                {
                    var resultAux = listRotas.Find(lr => lr.LocalDestinoId == localDestino.Id && lr.LocalOrigemId == result.LocalDestinoId);
                    var resultAux2 = listRotas.Find(lr => lr.LocalDestinoId == result.LocalOrigemId && lr.LocalOrigemId == rt.LocalDestinoId);

                    if (resultAux is not null && resultAux2 is not null)
                    {
                        aux.Add(new RotaIdealDto
                        {
                            Rotas = $"{rt.LocalOrigem.Nome} - {rt.LocalDestino.Nome} - {resultAux2.LocalDestino.Nome} - {resultAux.LocalOrigem.Nome} - {resultAux.LocalDestino.Nome}",
                            ValorTotal = (rt.Valor + result.Valor + resultAux.Valor + resultAux2.Valor)
                        });
                    }

                    continue;
                }
            }

            var rotaIdeal = aux.MinBy(aux => aux.ValorTotal);

            return $"{rotaIdeal.Rotas} ao custo de R$ {rotaIdeal.ValorTotal}";
        }
    }
}
