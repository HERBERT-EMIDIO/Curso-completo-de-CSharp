using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class UsandoDelegates
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }

        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static void Executar()
        {
            Soma operacao1 = MinhaSoma;
            Console.WriteLine(operacao1(2, 3.1));

            ImprimirSoma operacao2 = MeuImprimirSoma;
            operacao2(5.4, 3);

            Func<double, double, double> operacao3 = MinhaSoma;
            Console.WriteLine(operacao3(2.5, 3));

            Action<double, double> operacao4 = MeuImprimirSoma;
            operacao4(7.7, 23.4);

        }
    }
}
