namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de temperatura Celsius - Fahrenheit");
            Console.WriteLine("insira a temperatura em celsius: ");
            double x = double.Parse(Console.ReadLine());

            double toFahrenheit = (x * 9 / 5) + 32;
            Console.WriteLine("A temperatura em fahrenheit é " + toFahrenheit);

            Console.WriteLine("Insira o valor de A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de B");
            int b = int.Parse(Console.ReadLine());


            Console.WriteLine("Valor de A: " + a + " Valor de B" + b);
            int z = a;
            a = b;
            b = z;
            Console.WriteLine("Valores Trocados:");
            Console.WriteLine("Valor de A: " + a + " Valor de B" + b);
        }
    }
}