namespace ExercicioImc
{
    public class Pessoa
    {
        public double Peso, Altura;

        public double Calculo()
        {
            return Peso / Math.Pow(Altura, Altura);
        }

        public string resultadoImc(double imc)
        {
            string retorno;

            if (imc < 18.5)
            {
                retorno = "Abaixo do peso";
            }
            else if (imc < 25)
            {
                retorno = "Peso normal";
            }
            else if (imc < 30)
            {
                retorno = "Acima do peso";
            }
            else if (imc < 35)
            {
                retorno = "Obesidade I";
            }
            else if (imc < 40)
            {
                retorno = "Obesidade II";
            }
            else
            {
                retorno = "Obesidde III";
            }
            return retorno;
        
        }
        public void Mensagem(){
            double calculo = Calculo();
            string resultadoImc = this.resultadoImc(calculo);

            System.Console.WriteLine("Seu peso é {0}, sua altura é {1}. Logo, o cálculo do Imc é: {2}", Peso, Altura, resultadoImc);
        }
        
    }
}