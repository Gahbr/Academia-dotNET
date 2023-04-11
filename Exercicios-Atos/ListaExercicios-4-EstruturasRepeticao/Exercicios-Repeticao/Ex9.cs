//Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
//o zoológico num determinado dia, imprimindo:
//Quantas pessoas tem entre 1 e 3 filhos.
//Quantas pessoas tem entre 4 e 7 filhos.
//Quantas pessoas tem mais de 8 filhos.
//Quantas pessoas não tem filhos.

namespace Exercicios_Repeticao
{
    internal class Ex9
    {
        public static string Ex09()
        {
            {
                int categoriaA = 0;
                int categoriaB = 0;
                int categoriaC = 0;
                int categoriaD = 0;

                for (int i  = 1; i < 31; i++)
                {
                    Console.WriteLine($"Pessoa {i}, insira a quantidade de filhos:");
                    int filhos = int.Parse( Console.ReadLine());

                    if( filhos > 0 && filhos < 4)
                    {
                        categoriaA++;
                    }

                    if (filhos > 3 && filhos < 8)
                    {
                        categoriaB++;
                    }

                    if (filhos > 8)
                    {
                        categoriaC++;
                    }

                    if (filhos == 0 )
                    {
                        categoriaD++;
                    }
                }

                Console.WriteLine($"Quantas pessoas tem entre 1 e 3 filhos: {categoriaA}.\r\n//Quantas pessoas tem entre 4 e 7 filhos: {categoriaB}\r\n//Quantas pessoas tem mais de 8 filhos: {categoriaC}\r\n//Quantas pessoas não tem filhos: {categoriaD}");
                return "";
            }
        }
    }
}
