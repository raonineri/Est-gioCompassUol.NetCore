namespace Vendedores.Domain.Entidades
{
    public class Vendedor : BaseEntidade
    {
       
        protected Vendedor()
        {
            this.Id = Guid.NewGuid();
            this.DataCadastro = DateTime.Now;
        }

        public Guid Id { get; private set; }

        public string Nome { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public string DocIdentificacao { get; private set; }

        public DateTime DataCadastro { get; private set; }

        public virtual List<VendedorAlteracao> Alteracoes { get; private set; }

        public VendedorAlteracao ObterAlteracaoMaisRecente() => Alteracoes.OrderByDescending(x => x.DataAlteracao).FirstOrDefault();

    }


}
