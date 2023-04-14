//Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8. O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do vetor.

namespace ListaExercicios_5_Vetores
{
    internal class Exe13
    {
        public static void Ex()
        {
            int[] arr = new int[100];
            bool loop = true;
            int cont2 = 0;
            int cont4 = 0;
            int cont8 = 0;

            while (loop == true)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Insira um número:");
                    arr[i] = int.Parse(Console.ReadLine());

                    if (arr[i] == -1)
                    {
                        loop = false;
                        break;
                    }

                    if (arr[i] == 2) cont2++;
                    if (arr[i] == 4) cont4++;
                    if (arr[i] == 8) cont8++;
                }
            }

            Console.WriteLine($"2 aparece {cont2} vezes\n4 aparece {cont4} vezes\n8 aparece {cont8} vezes\n");
        }
    }
}
