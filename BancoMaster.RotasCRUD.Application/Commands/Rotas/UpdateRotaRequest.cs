using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMaster.RotasCRUD.Application.Commands.Rotas
{
    public class UpdateRotaRequest : IRequest<string>
    {

        [Required(ErrorMessage = "O Id da Rota é obrigatório")]
        public Guid? Id { get; set; }

        [Required(ErrorMessage = "O novo local de origem é obrigatório.")]
        public string? NovoLocalOrigem { get; set; }

        [Required(ErrorMessage = "O novo local de destino é obrigatório.")]
        public string? NovoLocalDestino { get; set; }

        public decimal? Valor { get; set; }
    }
}
