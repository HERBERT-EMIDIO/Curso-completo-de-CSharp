using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa       //classe pessoa com 2 atributos Nome e Idade
    {
        public string Nome; 
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        } 

        //criando um método que não retorna nada

        public void Zerar()
        {
            Nome = "---";
            Idade = 0;
        }



    }
}
