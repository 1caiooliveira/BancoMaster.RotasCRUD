﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMaster.RotasCRUD.Application.DTOs
{
    public class LocalDto
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public bool Ativo { get; set; }


    }
}
