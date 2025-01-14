namespace PropriedadesAtributos.GerenciamentoEstoque
{
    internal class Produto
    {
        //Nome do produto
        public string Nome { get; set; }
        
        //Marca do produto
        public string Marca { get; set; }

        //Referêcnia para a propriedade quatidade produto
        public int _quantidade;

        //Quantidade do produto
        public int Quantidade
        {
            get => _quantidade;
            //Não permite que quantidade negativas sejam adicionadas
            set
            {
                if (value > 0)
                {
                    _quantidade = value;
                }
                else
                {
                    _quantidade = 0;
                }
            }
        }

        //Referência para a propriedade de valor
        public double _valor;
        //Valor do produto
        public double Valor
        {
            //Impede que o valor do produto seja menor que 1
            get => _valor;
            set
            {
                if (value > 0)
                {
                    _valor = value;
                }
                else
                {
                    _valor = 1;
                }
            }
        }

        //Detalhes do produto
        public string Detalhes => $"{Nome} da marca {Marca}; há {Quantidade} unidades no estoque; cada unidade sai por {Valor}";
    }
}
