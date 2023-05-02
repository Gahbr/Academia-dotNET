//•2 - Crie uma classe chamada Computador que possua 4 atributos: marca, modelo, tipo (notebook, netbook, tablet, etc) e preço.

//Crie dois objetos onde o primeiro objeto deverá ser criado através da solicitação dos valores ao usuário por linha de execução. Já, os valores do segundo objeto, deverão ser definidos no código-fonte da classe que o criou. Exiba na tela os resultados.

namespace Exercicio_OOP
{
    internal class Computador
    {
        public string marca, modelo, tipo;
        public double preco;

        public Computador(){ }
        public Computador( string marca, string modelo, string tipo, double preco)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.tipo = tipo;
            this.preco = preco;
        }
        public void exibeDados()
        {
            Console.WriteLine($"Marca: {this.marca}");
            Console.WriteLine($"Modelo: {this.modelo}");
            Console.WriteLine($"Preço: {this.preco}");
        }
    }
}
