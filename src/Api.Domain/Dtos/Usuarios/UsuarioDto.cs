using System;
using Api.Domain.Dtos.Escolaridades;
using Api.Domain.Dtos.HistoricosEscolares;
using Api.Domain.Interfaces;

namespace Api.Domain.Dtos.Usuarios
{
    public class UsuarioDto : IDtoBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public int? EscolaridadeId { get; set; }
        public EscolaridadeDto Escolaridade {get;set;}
        public int? HistoricoEscolarId { get; set; }
        public HistoricoEscolarDto HistoricoEscolar {get;set;}
    }
}