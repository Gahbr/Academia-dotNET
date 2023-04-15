//4) Popule uma matriz 5x5 e informe:
//-Quantos números são pares
//-Quantos números são impares
//-Quantos números são positivos
//-Quantos números são negativos
//-Quantos zeros existem!

namespace ListaExercicios_6_Matrizes
{
    internal class Ex4
    {
        public static void Ex()
        {
            int[,] matriz = new int[5, 5];
            int pares = 0, impares = 0, positivos = 0, negativos = 0, zeros = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 0] = Random.Shared.Next(100) + 1;
                matriz[i, 1] = Random.Shared.Next(100) + 1;
                matriz[i, 2] = Random.Shared.Next(100) + 1;
                matriz[i, 3] = Random.Shared.Next(100) + 1;
                matriz[i, 4] = Random.Shared.Next(100) + 1;
            }

            //printando tudo
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);

                    if (matriz[i, j] % 2 == 0)
                    {
                        pares++;
                    }else impares++;

                    if (matriz[i, j] > 0)
                    {
                        positivos++;
                    }
                    else negativos++;

                    if (matriz[i, j] == 0) zeros++;
                    
                }
                Console.WriteLine();
            }
            Console.Write($"\nElementos pares : {pares}\nElementos ímpares : {impares}\nElementos positivos : {positivos}\nElementos negativos: {negativos}\nElementos iguais a 0: {zeros}\n ");

            
        }
    }
}
