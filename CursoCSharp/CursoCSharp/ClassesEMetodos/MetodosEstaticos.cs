using System;


namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        public static int Somar(int a, int b) // Método public = visível/ retornando um int nome do método Somar/ Estático .. o Acesso é direto, não necessita do var nomeQEuQuero = new CalculadoraEstatica(); pq esse método não pertence ao obj e sim a classe
        {
            return a + b;
        }

        //Método de Classe ou Método estático
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        //método sem ser static
         public int subtrair(int a, int b)
        {
            return a - b;
        }


    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            //chamando método com o static- já pertence a classe
            var resultado = CalculadoraEstatica.Multiplicar(2, 3);
            Console.WriteLine("Resultado da Calculadora: {0}",resultado);

            //chamar método não estático- usando o new -criando uma objeto
            CalculadoraEstatica batata = new CalculadoraEstatica();
            Console.WriteLine(batata.subtrair(10, 3));
            
        }
    }
}
