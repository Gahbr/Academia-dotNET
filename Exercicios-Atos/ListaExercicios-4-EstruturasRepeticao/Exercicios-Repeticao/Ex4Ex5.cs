//4.Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
//Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
//Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
//Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
//escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
//de votos em branco. 

//5.Modifique o programa em VS anterior para aceitar votos nulos 
//(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
//Ao final, informe o nome do candidato vencedor, o número de votos nulos 
//e o número de pessoas que votaram.

namespace Exercicios_Repeticao
{
    internal class Ex4Ex5
    {
        public static string Ex0405()
        {
            bool loop = true;
            int votosJoao = 0;
            int votosZeca = 0;
            int votosBranco = 0;
            int votosNulos = 0;
            Console.WriteLine("Candidatos: JOAO | ZECA");
            Console.WriteLine("Digite BRANCO para votar em branco e FIM para finalizar o programa.");
           
            while (loop == true)
            {
                Console.WriteLine("Insira o nome do seu candidato para votar");
                string input = Console.ReadLine();

                
                if (input.ToUpper() == "JOAO")
                {
                    votosJoao++;
                } else if (input.ToUpper() == "ZECA")
                {
                    votosZeca++;
                }else if (input.ToUpper() == "BRANCO")
                {
                    votosBranco++;
                }else if (input.ToUpper() == "FIM")
                {
                    Console.WriteLine($"Candidatos\nJoão: {votosJoao} votos\nZeca: {votosZeca} votos\nVotos em Branco: {votosBranco} votos\nVotos Nulos: {votosNulos} votos anulados\nTotal de Votos: {votosBranco+votosJoao+votosNulos+votosZeca}");
                    break;
                }else
                {
                    votosNulos++;
                }
            }
            return "";
        }
    }
}
