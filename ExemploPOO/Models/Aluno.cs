using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }
        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, eu sou o aluno {Nome} e tenho {Idade}");
        }
    }
}