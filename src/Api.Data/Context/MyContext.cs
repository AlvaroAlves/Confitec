using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UsuarioEntity> Usuarios { get; set; }
        public DbSet<EscolaridadeEntity> Escolaridade {get;set;}
        public DbSet<HistoricoEscolarEntity> HistoricoEscolar { get; set; }

    }
}