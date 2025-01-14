using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesAtributos.Escola
{
    internal class Aluno
    {
        //Nome do aluno
        public string Nome { get; set; }
        //Idade do Aluno
        public int Idade { get; set; }
        //Número de registro do aluno
        public int RA { get; set; }
        //Notas do aluno
        public float[] Notas { get; set; }
    }
}
