using System;

namespace Api.Domain.Models
{
    public class HistoricoEscolarModel
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        private string _formato;
        public string Formato
        {
            get { return _formato; }
            set { _formato = value; }
        }
        
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        

        private DateTime _createAt;
        public DateTime CreateAt
        {
            get { return _createAt; }
            set { _createAt = value; }
        }
        
        private DateTime _updateAt;
        public DateTime UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = value; }
        }
    }
}