//Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados,
//ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
//Ao final, mostre a idade digitada.

namespace Exercicios_Repeticao
{
    internal class Ex6
    {
        public static string Ex06()
        {
            bool loop = true;
            int number;
            while (loop == true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    Console.WriteLine($"A idade é: {input} anos");
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Insira uma idade válida.");
                }
            }
            return "";
        }
    }
}
