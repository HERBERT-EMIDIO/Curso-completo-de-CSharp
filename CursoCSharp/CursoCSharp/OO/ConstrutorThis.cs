using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.OO
{
    public class Animal //Classe Pai
    {
        public string Nome { get; set; }

        public Animal(string Nome) //Construtor base
        {
            this.Nome = Nome;
        }

        //construtor padrão sem nada, sem ele é necessário usar :base()
        //public Animal() { }
    }


    //--------------------------outra class -----------------

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        //puxando o contrut do animal usando " :base()"
        public Cachorro(string Nome) : base(Nome) 
        {
            Console.WriteLine($"Cachorro {Nome} inicializado.");
        }

        public Cachorro(string Nome, double Altura) : this(Nome)
        {
            this.Altura = Altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura.";
        }

    }

    //-----------------------------

    class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);
            Console.WriteLine();
            

            //como eu fiz o Tostring posso imprimir assim linha 37
            Console.WriteLine(spike);
            Console.WriteLine(max);
            
        }
    }
}
