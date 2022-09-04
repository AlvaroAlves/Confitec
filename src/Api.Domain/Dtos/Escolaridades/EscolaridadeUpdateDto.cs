using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Escolaridades
{
    public class EscolaridadeUpdateDto
    {
        [Required(ErrorMessage = "Id é um campo obrigatório")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Descricao é um campo obrigatório")]
        [MaxLength(12, ErrorMessage = "O campo descricao deve ter no máximo {1} caracteres.")]
        public string Descricao { get; set; }
    }
}