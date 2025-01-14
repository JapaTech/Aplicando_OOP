namespace PropriedadesAtributos.GerenciarRestaurante
{
    // Classe que representa um pedido feito no restaurante
    internal class PedidoRestaurante
    {
        // Produto que está sendo pedido (uma instância da classe ProdutoRestaurante)
        public ProdutoRestaurante Produto { get; set; }

        // Quantidade do produto pedido
        public int Qtd { get; set; }

        // Construtor que recebe a quantidade de itens no pedido
        public PedidoRestaurante(ProdutoRestaurante produto, int qtd)
        {
            Produto = produto;
            Qtd = qtd;
        }
    }
}
