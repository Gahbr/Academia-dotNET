//Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

namespace ListaExercicios_6_Matrizes
{
    internal class Ex3
    {
        public static void Ex()
        {
            int[,] matriz = new int[4, 4];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 0] = Random.Shared.Next(100) + 1;
                matriz[i, 1] = Random.Shared.Next(100) + 1;
                matriz[i, 2] = Random.Shared.Next(100) + 1;
                matriz[i, 3] = Random.Shared.Next(100) + 1;
            }

            //printando tudo
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("\nElementos na diagonal principal: ");

            // printando apenas a diagonal
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
        }
    }
}
