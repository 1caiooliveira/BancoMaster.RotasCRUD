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
    public class GetAllLocaisQuery : IRequest<IEnumerable<LocalDto>>
    {
        public class GetAllLocalQueryHandler : IRequestHandler<GetAllLocaisQuery, IEnumerable<LocalDto>>
        {
            private readonly AppDbContext _db;
            private readonly IMapper _mapper;

            public GetAllLocalQueryHandler(AppDbContext db, IMapper mapper)
            {
                _db = db;
                _mapper = mapper;
            }

            public async Task<IEnumerable<LocalDto>> Handle(GetAllLocaisQuery request, CancellationToken cancellationToken)
            {
                var localList = _mapper.Map<IEnumerable<LocalDto>>(await 
                    _db.Locais.Where(l => l.Ativo == true).ToListAsync());

                if(localList is null)
                {
                    return null;
                }

                return localList;
            }
        }
    }
}
