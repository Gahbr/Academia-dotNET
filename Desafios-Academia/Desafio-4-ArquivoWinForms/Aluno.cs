namespace Desafio_4_ArquivoWinForms
{
    internal class Aluno : Pessoa
    {
        public int Matricula { get; set; }
        public int CodigoCurso { get; set; }
        public string NomeCurso { get; set; }

        public Aluno(string nome, string telefone, string cidade, string rg, string cpf, int matricula, int codigoCurso, string nomeCurso) : base(nome, telefone, cidade, rg, cpf)
        {
            this.Matricula = matricula;
            this.CodigoCurso = codigoCurso;
            this.NomeCurso = nomeCurso;
        }
    }
}
