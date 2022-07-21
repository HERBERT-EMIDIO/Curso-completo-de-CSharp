namespace CursoCSharp.OO
{
    public class Carro
    {
        //protected = modificador de acesso(será trnasm por herança), readonly não permitirá mexer na velocidade.
        protected readonly int VelocidadeMaxima;

        int VelocidadeAtual;
        //public Carro() { } //construtor padrão

        public Carro(int VelocidadeMaxima) //Construtor base
        {
            this.VelocidadeMaxima = VelocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)//Método
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }
        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }
    //--------------------------
    public class Uno : Carro // Criando classe Uno
    {
        //como não há um contrutor padrão tm que chamar o construtor base
        public Uno() : base(200)
        {

        }
    }
    //---------------------------

    public class Ferrari : Carro //criando class Ferrari
    {
        public Ferrari() : base(350)
        {

        }

        //"Sobrescrever" o método acelerar modificando a classe mais genérica.
        public override int Acelerar() //obs: Devemos acrescentar o "virtual" na classe carro em  (public virtual int Acelerar())
        {
            return AlterarVelocidade(15);
        }

        //"ocutar" o método da classe Pai e sobrescreve
        public new int Frear()
        {
            return AlterarVelocidade(-9);
        }

    }



    //---------------------------

    class Heranca
    {
        public static void Executar()
        {
            System.Console.WriteLine("Trabalhando com o Uno...");

            Carro carroUno = new Uno();
            System.Console.WriteLine(carroUno.Acelerar());
            System.Console.WriteLine(carroUno.Acelerar());

            System.Console.WriteLine(carroUno.Frear());
            System.Console.WriteLine(carroUno.Frear());

            System.Console.WriteLine();

            System.Console.WriteLine("Trabalhando com Ferrari...");
            Carro carroFerrari = new Ferrari();
            System.Console.WriteLine(carroFerrari.Acelerar());
            System.Console.WriteLine(carroFerrari.Frear());

            System.Console.WriteLine(carroFerrari.Acelerar());
            System.Console.WriteLine(carroFerrari.Frear());
            System.Console.WriteLine();

            System.Console.WriteLine("Trabalhando com Ferrari tipo diferente");
            Carro ferrariTunada = new Ferrari(); //Polimorfismo
            System.Console.WriteLine(ferrariTunada.Acelerar()); 
            System.Console.WriteLine(ferrariTunada.Acelerar()); 
            System.Console.WriteLine(ferrariTunada.Acelerar()); 
            System.Console.WriteLine(ferrariTunada.Frear());
            System.Console.WriteLine();

            System.Console.WriteLine("Trabalhando com uma Ferrari com motor de Uno");
            ferrariTunada = new Uno(); //Polimorfismo
            System.Console.WriteLine(ferrariTunada.Acelerar());
            System.Console.WriteLine(ferrariTunada.Acelerar());
            System.Console.WriteLine(ferrariTunada.Frear());

        }
    }
}
