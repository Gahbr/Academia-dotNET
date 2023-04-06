namespace Exercicio_AreaTriangulo
{
    internal class Program
    {

        /*Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
        Área do triangulo = (base * altura) / 2; 
        Teste se a base ou a altura digitada não foi igual a zero.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Área do triangulo");
            Console.WriteLine("insira o valor da base: ");
            double Base = double.Parse(Console.ReadLine());

            Console.WriteLine("insira o valor da altura: ");
            double altura = double.Parse(Console.ReadLine());
            double area = (Base * altura) / 2;

            if (Base == 0 || altura == 0)
            {
                Console.WriteLine("valor da base ou altura é 0. Tente novamente.");
            } else
            {
                Console.WriteLine($"Área do triângulo: {area}");
            }
        }
    }
}