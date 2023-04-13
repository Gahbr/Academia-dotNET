// Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.

namespace ListaExercicios_5_Vetores
{
    internal class Ex1
    {
        public static void Ex () {
            int[] vetor = new int[10];
            int pares = 0;
            int impares = 0;
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"insira o valor do vetor {i}");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                {
                    pares++;
                } else impares++;
            }
            Console.WriteLine($"Quantidade de números pares : {pares}\nQuantidade de números ímpares: {impares}");
        }
    }
}
