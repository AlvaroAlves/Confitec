using System;

namespace Api.Domain.Models
{
    public class UsuarioModel
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
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
        
        private int _escolaridadeId;
        public int EscolaridadeId
        {
            get { return _escolaridadeId; }
            set { _escolaridadeId = value; }
        }
        
        private int _historicoEscolarId;
        public int HistoricoEscolarId
        {
            get { return _historicoEscolarId; }
            set { _historicoEscolarId = value; }
        }
        
        private DateTime _createAt;
        public DateTime CreateAt
        {
            get { return _createAt; }
            set { _createAt = value == null ? DateTime.UtcNow : value; }
        }
        
        private DateTime _updateAt;
        public DateTime UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = value; }
        }
    }
}