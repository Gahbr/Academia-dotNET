namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media aritmetica de 4 numeros");
            Console.WriteLine("insira o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o terceiro numero: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o quarto numero: ");
            int d = int.Parse(Console.ReadLine());
            double media = (a + b + c + d  )/4;
            Console.WriteLine("A média é " + media);
        }
    }
}