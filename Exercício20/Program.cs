using System;
using System.Globalization;
namespace Exercicio20;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o número de testes:");
        int testes = int.Parse(Console.ReadLine());

        for (int i = 0; i <= testes; i++)
        {
            Console.WriteLine("Digite 3 números:");
            string[] num = Console.ReadLine().Split(' ');
            double num1 = double.Parse(num[0], CultureInfo.InvariantCulture);
            double num2 = double.Parse(num[1], CultureInfo.InvariantCulture);
            double num3 = double.Parse(num[2], CultureInfo.InvariantCulture);
            double media = (num1 * 2.0 + num2 * 3.0 + num3 * 5.0) / 10.0;
            Console.WriteLine("A média é " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}