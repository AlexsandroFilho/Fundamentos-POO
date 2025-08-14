using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        //O "virtual" indica que o metodo pode ser sobreescrito
        public virtual void Apresentar()
        {
            Console.Write($"Ola, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}