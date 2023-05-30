using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Serializacao
{
    [Serializable]
    public class Pessoa
    {
        public string nome;
        public int idade;
        public double salario;
    }
}
