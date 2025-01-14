using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesAtributos.Escola
{
    internal class Professor
    {
        //Nome do professor
        public string Nome { get; set; }
        //Disciplinas que o professor leciona
        public List<Dicisplina> DicisplinasLecionadas = new List<Dicisplina>();
    }
}
