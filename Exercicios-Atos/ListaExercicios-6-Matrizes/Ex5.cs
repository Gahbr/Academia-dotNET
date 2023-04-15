//5) Leia duas matrizes 2x3 de números double. 
//Imprima a soma destas duas matrizes.

namespace ListaExercicios_6_Matrizes
{
    internal class Ex5
    {
        public static void Ex()
        {
            int[,] matriz = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] soma = new int[2, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 0] = Random.Shared.Next(10) + 1;
                matriz[i, 1] = Random.Shared.Next(10) + 1;
                matriz[i, 2] = Random.Shared.Next(10) + 1;

                matriz2[i, 0] = Random.Shared.Next(10) + 1;
                matriz2[i, 1] = Random.Shared.Next(10) + 1;
                matriz2[i, 2] = Random.Shared.Next(10) + 1;

                soma[i, 0] = matriz[i, 0] + matriz2[i, 0];
                soma[i, 1] = matriz[i, 1] + matriz2[i, 1];
                soma[i, 2] = matriz[i, 2] + matriz2[i, 2];
            }

            Console.WriteLine("--Matriz 1--");
            //printando tudo
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("--Matriz 2--");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matriz2[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("--Soma das matrizes--");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < soma.GetLength(1); j++)
                {
                    Console.Write("{0}\t", soma[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
