using Exercicio_WinForms_MiniERP.Model;
using System.Data;

namespace Exercicio_WinForms_MiniERP.Forms
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void btnCarregarClientes_Click(object sender, EventArgs e)
        {
            Database bd = new();
            string sql = "SELECT * FROM CLIENTES;";
            DataTable dt = new();
            dt = bd.ExecutarConsultaGenerica(sql);
            dataGridViewClientes.DataSource = dt;
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(textBoxNomeClienteC.Text);

            if (c.GravarCliente())
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar usuário");
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Cliente c = new(int.Parse(textBoxEditId.Text), textBoxEditNome.Text);

            if (c.EditarCliente(c.ID, c.Nome))
            {
                MessageBox.Show("Editado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao Editar usuário");
            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            var id = int.Parse(textBoxID.Text);
            Cliente c = new();

            if (c.DeletarPessoa(id))
            {
                MessageBox.Show("Deletado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao Deletar usuário");
            }
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control buttons in Controls)
            {
                if (buttons.GetType() == typeof(Button))
                {
                    Button btn = (Button)buttons;
                    btnCadastrarCliente.BackColor= ThemeColor.PrimaryColor;

                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    //label4.ForeColor = ThemeColor.SecondaryColor;
                }
            }
        }
    }
}

