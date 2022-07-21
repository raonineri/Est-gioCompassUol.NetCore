// https://www.beecrowd.com.br/judge/pt/problems/view/1251

using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        
        string entrada;
        List<StringBuilder> listaOrdenada = new List<StringBuilder>();

        while (!string.IsNullOrWhiteSpace(entrada = Console.ReadLine()))
        {
            Dictionary<byte, int> dicinario = new Dictionary<byte, int>();

            byte[] ASCII = Encoding.ASCII.GetBytes(entrada);
            
            foreach (var value in ASCII)
            {
                if (dicinario.Count == 0 || !dicinario.ContainsKey(value))
                {
                    dicinario.Add(value, 1);
                }
                else if (dicinario.ContainsKey(value))
                {
                    dicinario[value] += 1;
                }
            }
             
            var sortedDict = from letra in dicinario orderby letra.Value ascending select letra;
            //var listaordenada = lista.OrderBy(c => c.Count()).ThenByDescending(c => c.Key);



            //IEnumerable<KeyValuePair<byte, int>> dictionarySortedByCount = dicinario
            //    .OrderByDescending(x => x.Value.Count)
            //    .ThenBy(x => x.Value[0].ObjectId)
            //    .ToDictionary(x => x.Key, x => x.Value)

            foreach (var value in sortedDict)
            {
                
                Console.WriteLine($"{value.Key} {value.Value}");
            }
            Console.WriteLine();

        }
    }
}
