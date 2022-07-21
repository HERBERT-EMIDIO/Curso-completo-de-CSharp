using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{

    public class Cliente // classes com seus atributos
    {
        public string Nome;
        DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) // construtor
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento() //método
        {
            return String.Format("{0}/ {1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }

    }


    class Readonly
    {
        
        static public void Executar()
        {
            var novoCliente = new Cliente("Herbert Felipe", new DateTime(1983, 7, 28));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}
