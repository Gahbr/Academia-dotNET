// 10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

using System.Xml.Linq;

namespace ListaExercicios_6_Matrizes
{
    internal class Exe10
    {
        public static void Ex()
        {
            Random random = new Random();
            double[,] matriz = new double[4, 4];
            double media = 0;

            int abaixoMedia = 0;
            int numsMedia = 0;
            int acimaMedia = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 0] = Math.Round(random.NextDouble() * 10.0, 2);
                matriz[i, 1] = Math.Round(random.NextDouble() * 10.0, 2);
                matriz[i, 2] = Math.Round(random.NextDouble() * 10.0, 2);
                matriz[i, 3] = Math.Round(random.NextDouble() * 10.0, 2);
            }

            bool pesquisa = false;

            //printando tudo
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                    media += matriz[i, j];
                }
                Console.WriteLine();
            }
            media = Math.Round(media / matriz.Length, 2); ;

            foreach (int elemento in matriz)
            {
              
                if (elemento > media) acimaMedia ++;
                if (elemento < media) abaixoMedia++;
                if (elemento == media) numsMedia++;
            }

           
            Console.WriteLine($"A média é {media}");
            Console.WriteLine($"Quantidade de números que estão na média: {numsMedia}");
            Console.WriteLine($"Quantidade de números que estão acima da média: {acimaMedia}");
            Console.WriteLine($"Quantidade de números que estão abaixo da média: {abaixoMedia}");

        }
    }
}
