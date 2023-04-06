using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace Exercicio_5
{
//    Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
//se a média das duas notas for maior ou igual a 7,0. 

//Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
//é a média entre a nota do exame e a média das 2 notas.
//Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve
//escrever “Reprovado”.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira a nota 1 :");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("insira a nota 2 :");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2)/2 ;

            if(media < 7)
            {
                Console.WriteLine("Insira a nota do exame");
                double exame = double.Parse(Console.ReadLine());
                double mediaFinal = (nota1 + nota2 + exame)/3;

                if(mediaFinal >= 5)
                {
                    Console.WriteLine("APROVADO");
                }else
                {
                    Console.WriteLine("REPROVADO");
                }
            }
        }
    }
}