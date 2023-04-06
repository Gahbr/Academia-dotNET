namespace Exercicio_2
{
    internal class Program
    {
        //Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número!");
            int numero =  int.Parse(Console.ReadLine());

            if(numero % 2 == 0) {
                Console.WriteLine("É um número par");
            } else
            {
                Console.WriteLine("É um número ímpar");
            }

        }
    }
}