//7 - Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor (outra classe). Utilize o encapsulamento 
//para garantir que o título e o autor não sejam vazios.

namespace Exercicio_1
{
    internal class Livro
    {
        private string _titulo;
        private Autor _autor;

        public string Titulo { get => _titulo; set { if (string.IsNullOrEmpty(value)) _titulo = value; } }
        public Autor Autor { get => _autor; set => _autor = value; }

        public Livro (string titulo, Autor autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }
}
