//12) Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.

namespace ListaExercicios_6_Matrizes
{
    internal class Exe12
    {
        public static void Ex()
        {
            int[,] matriz = new int[4, 3];
           

            // Lê os números da matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = Random.Shared.Next(10) + 1;
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

            Console.WriteLine("Valores cuja soma dos índices (i+j) seja um número par:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if((i+j) % 2 == 0)
                    {
                        Console.Write("{0}\t", matriz[i, j]);
                    }

                }
               
            }


        }
    }
}
