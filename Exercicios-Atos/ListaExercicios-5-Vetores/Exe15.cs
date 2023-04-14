//Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, e copie estes conteúdos para outro vetor, invertendo sua ordem. Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo. Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.

namespace ListaExercicios_5_Vetores
{
    internal class Exe15
    {
        public static void Ex()
        {
            int[] arr = new int[5];
            int[] arrInvertido = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Insira um valor para inserir no vetor:");
                arr[i] = int.Parse(Console.ReadLine());
                arrInvertido[i] = arr[i];
            }

            Array.Reverse(arrInvertido);

            for(int i = 0;i < arr.Length; i++)
            {
                Console.WriteLine($"Array[{i}] - {arr[i]}");
                Console.WriteLine($"Array invertido[{i}] - {arrInvertido[i]}");
            }
        }
    }
}
