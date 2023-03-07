using System;
using System.Globalization;

namespace Exercicio5;

class Program
{
    public static void Main(string[] args)
    {
        double a, b, c, areatriangulo, areacirculo, areatrapezio, areaquadrado, arearetangulo;

        Console.WriteLine("Digite número para A, B e C:");
        string[] valores = Console.ReadLine().Split(' ');
        a = double.Parse(valores[0], CultureInfo.InvariantCulture);
        b = double.Parse(valores[1], CultureInfo.InvariantCulture);
        c = double.Parse(valores[2], CultureInfo.InvariantCulture);

        areatriangulo = (a * c) / 2;
        areacirculo = Math.PI * Math.Pow(c, 2);
        areatrapezio = ((a + b) / 2) * c;
        areaquadrado = Math.Pow(b, 2);
        arearetangulo = a * b;

        Console.WriteLine($"Triangulo: " + areatriangulo.ToString("F3", CultureInfo.InvariantCulture) + "\r\nCírculo: " + areacirculo.ToString("F3", CultureInfo.InvariantCulture) + "\r\nTrapézio: " + areatrapezio.ToString("F3", CultureInfo.InvariantCulture) + "\r\nQuadrado: " + areaquadrado.ToString("F3", CultureInfo.InvariantCulture) + "\r\nRetangulo: " + arearetangulo.ToString("F3", CultureInfo.InvariantCulture));

    }
}