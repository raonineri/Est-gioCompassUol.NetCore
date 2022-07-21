// https://www.beecrowd.com.br/judge/pt/problems/view/1234

using System;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        string sentencaDancante = null;
        bool letraMaiuscula = true;

        string casoTeste;

        while (!string.IsNullOrWhiteSpace(casoTeste = Console.ReadLine()))
        {
            for (int i = 0; i < casoTeste.Length; i++)
            {
                if (casoTeste[i] == ' ')
                {
                    sentencaDancante += casoTeste[i].ToString();
                    continue;
                }

                if (letraMaiuscula == true)
                {
                    sentencaDancante += casoTeste[i].ToString().ToUpper();
                    letraMaiuscula = false;
                }
                else
                {
                    sentencaDancante += casoTeste[i].ToString().ToLower();
                    letraMaiuscula = true;
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine(sentencaDancante);

    }
}
