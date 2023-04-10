using System;

namespace Exercicio7;

class Program
{
    public static void Main(string[] ags)
    {
        int num;
        Console.WriteLine("Digite um número para testra se ele é negativo ou não:");
        num = int.Parse(Console.ReadLine());
        if (num >= 0)
        {
            Console.WriteLine("POSITIVO");
        }
        else Console.WriteLine("NEGATIVO");
    }
}

