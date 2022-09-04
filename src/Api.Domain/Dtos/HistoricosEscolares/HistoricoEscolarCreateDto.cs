using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.HistoricosEscolares
{
    public class HistoricoEscolarCreateDto
    {
        [Required(ErrorMessage = "Formato é um campo obrigatório")]
        [MaxLength(4, ErrorMessage = "O campo Formato deve ter no máximo {1} caracteres.")]
        public string Formato { get; set; }
        
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [MaxLength(60, ErrorMessage = "O campo Nome deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }
    }
}