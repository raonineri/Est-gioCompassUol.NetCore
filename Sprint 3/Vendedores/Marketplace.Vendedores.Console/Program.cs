using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Collections;
using Vendedores.Application;
using Vendedores.Data;
using Vendedores.Domain.Interfaces;
using Vendedores.Domain.Entidades;

namespace Vendedores
{
    class Program
    {
        public static void Main(string[] args)
        {

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var _vendedoresService = serviceProvider.GetService<IVendedoresService>();
            var _vendedoresRepository = serviceProvider.GetService<IVendedoresRepository>();


            Console.WriteLine("Menu");
            Console.WriteLine("Primeira execução do programa? [S/N]");
            var criarArquivo = Console.ReadLine().ToUpper();

            if (criarArquivo == "S")
            {

                List<VendedoresOutput> vendedoresInput = _vendedoresRepository.DesserializacaoJson("vendedoresInput.json");


                _vendedoresRepository.PopulaListaJson(vendedoresInput);

                _vendedoresRepository.SerializacaoJsonOutput(vendedoresInput);

            }

                var vendedores = _vendedoresRepository.DesserializacaoJson("vendedoresOutput.json");


            while (true)
            {

                Console.WriteLine("Menu");
                Console.WriteLine("1 - Ver as informações do vendedor;");
                Console.WriteLine("2 - Acessar 10 registros quaisquer;");
                Console.WriteLine("3 - Alterar dados do vendedor;");
                Console.WriteLine("4 - Remover vendor da lista;");
                Console.WriteLine("5 - Encerrar programa.");
                Console.Write("Digite a opção desejada para proceguir: ");

                int.TryParse(Console.ReadLine(), out int entrada);

                switch (entrada)
                {
                    case 1:
                        _vendedoresService.PesquisaPorId(vendedores);
                        break;
                    case 2:
                        _vendedoresService.ShowDezVendedores(vendedores);
                        break;
                    case 3:
                        _vendedoresService.AlteraPorId(vendedores);
                        break;
                    case 4:
                        _vendedoresService.RemovePorId(vendedores);
                        break;
                    case 5:
                        Console.WriteLine("Fim do Programa.");
                        return;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
                Console.WriteLine();
                Console.Write("Encerrar programa? [S/N]");
                string condicaoParada = Console.ReadLine().ToUpper();
                if (condicaoParada == "S")
                {
                    Console.WriteLine("Fim do Programa.");
                    break;
                }
            }
        }

        public static void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton<IVendedoresService, VendedoresService>();
            services.AddSingleton<IVendedoresRepository, VendedoresRepository>();

        }

    }
}