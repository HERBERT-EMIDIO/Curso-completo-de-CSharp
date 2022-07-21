using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {

            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.Write("Possui bom comportamento? (S/N): ");
            entrada = Console.ReadLine();

            if(entrada == "s" || entrada == "S")
            {
                Console.WriteLine("Bom comportamento: True, {0}", entrada);
                bomComportamento = true;
            }

            //outra forma :
            //bomComportamento = entrada == "S" || entrada == "s";
            //bomComportamento = entrada.ToLower() == "s";

            if(nota >= 9 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }

        }
    }
}
