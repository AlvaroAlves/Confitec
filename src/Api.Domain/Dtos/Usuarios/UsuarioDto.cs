using System;
using Api.Domain.Interfaces;

namespace Api.Domain.Dtos.Usuarios
{
    public class UsuarioDto : IDtoBase
    {
        public string Nome { get; set; }
        
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}