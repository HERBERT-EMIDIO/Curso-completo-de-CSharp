namespace Encapsulamento
{
    public class Aluno
    {
        private double Nota1, Nota2;


        private double Media()
        {
            return (Nota1 + Nota2) / 2.0;
        }

        public void mensagem()
        {
            System.Console.Write("Informe a Primeira nota: ");
            Nota1 = double.Parse(Console.ReadLine());

            System.Console.Write("Informe a Segunda nota: ");
            Nota2 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("A média é: "+ Media());
        }
    }
}