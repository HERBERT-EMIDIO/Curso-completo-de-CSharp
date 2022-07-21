using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 6.0;
            bool bomResultado = true;
            string resultado = nota >= 7.0 && bomResultado ? "Aprovado" : "Reprovado"; // ?, : simbolos de um operador ternário ,3 expressões
            Console.WriteLine(resultado);
        }
    }
}
