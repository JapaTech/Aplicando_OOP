using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesAtributos.Escola
{
    internal class Dicisplina
    {
        //Nome da disciplina
        public string Nome { get; set; }
        //Lista dos alunos matriculados na disciplina
        public List <Aluno> alunos = new List<Aluno> ();
    }
}
