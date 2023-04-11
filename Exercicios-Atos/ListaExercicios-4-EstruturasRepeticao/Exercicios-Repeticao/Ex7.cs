//7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
//A cada solicitação, teste se o usuário informou um valor válido. 
//Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
//informe que ele está incorreto e saia do programa em VS. 
//Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
//informe que está errada e saia. Se estiver correta, solicite o salário. 
//Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
//Se estiver correto, mostre todos os valores lidos.

using static System.Net.Mime.MediaTypeNames;

namespace Exercicios_Repeticao
{
    internal class Ex7
    {
        public static string Ex07()
        {
            bool loop = true;
            int number;
        
            while (loop == true)
            {
                Console.WriteLine("Informe o nome da pessoa.");
                string nome = Console.ReadLine();

                if (int.TryParse(nome, out number)|| nome == "")
                {
                    Console.WriteLine($"Nome inválido");
                    loop = false;
                    break;
                }
              
                Console.WriteLine("Informe a idade da pessoa.");
                string idade = (Console.ReadLine());

                if (int.TryParse(idade, out number))
                {
                    loop = true;
                }
                else
                {
                    Console.WriteLine("Idade inválida.");
                    loop = false;
                }

                Console.WriteLine("Informe o salário da pessoa.");
                double salario = double.Parse(Console.ReadLine());
                if(salario < 0)
                {
                    Console.WriteLine("Salário incorreto");
                    loop = false;
                }
                Console.WriteLine($"Nome: {nome} Idade: {idade} anos Salario: ${salario}");
                loop = false;
                
            }
           
            return "";
        }
    }
}
