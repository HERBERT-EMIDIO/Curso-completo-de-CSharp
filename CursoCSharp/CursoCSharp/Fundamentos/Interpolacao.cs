﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + "da marca" + marca + ".");
            Console.WriteLine("O {0} da marca {1} custa {2}." , nome, marca, preco);
            Console.WriteLine($"O Preço custa {preco}, e a marca é {marca}.");


        }
    }
}
