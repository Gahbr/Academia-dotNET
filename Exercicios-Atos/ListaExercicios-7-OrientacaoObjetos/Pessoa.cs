//1 - Criar uma classe chamada Pessoa com 2 construtores, um que receba o nome e a idade da pessoa e 
//outro recebendo apenas a idade. Solicite ao usuário qual dos construtores ele gostaria de utilizar 
//na instanciação da classe. Além de receber parâmetros, os construtores imprimem na tela o conteúdo 
//dos parâmetros recebidos.

//4 - Crie uma classe chamada Pessoa que tenha as propriedades Nome e Idade. Utilize o encapsulamento para garantir 
//que o nome não seja vazio e que a idade seja maior que zero.

using System.Text.RegularExpressions;

namespace Exercicio_1
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if(nome.Length> 0)
                {
                    nome = value;
                }
            }
        }
        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if (idade > 0)
                {
                    idade = value;
                }
            }
        }

        public Pessoa(string nome)
        {
            Nome = nome;
            Console.WriteLine($"O nome é {nome} ");
        }
        public Pessoa(int idade)
        {
            Idade = idade;
            Console.WriteLine($"A idade é {idade} anos.");
        }

    }
}
