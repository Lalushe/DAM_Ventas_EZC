﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name="Pais")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo del {0} es obligatorio")]


        public string Name { get; set; } = null!;


    }
}
