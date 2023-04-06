namespace Exercicio_13
{
    internal class Program
    {
//Tendo como dado de entrada a altura(h) de uma pessoa, construa um programa no VS que calcule
//seu peso ideal, utilizando as seguintes fórmulas:
//Para homens: (72.7 * h) - 58
//Para mulheres: (62.1 * h) - 44.7
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a altura da pessoa:");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o sexo da pessoa : M ou F");
            string sexo = Console.ReadLine();
            sexo.ToUpper();
            
            if (sexo == "M")
            {
                double calculo = (72.7 * altura) - 58;
                Console.WriteLine($"Seu peso ideal é {calculo.ToString("0.00")}kg" );
            } else if (sexo == "F")
            {
                double calculo = (62.1 * altura) - 44.7;
                Console.WriteLine($"Seu peso ideal é {calculo.ToString("0.00")}kg");
            } else
            {
                Console.WriteLine("Sexo incorreto. Tente novamente");
            }
        }
    }
}