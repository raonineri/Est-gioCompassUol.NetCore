using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Vendedores.Data.Contexts;
using Vendedores.Domain.Entidades;
using Vendedores.Domain.Repository;

namespace Vendedores.Data.Repository
{
    public class VendedoresRepository : IVendedoresRepository
    {
        private readonly DbVendedorContext _context;

        public VendedoresRepository(DbVendedorContext context)
        {
            _context = context;

        }

        public async Task<List<Vendedor>> GetAll()
        {
            return await _context.Vendedores.ToListAsync();
        }

        public async Task<IEnumerable<Vendedor>> Get(Expression<Func<Vendedor, bool>> predicate)
        {
            List<Vendedor>? result = await _context.Vendedores.Where(predicate).ToListAsync();

            return result;
        }

        public async Task<Vendedor> GetById(Guid id)
        {
            Vendedor vendedor = await _context.Vendedores.FindAsync(id);

            return vendedor;
        }

        public async Task<bool> Create(Vendedor model)
        {

            await _context.AddRangeAsync(model);
            int test = await _context.SaveChangesAsync();
            if (test > 0) return true;

            return false;

        }

        public async Task<Vendedor> Update(VendedorAlteracao model)
        {

            await _context.AddAsync(model);
            int result = await _context.SaveChangesAsync();
            Vendedor? vendedor = await _context.Vendedores.FindAsync(model.VendedorPorId);
            
            if (result > 0) return vendedor;

            return null;
        }

        public async Task<bool> Delete(Guid id)
        {
            Vendedor vendedor = await GetById(id);

            if (vendedor != null)
            {
                await _context.Vendedores.Remove(vendedor).GetDatabaseValuesAsync();
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
