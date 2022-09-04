using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Escolaridades
{
    public class EscolaridadeCreateDto
    {
        [Required(ErrorMessage = "Descricao é um campo obrigatório")]
        [MaxLength(12, ErrorMessage = "O campo descricao deve ter no máximo {1} caracteres.")]
        [RegularExpression("Infantil|Fundamental|Médio|Superior", ErrorMessage = "Valor informado inválido, são aceitos somente os seguintes valores: Infantil|Fundamental|Médio|Superior")]
        public string Descricao { get; set; }
    }
}