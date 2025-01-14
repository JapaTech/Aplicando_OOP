namespace PropriedadesAtributos.GerenciarRestaurante
{
    // Classe que representa um produto do restaurante
    internal class ProdutoRestaurante
    {
        // Nome do produto
        public string Nome { get; set; }

        // Descrição do produto (detalhes sobre o produto)
        public string Descricao { get; set; }

        // Valor do produto (preço)
        public double Valor { get; set; }

        // Construtor que inicializa o produto com nome, descrição e valor
        public ProdutoRestaurante(string nome, string descricao, double valor)
        {
            Nome = nome;         // Inicializa a propriedade Nome
            Descricao = descricao; // Inicializa a propriedade Descricao
            Valor = valor;        // Inicializa a propriedade Valor
        }
    }
}
