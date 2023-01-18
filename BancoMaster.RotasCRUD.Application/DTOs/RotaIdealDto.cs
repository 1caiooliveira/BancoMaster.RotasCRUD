using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMaster.RotasCRUD.Application.DTOs
{
    public class RotaIdealDto
    {
        public string? Rotas { get; set; }
        public IEnumerable<Guid?> Ids { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
