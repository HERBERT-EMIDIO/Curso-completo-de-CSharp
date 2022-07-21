using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var nomes in pessoas)
            {
                Console.WriteLine("Olá {0}", nomes);
            }
        }

        public static void Executar()
        {
            Recepcionar("HERBERT", "Herbert", "Felipe", "Emidio");

           
                
        }
    }
}
