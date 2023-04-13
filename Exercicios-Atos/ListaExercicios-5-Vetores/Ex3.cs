// Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.

namespace ListaExercicios_5_Vetores
{
    internal class Ex3
    {
        public static void Ex()
        {
            int[] vetor = new int[20];

            for (int i = 0; i < 19; i++)
            {
                Console.WriteLine($"insira o valor do vetor 1 - [{i}]");
                vetor[i] = int.Parse(Console.ReadLine());

                if (NumeroPrimo(vetor[i]))
                {
                    Console.WriteLine($"vetor[{i}] = {vetor[i]} é número primo");
                }
            }
        }

        public static bool NumeroPrimo(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
