//11) Leia uma matriz A de tipo double de dimensão 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

namespace ListaExercicios_6_Matrizes
{
    internal class Exe11
    {
        public static void Ex()
        {
            Random random = new Random();
            double[,] matriz = new double[3, 3];
            double[,] divisao = new double[3, 3];
            int somaIndex = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 0] = Math.Round(random.NextDouble() * 100.0, 2);
                matriz[i, 1] = Math.Round(random.NextDouble() * 100.0, 2);
                matriz[i, 2] = Math.Round(random.NextDouble() * 100.0, 2);
            }

            Console.WriteLine("--Matriz 1--");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                    somaIndex += i + j;
                }
                Console.WriteLine();
            }

            Console.WriteLine("--Divisão--");
            for (int i = 0; i < divisao.GetLength(0); i++)
            {
                for (int j = 0; j < divisao.GetLength(1); j++)
                {
                    divisao[i, 0] = matriz[i, 0] / somaIndex;
                    divisao[i, 1] = matriz[i, 1] / somaIndex;
                    divisao[i, 2] = matriz[i, 2] / somaIndex;
                    Console.Write("{0}\t", (divisao[i, j]).ToString("N2"));
                }
                
                Console.WriteLine();
            }
        }
    }
}
