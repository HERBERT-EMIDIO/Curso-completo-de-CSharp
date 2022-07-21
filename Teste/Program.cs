// See https://aka.ms/new-console-template for more information
using Teste.Pasta01;

Aluno aluno = new Aluno();
aluno.Nome = "Herbert";
aluno.Nota1 = 10.0;
aluno.Nota2 = 9.0;

double media = aluno.Media();
System.Console.WriteLine( media );

string situacao = aluno.Situacao(media);

System.Console.WriteLine($"Aluno de nome: {aluno.Nome}.");
System.Console.WriteLine("Média: " + media);
System.Console.WriteLine("Situação: " + situacao);
