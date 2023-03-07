using System;

namespace Exercicio3
{
    class Program
    {
        public static void Main(string[] args)
        {

            int a, b, c, d, dif;

            Console.WriteLine("Digite 4 números:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            dif = a * b - c * d;

            Console.WriteLine("A diferença é = " + dif);
        }
    }
}