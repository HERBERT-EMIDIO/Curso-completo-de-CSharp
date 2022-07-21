namespace Teste.Pasta01
{
    public class Aluno
    {
        public string Nome;
        public double Nota1, Nota2;


        public double Media()
        {
            return (Nota1 + Nota2) / 2;
        }

        public string Situacao(double Media)
        {
            return Media >= 7 ? "Aprovado" : "Reprovado";
        }

        public void Mensagem()
        {
            double obterMedia = Media();
            string obterSituacao = Situacao(obterMedia);
            System.Console.WriteLine($"O aluno {Nome} com média {obterMedia} está {obterSituacao}.");
        }
    }
}