//8.Faça um programa em VS que solicite um numero inteiro. S
//e o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
//Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.

namespace Exercicios_Repeticao
{
    internal class Ex8
    {
        public static string Ex08()
        {
            {
                bool loop = true;

                while (loop == true)
                {
                    double d;
                    int i;
                    Console.WriteLine("Insira um numero inteiro");
                    d = Convert.ToDouble(Console.ReadLine());
                    i = Convert.ToInt32(d);

                    if (i == d)
                    {
                       if(i % 2 == 0)
                        {
                            Console.WriteLine("É um número par");
                        }else
                        {
                            Console.WriteLine("É um número ímpar");
                        }

                        Console.WriteLine("Deseja informar outro número (s/n)?");
                        string input = Console.ReadLine();
                        if (input == "s" || input == "S")
                        {
                            continue;
                        }
                        else if (input == "n" || input == "N")
                        {
                            loop = false;
                            Console.WriteLine("Programa finalizado!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("insira uma resposta válida!");
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
}
