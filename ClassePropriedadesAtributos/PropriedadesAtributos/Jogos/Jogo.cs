namespace PropriedadesAtributos.Jogos
{
    // Classe que representa um jogo com suas principais características
    internal class Jogo
    {
        // Propriedade somente leitura para armazenar o nome do jogo
        public string Nome { get; }

        // Propriedade somente leitura para armazenar a data de lançamento do jogo
        public DateTime Lancamento { get; }

        // Propriedade para armazenar o gênero do jogo
        // Pode ser lida e modificada após a criação do objeto
        public string Genero { get; set; }

        // Lista que armazena as plataformas em que o jogo está disponível
        public List<Plataforma> plataformas = new List<Plataforma>();

        // Propriedade somente leitura que cria uma descrição detalhada do jogo
        // Inclui o nome, data de lançamento, gênero e as plataformas disponíveis
        public string Descricao =>
            $"{Nome}, lançado em {Lancamento:dd/MM/yyyy}, Gênero: {Genero}, disponível para {string.Join(", ", plataformas)}";

        public Jogo(string nome, DateTime lancamento, string genero)
        {
            Nome = nome;
            Lancamento = lancamento;
            Genero = genero;
        }
    }
}
