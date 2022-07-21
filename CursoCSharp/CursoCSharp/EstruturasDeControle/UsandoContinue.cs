using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("Número pares entre 1 e {0}!", intervalo);

            for(int i = 1; i <= intervalo; i++)
            {
                if(i % 2 == 1) //numero inpar
                {
                    continue; 
                }

                Console.WriteLine(i + " "); // mostrando o números pares
            }
//------------------------------Mais Simples.
            for(int i = 2; i <= intervalo; i += 2)
            {
                Console.WriteLine("Número Par " + i );
            }
        }
    }
}
