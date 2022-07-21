using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vendedores.Domain.Entidades;

namespace Vendedores.Data.Mappings
{
    public class VendedorMap : IEntityTypeConfiguration<Vendedor>
    {
        public void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Nome)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.DataNascimento)
                .IsRequired();

            builder.Property(x => x.DataCadastro)
                .IsRequired();

            builder.Property(x => x.DocIdentificacao)
                .HasMaxLength(14)
                .IsRequired();

            builder.HasMany(x => x.Alteracoes)
                .WithOne(x => x.Vendedor)
                .HasForeignKey(x => x.VendedorPorId);
        }
    }
}
