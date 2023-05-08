//•1 - Crie uma classe chamada Carro que possua 3 atributos: marca, modelo e anoFabricacao. Além disso, na main crie 2 objetos do tipo Carro e exiba na tela os valores dos atributos criados.

//•Esses valores devem ser solicitados ao usuário, por linha de execução.

namespace Exercicio_OOP
{
    internal class Carro
    {
        private string marca, modelo;
        private int anoFabricacao;
        private Motor m;

        public string Marca { get { return marca; } set { marca = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }
        public int AnoFabricacao { get { return anoFabricacao; } set { anoFabricacao = value; } }
        public Motor Motor { get { return m; } set { m = value; } }
        public Carro(){}
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

        public void LigarCarro()
        {
            if (!m.Ligado)
            {
                m.LigarMotor();
                Console.WriteLine("O carro ligou!");
            }
            else
            {
                Console.WriteLine("O carro está ligado");
            }
        }

        public void DesligarCarro()
        {
            if (m.Ligado)
            {
                m.DesligarMotor();
                Console.WriteLine("O carro desligou!");
            }
            else
            {
                Console.WriteLine("O carro está desligado");
            }
        }
    }
}
