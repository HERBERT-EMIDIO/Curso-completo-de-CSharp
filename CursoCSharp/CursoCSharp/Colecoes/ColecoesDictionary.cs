using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>(); //1°coluna das chaves
            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "o Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2004]); //valor associado a chave 2004
                Console.WriteLine("2002: " + filmes.GetValueOrDefault(2002));//valor associado a chave 2002
            }
            Console.WriteLine();

            //verificar se há um valor contido o array
            Console.WriteLine(filmes.ContainsValue("Gladiador"));// true ou false
            Console.WriteLine();

            //remover filme
            Console.WriteLine($"O filme foi removido? {filmes.Remove(2004)}");
            foreach (var listfilme in filmes)
            {
                Console.WriteLine(listfilme);//já nao há mais "Os Incríveis"
            }
            Console.WriteLine();

            //----------------Formas de percorrer o Dicionário-----------------------

            //Só a chave
            foreach(var chave in filmes.Keys)
            {
                Console.WriteLine("Só chaves: "+ chave);
            }
            Console.WriteLine();

            //Só os valores

            foreach(var valor in filmes.Values)
            {
                Console.WriteLine("Só valore: "+ valor);
            }
            Console.WriteLine();

            //chave e valor
            foreach(KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine("Valor e Chave: "+ filme);
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
            Console.WriteLine();

            //
            foreach(var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            

        }
    }
}
