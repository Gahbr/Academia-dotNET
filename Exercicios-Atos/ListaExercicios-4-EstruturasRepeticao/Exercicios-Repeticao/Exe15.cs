//Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
//ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
//Considerar nota 7,0 como mínima para aprovação.

namespace Exercicios_Repeticao
{
    internal class Exe15
    {
        public static void Ex15()
        {
            {
                bool loop = true;
                int soma = 0;
                Console.WriteLine($"insira a nota 1 do aluno:");
                double nota = double.Parse(Console.ReadLine());
                nota *=2;

                Console.WriteLine($"insira a nota 2 do aluno:");
                double nota2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"insira a nota 3 do aluno:");

                double nota3 = double.Parse(Console.ReadLine());
                nota3 *= 2;

                Console.WriteLine($"insira a nota 4 do aluno:");
                double nota4 = double.Parse(Console.ReadLine());
                nota4 *= 4;

                double media = (nota+ nota2 + nota3 + nota4)/9 ;
                Console.WriteLine($"A nota final é {media}");
                if(media >= 7)
                {
                    Console.WriteLine("Aluno aprovado");
                }else Console.WriteLine("Aluno reprovado");
            }
        }
    }
}
