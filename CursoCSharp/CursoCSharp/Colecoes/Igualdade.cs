namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            //colecao lista- Produto
            var p1 = new Produto("Caneta", 1.99); 
            var p2 = new Produto("Caneta", 1.99);
            var p3 = p2;

            System.Console.WriteLine(p1 == p2);//comparar endereço de memória
            System.Console.WriteLine(p3 == p2);//comparar por referÊncia 

            System.Console.WriteLine(p1.Equals(p2));//comparar endereço de memória 
        }
    }
}
