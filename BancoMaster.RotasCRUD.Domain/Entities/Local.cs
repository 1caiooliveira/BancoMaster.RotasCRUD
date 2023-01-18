using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMaster.RotasCRUD.Domain.Entities
{
    public class Local : BaseEntity
    {
        public string? Nome { get; set; }
        public ICollection<Rota>? RotasOrigem { get; set; }
        public ICollection<Rota>? RotasDestino { get; set; }

    }
}
