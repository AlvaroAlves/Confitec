using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Interfaces;

namespace Api.Domain.Dtos.Usuarios
{
    public class UsuarioCreateUpdateResultDto : UsuarioDto, IDtoBase
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}