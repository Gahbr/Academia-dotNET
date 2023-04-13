// Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.

using System;

namespace ListaExercicios_5_Vetores
{
    internal class Ex2
    {
        public static void Ex()
        {
            int[] vetor = new int[20];
            int[] vetor2 = new int[20];
            int[] resultado = new int[20];

            for (int i = 0; i < 19; i++)
            {
                Console.WriteLine($"insira o valor do vetor 1 - [{i}]");
                vetor[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"insira o valor do vetor 2 - [{i}]");
                vetor2[i] = int.Parse(Console.ReadLine());

                resultado[i] = vetor[i] + vetor2[i];
                Console.WriteLine($"Resultado : {resultado[i]}");
            }
            
        }
    }
}
