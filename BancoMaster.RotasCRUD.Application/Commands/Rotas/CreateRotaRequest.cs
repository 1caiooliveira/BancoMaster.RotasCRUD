using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMaster.RotasCRUD.Application.Commands.Rotas
{
    public class CreateRotaRequest : IRequest<Guid?>
    {

        [Required(ErrorMessage = "O local de origem é obrigatório.")]
        public string? LocalOrigem { get; set; }

        [Required(ErrorMessage = "O local de destino é obrigatório.")]
        public string? LocalDestino { get; set; }

        [Required(ErrorMessage = "O valor é obrigatório.")]
        public decimal? Valor { get; set; }
    }
}
