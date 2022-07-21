// https://www.beecrowd.com.br/judge/pt/problems/view/1009?origem=1
using System;
class Program
{
    public static void Main(String[] args)
    {

        string nomeVendedor = Console.ReadLine();
        double.TryParse(Console.ReadLine(), out double salarioFixo);
        double.TryParse(Console.ReadLine(), out double vendasEfetuadas);

        var totalAReceber = salarioFixo + (vendasEfetuadas * 0.15);
        Console.WriteLine($"TOTAL = R$ {totalAReceber:f2}");

    }
}