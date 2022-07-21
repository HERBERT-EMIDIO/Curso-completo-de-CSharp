using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saldacao = "olá ".ToUpper().Insert(3, " World").Replace("World", "Mundo!");// altera o texto para letras maíusculas
           
            Console.WriteLine(saldacao);

            Console.WriteLine("texte".Length); // usando o . para visualizar as funcionalidades
        }
    }
}
