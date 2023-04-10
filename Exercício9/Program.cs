using System;

namespace Exercicio9;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite dois valores e descubra se são multiplos:");
        string[] valores = Console.ReadLine().Split(' ');
        int A = int.Parse(valores[0]);
        int B = int.Parse(valores[1]);
        if (A % B == 0 || B % A == 0)
        {
            Console.WriteLine("São multiplos");
        }
        else
        {
            Console.WriteLine("Não são múltiplos");
        }
    }
}