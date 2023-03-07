using System;
using System.Globalization;

namespace Exercicio5;

class Program
{
    public static void Main(string[] args)
    {
        int codigo1, quantidade1, codigo2, quantidade2;
        double valor1, valor2, total;

        Console.WriteLine("Digite o código, quantidade e valor dos dois itens, respectivmente separando-os com espaço:");
        string[] valores = Console.ReadLine().Split(' ');
        codigo1 = int.Parse(valores[0]);
        quantidade1 = int.Parse(valores[1]);
        valor1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        valores = Console.ReadLine().Split(' ');
        codigo2 = int.Parse(valores[0]);
        quantidade2 = int.Parse(valores[1]);
        valor2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        total = (quantidade1 * valor1) + (quantidade2 * valor2);

        Console.WriteLine($"Valor a pagar: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

    }

}