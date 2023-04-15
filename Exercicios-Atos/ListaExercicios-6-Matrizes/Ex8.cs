// 8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

namespace ListaExercicios_6_Matrizes
{
    internal class Ex8
    {
        public static void Ex()
        {
            int[,] matriz = new int[4, 4];
            int[] numeros = new int[16];

            // Lê os números da matriz
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = Random.Shared.Next(10) + 1;
                    numeros[i * 4 + j] = matriz[i, j];
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }

            // Imprime os números na ordem direta
            Console.WriteLine("\nNúmeros na ordem direta:");
            for (int i = 0; i < 16; i++)
            {
                Console.Write(numeros[i] + " ");
            }

            // Imprime os números na ordem inversa
            Console.WriteLine("\nNúmeros na ordem inversa:");
            for (int i = 15; i >= 0; i--)
            {
                Console.Write(numeros[i] + " ");
            }

            
        }
    }
}
