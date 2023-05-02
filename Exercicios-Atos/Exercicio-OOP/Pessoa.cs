
namespace Exercicio_OOP
{
    internal class Pessoa
    {
        public string nome;
        public int idade;

        //Construtores
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public Pessoa(int idade)
        {
            this.idade = idade;
        }

        public void exibeDados()
        {
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Idade: {this.idade}");
        }

        public void exibeIdade()
        {
            Console.WriteLine($"Idade: {this.idade}");
        }
    }
}
