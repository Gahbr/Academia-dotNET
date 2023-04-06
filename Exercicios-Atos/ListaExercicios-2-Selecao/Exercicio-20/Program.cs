using System.Runtime.Intrinsics.X86;

namespace Exercicio_20
{
    internal class Program
    {
        //Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”.
        //plus: você pode gerar o número de forma randomica(função random c#).
        static void Main(string[] args)
        {
            Console.WriteLine("Jogo de adivinhação!");
            bool acertou = false;
            int tentativas = 0;
            Random random = new Random();

            int numeroAleatorio = random.Next(1, 11);

            while (acertou == false && tentativas < 3)
            {
                Console.WriteLine("Insira um número");
                int input = int.Parse(Console.ReadLine());

                if(input == numeroAleatorio)
                {
                    Console.WriteLine("Você acertou!");
                    break;
                }else
                {
                    tentativas++;
                }
            }
            
            if(tentativas == 3)
            {
                Console.WriteLine("Você perdeu!!");
                Console.WriteLine($"O número era {numeroAleatorio}");
            }
           


        }
    }
}