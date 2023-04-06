namespace Exercicio_19
{
    internal class Program
    //Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro valor");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro valor");
            int num2 = int.Parse(Console.ReadLine());

            int[] numeros = { num1, num2, num };
            Array.Sort(numeros);
            
            Console.WriteLine("Números em ordem ascendente: ");
            foreach (int numero in numeros)
            {
                Console.Write($"{numero} ");
            }
            
        }
    }
}