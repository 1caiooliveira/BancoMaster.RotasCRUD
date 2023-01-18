using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMaster.RotasCRUD.Application.Commands.Rotas
{
    public class GetRotaIdealRequest : IRequest<string>
    {
        public string? Origem { get; set; }
        public string? Destino { get; set; }
    }
}
