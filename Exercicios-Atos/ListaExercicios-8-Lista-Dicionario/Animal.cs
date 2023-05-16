using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios_8_Lista_Dicionario
{
    internal class Animal
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        
        public Animal(string nome, string tipo) 
        {
            Nome = nome;
            Tipo = tipo;
        }

    }
}
