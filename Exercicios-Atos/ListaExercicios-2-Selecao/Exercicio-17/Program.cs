using System.Net;
using System.Runtime.ConstrainedExecution;

namespace Exercicio_17
{
    internal class Program
    {
//Faça um algoritmo que leia o tamanho dos lados de um triangulo(lado a, b e c), e então diga se esses lados podem ou não formar um triangulo.Para que os lados
//formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
//os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).

        static void Main(string[] args)
        {
            Console.WriteLine("Insira o lado A");
            double ladoA = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado B");
            double ladoB = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado C");
            double ladoC = double.Parse(Console.ReadLine());

            if (ladoA < (ladoB + ladoC) && ladoB < (ladoA + ladoC) && ladoC < (ladoA + ladoB))
            {
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("É um triangulo equilátero");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("É um triangulo isóceles");
                }
                else if (ladoA != ladoB && ladoB != ladoC && ladoA != ladoC)
                {
                    Console.WriteLine("é um triangulo escaleno");
                }
            } else
            {
                Console.WriteLine("Não forma um triangulo");
            }
        }
    }
}