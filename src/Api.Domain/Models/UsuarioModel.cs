using System;

namespace Api.Domain.Models
{
    public class UsuarioModel : BaseModel
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _sobrenome;
        public string Sobrenome
        {
            get { return _sobrenome; }
            set { _sobrenome = value; }
        }
        
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        
        private DateTime _dataNascimento;
        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }
        
        private int? _escolaridadeId;
        public int? EscolaridadeId
        {
            get { return _escolaridadeId; }
            set { _escolaridadeId = value == 0 ? null : value; }
        }
        
        private int? _historicoEscolarId;
        public int? HistoricoEscolarId
        {
            get { return _historicoEscolarId; }
            set { _historicoEscolarId = value == 0 ? null : value; }
        }
    }
}