using System;
using System.Collections.Generic;
using System.Linq;
namespace PropriedadesAtributos.Concessionaria
{
    internal class Carro
    {
        //Cor do carro
        public string Cor { get; set; }
        
        //Modelo do carro
        public string Modelo { get; set; }
        
        //Quantidade de portas do carro
        public int QuantidadeDePortas { get; set; }

        //Referência da propriedade do ano de criação do carro
        private DateTime _anoDeCriacao;
        //Propriedade do ano de criação do carro
        public DateTime AnoDeCriacao
        {
            get { return _anoDeCriacao; }
            //Impede que datas fora do intervalo entre 1960 e 2023
            set
            {
                if (value.Year >= 1960 && value.Year <= 2023)
                {
                    _anoDeCriacao = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("AnoDeCriacao", "O ano de criação deve estar entre 1960 e 2000.");
                }

            }
        }

        //Nome do fabricante
        public string Fabricante { get; set; }
        
        //Descrição detalhada do carro
        public string DescricaoDetalhada => $"O {Modelo} foi fabricado por {Fabricante} em {AnoDeCriacao}";

    }
}
