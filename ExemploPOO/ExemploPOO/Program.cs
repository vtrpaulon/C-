using System;
using ExemploPOO.models;

namespace ExemploPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pontos p1 = new Pontos();

            p1.IncluirValores (5, 2);

            Console.WriteLine($"Pontos p1: {p1.MostrarPontos()}");

            Pontos p2 = new Pontos();
            p2.IncluirValores (5, 3);

            Console.WriteLine($"Pontos p2: {p2.MostrarPontos()}");

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Vitor";
            // p1.Idade = 34;

            // p1.Apresentar();
        }
    }
}
