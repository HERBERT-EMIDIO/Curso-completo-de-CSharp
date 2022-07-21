namespace CursoCSharp.ClassesEMetodos
{

    public class Produto
    {
        //criando atributos
        public string Nome;
        public double Preco;
        public double Desconto = 0.1; // se fosse public static double Desconto -- o desconto seria da classe

        //construtor recebendo 3 parâmetros
        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        //criando construtor vazio/padrão
        public Produto()
        {

        }
        //criando método para calculo do desconto
        public double CaulcularDesconto()
        {
            return Preco - Preco * Desconto;
        }


    }




    class AtirbutosEstaticos
    {

        public static void Executar()
        {
            var produto1 = new Produto("caneta", 5.20, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
                Desconto = 0.1
            };

            System.Console.WriteLine("Preço com desconto: {0}", produto1.CaulcularDesconto());
            System.Console.WriteLine("Preço com desconto: {0}", produto2.CaulcularDesconto());
        }
    }
}
