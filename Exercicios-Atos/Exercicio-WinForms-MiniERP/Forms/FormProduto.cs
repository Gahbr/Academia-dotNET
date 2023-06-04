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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
          
        }
        private void FormProduto_Load(object sender, EventArgs e)
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
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                    label4.ForeColor = ThemeColor.SecondaryColor;
                }
            }
        }

    
    }
}
