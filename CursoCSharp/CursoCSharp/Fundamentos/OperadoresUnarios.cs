using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // para inverter o valor é só colocar o -
            Console.WriteLine(!booleano); // para mudar o valor lógico


            //-------------------------------mesmo resultado------------------------
            numero1++;//pós fixado
            Console.WriteLine(numero1);

            --numero1;//pré fixado maior precedência 
            Console.WriteLine(numero1);
            //---------------------------------------------------------------------

            Console.WriteLine(numero1++ == --numero2); // true, código ruim
            Console.WriteLine($"Valor do número1: {numero1} e o valor do número2: {numero2}");


        }
    }
}
