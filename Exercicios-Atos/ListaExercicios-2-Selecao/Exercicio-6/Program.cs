using System.Reflection.Emit;

namespace Exercicio_6
{
//    Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
//O programa deve calcular o Indice de Massa Corpórea(IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
//O cálculo do imc = peso / (altura * altura)
//IMC
//menor que 18                -> baixo peso
//maior que 18 e menor que 25 -> peso normal
//maior que 25 e menor que 30 -> sobrepeso
//maior que 30 e menor que 35 -> obesidade
//maior que 35                -> obesidade grau sério

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira o nome da pessoa :");
            string nome = Console.ReadLine().ToUpper();

            Console.WriteLine("insira a altura da pessoa :");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("insira o peso da pessoa :");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if(imc < 18)
            {
                Console.WriteLine($"Nome: {nome} - Altura: {altura}m - IMC: {imc.ToString("0.00")} -- baixo peso");
            } else if (imc >= 18 && imc < 25)
            {
                Console.WriteLine($"Nome: {nome} - Altura: {altura}m - IMC: {imc.ToString("0.00")} -- peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine($"Nome: {nome} - Altura: {altura}m - IMC: {imc.ToString("0.00")} -- sobrepeso");
            }
            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine($"Nome: {nome} - Altura: {altura}m - IMC: {imc.ToString("0.00")} -- obesidade");
            }
            else if (imc > 35)
            {
                Console.WriteLine($"Nome: {nome} - Altura: {altura}m - IMC: {imc.ToString("0.00")} -- obesidade grau sério");
            }
            
        }
    }
}