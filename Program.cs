using poo.models;

/* Pessoa p1 = new Pessoa("Alex", 22);
p1.Apresentar();
 */

//Encapsulamento
/* 
ContaCorrente conta = new ContaCorrente(1, 2300);
conta.Sacar(300);
conta.VerSaldo(); */

//Herança

Aluno aluno1 = new Aluno("Alex", 22, 9.0);
aluno1.Apresentar();
Console.WriteLine();

//Polimorfismo
Professor prof1 = new Professor("Danilo", 30, 2000);
prof1.Apresentar();
