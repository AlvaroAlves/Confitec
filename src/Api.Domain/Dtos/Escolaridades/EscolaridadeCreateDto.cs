using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Escolaridades
{
    public class EscolaridadeCreateDto
    {
        [Required(ErrorMessage = "Descricao é um campo obrigatório")]
        [MaxLength(12, ErrorMessage = "O campo descricao deve ter no máximo {1} caracteres.")]
        public string Descricao { get; set; }
    }
}