//6 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade. 
//Produto que tenha as propriedades Nome, Fabricante e Preco. Utilize o encapsulamento para garantir que o nome não
//seja vazio e que o preço seja positivo. 

namespace Exercicio_1
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private Fabricante _fabricante;


        //getters setters
        public string Nome { get { return _nome; } set { _nome = value; } }
        public double Preco { get => _preco; set => _preco = value;  }
        public Fabricante Fabricante { get => _fabricante; set => _fabricante = value; }
        

        public Produto(string nome, double preco, Fabricante fabricante)
        {
            Nome = nome;
            Preco = preco;
            Fabricante = fabricante;
        }

    }
}
