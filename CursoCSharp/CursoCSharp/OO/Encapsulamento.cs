using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            System.Console.WriteLine("FilhoNaoReconhecido...");
            System.Console.WriteLine(InfoPublica);
            System.Console.WriteLine(CorDosOlhos);
            System.Console.WriteLine(JeitoDeFalar);

            System.Console.WriteLine();
        }
    }

    //--------------------------outra class
    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            System.Console.WriteLine("AmigoDistante...");
            System.Console.WriteLine();
            System.Console.WriteLine(amiga.InfoPublica);
        }
    }

    //------------------------------------------------
    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();
            System.Console.WriteLine();

            new FilhoNaoReconhecido().MeusAcessos();
            System.Console.WriteLine();

            new AmigoDistante().MeusAcessos();
            System.Console.WriteLine();

            new AmigoProximo().MeusAcesso();
            System.Console.WriteLine();

            new FilhoReconhecido().MeusAcessos();


        }
    }
}
