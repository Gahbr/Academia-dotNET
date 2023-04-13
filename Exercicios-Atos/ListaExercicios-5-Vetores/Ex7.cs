//7.Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
//a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
//b.escreve: 	| 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |

namespace ListaExercicios_5_Vetores
{
    internal class Ex7
    {
        public static void Ex()
        {
            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"insira o valor do numero  ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine($"Array[{i}] = {vetor[i]}");
                }
               
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.WriteLine($"Array[{i}] = {vetor[i]}");
                }

            }

        }
    }
}
