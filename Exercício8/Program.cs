using System;

namespace Exercicio8;

class Program
{
    public static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Digite um número para saber se é par ou ímpar:");
        num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("PAR");
        }
        else { Console.WriteLine("ÍMPAR"); }
    }
}