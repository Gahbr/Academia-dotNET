//Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
//lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
//escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |

namespace ListaExercicios_5_Vetores
{
    internal class Ex6
    {
        public static void Ex()
        {
            int[] vetor = new int[10];

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine($"insira o valor do numero  ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Array[{i}] = {vetor[i]}");
            }
          
        }
    }
}
