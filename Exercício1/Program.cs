using System;

namespace Exercicio1;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2, soma;

        Console.WriteLine("Digite um número para somar:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número para somar:");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"SOMA = {num1 + num2}");

        soma = num1 + num2;

    }

}