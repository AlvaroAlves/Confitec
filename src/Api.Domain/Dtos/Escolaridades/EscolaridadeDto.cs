using System;
using Api.Domain.Interfaces;

namespace Api.Domain.Dtos.Escolaridades
{
    public class EscolaridadeDto : IDtoBase
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string Descricao { get; set; }
    }
}