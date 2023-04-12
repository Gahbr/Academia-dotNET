//Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa,
//a média aritmética da turma e a quantidade de alunos da turma. Usar -1 para encerrar a leitura.

namespace Exercicios_Repeticao
{
    internal class Exe11
    {
        public static string Ex11()
        {
            {
                bool loop = true;
                double notaAlta = 0;
                double notaBaixa = 0;

                while (loop == true)
                {
                   Console.WriteLine("Insira a nota do aluno:");
                   double nota = double.Parse(Console.ReadLine());

                    if (nota > notaAlta) notaAlta = nota;
                    if (notaBaixa == 0)notaBaixa = nota;
                    if (nota < notaBaixa && nota > 0) notaBaixa = nota;
                    if (nota == -1) loop = false;    
                    if (nota < 0) Console.WriteLine("Insira uma nota válida!");
                }
                Console.WriteLine($"A nota mais alta é : {notaAlta}\nA nota mais baixa é : {notaBaixa}");
                return "";
            }
        }
    }
}
