//4) Crie uma classe para representar um item de cenário, com os atributos privados de:
//    *descrição(string), 
//    *data de criação(date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
//    *altura(float).

//Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método para imprimir 
//todos dados de um item de cenário. 
//Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa em C# para testar
//a classe criada.

namespace ListaExercicios_8_Lista_Dicionario
{
    internal class Cenario
    {
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public float Altura { get; set; }

        public Cenario() { }
        public Cenario(string descricao,  DateTime dataCriacao, float altura)
        {
            Descricao = descricao;
            DataCriacao = dataCriacao;
            Altura = altura;
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Data de Criação: {DataCriacao}");
            Console.WriteLine($"Altura: {Altura}");
        }
        public void CalculoTempoCriacao(DateTime data)
        {
            TimeSpan timeDifference = DataCriacao- data ;
            Console.WriteLine("foi criado há: " + timeDifference.TotalDays.ToString("F0") + " dias atrás");
        }
    }
}
