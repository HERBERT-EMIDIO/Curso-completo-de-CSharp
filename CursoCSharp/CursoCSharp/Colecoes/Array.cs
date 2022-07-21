using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Herbert";
            alunos[1] = "Felipe";
            alunos[2] = "Emidio";
            alunos[3] = "Aline";
            alunos[4] = "Cavalcante";
           
            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }


            //OUTRA FORMA DE FAZER
            double Somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8};

            foreach (var notaAluno in notas) 
            {
                Somatorio += notaAluno;
            }

            double media = Somatorio / notas.Length;
            Console.WriteLine(media);

            //  ARRAY DE CHAR
            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavras = new string(letras);
            Console.WriteLine(palavras);

           


        }
    }
}
