using Microsoft.Extensions.DependencyInjection;
using Vendedores.Data;
using Vendedores.Domain.Entidades;
using Vendedores.Domain.Interfaces;

namespace Vendedores.Application
{
    public class VendedoresService : IVendedoresService
    {

        private readonly IVendedoresRepository _vendedoresRepository;

        public VendedoresService(IVendedoresRepository vendedoresRepository)
        {
            _vendedoresRepository = vendedoresRepository;
        }

        public void PesquisaPorId(List<VendedoresOutput> vendedores)
        {
            Console.WriteLine("Digite o ID: ");
            Guid.TryParse(Console.ReadLine(), out Guid id);
            foreach (var vendedor in vendedores)
            {
                if (vendedor.Id == id)
                {
                    Console.WriteLine();
                    Console.WriteLine("Dados Funcionário: ");
                    Console.WriteLine("Id: " + vendedor.Id);
                    Console.WriteLine("Nome: " + vendedor.Nome);
                    Console.WriteLine("Salário: " + vendedor.Salario);
                    Console.WriteLine("Comissão: " + vendedor.Comissao);
                    Console.WriteLine("Data de Admissão: " + vendedor.DataAdmissao);
                    Console.WriteLine("Data de Inclusão: " + vendedor.DataInclusao);
                    Console.WriteLine("Data de Alteracão: " + vendedor.DataAlteracao);
                }
            }
        }
        
        public void ShowDezVendedores(List<VendedoresOutput> vendedores)
        {
            for (int i = 0; i < 10; i++)
            {
                VendedoresOutput? vendedor = vendedores[i];
                Console.WriteLine();
                Console.WriteLine("Dados Funcionário: ");
                Console.WriteLine("Id: " + vendedor.Id);
                Console.WriteLine("Nome: " + vendedor.Nome);
                Console.WriteLine("Salário: " + vendedor.Salario);
                Console.WriteLine("Comissão: " + vendedor.Comissao);
                Console.WriteLine("Data de Admissão: " + vendedor.DataAdmissao);
                Console.WriteLine("Data de Inclusão: " + vendedor.DataInclusao);
                Console.WriteLine("Data de Alteracão: " + vendedor.DataAlteracao);
                Console.WriteLine();
            }
        }
        
        public void AlteraPorId(List<VendedoresOutput> vendedores)
        {
            Console.WriteLine("Infome o ID para alteração dos dados");
            Guid.TryParse(Console.ReadLine(), out Guid id);

            foreach (var vendedor in vendedores)
            {
                if (vendedor.Id == id)
                {

                    Console.WriteLine("Nome do Funcionário: ");
                    vendedor.Nome = Console.ReadLine();
                    Console.WriteLine("Salário: ");
                    Double.TryParse(Console.ReadLine(), out var novoSalario);
                    vendedor.Salario = novoSalario;
                    Console.WriteLine("Comissão: ");
                    Double.TryParse(Console.ReadLine(), out var novaComissao);
                    vendedor.Comissao = novaComissao;
                    Console.WriteLine("Data de Admissão: ");
                    DateTime.TryParse(Console.ReadLine(), out var novaDataAdmissao);
                    vendedor.DataAdmissao = novaDataAdmissao;
                    Console.WriteLine("Data de inclusão: ");
                    DateTime.TryParse(Console.ReadLine(), out var novaDataInclusao);
                    vendedor.DataInclusao = novaDataInclusao;

                    vendedor.DataAlteracao = DateTime.Now;

                    Console.WriteLine();
                    Console.WriteLine("Dados Funcionário Após Alteração: ");
                    Console.WriteLine("Id: " + vendedor.Id);
                    Console.WriteLine("Nome: " + vendedor.Nome);
                    Console.WriteLine("Salário: " + vendedor.Salario);
                    Console.WriteLine("Comissão: " + vendedor.Comissao);
                    Console.WriteLine("Data de Admissão: " + vendedor.DataAdmissao);
                    Console.WriteLine("Data de Inclusão: " + vendedor.DataInclusao);
                    Console.WriteLine("Data de Alteracão: " + vendedor.DataAlteracao);

                    _vendedoresRepository.SerializacaoJsonOutput(vendedores);
                    vendedores = _vendedoresRepository.DesserializacaoJson("vendedoresOutput.json");
                    break;
                }
            }
  
        }

        public void RemovePorId(List<VendedoresOutput> vendedores)
        {

            Console.WriteLine("Infome o ID para remoção");
            Guid.TryParse(Console.ReadLine(), out Guid id);
            for (int i = 0; i < vendedores.Count; i++)
            {
                VendedoresOutput? vendedor = vendedores[i];
                if (vendedor.Id == id)
                {
                    vendedores.RemoveAt(i);
                    _vendedoresRepository.SerializacaoJsonOutput(vendedores);
                    vendedores = _vendedoresRepository.DesserializacaoJson("vendedoresOutput.json");
                    Console.WriteLine("Operação realizada com sucesso!");
                    break;
                }
            }
        }

    }
}