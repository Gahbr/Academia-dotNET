using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    internal class Autor
    {
        private string _nome;
        private string _email;

        public string Nome { get => _nome; set { if (!string.IsNullOrEmpty(value)) _nome = value; } }
        public string Email { get => _email; set { if (!string.IsNullOrEmpty(value)) _email = value; } }

        public Autor(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
