using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.HistoricosEscolares
{
    public class HistoricoEscolarCreateDto
    {        
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [MaxLength(60, ErrorMessage = "O campo Nome deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }
    }
}