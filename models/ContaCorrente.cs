using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, int saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }
        public int NumeroConta { get; set; }
        private int Saldo;

        public void Sacar(int valorSaque)
        {
            if (Saldo >= valorSaque)
            {
                Saldo -= valorSaque;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para a operação");
            }

        }

        public void VerSaldo()
        {
            Console.WriteLine($"Saldo em conta é {Saldo}");
        }
    }
}