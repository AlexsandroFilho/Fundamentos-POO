using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.models
{
    //Para herdar de uma classe, basta apenas colocar ":" e o nome da classe
    public class Aluno : Pessoa
    {
        public Aluno(string nome, int idade, double nota) : base(nome, idade)
        {
            Nota = nota;
        }

        public double Nota { get; set; }

        //a palavra "override" indica que eu estou modificando o metodo da outra classe, para aplicar polimorfismo
        public override void Apresentar()
        {
            Console.WriteLine($"Ola, eu sou o Aluno {Nome}, e a minha note é {Nota}");
        }
    }
}