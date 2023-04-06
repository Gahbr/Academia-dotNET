using System.Drawing;

namespace Exercicio6
{
    internal class Program
    {
        //Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem de IPI(única) a ser acrescentada.
        static void Main(string[] args)
        {
            Console.WriteLine("Parafuso A:");
            Console.WriteLine("Insira o código:");
            int codA = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de peças do Parafuso A:");
            int qtdA = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor unitário do Parafuso A:");
            double valorA = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a porcentagem da IPI");
            double impostoA = double.Parse(Console.ReadLine());

            Console.WriteLine("Parafuso B:");
            Console.WriteLine("Insira o código:");
            int codB = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de peças do Parafuso B:");
            int qtdB = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor unitário do Parafuso B:");
            double valorB = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a porcentagem da IPI");
            double impostoB = double.Parse(Console.ReadLine());

            double valorFinalA = (qtdA * valorA) * impostoA;
            Console.WriteLine($"Parafuso A: Código: {codA} - Quantidade : {qtdA} - Valor unitário {valorA} - Porcentagem IPI: {impostoA}%");
            Console.WriteLine($"Parafuso B: Código: {codB} - Quantidade : {qtdB} - Valor unitário {valorB} - Porcentagem IPI: {impostoB}%");
        }
    }
}