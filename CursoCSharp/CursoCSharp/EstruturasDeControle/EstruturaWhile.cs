using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16); // 16 não entra. Logo, (1 até 15)
            bool numeroEncontrado = false;
            int tentativasRestantes = 15;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas foi {1}", tentativas, numeroSecreto);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("O número Secreto é menor do que o valor digitado: {0}, número de tentativas: {1}", entrada, tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("O número Secreto é maior do que o valor digitado: {0}, número de tentativas: {1}", entrada, tentativasRestantes);
                }
            }
        }
    }
}
