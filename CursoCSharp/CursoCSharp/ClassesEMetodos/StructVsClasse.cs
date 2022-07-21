using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class StructVsClasse
    {
        public struct SPonto
        {
            public int X;
            public int Y;
        }

        public class CPonto
        {
            public int X;
            public int Y;
        }

        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3};
            SPonto copiaPonto1 = ponto1;
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X: {0}", ponto1.X); // vai apontar para o valor original que é 1 
            Console.WriteLine("Copia Ponto 1 X: {0}", copiaPonto1.X); // cópia/Atribuição por valor


            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2;
            ponto2.X = 4;

            // na classe tanto o ponto 1 e a cópia a pontam para o mesmo lugar --> atribuição or referência
            Console.WriteLine("Ponto 2 X: {0}", ponto2.X); 
            Console.WriteLine("Copia Ponto 2 X: {0}", copiaPonto2.X); 



        }
    }
}
