namespace PropriedadesAtributos.GerenciarRestaurante
{
    // Classe que representa uma mesa em um restaurante
    internal class Mesa
    {
        // Número da mesa
        public int Numero { get; set; }

        // Indica se a mesa está reservada
        public bool Reservado { get; set; }

        // Lista de pedidos associados à mesa
        public List<PedidoRestaurante> Pedidos = new List<PedidoRestaurante>();

        //Adiciona um pedido no restaurante
        public void AdcionarPedido(PedidoRestaurante pedido)
        {
            Pedidos.Add(pedido);
        }

        // Método que lista todos os pedidos feitos na mesa
        public void ListarPedidos()
        {
            foreach (var item in Pedidos)
            {
                // Exibe a quantidade, o nome do produto e o total (quantidade * valor do produto)
                Console.WriteLine($"{item.qtd}x {item.produto.Nome} = R$ {item.produto.Valor * item.qtd}");
            }
        }

        // Método que calcula o valor total dos pedidos na mesa
        public double Total()
        {
            // Usa LINQ para somar o total de cada pedido
            return Pedidos.Sum(x => x.produto.Valor * x.qtd);
        }
    }
}
