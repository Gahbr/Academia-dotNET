//2) Solicite ao usuário, preencher uma Matriz 3x3

//Informe ao usuário:
//*A soma dos elementos de cada linha
//	-Ex: Linha 1: 30

//         Linha 2: 17
//* A soma dos elementos de cada coluna
//	-Ex: Coluna 1: 23

//         Coluna 2: 36

using System;

namespace ListaExercicios_6_Matrizes
{
    internal class Ex2
    {
        public static void Ex()
        {
            int[,] matriz = new int[3, 3];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("digite um número para inserir na i");
                matriz[i, 0] = int.Parse(Console.ReadLine());
                matriz[2, 0] = matriz[0, 0] + matriz[1, 0];

                matriz[i, 1] = Random.Shared.Next(10) + 1;
                matriz[2, 1] = matriz[0, 1] + matriz[1, 1];

                //soma coluna
                matriz[0, 2] = matriz[0, 0] + matriz[0, 1];
                matriz[1, 2] = matriz[1, 0] + matriz[1, 1];
                matriz[2, 2] = matriz[2, 0] + matriz[2, 1];

            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
