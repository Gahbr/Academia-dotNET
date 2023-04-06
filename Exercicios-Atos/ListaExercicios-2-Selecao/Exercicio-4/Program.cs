namespace Exercicio_4
{
    internal class Program
    {
        /*Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
        Mostrar na tela qual dos professores tem o maior salário total.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Salário dos professores");
            Console.WriteLine("Insira a quantidade de horas/aula do professor 1");
            double horasA = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor/hora do professor 1");
            double valorA = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de horas/aula do professor 2");
            double horasB = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor/hora do professor 2");
            double valorB= double.Parse(Console.ReadLine());

            double salarioA = horasA * valorA;
            double salarioB = horasB * valorB;

            if(salarioA > salarioB)
            {
                Console.WriteLine($"O maior salário é do professor 1 :  ${salarioA}");
            } else
            {
                Console.WriteLine($"O maior salário é do professor 2 :  ${salarioA}");
            }
        }
    }
}