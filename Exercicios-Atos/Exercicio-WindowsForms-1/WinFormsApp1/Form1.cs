using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            String linha;
            String[] vetorDados;
            string filePath = "pessoas.dat";
            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Length == 0)
            {
                StreamWriter escritor = new("pessoas.dat", true);
                escritor.WriteLine("Pessoa" + ";" + "Teste" + ";" + "teste@teste.com");
                escritor.Close();
            }

            StreamReader leitor = new StreamReader("pessoas.dat");
            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(";");
                listaPessoas.Add(new Pessoa(vetorDados[0], vetorDados[1], vetorDados[2]));
                textBoxListaEmails.AppendText(vetorDados[0].ToUpper() + " - " + vetorDados[1].ToUpper() + " - " + vetorDados[2] + Environment.NewLine);
                //textBoxListaEmails.AppendText($"Nome: {vetorDados[0]} - Sobrenome: {vetorDados[1]} - E-mail: {vetorDados[2]} {Environment.NewLine}");
            } while (!leitor.EndOfStream);

            leitor.Close();
        }

        //private void buttonGerarEmail_Click(object sender, EventArgs e)
        //{
        //    string[] vetorSobrenome = textBoxSobrenome.Text.Split(' ');
        //    string[] vetorNome = textBoxNome.Text.Split(' ');

        //    if (textBoxNome.Text.Length <= 0 || textBoxSobrenome.Text.Length <= 0) MessageBox.Show("Insira os dados corretamente!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    else
        //    {
        //        textBoxEmail.Text = textBoxSobrenome.Text.ToLower() + "_" + textBoxNome.Text.ToLower() + "@ufn.edu.br";
        //        textBoxListaEmails.AppendText(textBoxEmail.Text + Environment.NewLine);
        //        textBoxNome.Text = string.Empty;
        //        textBoxSobrenome.Text = string.Empty;
        //    }
        //}

        private void buttonGerarEmail_Click2(object sender, EventArgs e)
        {
            string[] vetorSobrenome = textBoxSobrenome.Text.Split(' ');
            string[] vetorNome = textBoxNome.Text.Split(' ');

            if (textBoxNome.Text.Length <= 0 || textBoxSobrenome.Text.Length <= 0) MessageBox.Show("Insira os dados corretamente!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                string email = vetorSobrenome[0].ToLower() + "_" + vetorNome[0].ToLower() + "@ufn.edu.br";
                textBoxEmail.Text = email;

                if (Pessoa.JaCadastrado(email, listaPessoas)) MessageBox.Show("Pessoa já cadastrada.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else listaPessoas.Add(new Pessoa(vetorNome[0], vetorSobrenome[0], email));

                textBoxListaEmails.AppendText(textBoxNome.Text.ToUpper() + " - " + textBoxSobrenome.Text.ToUpper() + " - " + textBoxEmail.Text + Environment.NewLine);

                //salvando no arquivo
                StreamWriter escritor = new StreamWriter("pessoas.dat", true);
                escritor.WriteLine(textBoxNome.Text + ";" + textBoxSobrenome.Text + ";" + email);
                escritor.Close();

                textBoxNome.Text = string.Empty;
                textBoxSobrenome.Text = string.Empty;
            }
        }

        List<Pessoa> listaPessoas = new List<Pessoa>();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxListaEmails_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonLimparLista(object sender, EventArgs e)
        {
            listaPessoas.Clear();
            textBoxListaEmails.Clear();
            StreamWriter escritor = new("pessoas.dat", false);
            escritor.Close();
        }
    }
}