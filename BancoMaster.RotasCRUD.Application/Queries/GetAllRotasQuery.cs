using AutoMapper;
using BancoMaster.RotasCRUD.Application.DTOs;
using BancoMaster.RotasCRUD.Domain.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMaster.RotasCRUD.Application.Queries
{
    public class GetAllRotasQuery : IRequest<IEnumerable<RotaDto>>
    {
        public class GetAllRotasQueryyHandler : IRequestHandler<GetAllRotasQuery, IEnumerable<RotaDto>>
        {
            private readonly AppDbContext _db;
            private readonly IMapper _mapper;

            public GetAllRotasQueryyHandler(AppDbContext db, IMapper mapper)
            {
                _db = db;
                _mapper = mapper;
            }

            public async Task<IEnumerable<RotaDto>> Handle(GetAllRotasQuery request, CancellationToken cancellationToken)
            {
                var rotasList = _mapper.Map<IEnumerable<RotaDto>>(await
                    _db.Rotas
                    .Include(r => r.LocalOrigem)
                    .Include(r => r.LocalDestino)
                    .ToListAsync());

                if (rotasList is null)
                {
                    return null;
                }

                return rotasList;
            }
        }
    }

}
