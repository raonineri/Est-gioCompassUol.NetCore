using Vendedores.Domain.Entidades;
using Vendedores.Domain.Repository;
using Vendedores.Domain.Services.Interfaces;

namespace Vendedores.Domain.Services
{
    public sealed class VendedorDomainService : IVendedorDomainService
    {
        private readonly IBaseRepository<Vendedor, VendedorAlteracao> _vendedoresRepository;

        public VendedorDomainService(IBaseRepository<Vendedor, VendedorAlteracao> vendedoresRepository)
        {
            this._vendedoresRepository = vendedoresRepository;
        }

        public async Task<bool> AdicionarVendedor(Vendedor entidade)
        {
            bool resp = await _vendedoresRepository.Create(entidade);
            return resp;
        }

        public async Task<bool> AtualizarVendedor(VendedorAlteracao entidade)
        {
            Vendedor? resp = await _vendedoresRepository.Update(entidade);
            
            if (resp != null) return true;
            return false;
        }

        public async Task<bool> RemoverVendedor(Guid id)
        {
            bool resp = await _vendedoresRepository.Delete(id);

            return resp;
        }

        public async Task<VendedorAlteracao> ObterUltimaAlteracao(Guid id)
        {
            Vendedor? model = await _vendedoresRepository.GetById(id);

            VendedorAlteracao? ultimaAlteracao = model.ObterAlteracaoMaisRecente();

            return ultimaAlteracao;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
