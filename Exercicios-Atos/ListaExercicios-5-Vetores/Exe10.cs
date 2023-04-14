//Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.

namespace ListaExercicios_5_Vetores
{
    internal class Exe10
    {
        public static void Ex()
        {
            int[] vetor = new int[20];
            int[] vetorNovo = new int[20];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Insira um número");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                vetorNovo[i] = vetor[i];
                if (vetor[i] == 0)
                {
                    vetorNovo[i] = 2;
                }
            }

            for(int i = 0;i < vetorNovo.Length; i++)
            {
                Console.WriteLine($"Array[{i} = {vetorNovo[i]}]");
            }
        }
    }
}
