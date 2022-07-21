namespace GetSet
{
    public class Conta
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public string NomeConta { get; set; }
        public Titular Titular { get; set; }
        public Decimal Saldo { get; set; }

        public Conta(int agencia, int numeroConta, string nomeConta, Titular titular, Decimal saldo){
            Agencia = agencia;
            NumeroConta = numeroConta;
            NomeConta = nomeConta;
            Titular = titular;
            Saldo = saldo;

            System.Console.WriteLine($"Agencia: {agencia}, Número da Conta: {numeroConta}, Nome da conta: {nomeConta}, Titular da conta: {titular}, Saldo da conta {saldo}. ");

        }

        public Decimal VerSaldo()
        {
            return Saldo;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                System.Console.WriteLine("Valor indisponível para saque!");
            }

        }


    }
}