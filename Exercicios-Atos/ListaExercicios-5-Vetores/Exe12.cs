//Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor. Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".

using System;

namespace ListaExercicios_5_Vetores
{
    internal class Exe12
    {
        public static void Ex()
        {
            int[] arr = new int[3];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Insira um valor para inserir no vetor:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Insira agora um número para procurar no vetor");
            int busca = int.Parse((string) Console.ReadLine());

            if (arr.Contains(busca))
            {
                Console.WriteLine(Array.IndexOf(arr, busca)); 
            }
            else Console.WriteLine("O número fornecido não existe no vetor!");

        }
    }
}
