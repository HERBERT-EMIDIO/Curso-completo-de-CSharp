using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresDeAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7; // agora o var num1 possui 7
            num1 += 10; // num1 = num1 + 10
            num1 -= 3; //retirando 3 num1 = num1 - 3
            num1 *= 5;
            num1 /= 2;
            Console.WriteLine(num1);

            //copia vs referência
            int a = 1;
            int b = a;

            //operadores unários  (! ++ --)
            a++; // ENCREMENTO a = a + 1;
            b--; // DECREMENTO b = b - 1;
            Console.WriteLine($"Valor de a : {a} e o valor de b: {b}.");

        }
    }
}
