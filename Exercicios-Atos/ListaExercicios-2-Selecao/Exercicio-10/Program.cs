using static System.Net.Mime.MediaTypeNames;

namespace Exercicio_10
{
    internal class Program
    {
//Faça um programa no VS que receba dados de dois atletas(nome, idade e altura).
//O programa deve mostrar os dados do atleta mais novo e mais alto.
        static void Main(string[] args)
        {

            Console.WriteLine("Insira o nome do atleta 1:");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira a idade do atleta 1:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a altura do atleta 1:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome do atleta 2:");
            string nome2 = Console.ReadLine();

            Console.WriteLine("Insira a idade do atleta 2:");
            int idade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a altura do atleta 2:");
            double altura2 = double.Parse(Console.ReadLine());

            if(idade > idade2)
            {
                Console.WriteLine($"O atleta mais novo é o {nome2} - {idade2} anos");
            } else if (idade2 > idade)
            {
                Console.WriteLine($"O atleta mais novo é o {nome} - {idade} anos");
            } else if (idade == idade2)
            {
                Console.WriteLine("Eles têm a mesma idade" + idade + " anos");
            }

            if (altura > altura2)
            {
                Console.WriteLine($"O atleta mais alto é o {nome} - {altura}cm");
            }
            else if (altura2 > altura)
            {
                Console.WriteLine($"O atleta mais alto é o {nome2} - {altura2}cm");
               
            }
            else if (altura == altura2)
            {
                Console.WriteLine("Eles têm a mesma altura" + altura + "m");
            }


        }
    }
}