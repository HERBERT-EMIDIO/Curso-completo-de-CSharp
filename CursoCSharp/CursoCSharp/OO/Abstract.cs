using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{

    public abstract class Celular //conceito de celular em geral, classe inacabada
    {
        public abstract string Assistente(); //métodos abstrato sem implementação
        public string Tocar()
        {
            return "trim trim trim........";
        }

    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá!! Meu nome é Bixby!";
        }  
    }

    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Siri";
        }

    }


    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new Iphone(),
                new Samsung()
            };

            foreach(var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
            
        }
    }
}
