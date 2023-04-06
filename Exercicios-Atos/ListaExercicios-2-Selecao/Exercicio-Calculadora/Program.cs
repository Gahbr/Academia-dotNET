namespace Exercicio_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora:");
            Console.WriteLine("insira o primeiro numero");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("insira o segundo numero");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação você quer fazer? Opções: +, -, *, /");
            char operacao = char.Parse(Console.ReadLine());

            switch (operacao)
            {
                case '*':
                    Console.WriteLine($"Resultado: {number * number2}");
                    break;

                case '+':
                    Console.WriteLine($"Resultado: {number + number2}");
                    break;

                case '-':
                    Console.WriteLine($"Resultado: {number - number2}");
                    break;

                case '/':
                    Console.WriteLine($"Resultado: {number / number2}");
                    break;

                default:
                    Console.WriteLine("Operação inválida");
                    break;

            }
        }
    }
}