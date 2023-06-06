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
            dataGridViewClientes = new DataGridView();
            btnCarregarClientes = new Button();
            btnCadastrarCliente = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBoxNomeCliente = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblClienteNome = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(372, 64);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowTemplate.Height = 25;
            dataGridViewClientes.Size = new Size(349, 230);
            dataGridViewClientes.TabIndex = 19;
            // 
            // btnCarregarClientes
            // 
            btnCarregarClientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCarregarClientes.Location = new Point(372, 300);
            btnCarregarClientes.Name = "btnCarregarClientes";
            btnCarregarClientes.Size = new Size(105, 43);
            btnCarregarClientes.TabIndex = 18;
            btnCarregarClientes.Text = "Carregar Clientes";
            btnCarregarClientes.UseVisualStyleBackColor = true;
            btnCarregarClientes.Click += btnCarregarClientes_Click;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadastrarCliente.Location = new Point(483, 300);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(103, 43);
            btnCadastrarCliente.TabIndex = 17;
            btnCadastrarCliente.Text = "Cadastrar";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(66, 90);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 15;
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.Location = new Point(66, 24);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(100, 23);
            textBoxNomeCliente.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(469, 32);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 13;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 12;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 11;
            label2.Text = "label2";
            // 
            // lblClienteNome
            // 
            lblClienteNome.AutoSize = true;
            lblClienteNome.Location = new Point(12, 32);
            lblClienteNome.Name = "lblClienteNome";
            lblClienteNome.Size = new Size(40, 15);
            lblClienteNome.TabIndex = 10;
            lblClienteNome.Text = "Nome";
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewClientes);
            Controls.Add(btnCarregarClientes);
            Controls.Add(btnCadastrarCliente);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBoxNomeCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblClienteNome);
            Name = "FormCliente";
            Text = "FormCliente";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewClientes;
        private Button btnCarregarClientes;
        private Button btnCadastrarCliente;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBoxNomeCliente;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblClienteNome;
    }
}