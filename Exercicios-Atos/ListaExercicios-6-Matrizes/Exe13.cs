//13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da 
//diagonal secundária.

namespace ListaExercicios_6_Matrizes
{
    internal class Exe13
    {
        public static void Ex()
        {
            int[,] matriz = new int[5, 5];
            int diagPrincipal = 0;
            int diagSecundaria = 0;

            // Lê os números da matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = Random.Shared.Next(10) + 1;

                    if (i + j == matriz.GetLength(0) - 1)
                    {
                        diagSecundaria += matriz[i, j];
                    }
                    
                }
                diagPrincipal += matriz[i, i];
                
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }

            if(diagPrincipal == diagSecundaria)
            {
                Console.WriteLine("A soma das diagonais são iguais");
            }else Console.WriteLine("A soma das diagonais são diferentes");
           

        }
    }
}
