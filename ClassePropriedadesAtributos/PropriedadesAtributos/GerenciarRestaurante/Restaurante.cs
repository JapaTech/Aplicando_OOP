namespace PropriedadesAtributos.GerenciarRestaurante
{
    // Classe que representa um restaurante
    internal class Restaurante
    {
        // Nome do restaurante
        public string Nome { get; set; }

        // Endereço do restaurante
        public string Endereco { get; set; }

        // Lista de mesas disponíveis no restaurante
        public List<Mesa> Mesas = new List<Mesa>();

        // Cardápio do restaurante (instância da classe Cardapio)
        public Cardapio Cardapio = new Cardapio();

        // Construtor que inicializa o restaurante com nome, endereço e um cardápio
        public Restaurante(string nome, string endereco, Cardapio cardapio)
        {
            Nome = nome;        // Inicializa a propriedade Nome com o nome fornecido
            Endereco = endereco; // Inicializa a propriedade Endereco com o endereço fornecido
            Cardapio = cardapio; // Inicializa a propriedade Cardapio com o cardápio fornecido
        }

        // Método que adiciona uma mesa ao restaurante
        public void AdicionarMesa(Mesa mesa)
        {
            Mesas.Add(mesa);  // Adiciona a mesa à lista de mesas do restaurante
        }
    }
}
