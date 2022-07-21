using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    
    class DesafioAtributo
    {
        int a = 10;

        public static void Executar()
        {
            //Acessar variável  'a' dentro do método Executar!

            DesafioAtributo varA = new DesafioAtributo();
            Console.WriteLine("A variável a possui o valor de {0}:", varA.a); 


        }
    }
}
