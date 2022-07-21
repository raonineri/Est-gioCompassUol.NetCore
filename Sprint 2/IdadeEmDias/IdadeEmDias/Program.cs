// https://www.beecrowd.com.br/judge/pt/problems/view/1020
using System;
public class Program {
    static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out int idadeEmDias);

        int diasNoAno = 365;
        int diasNoMes = 30;
        int restoDias;

        int anos = idadeEmDias / 365;
        Console.WriteLine($"{anos} ano(s)");

        restoDias = idadeEmDias % 365;
        int meses = restoDias / 30;

        Console.WriteLine($"{meses} mes(es)");

        int dias = restoDias % 30;

        Console.WriteLine($"{dias} dia(s)");
    }
}