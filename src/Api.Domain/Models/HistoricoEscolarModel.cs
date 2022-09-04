using System;

namespace Api.Domain.Models
{
    public class HistoricoEscolarModel : BaseModel
    {
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

        private string _historicoUrl;
        public string HistoricoUrl
        {
            get { return _historicoUrl; }
            set { _historicoUrl = value;}
        }
    }
}