
namespace Exercicios_Repeticao
{
//    1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados
//(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
//Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.
    internal class Ex1
    {
        public static string ex01()
        {
            bool loop = true;

          while (loop == true)
            {
                double d;
                int i;
                Console.WriteLine("Insira um numero inteiro positivo");
                d = Convert.ToDouble(Console.ReadLine());
                i = Convert.ToInt32(d);

                if (i == d && d > 0)
                {
                    Console.WriteLine("Números pares entre 1 e " + i);
                    loop = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.WriteLine(j);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Insira um número correto!");
                    continue;
                }
            }
            return "";
        }
    }
}
