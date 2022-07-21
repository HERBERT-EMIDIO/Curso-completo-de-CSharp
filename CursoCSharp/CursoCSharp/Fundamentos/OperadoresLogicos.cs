using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50P = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine($"Comprou Tv de 50P? {comprouTv50P}.");

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou sorvete? " + comprouSorvete);

            //negação
            Console.WriteLine("Comprou sorvete?  " + comprouSorvete + " ou  mais saldável seria que o resultado fosse " + !comprouSorvete);

            var comprouTv32P = executouTrabalho1 ^ executouTrabalho2; //OR EXCLUSIVO
            Console.WriteLine("Comprou TV de 32P? {0}", comprouTv32P);


        } 
    }
}
