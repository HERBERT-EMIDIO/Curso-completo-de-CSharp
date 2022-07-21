using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Tenho um instagram!";

        //Herança
        protected string CorDosOlhos = "Verde";

        //Mesmo Projeto (Mesmo Assembly)
        internal ulong NumeroCelular = 5511999999999;

        //Herança ou Mesmo Projeto
        protected internal string JeitoDeFalar = "Uso muitas Gírias";

        //Mesma classe ou Herança no mesmo Projeto (c# 7.0)
        // private protected string SergredoFamilia = "BlaBlaBla";

        //private que é o valor padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("Subcelebridade...");
            Console.WriteLine();
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SergredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }

    }
}
