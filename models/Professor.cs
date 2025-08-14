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
    }
}