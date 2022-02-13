using System;
using ExemploPOO.models;

namespace ExemploPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Vitor";
            p1.Idade = 34;

            p1.Apresentar();
        }
    }
}
