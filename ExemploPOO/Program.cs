using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {   
            Computador comp = new Computador();
            System.Console.WriteLine(comp.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();


            // Aluno p1 = new Aluno();
            // p1.Nome = "Guilherme";
            // p1.Idade = 25;

            // p1.Apresentar();

            // // Valores validos:
            // Retangulo r1 = new Retangulo();
            // r1.DefinirMedidas(30, 40);
            // System.Console.WriteLine($"Área: {r1.ObterArea()}");
            // // Valores invalidos:
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0,0);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");
            
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Guilherme";
            // p1.Idade = 25;

            // p1.Apresentar ();
        }
    }
}