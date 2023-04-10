using System;

namespace Exercicio19;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite aa quantidade de testes:");
        int n = int.Parse(Console.ReadLine());
        int contin = 0;
        int contout = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite um número para testar:");
            int x = int.Parse(Console.ReadLine());
            if (x >= 10 && x <= 20)
            {
                contin = contin + 1;
            }
            else
            {
                contout = contout + 1;
            }
        }

        Console.WriteLine(contin + " in");
        Console.WriteLine(contout + " out");
    }
}