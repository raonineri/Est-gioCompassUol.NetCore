// https://www.beecrowd.com.br/judge/pt/problems/view/1013?origem=1
using System.Text;
    public class Program
    {
        public static void Main(string[] args)
        {

            String[] valoresInput = Console.ReadLine().Split(' ');
            int valorA, valorB, valorC;

            valorA = int.Parse(valoresInput[0]);
            valorB = int.Parse(valoresInput[1]);
            valorC = int.Parse(valoresInput[2]);

            Console.WriteLine($"{MaiorEntre(valorA, valorB, valorC)} eh o maior");
            
        }

        public static int MaiorEntre(int x, int y)
        {

            int maior = (x + y + Math.Abs(x - y)) / 2;

            return maior;
        }

        public static int MaiorEntre(int x, int y, int z)
        {

            int maiorXY = MaiorEntre(x, y);
            int maiorXYZ = (maiorXY + z + Math.Abs(maiorXY - z)) / 2;

            return maiorXYZ;

        }
    }
