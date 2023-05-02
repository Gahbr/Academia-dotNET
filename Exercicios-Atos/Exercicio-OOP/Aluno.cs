
namespace Exercicio_OOP
{
    internal class Aluno
    {
        public string nome,dataNascimento;
        public int matricula, ingressoFaculdade;

    public Aluno(string nome, int matricula)
    {
        this.nome = nome;
        this.matricula = matricula;
    }

    public Aluno(string dataNascimento)
    {
        this.dataNascimento = dataNascimento;
    }
    public Aluno(string nome, string dataNascimento, int ingressoFaculdade)
    {
        this.nome = nome;
        this.dataNascimento = dataNascimento;
        this.ingressoFaculdade = ingressoFaculdade;
        }


        public void exibeDados()
    {
        Console.WriteLine($"Nome: {this.nome}");
        Console.WriteLine($"dataNascimento: {this.dataNascimento}");
        Console.WriteLine($"matricula: {this.matricula}");
        Console.WriteLine($"ingressoFaculdade: {this.ingressoFaculdade}");
        }

   
}
}
