namespace PropriedadesAtributos.Jogos
{
    // Classe que representa um catálogo de jogos
    internal class Catalogo
    {
        // Lista privada para armazenar os jogos adicionados ao catálogo
        List<Jogo> jogosDoCatalogo = new List<Jogo>();

        // Propriedade somente leitura que verifica se o catálogo está vazio
        // Retorna true se a lista de jogos estiver vazia
        public bool CatalogoVazio => jogosDoCatalogo.Count == 0;

        // Método público para adicionar um jogo ao catálogo
        public void AdicionarJogo(Jogo jogo)
        {
            jogosDoCatalogo.Add(jogo); // Adiciona o jogo à lista
            Console.WriteLine($"Jogo {jogo.Nome} adicionado no catálogo"); // Mensagem de confirmação
        }

        // Método público para listar todos os jogos do catálogo
        public void ListarJogos()
        {
            // Verifica se o catálogo está vazio
            if (CatalogoVazio)
            {
                // Exibe mensagem informando que não há jogos
                Console.WriteLine("Não há jogos nesse catálogo");
            }
            else
            {
                // Percorre a lista de jogos e exibe a descrição de cada um
                foreach (var item in jogosDoCatalogo)
                {
                    Console.WriteLine(item.Descricao);
                }
            }
        }
    }
}
