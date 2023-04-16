//9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
//Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.

namespace ListaExercicios_6_Matrizes
{
    internal class Ex9
    {
        public static void Ex()
        {
            int[,] matriz = new int[3,3];
            int num = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 0] = Random.Shared.Next(10) + 1;
                matriz[i, 1] = Random.Shared.Next(10) + 1;
                matriz[i, 2] = Random.Shared.Next(10) + 1;
            }

            bool pesquisa = false;

            //printando tudo
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Digite um número para pesquisar na matriz");
            num = int.Parse(Console.ReadLine());

            foreach (int elemento in matriz)
            {
                if (num == elemento) pesquisa = true;
            }

            Console.WriteLine(pesquisa == true ? "O número existe no vetor”" : "Número inexistente");
        }

    }
    }
