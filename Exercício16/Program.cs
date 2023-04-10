using System;

namespace Exercicio16;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor para x e y:");
        string[] cordenadas = Console.ReadLine().Split(' ');
        int x = int.Parse(cordenadas[0]);
        int y = int.Parse(cordenadas[1]);
        while (x != 0 && y != 0)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("PRIMEIRO");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("QUARTO");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("TERCEIRO");
            }
            else
            {
                Console.WriteLine("SEGUNDO");
            }
            Console.WriteLine("Digite um novo valor para x e y:");
            cordenadas = Console.ReadLine().Split(' ');
            x = int.Parse(cordenadas[0]);
            y = int.Parse(cordenadas[1]);
        }
    }
}