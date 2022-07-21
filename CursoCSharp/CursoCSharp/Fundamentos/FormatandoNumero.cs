using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.178;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));//para Real
            Console.WriteLine( valor.ToString("P")); //porcentagem
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US"); // formatação da linguagem
            Console.WriteLine(valor.ToString("C3", cultura));// c3 com 3 casas decimais

            int inteiroComDezPosisoes = 256;
            Console.WriteLine("Apresentando um numero inteiro com 10 posições: " + inteiroComDezPosisoes.ToString("D10"));


        }
    }
}
