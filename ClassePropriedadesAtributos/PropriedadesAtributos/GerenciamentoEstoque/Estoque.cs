namespace PropriedadesAtributos.GerenciamentoEstoque
{
    // Classe que representa o estoque com suas características
    internal class Estoque
    {
        //Lista que armazena os produtos do estoque
        List<Produto> Produtos = new List<Produto>();

        //Funcção que adiciona um produto na lista do estoque
        public void AddProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        //Lista todos os produtos da lista do estoque
        public void ListarProdutos()
        {
            foreach (var produto in Produtos) 
            {
                Console.WriteLine($"O produto {produto.Nome} tem {produto.Quantidade} uniades no estoque");
            }
        }
    }
}
