//12.Apresentar o total da soma dos cem primeiros números inteiros.

namespace Exercicios_Repeticao
{
    internal class Exe12
    {
        public static string Ex12()
        {
            {
                bool loop = true;
                double notaAlta = 0;
                double notaBaixa = 0;
                int soma = 0;
                for(int i = 0; i <= 100; i++)
                {
                    soma += i;
                }
                Console.WriteLine($"A soma dos números de 1 até 100 é {soma}");
                return "";
            }
        }
    }
}
