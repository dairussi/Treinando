using System;
namespace Exercicio15;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite sua senha:");
        int senha = int.Parse(Console.ReadLine());
        while (senha != 2022)
        {
            Console.WriteLine("Essa não é a sua senha não môquirido");
            Console.WriteLine("Tente novamente:");
            senha = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Agora sim istopô!");
    }
}