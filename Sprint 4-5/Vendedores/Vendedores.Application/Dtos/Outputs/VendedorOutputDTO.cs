namespace Vendedores.Application.Dtos.Outputs
{
    public class VendedorOutputDto
    {
        public VendedorOutputDto(
            Guid id,
            string nome,
            DateTime dataNascimento,
            string docIdentificacao,
            DateTime dataCadastro)
        {
            this.Id = id;
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.DocIdentificacao = docIdentificacao;
            this.DataCadastro = dataCadastro;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string DocIdentificacao { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
