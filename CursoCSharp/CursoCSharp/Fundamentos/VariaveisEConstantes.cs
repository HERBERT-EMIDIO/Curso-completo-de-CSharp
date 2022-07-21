using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //área da circunferência

            double raio = 4.5;
            const double PI = 3.1415;

            raio = 5.5;

            double area = PI * Math.Pow(raio, 2);
            Console.WriteLine($"Área é {area}");


            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está Chovendo? " + estaChovendo);

            byte idade = 45; // não entra valores negativo  0 até 256  sem sinal
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MaxValue;//-127 até +128  com sinal
            sbyte saldoDeGols2 = sbyte.MinValue;
            Console.WriteLine($"Máximo valor {saldoDeGols} e o Valor Mínimo {saldoDeGols2}");

            short salario = short.MaxValue;
            Console.WriteLine($"Salário {salario}");

            int MenorValorInt = int.MinValue; // com sinal
            Console.WriteLine("Menor valor do int " + MenorValorInt);

            uint populacaoBrasil = 207_600_00;// sem sianl
            Console.WriteLine("População Brasileira " + populacaoBrasil);

            long menorValorLong = long.MinValue; // com sinal, é um inteiro que armaz em 8 bytes
            Console.WriteLine("Menor Valor do Long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000; // sem sinal
            Console.WriteLine("População Mundial " + populacaoMundial);


            float precoComputador = 1299.99F; // usa-se o F no final, float armaz em 4 bytes
            Console.WriteLine("Preço do computador é de: " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // armaz 8 bytes de ponto flut
            Console.WriteLine("Valor de Mercado da Aplle " + valorDeMercadoDaApple);

            decimal distanciaDasEstrelas = decimal.MaxValue;
            Console.WriteLine("A distância das estrelas é de " + distanciaDasEstrelas);

            char letra = 'b';//uma so letra
            Console.WriteLine("Letra" + letra);

            string texto = "Seja bem vindo";
            Console.WriteLine(texto);








        }
    }
}
