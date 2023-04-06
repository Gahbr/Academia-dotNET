using System.Diagnostics;

namespace Exercicio_7
{
    internal class Program
    {
//Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
//O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
//exemplo, A palavra encontra-se na frase ou A palavra não se encontra na frase.

        static void Main(string[] args)
        {
            Console.WriteLine("Insira uma frase:");
            string frase = Console.ReadLine();
            Console.WriteLine("Insira uma palavra para buscar na frase");
            string palavra = Console.ReadLine();

            if(frase.Contains(palavra))
            {
                Console.WriteLine("A palavra se encontra na frase");
            }else
            {
                Console.WriteLine("A palavra não se encontra na frase");
            }
        }
    }
}