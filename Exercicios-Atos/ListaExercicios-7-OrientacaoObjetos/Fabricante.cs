//6 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade. 
//Produto que tenha as propriedades Nome, Fabricante e Preco. Utilize o encapsulamento para garantir que o nome não
//seja vazio e que o preço seja positivo. 

namespace Exercicio_1
{
    internal class Fabricante
    {
        private string _nome;
        private string _endereco;
        private string _cidade;

        //getters setters
        public string Nome { get => _nome; set => _nome = value; }
        public string Endereco { get => _endereco; set => _endereco = value;}
        public string Cidade { get => _cidade; set => _cidade = value;}
        //construtor
        public Fabricante(string nome, string endereco, string cidade)
        {
            Nome = nome;
            Endereco = endereco;
            this._cidade = cidade;
        }

        //metodos
    }
}