using System.Runtime.Intrinsics.X86;

namespace Exercicio_11
{
    internal class Program
    {
//Faça um programa no VS que receba uma hora, dividida em 2 variáveis(uma para hora e outra para minutos).
//O programa deve exibir se a hora digitada está ou não válida.
//Lembre que usaremos o padrão de hora com 24h, de 0 a 23.
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a hora:");
            string input= Console.ReadLine();

            string[] substring = input.Split(':');
            int hora = int.Parse(substring[0]);
            int minutos = int.Parse(substring[1]);

            if(hora < 0 || hora > 23 || minutos < 0 || minutos > 59) 
            {
                Console.WriteLine("Hora inválida!");
            } else
            {
                Console.WriteLine("Hora válida!");
            }
        }

    }
}