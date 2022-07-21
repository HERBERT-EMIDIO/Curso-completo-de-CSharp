using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavras = "opa!";

            foreach (var letras in palavras)
            {
                Console.WriteLine(letras);
            }

            var alunos = new string[] { "Herbert", "Felipe", "Emidio" };
            foreach(string aprendiz in alunos)
            {
                Console.WriteLine(aprendiz);
            }
        }
    }
}
