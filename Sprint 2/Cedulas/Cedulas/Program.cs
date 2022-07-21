// https://www.beecrowd.com.br/judge/pt/problems/view/1018?origem=1
using System;
class Program {
    public static void Main(String[] args) {
        int valor = int.Parse(Console.ReadLine());

        int total = valor;
        int cedulas = 100;
        int totalDeCedulas = 0;

        Console.WriteLine(valor);
        while (true)
        {
            if (total >= cedulas)
            {
                total -= cedulas;
                totalDeCedulas++;
            }
            else
            {

                Console.WriteLine($"{totalDeCedulas} nota(s) de R$ {cedulas},00");

                if (cedulas == 100)
                {
                    cedulas = 50;
                }
                else if (cedulas == 50)
                {
                    cedulas = 20;
                }
                else if (cedulas == 20)
                {
                    cedulas = 10;
                }
                else if (cedulas == 10)
                {
                    cedulas = 5;
                }
                else if (cedulas == 5)
                {
                    cedulas = 2;
                }
                else if (cedulas == 2)
                {
                    cedulas = 1;
                }
                else if (cedulas == 1)
                {
                    cedulas = 0;
                }

                totalDeCedulas = 0;
                if (cedulas == 0)
                {
                    break;
                }
            }
        }
    }
}