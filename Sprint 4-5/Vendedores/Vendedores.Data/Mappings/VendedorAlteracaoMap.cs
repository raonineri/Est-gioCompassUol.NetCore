using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vendedores.Domain.Entidades;

namespace Vendedores.Data.Mappings
{
    public class VendedorAlteracaoMap : IEntityTypeConfiguration<VendedorAlteracao>
    {
        public void Configure(EntityTypeBuilder<VendedorAlteracao> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.EstadoPreAlteracao)
                .IsRequired();

            builder.Property(x => x.DataAlteracao)
                .IsRequired();

            builder.HasOne(x => x.Vendedor)
                .WithMany(x => x.Alteracoes);
        }
    }
}
