using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }

        public Pessoa(string nome, string sobrenome, string email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
        }

        public static bool JaCadastrado ( string email, List<Pessoa> lista)
        {
            foreach(Pessoa p in lista)
            {
                if (email.Equals(p.Email)) return true;
            }
            return false; // jogador nao encontrado na lista
        }
    }
}
