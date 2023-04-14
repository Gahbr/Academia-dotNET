// Escreva um programa que leia valores em um vetor de 5 posições. Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

using System.Drawing;

namespace ListaExercicios_5_Vetores
{
    internal class Exe11
    {
        public static void Ex()
        {
            int[] vetor = new int[5];
            int[] vetorInverso = new int[5];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Insira um número");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            vetorInverso = vetor;
             

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Array[{i}] = {vetor[i]}");
            }

            Array.Reverse(vetorInverso);

            for (int i = 0; i < vetorInverso.Length; i++)
            {
                Console.WriteLine($"Array Inverso[{i}] = {vetorInverso[i]}");
            }
           
        }
    }
}
