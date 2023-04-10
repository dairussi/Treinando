using System;

namespace Exercicio17;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1.Álcool 2.Gasolina 3.Diesel 4.Fim");
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;
        int escolha = int.Parse(Console.ReadLine());

        while (escolha != 4)
        {
            if (escolha == 1)
            {
                alcool = alcool + 1;
            }
            else if (escolha == 2)
            {
                gasolina = gasolina + 1;
            }
            else if (escolha == 3)
            {
                diesel = diesel + 1;
            }

            escolha = int.Parse(Console.ReadLine());

        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);

    }
}