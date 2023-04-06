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
            Console.WriteLine("Insira o código do funcionário:");
            int cod = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira o salário base:");
            double salario = double.Parse(Console.ReadLine());
            double salarioFinal, bonus;

            Console.WriteLine("Insira o total de vendas em $:");
            double vendas = double.Parse(Console.ReadLine());

            if (vendas > 500 && vendas <=1000)
            {
                salarioFinal = salario + ((vendas * 105) / 100);
                Console.WriteLine($"SalárioFinal = ${salarioFinal}");
            }
            else if (vendas > 1000 && vendas <= 5000)
            {
                salarioFinal = salario + ((vendas * 107) / 100);
                Console.WriteLine($"SalárioFinal = ${salarioFinal}");
            }
            else if (vendas > 5000)
            {
                salarioFinal = salario + ((vendas * 110) / 100);
                Console.WriteLine($"SalárioFinal = ${salarioFinal}");
            }
        }
    }
}