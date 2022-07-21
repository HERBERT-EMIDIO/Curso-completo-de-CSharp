using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.Write("Avalie o meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                    Console.WriteLine("Muito Ruim");
                    break;
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Poderia ser melhor");
                    break;
                case 4:
                    Console.WriteLine("Já vi melhor");
                    break;
                case 5:
                    Console.WriteLine("Atendimento Top");
                    Console.WriteLine("Parabéns");
                    break;
                default:
                    Console.WriteLine("Digite um valor válido!");
                    break;
            }
            Console.WriteLine("Obrigado!!!");
        }
    }
}
