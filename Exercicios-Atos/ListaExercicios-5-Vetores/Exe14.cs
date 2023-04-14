//14.Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números. Se o código for zero, termine o algoritmo. Se o código for 1, mostre o vetor na ordem em que foi lido. Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro

namespace ListaExercicios_5_Vetores
{
    internal class Exe14
    {
        public static void Ex()
        {
            int[] arr = new int[5];
            int cod;

            Console.WriteLine($"Insira um código : \n0 - terminar algoritmo\n1 - vetor ordenado\n2 - vetor inverso");
            cod = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Insira um valor para inserir no vetor:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            switch (cod)
            {
                case 0:
                    break;

                case 1:
                    Array.Sort(arr);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine($"Array[{i}] - {arr[i]}");
                    }
                    break;

                case 2:
                    Array.Reverse(arr);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine($"Array[{i}] - {arr[i]}");
                    }
                    break;
            }
        }
    }
}
