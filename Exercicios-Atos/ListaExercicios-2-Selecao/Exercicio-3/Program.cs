namespace Exercicio_Media4Valores
{
    internal class Program
    {
        //Escrever um algoritmo para ler quatro valores, calcular a sua média, e escrever na tela os que são superiores à média.
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de média");
            Console.WriteLine("Insira o valor 1 :");
            double valorA = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor 2 :");
            double valorB = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor 3 :");
            double valorC = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor 4 :");
            double valorD = double.Parse(Console.ReadLine());

            double media = (valorA + valorB + valorC + valorD) / 4;
            Console.WriteLine("Média :" + media);

            Console.WriteLine("Valores maiores que a média:");
            if (valorA > media) { Console.WriteLine(valorA); }
            if (valorB > media) { Console.WriteLine(valorB); }
            if (valorC > media) { Console.WriteLine(valorC); }
            if (valorD > media) { Console.WriteLine(valorD); }
        }
    }
}