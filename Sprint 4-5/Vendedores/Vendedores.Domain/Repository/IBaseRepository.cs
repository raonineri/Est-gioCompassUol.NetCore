using System.Linq.Expressions;
using Vendedores.Domain.Entidades;

namespace Vendedores.Domain.Repository
{
    public interface IBaseRepository<T, U> : IDisposable where T : BaseEntidade where U : BaseEntidade
    {

        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate);

        Task<T> GetById(Guid id);

        Task<List<Vendedor>> GetAll();

        Task<bool> Create(T model);

        Task<T> Update(U model);

        Task<bool> Delete(Guid id);

    }
}
