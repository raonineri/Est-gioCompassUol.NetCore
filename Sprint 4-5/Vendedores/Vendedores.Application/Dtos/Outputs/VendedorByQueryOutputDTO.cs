namespace Vendedores.Application.Dtos.Outputs
{
    public class VendedorByQueryOutputDTO
    {
        public VendedorByQueryOutputDTO(List<VendedorOutputDto> vendedor)
        {
            Vendedor = vendedor;
        }

        public List<VendedorOutputDto> Vendedor { get; set; }
    }
}
