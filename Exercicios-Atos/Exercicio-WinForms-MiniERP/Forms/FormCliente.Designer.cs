namespace Exercicio_WinForms_MiniERP.Forms
{
    partial class FormCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCarregarClientes = new Button();
            btnCadastrarCliente = new Button();
            label11 = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            label5 = new Label();
            textBoxNomeClienteC = new TextBox();
            label7 = new Label();
            tabPage3 = new TabPage();
            textBoxEditId = new TextBox();
            label12 = new Label();
            label8 = new Label();
            buttonEditar = new Button();
            textBoxEditNome = new TextBox();
            label10 = new Label();
            tabPage4 = new TabPage();
            label13 = new Label();
            buttonDeletar = new Button();
            textBoxID = new TextBox();
            label14 = new Label();
            label15 = new Label();
            dataGridViewClientes = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // btnCarregarClientes
            // 
            btnCarregarClientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCarregarClientes.Location = new Point(429, 264);
            btnCarregarClientes.Name = "btnCarregarClientes";
            btnCarregarClientes.Size = new Size(142, 29);
            btnCarregarClientes.TabIndex = 18;
            btnCarregarClientes.Text = "Carregar Clientes";
            btnCarregarClientes.UseVisualStyleBackColor = true;
            btnCarregarClientes.Click += btnCarregarClientes_Click;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadastrarCliente.Location = new Point(6, 101);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(246, 44);
            btnCadastrarCliente.TabIndex = 17;
            btnCadastrarCliente.Text = "Cadastrar";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(113, 25);
            label11.Name = "label11";
            label11.Size = new Size(64, 25);
            label11.TabIndex = 23;
            label11.Text = "CRUD";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 62);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(280, 196);
            tabControl1.TabIndex = 22;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(textBoxNomeClienteC);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(btnCadastrarCliente);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(272, 168);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastro";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(67, 19);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 9;
            label5.Text = "Cadastro";
            // 
            // textBoxNomeClienteC
            // 
            textBoxNomeClienteC.Location = new Point(67, 57);
            textBoxNomeClienteC.Name = "textBoxNomeClienteC";
            textBoxNomeClienteC.Size = new Size(114, 23);
            textBoxNomeClienteC.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 60);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 7;
            label7.Text = "Nome";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBoxEditId);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(buttonEditar);
            tabPage3.Controls.Add(textBoxEditNome);
            tabPage3.Controls.Add(label10);
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
            textBoxEditId.Location = new Point(38, 65);
            textBoxEditId.Name = "textBoxEditId";
            textBoxEditId.Size = new Size(40, 23);
            textBoxEditId.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 68);
            label12.Name = "label12";
            label12.Size = new Size(18, 15);
            label12.TabIndex = 14;
            label12.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(94, 18);
            label8.Name = "label8";
            label8.Size = new Size(64, 25);
            label8.TabIndex = 9;
            label8.Text = "Editar";
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(14, 107);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(228, 45);
            buttonEditar.TabIndex = 12;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // textBoxEditNome
            // 
            textBoxEditNome.Location = new Point(142, 65);
            textBoxEditNome.Name = "textBoxEditNome";
            textBoxEditNome.Size = new Size(100, 23);
            textBoxEditNome.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(94, 68);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 7;
            label10.Text = "Nome";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(buttonDeletar);
            tabPage4.Controls.Add(textBoxID);
            tabPage4.Controls.Add(label14);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(272, 168);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Deletar";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(82, 19);
            label13.Name = "label13";
            label13.Size = new Size(76, 25);
            label13.TabIndex = 9;
            label13.Text = "Deletar";
            // 
            // buttonDeletar
            // 
            buttonDeletar.Location = new Point(34, 109);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(210, 43);
            buttonDeletar.TabIndex = 12;
            buttonDeletar.Text = "Deletar";
            buttonDeletar.UseVisualStyleBackColor = true;
            buttonDeletar.Click += buttonDeletar_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(58, 64);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(64, 23);
            textBoxID.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(34, 67);
            label14.Name = "label14";
            label14.Size = new Size(18, 15);
            label14.TabIndex = 7;
            label14.Text = "ID";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(443, 25);
            label15.Name = "label15";
            label15.Size = new Size(68, 25);
            label15.TabIndex = 21;
            label15.Text = "Tabela";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(345, 90);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowTemplate.Height = 25;
            dataGridViewClientes.Size = new Size(282, 168);
            dataGridViewClientes.TabIndex = 20;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 450);
            Controls.Add(label11);
            Controls.Add(tabControl1);
            Controls.Add(btnCarregarClientes);
            Controls.Add(label15);
            Controls.Add(dataGridViewClientes);
            Name = "FormCliente";
            Text = "FormCliente";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewClientes;
        private Button btnCarregarClientes;
        private Button btnCadastrarCliente;
        private Label label11;
        private TabControl tabControl1;
        private Button btnFiltrar;
        private Button btnConsultar;
        private TabPage tabPage2;
        private Label label5;
        private TextBox textBoxNomeClienteC;
        private Label label7;
        private TabPage tabPage3;
        private TextBox textBoxEditId;
        private Label label12;
        private Label label8;
        private Button buttonEditar;
        private TextBox textBoxEditNome;
        private Label label10;
        private TabPage tabPage4;
        private Label label13;
        private Button buttonDeletar;
        private TextBox textBoxID;
        private Label label14;
        private Label label15;
        private DataGridView dataGridView1;
    }
}