
namespace Exercicio_OOP
{
    internal class Pessoa
    {
        /*Encapsulamento é um principio da orientação a objetos - Permite proteger informações de um objeto
         * public -> vai ser publico, vai ser visivel a todos os componentes do propgrama 
         * private -> é acessivel somente dentro da classe 
         * protected -> é acessivel dentro da prórpia classe e nas suas subclasses (herança) 
         * internal -> podem ser acessado dentro do mesmo assembly (um conjunto de aquivos de código fontes
         */

        private string nome;
        private int idade;

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
            public string Nome
        {
            get { return nome; }
            set { nome = value; }
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
