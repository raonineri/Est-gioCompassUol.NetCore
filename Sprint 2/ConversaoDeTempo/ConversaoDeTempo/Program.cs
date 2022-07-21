// https://www.beecrowd.com.br/judge/pt/problems/view/1019
using System;

public class Program
{
    public static void Main(string[] args)
    {

        int.TryParse(Console.ReadLine(), out int valorSegundos);

        int segundos, horas, minutos, restoSegundos;

        horas = valorSegundos / 3600;
        restoSegundos = valorSegundos % 3600;

        minutos = restoSegundos / 60;

        segundos = restoSegundos % 60;

        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
}


