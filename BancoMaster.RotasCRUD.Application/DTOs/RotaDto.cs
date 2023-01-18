using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMaster.RotasCRUD.Application.DTOs
{
    public class RotaDto
    {
        public Guid? Id { get; set; }
        public string? Origem { get; set; }
        public string? Destino { get; set; }
        public decimal? Valor { get; set; }

    }
}
