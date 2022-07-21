using System;
using System.Collections.Generic;//trabalando com uma colecao gereric
using System.Collections;// pra usar o queue sem generic linha 23
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecaoQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrana");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());//exibir o elemento que vai sair da fila, não remove
            Console.WriteLine(fila.Count);// (atributos)-->nos array usamos o length e nas colecções usa-se Count
            Console.WriteLine(fila.Dequeue());//exibe e retira da fila
            Console.WriteLine(fila.Count);//diz o tamanho da fila

            foreach(var pessoa in fila) // Fulano saiu
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item")); //não há com letra minúscula
            Console.WriteLine(salada.Contains("Item"));

           
        }


    }
}
