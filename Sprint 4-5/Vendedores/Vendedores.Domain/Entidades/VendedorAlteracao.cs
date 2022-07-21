namespace Vendedores.Domain.Entidades
{
    public class VendedorAlteracao : BaseEntidade
    {
        protected VendedorAlteracao() { }

        public VendedorAlteracao(Guid vendedorPorId, string estadoPreAlteracao, DateTime dataAlteracao)
        {

            this.VendedorPorId = vendedorPorId;
            this.DataAlteracao = dataAlteracao;
            this.EstadoPreAlteracao = estadoPreAlteracao;
        }

        public Guid Id { get; private set; }

        public Guid VendedorPorId { get; private set; }

        public string EstadoPreAlteracao { get; private set; }

        public DateTime DataAlteracao { get; private set; }

        public virtual Vendedor Vendedor { get; private set; }

    }
}
