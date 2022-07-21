using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{

    public struct Dependente //mudar para struct ou para class
    {
        public string Nome;
        public int Idade;

    }

    class ValorVsReferencia
    {
    
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;

            Console.WriteLine($"Numero: {numero}, Cópia do Número: {copiaNumero}"); //Fiz nada

            numero++; //implementação
            Console.WriteLine($"Número: {numero} Cópia do Número: {copiaNumero}");

            //-----------------------------------------------//

            Dependente dep = new Dependente { Nome = "Herbert", Idade = 38 };
            Dependente copiaDep = dep;
            Console.WriteLine();

            Console.WriteLine($"Dep : {dep.Nome} e copiadep: {copiaDep.Nome}.");
            Console.WriteLine($"dep: {dep.Idade} e copiadep: {copiaDep.Idade}.");
            Console.WriteLine();

            copiaDep.Nome = "Emidio";
            dep.Idade = 39;
            Console.WriteLine();
            Console.WriteLine($"Agora a copiaDep: {copiaDep.Nome} e o dep: {dep.Nome}");
            Console.WriteLine($"Agora a copiaDep: {copiaDep.Idade} e o dep: {dep.Idade}");
          

        }
    }
}
