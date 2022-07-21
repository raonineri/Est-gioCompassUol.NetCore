namespace Vendedores.Application.Dtos.Outputs
{
    public class VendedorByIdOutputDto
    {
        public Guid Id { get; private set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string DocIdentificacao { get; set; }

        public DateTime DataCadastro { get; private set; }

    }
}
