using System;
using System.Globalization;
namespace Execicio11;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escolha o Produto: \r\n 1-Cachorro Quente \r\n 2-X Salada \r\n 3-X Bacon \r\n 4-Torrada Simples \r\n 5-Refrigerante \r\n Em seguida a quantidade.");
        string[] valores = Console.ReadLine().Split(' ');
        int codigo = int.Parse(valores[0]);
        int quantidade = int.Parse(valores[1]);

        double total;
        if (codigo == 1)
        {
            total = quantidade * 4.0;
        }
        else if (codigo == 2)
        {
            total = quantidade * 4.5;
        }
        else if (codigo == 3)
        {
            total = quantidade * 5.0;
        }
        else if (codigo == 4)
        {
            total = quantidade * 2.0;
        }
        else
        {
            total = quantidade * 1.5;
        }

        Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

    }
}