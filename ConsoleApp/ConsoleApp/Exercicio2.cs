namespace Exercicios
{
    public class Exercicio2
    //Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media aritmetica de 2 numeros");
            Console.WriteLine("insira o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double media = (a+b)/2 ;
            Console.WriteLine("A média é " + media);

            
        }
    }
}