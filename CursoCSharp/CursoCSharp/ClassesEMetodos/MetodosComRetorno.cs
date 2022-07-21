namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        //método1 onde em 1º lugar temos o tipo de retorno = int e 2° parâmetros de entrada a , b logo, 2 parâmetros
        public int Somar(double a, int b)
        {
            return (int)a + b; //somando um double com um int e convertendo para um int
        }

        //método2 com 3 parametros para nao ser diferente do método 1
        public int Somar(int c, int d, int e)
        {
            return c + d;
        }

        //método3
        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        //método4
        public int Multilicar(int a, int b)
        {
            return a * b;
        }

    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }
        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir()
        {
            System.Console.WriteLine(memoria);
            return this;
        }
        public int Resultado()
        {
            return memoria;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);
            System.Console.WriteLine(resultado);
            System.Console.WriteLine(calculadoraComum.Subtrair(12, 6));


            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(6).Multiplicar(5).Imprimir().Limpar().Imprimir();
            System.Console.WriteLine("resultado final:" + resultado );
        }
    }
}
