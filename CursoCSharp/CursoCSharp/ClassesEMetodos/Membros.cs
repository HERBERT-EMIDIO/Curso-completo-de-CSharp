using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa(); //contrutor onde o Pessoa é o tipo, sicrano é o nome, 
            sicrano.Nome = "Herbert";
            sicrano.Idade = 38;

            //chamando um método vazio
            sicrano.Zerar();

            Console.WriteLine($"{sicrano.Nome} tem  {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Felipe";
            fulano.Idade = 36;

            fulano.ApresentarNoConsole();

            var alunoTeste = new Pessoa(); //criando outro objeto
            alunoTeste.Nome = "Her";
            alunoTeste.Idade = 31;

            alunoTeste.ApresentarNoConsole();

            var tamanhoTexto = alunoTeste.Nome;
            Console.WriteLine("tamanho dessa string {0}",tamanhoTexto.Length);

        }
    }
}
