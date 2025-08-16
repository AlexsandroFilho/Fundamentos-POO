using poo.Interfaces;
using poo.models;
using POO.models;

/* Pessoa p1 = new Pessoa("Alex", 22);
p1.Apresentar();
 */

//Encapsulamento
/* 
ContaCorrente conta = new ContaCorrente(1, 2300);
conta.Sacar(300);
conta.VerSaldo(); */

//Herança

/* Aluno aluno1 = new Aluno("Alex", 22, 9.0);
aluno1.Apresentar();
Console.WriteLine();

//Polimorfismo
Professor prof1 = new Professor("Danilo", 30, 2000);
prof1.Apresentar(); */

//Classes abstratas e interfaces - Classe que é apenas modelo para outras fazerem herança
/* Corrente conta = new Corrente();
conta.Creditar(700);
conta.ExibirSaldo();
 */

//Interface
ICalculadora calc = new Calculadora();
Console.Write(calc.Somar(11, 4));