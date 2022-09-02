using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class HistoricoEscolarMap : IEntityTypeConfiguration<HistoricoEscolarEntity>
    {
        public void Configure(EntityTypeBuilder<HistoricoEscolarEntity> builder)
        {
            builder.ToTable("HistoricoEscolar");

            builder.HasKey(k => k.Id);
                    
            builder.Property(h => h.Nome)
                    .IsRequired()
                    .HasMaxLength(60);
            builder.Property(h => h.Formato)
                    .IsRequired()
                    .HasMaxLength(4);
        }
    }
}