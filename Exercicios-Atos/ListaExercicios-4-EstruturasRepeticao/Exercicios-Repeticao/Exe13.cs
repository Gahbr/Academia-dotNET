// 13.Elaborar um programa que apresente o somatório dos valores pares existentes entre 1 e 500.
namespace Exercicios_Repeticao
{
    internal class Exe13
    {
        public static string Ex13()
        {
            {
                bool loop = true;
                double notaAlta = 0;
                double notaBaixa = 0;
                int soma = 0;
                for (int i = 0; i <= 500; i++)
                {
                    if(i % 2 == 0)
                    {
                        soma += i;
                    }
                }
                Console.WriteLine($"A soma dos números pares de 1 até 500 é {soma}");
                return "";
            }
        }
    }
}
