namespace Exercicio_Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o salário:");
            double salario = double.Parse(Console.ReadLine()); 

            if(salario <=900) {
                double taxa = 0.05 * salario;
                double novoSalario =+ taxa;
                Console.WriteLine($"Salário = ${salario} - Taxa de aumento = {5}% - Novo salário ${salario + novoSalario}");
            } else if (salario >900 && salario < 1400)
            {
                double taxa = 0.08 * salario;
                double novoSalario = +taxa;
                Console.WriteLine($"Salário = ${salario} - Taxa de aumento = {8}% - Novo salário ${salario + novoSalario}");
            } else if (salario > 1400)
            {
                double taxa = 0.10 * salario;
                double novoSalario = +taxa;
                Console.WriteLine($"Salário = ${salario} - Taxa de aumento = {10}% - Novo salário ${salario + novoSalario}");
            }

        }
    }
}