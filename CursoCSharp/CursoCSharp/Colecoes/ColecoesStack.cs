using System;
using System.Collections;//não usa o generic

namespace CursoCSharp.Colecoes
{
    class ColecoesStack //pilha último a entrar é o primeiro a sair
    {
        public static void Executar()
        {

            //-------------preimeiro momento
            var pilha = new Stack();
            pilha.Push(3); //silva
            pilha.Push("a"); // emidio
            pilha.Push(true); // felipe
            pilha.Push(3.14f); //herbert

            foreach (var item in pilha)
            {
                Console.WriteLine($"Primeira varredura nos elementos da pilha: {item}. ");
            }
            Console.WriteLine($"\nUsando o Pop() sai/remove o primeiro elemento: {pilha.Pop()}");// O Pop vai sacar o Primeiro elemento (3,14) da pilha e retornar o objeto removido da pilha (3,14)

            foreach (var item in pilha) //varredura e jogar no item
            {
                Console.WriteLine($"Segunda varredura nos elementos da pilha logo após o 1 pop: usando foreach {item}.");
            }

            Console.WriteLine($"Usando o Caunt {pilha.Count}");
            Console.WriteLine();
//-------------------------------------------SEGUNDO MOMENTO
            Console.WriteLine($"\nUsando o Peek() sai o preimeiro elemento: {pilha.Peek()}");//apresenta,mas não remove o primeiro elemento(agora, o "true" ..3,14 já morreu) e apresenta o último(3).

            //Console.WriteLine($"após o Peek usando o Count: {pilha.Count}");//metodo q mostra o elemento no topo 

            foreach (var item in pilha)
            {
                Console.WriteLine($"após o Peek usando o foreach: {item}");
            }



        }
    }
}
