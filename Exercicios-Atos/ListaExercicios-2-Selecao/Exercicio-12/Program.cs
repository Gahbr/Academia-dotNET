namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e
//número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo - se que ele ganha
//R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento
//armazenando - o na variável "extra", caso contrário zerar tal variável.A hora excedente de trabalho vale R$ 20,00.
//No final do processamento, exibir o salário total e o salário excedente do operário.

            Console.WriteLine("insira o código:");
            int cod = int.Parse(Console.ReadLine());

            Console.WriteLine("insira o número de horas trabalhadas:");
            double horas = double.Parse(Console.ReadLine());

            if(horas > 50)
            {
                double calculoSal = 50 * 10;
                double excessoHoras = horas - 50;
                double salarioExcesso = excessoHoras * 20;
                double salarioTotal = calculoSal + salarioExcesso;
                Console.WriteLine($"Salário total ${salarioTotal} - Salário excedente: {salarioExcesso}");
            } else
            {
                double salarioTotal= horas * 10;
                Console.WriteLine($"Salário total ${salarioTotal} - Salário excedente: $0");
            }
        }
    }
}