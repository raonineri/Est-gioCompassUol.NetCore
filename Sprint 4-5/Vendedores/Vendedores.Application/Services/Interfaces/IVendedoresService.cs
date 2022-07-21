using FluentResults;
using Vendedores.Application.Dtos.Inputs;
using Vendedores.Application.Dtos.Outputs;
using Vendedores.Domain.Entidades;

namespace Vendedores.Application.Services.Interfaces
{
    public interface IVendedoresService : IDisposable
    {
        Task<VendedorOutputDto> AdicionaVendedorDb(CreateVendedorDto vendedorDto);
        
        Task<Result> EditVendedor(Guid id, EditVendedorDto vendedorDto);
        
        Task<VendedorByIdOutputDto> RecuperaVendedorId(GetVendedorDto dto);

        Task<VendedorByQueryOutputDTO> RecuperaVendedorQuery(GetVendedorDto dto);
        
        Task<GetAllVendedoresOutputDto> RecuperaTodosVendedores();
        
        Task<Result> RemovePorId(Guid id);


        VendedorAlteracao SerializaAlteracao(Vendedor vendedor);


    }
}
