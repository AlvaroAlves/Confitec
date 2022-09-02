using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class HistoricoEscolarEntity : BaseEntity
    {
        public string Formato { get; set; }
        public string Nome { get; set; }
    }
}