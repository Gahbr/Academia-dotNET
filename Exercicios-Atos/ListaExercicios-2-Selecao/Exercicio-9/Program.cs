using System.Drawing;
using System.Net;

namespace Exercicio_9
{
    internal class Program
    {
//        Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
//        diária de um paciente diabético.Para cada valor recebido analisar e informar ao paciente o seguinte:
//Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
//        Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
//        Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
//menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina.Se a média for maior que
//150, avisá-lo que será necessário adicionar 2 unidades de insulina.
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro valor:");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro valor:");
            double valor3 = double.Parse(Console.ReadLine());

          if (valor1  < 65)
            {
                Console.WriteLine("Você corre risco de hipoglicemia");
            } else if (valor1 > 250)
            {
                Console.WriteLine("Você  corre risco de hiperglicemia.");
            }

            if (valor2 < 65)
            {
                Console.WriteLine("Você corre risco de hipoglicemia");
            }
            else if (valor2 > 250)
            {
                Console.WriteLine("Você  corre risco de hiperglicemia.");
            }

            if (valor3 < 65)
            {
                Console.WriteLine("Você corre risco de hipoglicemia");
            }
            else if (valor3 > 250)
            {
                Console.WriteLine("Você  corre risco de hiperglicemia.");
            }

            double media = (valor1 + valor2 + valor3) / 3;

            if(media < 80)
            {
                Console.WriteLine("é preciso diminuir 2 unidades de insulina");
            }else if (media > 150)
            {
                Console.WriteLine("Será necessário adicionar 2 unidades de insulina.");
            }
        }
    }
}