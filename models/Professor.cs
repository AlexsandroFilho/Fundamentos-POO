using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.models
{
    public class Professor : Pessoa
    {
        public Professor(string nome, int idade, decimal salario) : base(nome, idade)
        {
            Salario = salario;
        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Ola, sou o Professor {Nome}, e o meu salario é {Salario}");
        }
    }
}