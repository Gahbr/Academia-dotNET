using System.IO;
using System.Runtime.Intrinsics.X86;

namespace Exercicio_15
{
    internal class Program
    {
// Faça um programa para uma loja de tintas.O programa deverá pedir o tamanho em metros quadrados
//da área a ser pintada.Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados
//e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
//Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor da área a ser pintada?");
            double input = double.Parse(Console.ReadLine());
            double qtdLitros = (input / 3);
            double qtdLatas = Math.Ceiling((input / 18));
            double preco = qtdLatas * 80;
            Console.WriteLine($"Latas necessárias a serem compradas: {qtdLatas} - Preço total: ${preco} ");
        }
    }
}