namespace PropriedadesAtributos.Jogos
{
    // Classe que representa uma plataforma (exemplo: PC, PS5, Xbox) com suas informações principais
    internal class Plataforma
    {
        // Propriedade somente leitura que armazena o nome da plataforma
        public string Nome { get; }

        // Propriedade somente leitura para armazenar a versão da plataforma
        public string Versao { get;  }

        // Propriedade somente leitura para armazenar a data de lançamento da plataforma
        public DateTime Lancamento { get; }

        // Propriedade somente leitura que retorna uma descrição detalhada da plataforma
        public string Detalhes =>
            $"{Nome}, {Versao}, Lançado em {Lancamento:dd/MM/yyyy}";

        // Construtor que inicializa as propriedades obrigatórias da plataforma
        public Plataforma(string nome, string versao, DateTime lancamento)
        {
            Nome = nome;         // Define o nome da plataforma
            Versao = versao;     // Define a versão inicial
            Lancamento = lancamento; // Define a data de lançamento inicial
        }
    }
}
