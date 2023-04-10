using System;
using System.Globalization;
namespace Exercicio21;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite casos de teste:");
        int teste = int.Parse(Console.ReadLine());


        for (int i = 1; i <= teste; i++)
        {
            Console.WriteLine("Digite dois números para divisão:");
            string[] num = Console.ReadLine().Split(' ');
            double a = double.Parse(num[0], CultureInfo.InvariantCulture);
            double b = double.Parse(num[1], CultureInfo.InvariantCulture);
            if (a != 0 && b != 0)
            {

                double resultado = a / b;
                Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Divisão impossível");
            }
        }
    }
}