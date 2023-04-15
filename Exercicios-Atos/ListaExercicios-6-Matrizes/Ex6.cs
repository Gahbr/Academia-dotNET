//6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.

//Random random = new Random();
//int randomNumber = random.Next(0, 100);

namespace ListaExercicios_6_Matrizes
{
    internal class Ex6
    {
        public static void Ex()
        {
            int[,] matriz = new int[4, 4];
          

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 0] = Random.Shared.Next(10) + 1;
                matriz[i, 1] = Random.Shared.Next(10) + 1;
                matriz[i, 2] = Random.Shared.Next(10) + 1;
                matriz[i, 3] = Random.Shared.Next(10) + 1;
            }

            int maior = matriz[0, 0];

            //printando tudo
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);

                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.Write("Maior número da matriz: " + maior);
        }
    }
}
