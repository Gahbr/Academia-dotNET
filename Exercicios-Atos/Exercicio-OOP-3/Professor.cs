using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_OOP_3
{
    internal class Professor : Pessoa
    {
        private string disciplina;

        public string Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Matrícula: {Disciplina}");
        }
    }
}
