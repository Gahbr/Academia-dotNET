using System.Threading.Channels;

namespace Exercicio_16
{
    internal class Program
    {
//Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil.Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
//na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase.Caso contrário, mostre uma mensagem indicando que os dois times irão se
//enfrentar novamente em um novo jogo.
//ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
//ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
//plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.

        static void Main(string[] args)
        {
            Console.WriteLine("insira o placar do jogo: Formato - 00x00");
            string placar = Console.ReadLine();
            string[] substring = placar.Split('x');

            int timeCasa = int.Parse(substring[0]);
            int timeFora= int.Parse(substring[1]);

            if(timeCasa - timeFora >= 2) {
                Console.WriteLine("Time de casa se classificou para a próxima fase.");
            } else if (timeFora  - timeCasa >= 2) {
                Console.WriteLine("Time de fora se classificou para a próxima fase.");
            } else
            {
                Console.WriteLine("Os dois irão se enfrentar novamente");
                Console.WriteLine("Insira o placar do novo jogo");
                string placarVolta = Console.ReadLine();
                string[] substring2 = placar.Split('x');

                int timeCasa2 = int.Parse(substring[0]);
                int timeFora2 = int.Parse(substring[1]);

            
                if (timeCasa > timeFora)
                {
                    Console.WriteLine("Time de casa se classificou para a próxima fase.");
                }
                else
                {
                    Console.WriteLine("Time de fora se classificou para a próxima fase.");
                }
                
            }

        }
    }
}