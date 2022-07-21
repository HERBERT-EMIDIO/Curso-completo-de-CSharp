namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;

            }
            set
            {
                nome = value;
            }
        }

        // Propriedade autoimplementada
        public double Preco { get; set; }

        //somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); // Lambda
                                               //get
                                               //{
                                               //    return Preco - (desconto * Preco);
                                               //}

        }

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            this.Preco = preco;
        }


    }
    class Props
    {
        public static void Executar() // método
        {
            var opcionalCarro1 = new CarroOpcional("Ar Condicionado" , 3499.9);
            System.Console.WriteLine(opcionalCarro1.PrecoComDesconto);

            // opcionalCarro1.PrecoComDesconto = 1000; não é possivél atribuir outro valor

            var opcionalCarro2 = new CarroOpcional();
            opcionalCarro2.Nome = "Direção Elétrica";
            opcionalCarro2.Preco = 2345.9;

            System.Console.WriteLine(opcionalCarro1.Nome);
            System.Console.WriteLine(opcionalCarro1.Preco);
            System.Console.WriteLine(opcionalCarro1.PrecoComDesconto);

            System.Console.WriteLine(opcionalCarro2.Nome);
            System.Console.WriteLine(opcionalCarro2.Preco);
            System.Console.WriteLine(opcionalCarro2.PrecoComDesconto);

        }
    }
}
