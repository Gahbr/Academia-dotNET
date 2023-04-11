namespace Exercicios_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        static string ex()
        {
            //Escreva um algoritmo leia pelo teclado um valor inteiro chamado x, e então mostre na tela todos os números de 0 a 100, pulando de x em x.
            Console.WriteLine("Insira um valor");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < 100; i = i + input)
            {
                Console.WriteLine(i);
            }
            return "";
        }

        static string ex1()
        //Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n pessoas e calcular a média das idades.
        {
            Console.WriteLine("Quantas pessoas?");
            int input = int.Parse(Console.ReadLine());
            double idades = 0;

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("Insira a idade da pessoa:" + i);
                int idade = int.Parse(Console.ReadLine());
                idades += idade;
            }
            Console.WriteLine("A média de idade é: " + (idades / input) + " anos.");
            return "";
        }

        static string ex2()
        //Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.
        {
            double maior = 0;

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Insira o número " + i);
                int input = int.Parse(Console.ReadLine());

                if (input > maior)
                {
                    maior = input;
                }
            }
            Console.WriteLine("Maior número:" + maior);
            return "";
        }

        static string ex3()
        //Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número x lido utilizando laços de repetição, e mostre na tela.
        {
            Console.WriteLine("Tabuada");
            Console.WriteLine("Insira o número ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{input} x {i} = {input * i}");
            }
            return "";
        }

        static string ex4()
        //Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x elevado na y sem utilizar a função pow.
        {
            Console.WriteLine("Potenciação");
            Console.WriteLine("Insira o valor X");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor Y");
            int Y = int.Parse(Console.ReadLine());

            int res = X;
            for (int i = 1; i < Y; i++)
            {
                res = res * X;
            }
            Console.WriteLine(res);
            return "";
        }

        static string ex5()
        //Escreva um algoritmo para calcular o fatorial de um número.
        {
            Console.WriteLine("Insira o número ");
            int n = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for (int i = 1; i <= n; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine(n + "! = " + fatorial);
            return "";
        }

        static string ex6()
        //Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações aplicadas para aquela turma.Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final (média das notas das avaliações).
        {
            int numAlunos, numAvaliacoes;
            double nota, media;

            Console.Write("Digite o número de alunos da turma: ");
            numAlunos = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de avaliações aplicadas: ");
            numAvaliacoes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numAlunos; i++)
            {
                media = 0;
                Console.WriteLine("Notas do aluno {0}:", i);

                for (int j = 1; j <= numAvaliacoes; j++)
                {
                    Console.Write("Digite a nota da avaliação {0}: ", j);
                    nota = double.Parse(Console.ReadLine());
                    media += nota;
                }

                media /= numAvaliacoes;

                Console.WriteLine("Média do aluno {0}: {1:F2}", i, media);
            }

            Console.ReadKey();
            return "";
        }

        static string ex7()
        // Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por um usuário.Apresente o resultado.
        {
            Console.WriteLine("Números pares e impares");
            int pares = 0;
            int impares = 0;

            for (int i = 0; i < 20; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
            Console.WriteLine($"números pares : {pares} - numeros impares : {impares}");
            return "";
        }
    }
}