using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7.0)
            {
                Console.WriteLine("Arovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");
            }
            else
                Console.WriteLine("Reprovado");

        }
    }
}
