// Apresentar os quadrados dos números inteiros de 15 a 200.

namespace Exercicios_Repeticao
{
    internal class Exe17
    {
        public static void Ex17()
        {

         for(int i = 15; i <=200; i++)
            {
                Console.WriteLine($"{i}² = {Math.Pow(i,2)}");
            }
        }
    }
}
