//Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
//elevada a um expoente qualquer, ou seja, NM.

namespace Exercicios_Repeticao
{
    internal class Exe18
    {
        public static void Ex18()
        {
            Console.WriteLine("Potencia");
            Console.WriteLine("Insira a base");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um expoente");
            int exp = int.Parse(Console.ReadLine());
            Console.WriteLine($"A potência de {num} elevado a {exp} = {Math.Pow(num,exp)}");
        }
    }
}
