namespace PedraPapelTesoura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

            while (scorePlayer < 3 && scoreCPU < 3)
            {

                Console.WriteLine("Escolha entre PEDRA, PAPEL E TESOURA: ");
                inputPlayer = Console.ReadLine();
                inputPlayer = inputPlayer.ToUpper();

                Random rnd = new Random();
                randomInt = rnd.Next(1, 4);

                switch (randomInt)
                {
                    case 1:
                        inputCPU = "PEDRA";
                        Console.WriteLine("Computador escolheu PEDRA");

                        if (inputPlayer == "PEDRA")
                        {
                            Console.WriteLine("EMPATE!!\n\n");
                        }
                        else if (inputPlayer == "PAPEL")
                        {
                            Console.WriteLine("---Jogador vence!---");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "TESOURA")
                        {
                            Console.WriteLine("---Computador vence!---");
                            scoreCPU++;
                        }
                        break;
                    case 2:
                        inputCPU = "PAPEL";
                        Console.WriteLine("Computador escolheu PAPEL");

                        if (inputPlayer == "PEDRA")
                        {
                            Console.WriteLine("---Computador vence!---");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "PAPEL")
                        {
                            Console.WriteLine("EMPATE!!\n\n");
                        }
                        else if (inputPlayer == "TESOURA")
                        {
                            Console.WriteLine("---Jogador vence!---");
                            scorePlayer++;
                        }
                        break;
                    case 3:
                        inputCPU = "TESOURA";
                        Console.WriteLine("Computador escolheu TESOURA");

                        if (inputPlayer == "PEDRA")
                        {
                            Console.WriteLine("---Jogador vence!---");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "PAPEL")
                        {
                            Console.WriteLine("---Computador vence!---");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "TESOURA")
                        {
                            Console.WriteLine("EMPATE!!\n\n");
                        }
                        break;
                    default:
                        Console.WriteLine("Entrada inválida!");
                        break;
                }
            }

            Console.WriteLine($"Placar final: JOGADOR: {scorePlayer} x {scoreCPU} CPU: ");
        }
    }
}