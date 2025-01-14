namespace PropriedadesAtributos.Banco
{
    // Classe que representa o titular de uma conta bancária
    internal class Titular
    {
        // Nome do titular (imutável após criação)
        public string Nome { get; }

        // Endereço do titular (pode ser alterado)
        public string Endereco { get; set; }

        // CPF do titular (imutável após criação)
        public string CPF { get; }

        // Propriedade que retorna um resumo com os dados do titular
        public string Dados => $"Conta de {Nome}; CPF: {CPF}; residente em: {Endereco}";

        // Construtor que inicializa os valores do titular
        public Titular(string nome, string endereco, string cpf)
        {
            Nome = nome;         // Inicializa o nome do titular
            Endereco = endereco; // Inicializa o endereço do titular
            CPF = cpf;           // Inicializa o CPF do titular
        }
    }
}
