//Fazer um laço (repetição) que fique solicitando números ao usuário. 
//Se o usuário digitar 0 o programa em VS deve parar. 
//Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.   

namespace Exercicios_Repeticao
{
    internal class Ex3
    {
        public static string Ex03()
        {
            bool loop = true;

            while (loop == true)
            {
                Console.WriteLine("Insira um numero - Para parar o programa digite 0 ");
                int input = int.Parse(Console.ReadLine());

                if (input ==  0)
                {
                    loop = false;
                }
                else
                {
                    if(input % 2 == 0 ) {
                        Console.WriteLine($"O número {input} é par");
                        if (EPrimo(input))
                        {
                            Console.WriteLine($"O número {input} é primo");
                        }else
                        {
                            Console.WriteLine($"O número {input} não é primo");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"O número {input} é ímpar");
                        if (EPrimo(input))
                        {
                            Console.WriteLine($"O número {input} é primo");
                        }
                        else
                        {
                            Console.WriteLine($"O número {input} não é primo");
                        }
                    }
                    continue;
                }
            }
            return "";
        }

        public static bool EPrimo(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
