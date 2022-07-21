// https://www.beecrowd.com.br/judge/pt/problems/view/1259
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> valoresPares = new List<int>();
        List<int> valoresImpares = new List<int>();

        int.TryParse(Console.ReadLine(), out int entrada);

        for(int i = 0; i < entrada; i++)
        {
            int.TryParse(Console.ReadLine(), out int entrada2);
            if(entrada2 % 2 == 0)
            {
                valoresPares.Add(entrada2);
            }
            else
            {
                valoresImpares.Add(entrada2);
            }
        }

        valoresPares.Sort();
        valoresImpares.Sort();
        valoresImpares.Reverse();

        foreach(int i in valoresPares)
        {
            Console.WriteLine(i);
        }
        foreach(int i in valoresImpares)
        {
            Console.WriteLine(i);
        }

    }
}