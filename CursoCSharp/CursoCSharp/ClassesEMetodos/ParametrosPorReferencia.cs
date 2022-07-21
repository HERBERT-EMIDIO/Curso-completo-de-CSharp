using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero +=  1000;
        }

        public static void AlteratOut(out int numero)
        {
            numero = 0;
            numero = numero + 15;
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a); //usando ref --> referência 
            Console.WriteLine(a);

            //int b = 2;
            AlteratOut(out int b);
            Console.WriteLine(b);
        }
    }
}
