using System;

namespace Api.Domain.Entities
{
    public class UsuarioEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int? EscolaridadeId { get; set; }
        public EscolaridadeEntity Escolaridade { get; set; }
        public int? HistoricoEscolarId { get; set; }
        public HistoricoEscolarEntity HistoricoEscolar { get; set; }
    }
}