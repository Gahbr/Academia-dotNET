//17) Desafio: Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, ou seja, o menor elemento da linha onde se encontra o 
//maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.

namespace ListaExercicios_6_Matrizes
{
    internal class Exe17
    {
        public static void Ex()
        {
            int[,] matriz = new int[10, 10];
            int[,] soma = new int[10, 10];
            int linhaMaior = 0, maior = matriz[0, 0];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 0] = Random.Shared.Next(100) + 1;
                matriz[i, 1] = Random.Shared.Next(100) + 1;
                matriz[i, 2] = Random.Shared.Next(100) + 1;
                matriz[i, 3] = Random.Shared.Next(100) + 1;
                matriz[i, 4] = Random.Shared.Next(100) + 1;
                matriz[i, 5] = Random.Shared.Next(100) + 1;
                matriz[i, 6] = Random.Shared.Next(100) + 1;
                matriz[i, 7] = Random.Shared.Next(100) + 1;
                matriz[i, 8] = Random.Shared.Next(100) + 1;
                matriz[i, 9] = Random.Shared.Next(100) + 1;
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    // Encontra o maior número da matriz e guarda sua linha
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                        linhaMaior = i;
                    }
                }
            }

            // Encontra o menor elemento da linha onde se encontra o maior elemento
            int minmax = matriz[linhaMaior, 0];
            int colunaMin = 0;

            for (int j = 1; j < matriz.GetLength(0); j++)
            {
                if (matriz[linhaMaior, j] < minmax)
                {
                    minmax = matriz[linhaMaior, j];
                    colunaMin = j;
                }
            }

            Console.WriteLine("--Matriz 10x10--");
            //printando tudo
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("");

            Console.WriteLine("O elemento minimax é {0}, encontrado em Matriz[{1},{2}]. O maior numero é o {3}", minmax, linhaMaior,colunaMin, maior);
           
        }
    }
}
