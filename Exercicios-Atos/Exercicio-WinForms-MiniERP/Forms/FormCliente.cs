using Exercicio_WinForms_MiniERP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
