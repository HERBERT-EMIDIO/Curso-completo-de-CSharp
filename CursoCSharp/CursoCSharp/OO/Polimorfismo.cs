using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso  { get; set; }

        public Comida()
        {
        }
        public Comida(double Peso)
        {
            this.Peso = Peso;
        }
       
    }

    public class Feijao : Comida
    {
        //public double Peso; // há uma herança uqe recebe o peso
    }

    public class Arroz :Comida
    {
        //public double Peso;
    }

    public class Carne : Comida
    {
        //public double Peso;
    }

    public class Pessoa
    {
        public double Peso;

        /*public void Comer(Feijao feijao)//pegar o peso do feijão e add 
        {
            Peso += feijao.Peso;
        }

        public void Comer(Arroz arroz)//pegar o peso do arroz e add 
        {
            Peso += arroz.Peso;
        }

        public void Comer(Carne carne)//pegar o peso do carne e add 
        {
            Peso += carne.Peso;
        }*/
        public void Comer(Comida comida)
        {
            Peso += comida.Peso;
        }
    }

    class Polimorfismo
    {

        public static void Executar()
        {
            Feijao ingrediente1 = new Feijao();
            ingrediente1.Peso = 0.3;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso =0.3;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Balança : peso do cliente é {cliente.Peso}Kg!");

        }
    }
}
