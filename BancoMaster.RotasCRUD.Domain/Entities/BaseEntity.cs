using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMaster.RotasCRUD.Domain.Entities
{
    public class BaseEntity
    {
        public BaseEntity() => Id = Guid.NewGuid();
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
