//using System.ComponentModel;

//2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
//informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 
//Exemplo:
//Digite um número inteiro positivo: 8
//Numero digitado: 8
//Números inteiros pares entre 1 e 8: 2, 4, 6.


//Deseja informar outro número (s/n)? S
 
//Digite um número inteiro positivo: 12
//Numero digitado: 20
//Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.


//Deseja informar outro número (s/n)? N

namespace Exercicios_Repeticao
{
    internal class Ex2
    {
        public static string ex02()
        {
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
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.WriteLine(j);
                            }
                        }

                        Console.WriteLine("Deseja informar outro número (s/n)?");
                        string input = Console.ReadLine();
                        if(input == "s" || input == "S")
                        {
                            continue;
                        }else if (input == "n" || input == "N")
                        {
                            loop = false;
                            Console.WriteLine("Programa finalizado!");
                            break;
                        }else
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
