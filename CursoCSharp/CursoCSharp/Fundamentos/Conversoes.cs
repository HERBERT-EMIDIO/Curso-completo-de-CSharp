using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro; //Houve uma conversão
            Console.WriteLine(quebrado);


            double nota =9.7;
            //int notaTruncada = nota; // não é possível, dessa forma, realizar essa conversão de double para int
            int notaTruncada = (int)nota; // houve uma conversão de double para int
            Console.WriteLine("Nota Truncada: {0}", notaTruncada); // resposta --> 9


            Console.WriteLine("Digite sua idade: ");// vamos converter de string para int
            string idadestring = Console.ReadLine();
            int idadeInteiro = int.Parse(idadestring);
            Console.WriteLine("Idade na forma de string: {0} e a idade na forma de inteiro: {1}", idadestring, idadeInteiro);


            idadeInteiro = Convert.ToInt32(idadestring);
            Console.WriteLine("Convertendo usando o ToInt32 " + idadeInteiro);


            //usando TryParse
            Console.WriteLine("Digite o primeiro número:");
            string palavraParaConverter = Console.ReadLine();
            int numero1;
            int.TryParse(palavraParaConverter, out numero1);
            Console.WriteLine("Resultado 1: " + numero1);


            //outra forma de usar o Tryparse
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: " + numero2);



        } 
    }
}
