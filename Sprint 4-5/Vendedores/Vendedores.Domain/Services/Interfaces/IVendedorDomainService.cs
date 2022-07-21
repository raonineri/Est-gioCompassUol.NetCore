using Vendedores.Domain.Entidades;

namespace Vendedores.Domain.Services.Interfaces
{
    public interface IVendedorDomainService : IDisposable
    {

        Task<bool> AdicionarVendedor(Vendedor entidade);
        
        Task<bool> AtualizarVendedor(VendedorAlteracao entidade);

        Task<bool> RemoverVendedor(Guid id);
        
        Task<VendedorAlteracao> ObterUltimaAlteracao(Guid id);

    }
}
