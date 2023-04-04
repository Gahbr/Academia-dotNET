namespace Exercicio5
{
    internal class Program
    {
        // Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível consumido para percorrê-la(medido em l).
        static void Main(string[] args)
        {
            Console.WriteLine("Consumo médio de um automóvel");
            Console.WriteLine("Insira a distância total percorrida:");
            double distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira volume de combustível consumido:");
            double km= double.Parse(Console.ReadLine());
            Console.WriteLine("O consumo médio é " + distancia/km;
        }
    }
}