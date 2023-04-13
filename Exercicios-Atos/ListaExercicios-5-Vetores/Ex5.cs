//Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.

namespace ListaExercicios_5_Vetores
{
    internal class Ex5
    {
        public static void Ex()
        {
            int[] vetor = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"insira o valor do vetor  - [{i}]");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int valorMinimo = vetor.Min();
            int posicaoMinima = Array.IndexOf(vetor, valorMinimo);

            Console.WriteLine($"O menor elemento do vetor é  : {valorMinimo} e sua posição é {posicaoMinima}");
        }
    }
}
