//Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.

namespace ListaExercicios_5_Vetores
{
    internal class Ex9
    {
        public static void Ex()
        {
            int[] vetor = new int[10];
            int[] vetorOrdenado = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Insira um número");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            
            Array.Sort(vetorOrdenado);

            for (int i = 0; i < vetor.Length ; i++)
            {
                Console.WriteLine($"Array[{i}] = {vetor[i]}");
            }
        }

    }
}
