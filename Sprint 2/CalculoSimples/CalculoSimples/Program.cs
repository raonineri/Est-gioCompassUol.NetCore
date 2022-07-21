// https://www.beecrowd.com.br/judge/pt/problems/view/1010?origem=1
using System;
class Program {
    public static void Main(string[] args)
    {
        String linhaUm = Console.ReadLine();
        String linhaDois = Console.ReadLine();

        String[] valoresLinhaUm = linhaUm.Split(' ');
        int codPecaUm = int.Parse(valoresLinhaUm[0]);
        int numPecasUm = int.Parse(valoresLinhaUm[1]);
        double valorPecaUm = double.Parse(valoresLinhaUm[2]);

        String[] valoresLinhaDois = linhaDois.Split(' ');
        int codPecaDois = int.Parse(valoresLinhaDois[0]);
        int numPecasDois = int.Parse(valoresLinhaDois[1]);
        double valorPecaDois = double.Parse(valoresLinhaDois[2]);

        double valorAPagarLinhaUm = numPecasUm * valorPecaUm;
        double valorAPagarLinhaDois = numPecasDois * valorPecaDois;

        Console.WriteLine($"VALOR A PAGAR: R$ {valorAPagarLinhaUm + valorAPagarLinhaDois:f2}");
    }        
}