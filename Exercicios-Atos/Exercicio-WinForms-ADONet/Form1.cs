using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WF_ADONet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            string sql = "SELECT * FROM PESSOAS;";
            DataTable dt = new DataTable();
            dt = bd.ExecutarConsultaGenerica(sql);
            dataGridView1.DataSource = dt;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            string sql = "select * from PESSOAS where nome = '" + textBoxNome.Text + "'";
            DataTable dt = new DataTable();
            dt = bd.ExecutarConsultaGenerica(sql);
            dataGridView1.DataSource = dt;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = textBoxNewNome.Text;
            p.profissao = textBoxNewProfissao.Text;

            if (p.GravarPessoa())
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
            Pessoa p = new Pessoa();
            p.id = int.Parse(textBoxEditId.Text);
            p.nome = textBoxEditNome.Text;
            p.profissao = textBoxEditProf.Text;

            if (p.EditarPessoa(p.nome, p.profissao, p.id))
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
            Pessoa p = new Pessoa();

            if (p.DeletarPessoa(int.Parse(textBoxID.Text)))
            {
                MessageBox.Show("Usuário deletado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao deletar usuário");
            }
        }
    }
}