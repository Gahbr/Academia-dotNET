namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media aritmetica de 2 numeros");
            Console.WriteLine("insira o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            double media = (a + b)/2;
            Console.WriteLine( media);
        }
    }
}