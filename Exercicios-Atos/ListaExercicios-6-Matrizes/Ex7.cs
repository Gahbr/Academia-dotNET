//7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.

namespace ListaExercicios_6_Matrizes
{
    internal class Ex7
    {
        public static void Ex()
        {
            int[,] matriz = new int[3, 3];
            int[,] matriz2 = new int[3, 3];
            int[,] subtracao = new int[3, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 0] = Random.Shared.Next(50) + 1;
                matriz[i, 1] = Random.Shared.Next(50) + 1;
                matriz[i, 2] = Random.Shared.Next(50) + 1;

                matriz2[i, 0] = Random.Shared.Next(50) + 1;
                matriz2[i, 1] = Random.Shared.Next(50) + 1;
                matriz2[i, 2] = Random.Shared.Next(50) + 1;

                subtracao[i, 0] = matriz[i, 0] - matriz2[i, 0];
                subtracao[i, 1] = matriz[i, 1] - matriz2[i, 1];
                subtracao[i, 2] = matriz[i, 2] - matriz2[i, 2];
            }

            Console.WriteLine("--Matriz 1--");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("--Matriz 2--");
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matriz2[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("--Subtração--");
            for (int i = 0; i < subtracao.GetLength(0); i++)
            {
                for (int j = 0; j < subtracao.GetLength(1); j++)
                {
                    Console.Write("{0}\t", subtracao[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
