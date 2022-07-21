using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do aluno: ");

            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Quadro de Honra!");
            }
            else if (nota >= 7.0)// posso simplificar retirarndo  && nota < 9
            {
                Console.WriteLine("Aluno aprovado");
            }else if(nota >= 5.0) // posso simplificar retirando  && nota < 7.0
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Fim do teste lógico!");
            }


            Console.WriteLine("FIM!!");


        }
    }
}
