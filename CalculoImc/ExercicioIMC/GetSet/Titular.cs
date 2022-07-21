namespace GetSet
{
    public class Titular
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }

        public Titular(string nome, string cpf, string rg, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Endereco = endereco;

            System.Console.WriteLine($"O titular da conta é: {nome}, Cpf número {cpf}, RG número {rg}, e o endereço é {endereco}");
        }
    }
}