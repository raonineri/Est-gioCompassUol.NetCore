namespace Vendedores.Application.Dtos.Outputs
{
    public class GetAllVendedoresOutputDto
    {
        public GetAllVendedoresOutputDto(List<VendedorOutputDto> vendedor)
        {
            Vendedor = vendedor;
        }

        public List<VendedorOutputDto> Vendedor { get; set; }

    }
}
