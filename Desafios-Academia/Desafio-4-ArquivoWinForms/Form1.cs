using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Desafio_4_ArquivoWinForms
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoasList = new();
        List<Aluno> alunosList = new();
        public Form1()
        {
            InitializeComponent();

            string filePath = Path.Combine(Application.StartupPath, "arquivo.txt");
            string line;

            StreamReader reader = new(filePath, Encoding.Latin1);

            while ((line = reader.ReadLine()) != null)
            {
                listBoxArquivo.Items.Add(line);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //visibilidade
            button1.Visible = false;
            dataGridView1.Visible = true;
            labelAlunos.Visible = true;
            labelQtdAlunos.Visible = true;
            labelQtdAlunosValor.Visible = true;
            labelQtdPessoas.Visible = true;
            labelQtdPessoasValor.Visible = true;

            int lineCount = listBoxArquivo.Items.Count;
            int alunosCount = 0;
            int pessoasCount = 0;

            for (int i = 1; i < lineCount; i++)
            {
                string line = listBoxArquivo.Items[i].ToString();
                string[] vectorLine = line.Split("-");
                string previousLine = listBoxArquivo.Items[i - 1].ToString();
                string[] vectorPreviousLine = previousLine.Split("-");
                Pessoa pessoa;
                Aluno aluno;

                if (vectorLine[0] == "Z")
                {
                    pessoasCount++;
                    pessoa = new(vectorLine[1], vectorLine[2], vectorLine[3], vectorLine[4], vectorLine[5]);
                    pessoasList.Add(pessoa);
                }

                if (vectorLine[0] == "Y")
                {
                    alunosCount++;
                    aluno = new(vectorPreviousLine[1], vectorPreviousLine[2], vectorPreviousLine[3], vectorPreviousLine[4], vectorPreviousLine[5], int.Parse(vectorLine[1]), int.Parse(vectorLine[2]), vectorLine[3]);
                    alunosList.Add(aluno);

                    DataGridViewRow row = new DataGridViewRow();

                    DataGridViewTextBoxCell cell1 = new();
                    cell1.Value = aluno.Nome;
                    row.Cells.Add(cell1);

                    DataGridViewTextBoxCell cell2 = new();
                    cell2.Value = aluno.NomeCurso;
                    row.Cells.Add(cell2);
                    dataGridView1.Rows.Add(row);
                }
            }

            //Removendo alunos da lista de pessoas
            List<Pessoa> pessoasToRemove = new List<Pessoa>();

            foreach (var item in pessoasList)
            {
                if (alunosList.Any(aluno => aluno.Cpf == item.Cpf))
                {
                    pessoasToRemove.Add(item);
                    pessoasCount--;
                }
            }

            foreach (var pessoa in pessoasToRemove) pessoasList.Remove(pessoa);

            labelQtdAlunosValor.Text = alunosCount.ToString();
            labelQtdPessoasValor.Text = pessoasCount.ToString();
        }
    }
}