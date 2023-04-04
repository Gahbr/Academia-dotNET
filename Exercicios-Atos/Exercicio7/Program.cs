namespace Exercicio7
{
    internal class Program
    {
        //Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo,o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.
        static void Main(string[] args)
        {
            Console.WriteLine("Número do vendedor:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Salário:");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o total de vendas realizadas:");
            int totalVendas = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o percentual sobre o total de vendas :");
            double percentual= double.Parse(Console.ReadLine());
            double calculoPercentual= (percentual/100)*totalVendas;
            Console.WriteLine($"Número do vendedor : {num} - Salário total : {salario + calculoPercentual}");
        }
    }
}