using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Interfaces;

namespace Api.Domain.Dtos.Escolaridades
{
    public class EscolaridadeCreateUpdateDto : EscolaridadeDto, IDtoBase
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}