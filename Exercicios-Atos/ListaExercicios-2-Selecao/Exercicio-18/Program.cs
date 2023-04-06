namespace Exercicio_18
{
    internal class Program
    {
        // Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro valor");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro valor");
            int num2 = int.Parse(Console.ReadLine());

            int maiorNumero = Math.Max(num, Math.Max(num1, num2));
            Console.WriteLine($"O maior número é : {maiorNumero}");
        }
    }
}