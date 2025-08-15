using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.models
{
    public abstract class Conta
    {
        protected decimal Saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo da conta é: {Saldo}");
        }
    }
}