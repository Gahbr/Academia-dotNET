//16.Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
//•	A união de X com Y
//•	A diferença entre X e Y
//•	A interseção entre X e Y
//Escreva o vetor resultado de cada uma das operações.

using System;

namespace ListaExercicios_5_Vetores
{
    internal class Exe16
    {
        public static void Ex()
        {
            int[] arr = new int[5], arr2 = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Insira um valor para inserir no vetor:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Insira um valor para inserir no vetor 2:");
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int[] uniao = arr.Union(arr2).ToArray();
            int[] diferenca = arr.Except(arr2).ToArray();
            int[] intersecao = arr.Intersect(arr2).ToArray();


            Console.WriteLine($"União de X com Y - {string.Join("|", uniao)}");
            Console.WriteLine($"Diferença de X com Y - {string.Join("|", diferenca)}");
            Console.WriteLine($"Interseção de X com Y - {string.Join("|", intersecao)}");
        }
    }
}
