using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Herbert";
            // nome = 123; 
            Console.WriteLine(nome);

            //int idade
            var idade = 32;
            Console.WriteLine("Idade é: " + idade);

            int a; // declaração de uma variável
            a = 15;
            int b = 2; // iniciando uma variável

            int somaIdade = a + b;
            Console.WriteLine(somaIdade);

        }
    }
}
