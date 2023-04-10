using System;

namespace Exercicio12;

class Program
{
    public static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());

        if (x < 0 || x > 100)
        {
            Console.WriteLine("Fora do intervalo");
        }
        else if (x <= 25.0)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (x <= 50.0)
        {
            Console.WriteLine("Intervalo [25,50]");
        }
        else if (x <= 75.0)
        {
            Console.WriteLine("Intervalo [50,75]");
        }
        else
        {
            Console.WriteLine("Intervalo [75,100]");
        }
    }
}