namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit A fórmula da conversão é F = (9 * C + 160) / 5.
            Console.WriteLine("Conversor de temperatura Celsius - Fahrenheit");
            Console.WriteLine("insira a temperatura em celsius: ");
            double x = double.Parse(Console.ReadLine());

            double toFahrenheit = (x * 9 / 5) + 32;
            Console.WriteLine("A temperatura em fahrenheit é " + toFahrenheit);
        }
    }
}