//10.Ler nome, sexo e idade de 50 pessoas e após imprimir:
//Número de pessoas do sexo masculino.
//Número de pessoas do sexo feminino.
//Número de pessoas com idade inferior a 30 anos.
//Número de pessoas com idade superior a 60 anos.
//Média de idade das mulheres.

namespace Exercicios_Repeticao
{
    internal class Exe10
    {
        public static string Ex10()
        {
            {
                int idadeA = 0;
                int idadeB = 0;
                int homens = 0;
                int mulheres = 0;
                double mediaMulheres = 0;

                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine($"Pessoa {i}, insira seu nome:");
                    string nome = Console.ReadLine();

                    Console.WriteLine($"Pessoa {i}, insira a idade:");
                    int idade = int.Parse(Console.ReadLine());

                    if (idade < 30)
                    {
                        idadeA++;
                    }

                    if (idade > 60)
                    {
                        idadeB++;
                    }

                    Console.WriteLine($"Pessoa {i}, insira seu sexo: M ou F");
                    string sexo = Console.ReadLine();

                    if (sexo.ToUpper() == "M")
                    {
                        homens++;
                    } else if (sexo.ToUpper() == "F")
                    {
                        mediaMulheres += idade;
                        mulheres++;
                    }
                }

                Console.WriteLine($"Número de pessoas do sexo masculino: {homens}.\r\n//Número de pessoas do sexo feminino: {mulheres}\r\n//Número de pessoas com idade inferior a 30 anos: {idadeA} pessoas\r\n//Número de pessoas com idade superior a 60 anos: {idadeB} pessoas\r\nMédia de idade das mulheres: {mediaMulheres / Convert.ToDouble(mulheres)} anos");
                return "";
            }
        }
    }
}
