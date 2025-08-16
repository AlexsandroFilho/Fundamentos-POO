using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.models
{
    public class Diretor : Professor
    {
        public Diretor(string nome, int idade, decimal salario) : base(nome, idade, salario)
        {
            
        }
        
    }
}