//16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3. Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.

using System;
using System.Reflection;

namespace ListaExercicios_6_Matrizes
{
    internal class Exe16
    {
        public static void Ex()
        {
            int[,] matriz = new int[3, 4];
            int[] matrizAuxiliar = new int[12];
            int[,] matrizConvertida = new int[4, 3];
            int index = 0;

            // Lê os números da matriz
            for (int i = 0;  i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = Random.Shared.Next(10) + 1;

                    matrizAuxiliar[index] = matriz[i, j];
                    index++;
                }
            }

           index = 0;

            for(int i = 0; i< matrizConvertida.GetLength(0); i++)
            {
                for (int j = 0; j < matrizConvertida.GetLength(1); j++)
                {
                    matrizConvertida[i, j] = matrizAuxiliar[index];
                    index++;
                }

            }

            Console.WriteLine("---Matriz 3x4---");

            //printando
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("---Matriz convertida em 4x3---");

            //printando
            for (int i = 0; i < matrizConvertida.GetLength(0); i++)
            {
                for (int j = 0; j < matrizConvertida.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matrizConvertida[i, j]);

                }
                Console.WriteLine();
            }
        }
    }
}
