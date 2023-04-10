using System;

namespace Exercicio10;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a hora inicial e em seguida a hora final do jogo:");
        string[] horas = Console.ReadLine().Split(' ');
        int horaInicial = int.Parse(horas[0]);
        int horaFinal = int.Parse(horas[1]);

        int duracao;
        if (horaInicial < horaFinal)
        {
            duracao = horaFinal - horaInicial;
        }
        else
        {
            duracao = (24 - horaInicial) + horaFinal;
        }

        Console.WriteLine($"A duração da competição foi: {duracao}");

    }
}