namespace WF_ADONet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNome = new TextBox();
            btnFiltrar = new Button();
            btnConsultar = new Button();
            dataGridView1 = new DataGridView();
            textBoxNewNome = new TextBox();
            textBoxNewProfissao = new TextBox();
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonEditar = new Button();
            label6 = new Label();
            textBoxEditNome = new TextBox();
            textBoxEditProf = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            textBoxID = new TextBox();
            buttonDeletar = new Button();
            label9 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            textBoxEditId = new TextBox();
            label12 = new Label();
            tabPage4 = new TabPage();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(6, 31);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(142, 23);
            textBoxNome.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(6, 60);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 1;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(86, 60);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(314, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(349, 168);
            dataGridView1.TabIndex = 3;
            // 
            // textBoxNewNome
            // 
            textBoxNewNome.Location = new Point(16, 57);
            textBoxNewNome.Name = "textBoxNewNome";
            textBoxNewNome.Size = new Size(100, 23);
            textBoxNewNome.TabIndex = 4;
            // 
            // textBoxNewProfissao
            // 
            textBoxNewProfissao.Location = new Point(16, 101);
            textBoxNewProfissao.Name = "textBoxNewProfissao";
            textBoxNewProfissao.Size = new Size(100, 23);
            textBoxNewProfissao.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(16, 132);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 23);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 39);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 83);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 8;
            label2.Text = "Profissao";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 3);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 9;
            label3.Text = "Cadastro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 10;
            label4.Text = "Consulta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(454, 21);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 11;
            label5.Text = "Tabela";
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(144, 100);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(100, 23);
            buttonEditar.TabIndex = 12;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 3);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 9;
            label6.Text = "Editar";
            // 
            // textBoxEditNome
            // 
            textBoxEditNome.Location = new Point(144, 46);
            textBoxEditNome.Name = "textBoxEditNome";
            textBoxEditNome.Size = new Size(100, 23);
            textBoxEditNome.TabIndex = 4;
            // 
            // textBoxEditProf
            // 
            textBoxEditProf.Location = new Point(16, 101);
            textBoxEditProf.Name = "textBoxEditProf";
            textBoxEditProf.Size = new Size(100, 23);
            textBoxEditProf.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(144, 28);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 7;
            label7.Text = "Nome";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 83);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 8;
            label8.Text = "Profissao";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 39);
            label10.Name = "label10";
            label10.Size = new Size(18, 15);
            label10.TabIndex = 7;
            label10.Text = "ID";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(16, 57);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 4;
            // 
            // buttonDeletar
            // 
            buttonDeletar.Location = new Point(16, 86);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(100, 23);
            buttonDeletar.TabIndex = 12;
            buttonDeletar.Text = "Deletar";
            buttonDeletar.UseVisualStyleBackColor = true;
            buttonDeletar.Click += buttonDeletar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(6, 3);
            label9.Name = "label9";
            label9.Size = new Size(76, 25);
            label9.TabIndex = 9;
            label9.Text = "Deletar";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(280, 196);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBoxNome);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(btnFiltrar);
            tabPage1.Controls.Add(btnConsultar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(272, 168);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Consulta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(textBoxNewNome);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBoxNewProfissao);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(btnCadastrar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(272, 168);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastro";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBoxEditId);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(buttonEditar);
            tabPage3.Controls.Add(textBoxEditProf);
            tabPage3.Controls.Add(textBoxEditNome);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(272, 168);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Editar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxEditId
            // 
            textBoxEditId.Location = new Point(16, 46);
            textBoxEditId.Name = "textBoxEditId";
            textBoxEditId.Size = new Size(100, 23);
            textBoxEditId.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 28);
            label12.Name = "label12";
            label12.Size = new Size(18, 15);
            label12.TabIndex = 14;
            label12.Text = "ID";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(buttonDeletar);
            tabPage4.Controls.Add(textBoxID);
            tabPage4.Controls.Add(label10);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(272, 168);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Deletar";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(110, 21);
            label11.Name = "label11";
            label11.Size = new Size(64, 25);
            label11.TabIndex = 19;
            label11.Text = "CRUD";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 292);
            Controls.Add(label11);
            Controls.Add(tabControl1);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private Button btnFiltrar;
        private Button btnConsultar;
        private DataGridView dataGridView1;
        private TextBox textBoxNewNome;
        private TextBox textBoxNewProfissao;
        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonEditar;
        private Label label6;
        private TextBox textBoxEditNome;
        private TextBox textBoxEditProf;
        private Label label7;
        private Label label8;
        private Label label10;
        private TextBox textBoxID;
        private Button buttonDeletar;
        private Label label9;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label11;
        private TextBox textBoxEditId;
        private Label label12;
    }
}