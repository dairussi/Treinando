using System;
using System.Globalization;

namespace Exercicio13;

class Program
{
    public static void Main(string[] args)
    {
        string[] cordenadas = Console.ReadLine().Split(' ');
        double x = double.Parse(cordenadas[0]);
        double y = double.Parse(cordenadas[1]);

        if (x == 0 && y == 0)
        {
            Console.WriteLine("Origem");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("Q1");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Q4");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Q3");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Q2");
        }
    }
}