// https://www.beecrowd.com.br/judge/pt/problems/view/1244

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

class program
{
    static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out int numeroDeTestes);

        List<String> frases = new List<String>();
        List<String> list = new List<String>();
        List<String> listOutput = new List<String>();
        var outPut = new StringBuilder();

        for (int i = 0; i < numeroDeTestes; i++)
        {
            String frase = Console.ReadLine();
            frases.Add(frase);
        }

        foreach (string frase in frases)
        {
            var teste = frase.Split(' ');
            list.Clear();
            foreach (var s in teste)
            {
                list.Add(s);
            }
            var result = list.OrderByDescending(palavra => palavra.Length);

            foreach (var s in result)
            {
                outPut.Append(s);
                outPut.Append(' ');
            }
            outPut.Remove(outPut.Length - 1, 1);
            listOutput.Add(outPut.ToString());
            outPut.Clear();
        }
        foreach (var i in listOutput)
        {
            Console.WriteLine(i);
        }

    }
}
