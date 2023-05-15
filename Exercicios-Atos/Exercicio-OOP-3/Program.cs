//Criar uma classe Pessoa que contém as propriedades Nome e Idade. Criar duas classes derivadas, Aluno e Professor, que herdam de Pessoa. A classe Aluno deve ter uma propriedade adicional Matricula, enquanto a classe Professor deve ter uma propriedade adicional Disciplina. Criar um método Apresentar na classe Pessoa que imprime o nome e a idade da pessoa. Em seguida, criar um método Apresentar na classe Aluno que imprime o nome, a idade e a matrícula do aluno, e um método Apresentar na classe Professor que imprime o nome, a idade e a disciplina do professor.
namespace Exercicio_OOP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno { Nome = "alunao", Idade = 12, Matricula = 123145 };
            Professor p = new Professor { Nome = "PROFE", Idade = 58, Disciplina = "MATEMÁTICA" };

            a.Apresentar();
            Console.WriteLine("--------");
            p.Apresentar();
            Console.WriteLine("----------------------------------");

            Carro carro = new Carro { Marca = "Fiat", Modelo = "Uno", QuantidadeDePortas = 2 };
            carro.Dirigir();
        }
    }
}