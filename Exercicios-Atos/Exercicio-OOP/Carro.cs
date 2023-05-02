//•1 - Crie uma classe chamada Carro que possua 3 atributos: marca, modelo e anoFabricacao. Além disso, na main crie 2 objetos do tipo Carro e exiba na tela os valores dos atributos criados.

//•Esses valores devem ser solicitados ao usuário, por linha de execução.

namespace Exercicio_OOP
{
    internal class Carro
    {
        public string marca, modelo;
        public int anoFabricacao;

        public Carro()
        {
            
        }
        public Carro(string marca, string modelo, int anoFabricacao)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anoFabricacao = anoFabricacao;
        }
        public void exibeDados()
        {
            Console.WriteLine($"Marca: {this.marca}");
            Console.WriteLine($"Modelo: {this.modelo}");
            Console.WriteLine($"Ano de fabricação: {this.anoFabricacao}");

        }
    }
}
