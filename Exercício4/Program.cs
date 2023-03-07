using System;
using System.Globalization;
namespace Exercicio4;

class Program
{
    public static void Main(string[] args)
    {
        int codigo;
        double horas, valorHora, salario;

        Console.WriteLine("Digite o código do funcionário:");
        codigo = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número de horas trabalhadas:");
        horas = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da hora trabalhada:");
        valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        salario = horas * valorHora;

        Console.WriteLine($"Código do Funcionário: {codigo}");
        Console.WriteLine($"Salário: R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
    }

}