namespace Exercicio_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculadora Simples com escolha da operação pro parte do usuário
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("Insira o primeiro número");
            double numA = double.Parse(Console.ReadLine());  
            Console.WriteLine("Insira o segundo número");
            double numB = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma operação: 1 - SOMA; 2 - SUBTRAÇÃO; 3 - DIVISÃO; 4 - MULTIPLICAÇÃO");
            int operation= int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"A soma é {numA + numB }");
                    break;
                case 2:
                    Console.WriteLine($"A subtração é {numA - numB}");
                    break;
                case 3:
                    double result = numA / numB;
                    Console.WriteLine($"A divisão é {result.ToString("0.00")}");
                    break;
                case 4:
                    Console.WriteLine($"A multiplicação é {numA * numB}");
                    break;
               
            }
        }
    }
}