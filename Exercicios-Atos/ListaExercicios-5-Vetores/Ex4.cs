//Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.

namespace ListaExercicios_5_Vetores
{
    internal class Ex4
    {
        public static void Ex()
        {
            int[] vetor = new int[10];
            int[] vetor2 = new int[10];
            int[] resultado = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"insira o valor do vetor 1 - [{i}]");
                vetor[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"insira o valor do vetor 2 - [{i}]");
                vetor2[i] = int.Parse(Console.ReadLine());

                resultado[i] = vetor[i] * vetor2[i];
                Console.WriteLine($"Resultado : {resultado[i]}");
            }

        }
    }
}
