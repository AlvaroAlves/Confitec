using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.Escolaridades
{
    public class EscolaridadeDto
    {
        [Required(ErrorMessage = "Descricao é um campo obrigatório")]
        [MaxLength(12, ErrorMessage = "O campo descricao deve ter no máximo {1} caracteres.")]
        public string Descricao { get; set; }
    }
}