//14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal (da esquerda para a direita)
// são os mesmos da diagonal secundária (direita pra esquerda).

namespace ListaExercicios_6_Matrizes
{
    internal class Exe14
    {
        public static void Ex()
        {
            int[,] matriz = new int[5, 5];
            int[] diagPrincipal = new int[5];
            int[] diagSecundaria = new int[5];
            bool compara = false;

            // Lê os números da matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = Random.Shared.Next(10) + 1;

                    if (i + j == matriz.GetLength(0) - 1)
                    {
                        diagSecundaria[i] = matriz[i, j];
                    }
                }
                diagPrincipal[i] = matriz[i, i];

            }
           
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                   
                }
                Console.WriteLine();
            }

            for(int i = 0;i < diagPrincipal.Length; i++)
            {
                if (diagPrincipal[i] == diagSecundaria[i])
                {
                    compara = true;
                }
                else
                {
                    compara = false;
                    break;
                };
            }

            Console.WriteLine(compara ? "As diagonais são iguais " : "As diagonais são diferentes");
            

        }

    }
}
