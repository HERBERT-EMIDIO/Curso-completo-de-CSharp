using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é seu salário? ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"Nome {nome}, Idade {idade}, Salário R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
