
namespace Exercicio_OOP_2
{
    internal class Paciente
    {
        private string email;
        private string nome;
        private string cpf;
        private string dataNascimento;

        public Paciente(string nome, string cpf, string email, string dataNascimento)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.DataNascimento = dataNascimento;

        }

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Email { get => email; set => email = value; }
    }
}
