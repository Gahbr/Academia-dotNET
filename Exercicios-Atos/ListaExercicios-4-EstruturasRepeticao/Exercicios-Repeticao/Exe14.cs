//Mostrar as potências de 2 variando de 0 a 10.
namespace Exercicios_Repeticao
{
    internal class Exe14
    {
        public static string Ex14()
        {
            {
                bool loop = true;
                int soma = 0;
                for (int i = 0; i <= 10; i++) Console.WriteLine($"Potencia de 2 elevado a {i} é {Math.Pow(2, i)}");
                return "";
            }
        }
    }
}
