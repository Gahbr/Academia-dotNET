namespace Exercicio_MediaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado”
            Console.WriteLine("Insira a nota 1 do aluno: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a nota 2 do aluno: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2)/2;

            if(media >=7) {
                Console.WriteLine("APROVADO");
            }else
            {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}