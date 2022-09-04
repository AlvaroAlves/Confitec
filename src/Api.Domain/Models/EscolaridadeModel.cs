using System;

namespace Api.Domain.Models
{
    public class EscolaridadeModel : BaseModel
    {
        
        
        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
    }
}