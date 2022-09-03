using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.Usuarios
{
    public class UsuarioUpdateDto
    {
        [Required(ErrorMessage = "Id é um campo obrigatório")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [MaxLength(60, ErrorMessage = "O campo Nome deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }
        
        [MaxLength(100, ErrorMessage = "O campo Sobrenome deve ter no máximo {1} caracteres.")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Email é um campo obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo Email deve ter no máximo {1} caracteres.")]
        [EmailAddress(ErrorMessage = "Email em formato inválido.")]
        public string Email { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }
    }
}