namespace Construtores
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public string Profissao;

        public Pessoa(string Nome, int Idade, string Profissao) //Construtor
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Profissao = Profissao;
            System.Console.WriteLine( "Nome: "+Nome+ ", Idade :"+Idade+ "anos, Profissão: "+Profissao);
        }

      

       
    }
}