using PropriedadesAtributos.GerenciamentoEstoque;

namespace PropriedadesAtributos.GerenciarRestaurante
{
    // Classe que representa um cardápio em um restaurante
    internal class Cardapio
    {
        // Lista de produtos que compõem o cardápio do restaurante
        // Cada item da lista é do tipo ProdutoRestaurante
        public List<ProdutoRestaurante> produtos = new List<ProdutoRestaurante>();

        //Adiciona um produto no cadarpio do restaurante
        public void AdicionarProduto(ProdutoRestaurante produto)
        {
            produtos.Add(produto);
            Console.WriteLine($"{produto.Nome} adicionado ao cardápio.");
        }

        //Remove um produto no cadarpio do restaurante
        public void RemoverProduto(ProdutoRestaurante produto)
        {
            if (produtos.Remove(produto))
            {
                Console.WriteLine($"{produto.Nome} removido do cardápio.");
            }
            else
            {
                Console.WriteLine($"{produto.Nome} não encontrado no cardápio.");
            }
        }
    }
}
