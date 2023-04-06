namespace Exercicio_8
{
//    Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
//Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
//Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
//E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
//total de vendas.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o salário:");
            double salario = double.Parse(Console.ReadLine());

            if (salario <= 900)
            {
                double taxa = 0.05 * salario;
                double novoSalario = +taxa;
                Console.WriteLine($"Salário = ${salario} - Taxa de aumento = {5}% - Novo salário ${salario + novoSalario}");
            }
            else if (salario > 900 && salario < 1400)
            {
                double taxa = 0.08 * salario;
                double novoSalario = +taxa;
                Console.WriteLine($"Salário = ${salario} - Taxa de aumento = {8}% - Novo salário ${salario + novoSalario}");
            }
            else if (salario > 1400)
            {
                double taxa = 0.10 * salario;
                double novoSalario = +taxa;
                Console.WriteLine($"Salário = ${salario} - Taxa de aumento = {10}% - Novo salário ${salario + novoSalario}");
            }
        }
    }
}