namespace PropriedadesAtributos.Banco
{
    // Classe que representa uma conta bancária
    internal class Conta
    {
        // Número da conta (imutável após criação)
        public int NumeroDaConta { get; }

        // Número da agência (imutável após criação)
        public int Agencia { get; }

        // Senha da conta (pode ser alterada)
        public string Senha { get; set; }

        // Saldo da conta (pode ser alterado)
        public double Saldo { get; set; }

        // Limite de crédito da conta (pode ser alterado)
        public double Limite { get; set; }

        // Titular da conta (imutável após criação)
        public Titular Titular { get; }

        // Propriedade que retorna um resumo com o nome do titular, saldo e limite
        public string DadosGerais => $"{Titular.Nome} tem o saldo de R$ {Saldo.ToString("F2")} e um limite de {Limite}";

        // Construtor que inicializa os valores da conta
        public Conta(int numeroDaConta, int agencia, string senha, double saldo,
            double limite, Titular titular)
        {
            NumeroDaConta = numeroDaConta; // Inicializa o número da conta
            Agencia = agencia;             // Inicializa o número da agência
            Senha = senha;                 // Inicializa a senha
            Saldo = saldo;                 // Inicializa o saldo
            Limite = limite;               // Inicializa o limite de crédito
            Titular = titular;             // Inicializa o titular da conta
        }
    }
}
