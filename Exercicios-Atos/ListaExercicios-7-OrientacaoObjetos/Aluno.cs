//2 - Criar uma classe chamada Aluno com 3 construtores, sendo que o primeiro recebe o nome e a matrícula
//do aluno, o segundo recebe apenas a data de nascimento do aluno e o terceiro construtor recebe o nome
//do aluno, a data de nascimento e o ano em que o aluno ingressou na faculdade.
//Crie uma classe principal, com 3 objetos, cada um instanciando a classe com um construtor diferente.

//8 - Crie uma classe chamada Aluno que tenha as propriedades Nome e Matricula. Utilize o encapsulamento para garantir 
//que o nome não seja vazio (utilize função nativa) e que a matrícula seja positiva.

namespace Exercicio_1
{
    internal class Aluno
    {
        private string nome;
        private int matricula;
        private string dataNascimento;
        private DateTime dataIngresso;

        public string Nome { get => nome; set { if (string.IsNullOrEmpty(value)) nome = value; } }
        public int Matricula { get => matricula; set { if (value > 0) matricula = value; } }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public DateTime DataIngresso { get => dataIngresso; set => dataIngresso = value; }

        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }

        public Aluno(DateTime dataIngresso)
        {
            this.dataIngresso = dataIngresso;
        }

        public Aluno(string nome, int matricula, string dataNascimento, DateTime dataIngresso )
        {
            this.nome = nome;
            this.matricula = matricula;
            this.dataNascimento = dataNascimento;
            this.dataIngresso = dataIngresso;
        }
    }
}
