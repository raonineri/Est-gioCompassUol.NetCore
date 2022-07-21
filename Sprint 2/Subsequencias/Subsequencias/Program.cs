using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        string stringPrincipal;

        int.TryParse(Console.ReadLine(), out int numeroCasosTeste);
        for(int i = 0; i < numeroCasosTeste; i++)
        {
            while (!string.IsNullOrWhiteSpace(stringPrincipal = Console.ReadLine()))
            {
                string subString;
                string resposta;

                int.TryParse(Console.ReadLine(), out int numerosQueries);
                for (int f = 0; f < numerosQueries; f++)
                {
                    subString = Console.ReadLine();

                    resposta = temSubstring(subString, stringPrincipal);

                    if (resposta == "Yes")
                    {
                        Console.Write("Yes");
                    }
                    else
                    {
                        Console.Write("No");
                    }
                    Console.WriteLine();

                }
            }
        }

        static string temSubstring(string string1, string string2)
        {

            for (int i = 0; i <= string2.Length - string1.Length; i++)
            {
                int j;

                for (j = 0; j < string1.Length; j++)
                {
                    if (string2[i + j] != string1[j])
                        break;
                }

                if (j == string1.Length)
                {
                    return "Yes";
                }
            }
            return "No";
        }

    }
}


