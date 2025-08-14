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

        public void ExibirNota()
        {
            Console.WriteLine($"Nota: {Nota}, do Aluno: {Nome}");
        }
    }
}