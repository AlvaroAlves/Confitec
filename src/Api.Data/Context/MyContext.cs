using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UsuarioEntity> Usuarios { get; set; }
        public DbSet<EscolaridadeEntity> Escolaridade {get;set;}
        public DbSet<HistoricoEscolarEntity> HistoricoEscolar { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);
            builder.Entity<UsuarioEntity> (new UsuarioMap().Configure);
            builder.Entity<EscolaridadeEntity> (new EscolaridadeMap().Configure);
            builder.Entity<HistoricoEscolarEntity> (new HistoricoEscolarMap().Configure);
        }
    }
}