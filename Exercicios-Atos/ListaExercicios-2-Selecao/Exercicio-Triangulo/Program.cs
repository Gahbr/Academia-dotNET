namespace Exercicio_Triangulo
{
    internal class Program
    {
        /*
        •Dados três números, verificar se eles podem representar as medidas dos lados de um triângulo e, classificar o triângulo em equilátero, isósceles ou escaleno.
        •Para que três números representem os lados de um triângulo é necessário que cada um deles seja menor que a soma dos outros dois.
        •Um triângulo é equilátero se tem os três lados iguais,  isósceles se tem apenas dois lados iguais e escaleno se tem todos os lados distintos.
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o lado A");
            double ladoA = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado B");
            double ladoB = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado C");
            double ladoC = double.Parse(Console.ReadLine());

            if (ladoA < (ladoB + ladoC) && ladoB < (ladoA + ladoC) && ladoC < (ladoA + ladoB))
            {
              if(ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("É um triangulo equilátero");
                }else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("É um triangulo isóceles");
                } else if (ladoA != ladoB && ladoB != ladoC && ladoA!= ladoC)
                {
                    Console.WriteLine("é um triangulo escaleno");
                }
            }
        }
    }
}