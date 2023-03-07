using System;
using System.Globalization;

namespace Exercicio2;

class Program
{
    public static void Main(string[] args)
    {
        double raio, area;

        Console.WriteLine("Informe o valor do raio para saber a área do círculo:");
        raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        area = Math.PI * Math.Pow(raio, 2);
        Console.WriteLine($"A área correspondente é: {area.ToString("F4", CultureInfo.InvariantCulture)}");

    }
}



