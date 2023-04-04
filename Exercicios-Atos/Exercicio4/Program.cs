

namespace Exercicio4
{
    //Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na forma AAAAMMDD e AAMMDD.Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira a data na forma DDMMAAAA");
            Console.WriteLine("Dia:");
            string dia = Console.ReadLine();
            Console.WriteLine("Mês:");
            string mes = Console.ReadLine();
            Console.WriteLine("Ano:");
            string ano= Console.ReadLine();

            Console.WriteLine(dia + "/"+mes+ "/"+ano);
            Console.WriteLine(ano + "/" + mes + "/" + dia);

        }
    }
}