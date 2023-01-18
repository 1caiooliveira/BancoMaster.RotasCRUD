using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMaster.RotasCRUD.Domain.Entities
{
    public class Rota : BaseEntity
    {
        public Guid? LocalOrigemId { get; set; }
        public Local LocalOrigem { get; set; }
        public Guid? LocalDestinoId { get; set; }
        public Local LocalDestino { get; set; }
        public decimal Valor { get; set; }
    }
}
