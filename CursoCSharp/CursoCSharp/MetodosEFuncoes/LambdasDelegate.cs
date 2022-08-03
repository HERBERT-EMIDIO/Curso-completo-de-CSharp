using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y); // o delegete criando um tipo Operacao

    class LambdasDelegate
    {

        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(2, 3));
            Console.WriteLine(sub(2, 3));
            Console.WriteLine(mult(2, 3));
        }
    }
}
