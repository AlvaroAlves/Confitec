namespace Api.Domain.Entities
{
    public class HistoricoEscolarEntity : BaseEntity
    {
        public string Formato { get; set; }
        public string Nome { get; set; }
        public string HistoricoUrl {get; set;}
        public int IdUsuario {get;set;}
    }
}