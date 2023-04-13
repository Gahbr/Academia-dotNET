//20.Foi realizada uma pesquisa de algumas características físicas da população de uma 
//certa região, a qual coletou os seguintes dados referentes a cada habitante para 
//serem analisados:
//-sexo(masculino e feminino)
//- cor dos olhos(azuis, verdes ou castanhos)
//-cor dos cabelos(louros, castanhos, pretos)
//-idade

//Faça um algoritmo que determine e escreva: 

//-a maior idade dos habitantes
//- a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
//e que tenham olhos verdes e cabelos louros.
//O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.
namespace Exercicios_Repeticao
{
    internal class Exe20
    {
        public static void Ex20()
        {
            bool loop = true;
            List<int> idades = new List<int>();
            int grupoMulheres = 0;

            for (int i = 1; loop==true; i++)
            {   
                Console.WriteLine($"Insira o sexo da pessoa {i}: M ou F");
                char sexo = char.Parse( Console.ReadLine() );

                Console.WriteLine($"Escolha a opção da cor dos olhos da pessoa {i}: 1 - Azuis, 2 - verdes ou 3 - castanhos");
                int olhos = int.Parse(Console.ReadLine());

                Console.WriteLine($"Escolha a opção da cor do cabelo da pessoa {i}: 1 - louro, 2 - castanho ou 3 - preto");
                int cabelo = int.Parse(Console.ReadLine());

                Console.WriteLine($"Insira a idade da pessoa {i}: ");
                int idade = int.Parse(Console.ReadLine());

                if(idade == -1)
                {
                    loop = false;
                    break;
                }

                if ((sexo == 'f' || sexo == 'F') && idade >= 18 && idade < 36 && olhos == 2 && cabelo == 1) grupoMulheres++;

                idades.Add(idade);
               
                
            }
            Console.WriteLine($"o habitante mais velho tem {idades.Max()} anos");
            Console.WriteLine("a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive\r\n//e que tenham olhos verdes e cabelos louros. é de :" + grupoMulheres + " mulheres");

        }
    }
}