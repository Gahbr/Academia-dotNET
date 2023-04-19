

//Desenvolva um jogo da velha utilizando matrizes em C#. Faça com que cada jogador insira a sua jogada em uma interface amigavel. 
//Teste se a posição é válida e caso não seja solicite ao jogador repetir a jogada. Após cada jogada, apresente o tabuleiro com as 
//jogadas representadas por "X" e "O" e faça a verficação se algum jogador venceu.
//Caso seja empate, apresente o resultado na tela. Possilibilite que o jogo seja reinicializado sem a necessidade de reiniciar o jogo. 


//Desafio extra, pode valer por alguma atividade futura: Faça a implementação de um jogo contra o computador. Faça o possível para evitar que o jogador vença do computador. 
//Para facilitar, faça com que o computador inicie jogando.

//Prazo de entrega: 24 / 04
//Forma e envio: Enviar pelo chat o link do github


namespace Desafio_Jogo_Da_Velha
{
    internal class Program
    {
        static string[] tabuleiro = new string[9];
        static string jogoAtivo = "Y";

    


        static void Main(string[] args)
        {
            while (jogoAtivo == "Y")
            {
                montarTabuleiro();

                while (!verificaVitoria())
                {
                    receberInput("X");
                    if (verificaVitoria())
                    {
                        jogoAtivo = "N";
                        break;
                    }

                    receberInput("O");
                    if (verificaVitoria())
                    {
                        jogoAtivo = "N";
                        break;
                    }
                }

                if (verificaVitoria())
                    Console.WriteLine("Parabéns! Você venceu!");
                else
                    Console.WriteLine("Empate!");

            }

            mensagemFinal();
        }

        static void montarTabuleiro()
        {
            for (int i = 0; i < 9; i++)
            {
                tabuleiro[i] = i.ToString();
            }
        }

        static void mensagemFinal()
        {
            Console.WriteLine("Desafio Academia .NET ATOS.");
        }

        static void receberInput(string jogador)
        {
            Console.Clear();
            Console.WriteLine("---JOGO DA VELHA---");
            Console.WriteLine($"Jogador Atual - {jogador}");

            int input;
            bool validaInput;

            do
            {
                Console.WriteLine("Digite um número para jogar:\n");

                imprimirTabuleiro();

                //valida a entrada de dados
                validaInput = int.TryParse(Console.ReadLine(), out input) && input >= 0 && input < 9 && tabuleiro[input] != "X" && tabuleiro[input] != "O";

                if (!validaInput)
                {
                    Console.WriteLine("Seleção inválida! Escolha um número entre 0 e 8 que não tenha sido escolhido antes.");
                }
            } while (!validaInput);

            tabuleiro[input] = jogador;
        }

        static void imprimirTabuleiro()
        {
            Console.Write($"{tabuleiro[0]}  | {tabuleiro[1]}  | {tabuleiro[2]}");
            Console.WriteLine();
            Console.WriteLine("_____________\n");

            Console.Write($"{tabuleiro[3]}  | {tabuleiro[4]}  | {tabuleiro[5]}");
            Console.WriteLine();
            Console.WriteLine("_____________\n");

            Console.Write($"{tabuleiro[6]}  | {tabuleiro[7]}  | {tabuleiro[8]}");
            Console.WriteLine();
            Console.WriteLine("_____________\n");
        }


        static bool verificaVitoria()
        {
            // checando se as linhas  sao iguais
            if (tabuleiro[0] == tabuleiro[1] && tabuleiro[1] == tabuleiro[2]) return true;
            if (tabuleiro[3] == tabuleiro[4] && tabuleiro[4] == tabuleiro[5]) return true;
            if (tabuleiro[6] == tabuleiro[7] && tabuleiro[7] == tabuleiro[8]) return true;

            // verificando as colunas
            if (tabuleiro[0] == tabuleiro[3] && tabuleiro[3] == tabuleiro[6]) return true;
            if (tabuleiro[1] == tabuleiro[4] && tabuleiro[4] == tabuleiro[7]) return true;
            if (tabuleiro[2] == tabuleiro[5] && tabuleiro[5] == tabuleiro[8]) return true;

            // verificando as diagonais 
            if (tabuleiro[0] == tabuleiro[4] && tabuleiro[4] == tabuleiro[8]) return true;
            if (tabuleiro[2] == tabuleiro[4] && tabuleiro[4] == tabuleiro[6]) return true;

            return false;
        }
    }
}

