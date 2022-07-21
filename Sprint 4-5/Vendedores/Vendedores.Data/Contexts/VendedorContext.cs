using Microsoft.EntityFrameworkCore;
using Vendedores.Data.Mappings;
using Vendedores.Domain.Entidades;

namespace Vendedores.Data.Contexts
{
    public class DbVendedorContext : DbContext
    {
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<VendedorAlteracao> VendedoresAlteracaos { get; set; }

        public DbVendedorContext(DbContextOptions<DbVendedorContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VendedorMap());
            modelBuilder.ApplyConfiguration(new VendedorAlteracaoMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
