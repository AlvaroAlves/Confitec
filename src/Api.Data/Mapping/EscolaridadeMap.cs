using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class EscolaridadeMap : IEntityTypeConfiguration<EscolaridadeEntity>
    {
        public void Configure(EntityTypeBuilder<EscolaridadeEntity> builder)
        {
            builder.ToTable("Escolaridades");

            builder.HasKey(k => k.Id);
            builder.Property(e => e.Id)
                    .ValueGeneratedOnAdd();
            builder.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(12);
        }
    }
}