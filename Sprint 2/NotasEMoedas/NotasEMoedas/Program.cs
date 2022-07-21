// https://www.beecrowd.com.br/judge/pt/problems/view/1021?origem=1
using System;
public class Program {
    public static void Main(string[] args)
    {
        double input = double.Parse(Console.ReadLine());
        int valor, valorMonetario, cedula, moeda;

        valorMonetario = (int)(input * 100 + 0.5);

        Console.WriteLine("NOTAS:");

        cedula = 100;
        valor = valorMonetario / (cedula * 100);
        Console.WriteLine($"{valor} nota(s) de R$ {cedula}.00");
        valorMonetario %= (cedula * 100);

        cedula = 50;
        valor = valorMonetario / (cedula * 100);
        Console.WriteLine($"{valor} nota(s) de R$ {cedula}.00");
        valorMonetario %= (cedula * 100); ;

        cedula = 20;
        valor = valorMonetario / (cedula * 100);
        Console.WriteLine($"{valor} nota(s) de R$ {cedula}.00");
        valorMonetario %= (cedula * 100);

        cedula = 10;
        valor = valorMonetario / (cedula * 100);
        Console.WriteLine($"{valor} nota(s) de R$ {cedula}.00");
        valorMonetario %= (cedula * 100);

        cedula = 5;
        valor = valorMonetario / (cedula * 100);
        Console.WriteLine($"{valor} nota(s) de R$ {cedula}.00");
        valorMonetario %= (cedula * 100);

        cedula = 2;
        valor = valorMonetario / (cedula * 100);
        Console.WriteLine($"{valor} nota(s) de R$ {cedula}.00");
        valorMonetario %= (cedula * 100);

        Console.WriteLine("MOEDAS:");

        moeda = 100;
        valor = valorMonetario / moeda;
        Console.WriteLine($"{valor} moeda(s) de R$ 1.00");
        valorMonetario %= moeda;

        moeda = 50;
        valor = valorMonetario / moeda;
        Console.WriteLine($"{valor} moeda(s) de R$ 0.50");
        valorMonetario %= moeda;

        moeda = 25;
        valor = valorMonetario / moeda;
        Console.WriteLine($"{valor} moeda(s) de R$ 0.25");
        valorMonetario %= moeda;

        moeda = 10;
        valor = valorMonetario / moeda;
        Console.WriteLine($"{valor} moeda(s) de R$ 0.10");
        valorMonetario %= moeda;

        moeda = 5;
        valor = valorMonetario / moeda;
        Console.WriteLine($"{valor} moeda(s) de R$ 0.05");
        valorMonetario %= moeda;

        moeda = 1;
        valor = valorMonetario / moeda;
        Console.WriteLine($"{valor} moeda(s) de R$ 0.01");
        
    }
}