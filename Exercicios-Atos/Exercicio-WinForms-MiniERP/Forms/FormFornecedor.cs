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
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void btnCarregarFornecedores_Click(object sender, EventArgs e)
        {

            Database bd = new();
            string sql = "SELECT * FROM FORNECEDORES;";
            DataTable dt = new();
            dt = bd.ExecutarConsultaGenerica(sql);
             dgvFornecedor.DataSource = dt;


        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {

        }
    }
}
