//Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
//multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
//(N*3; N * 3 * 3; N * 3 * 3 * 3; etc).

namespace Exercicios_Repeticao
{
    internal class Exe16
    {
        public static void Ex16()
        {
            Console.WriteLine("Insira um número igual ou menor que 50");
            int num = int.Parse(Console.ReadLine());
            int mult = num;

            while (mult < 250)
            {
                Console.WriteLine(mult);
                mult *= 3;
            }
        }
    }
}
