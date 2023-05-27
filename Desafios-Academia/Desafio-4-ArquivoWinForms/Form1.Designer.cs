namespace Desafio_4_ArquivoWinForms
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            listBoxArquivo = new ListBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Curso = new DataGridViewTextBoxColumn();
            labelAlunos = new Label();
            labelQtdAlunos = new Label();
            labelQtdPessoas = new Label();
            labelQtdAlunosValor = new Label();
            labelQtdPessoasValor = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBoxArquivo
            // 
            listBoxArquivo.BackColor = SystemColors.MenuBar;
            listBoxArquivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxArquivo.FormattingEnabled = true;
            listBoxArquivo.HorizontalScrollbar = true;
            listBoxArquivo.ItemHeight = 21;
            listBoxArquivo.Location = new Point(22, 121);
            listBoxArquivo.Name = "listBoxArquivo";
            listBoxArquivo.Size = new Size(317, 298);
            listBoxArquivo.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(22, 425);
            button1.Name = "button1";
            button1.Size = new Size(317, 38);
            button1.TabIndex = 2;
            button1.Text = "Processar Dados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(206, 9);
            label1.Name = "label1";
            label1.Size = new Size(420, 42);
            label1.TabIndex = 4;
            label1.Text = "Tratamento de Dados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(88, 84);
            label2.Name = "label2";
            label2.Size = new Size(170, 34);
            label2.TabIndex = 5;
            label2.Text = "Dados brutos";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Curso });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(404, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.Size = new Size(414, 160);
            dataGridView1.TabIndex = 6;
            dataGridView1.Visible = false;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Resizable = DataGridViewTriState.False;
            // 
            // Curso
            // 
            Curso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Curso.HeaderText = "Curso";
            Curso.Name = "Curso";
            Curso.ReadOnly = true;
            Curso.Resizable = DataGridViewTriState.False;
            // 
            // labelAlunos
            // 
            labelAlunos.AutoSize = true;
            labelAlunos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelAlunos.Location = new Point(543, 84);
            labelAlunos.Name = "labelAlunos";
            labelAlunos.Size = new Size(94, 32);
            labelAlunos.TabIndex = 7;
            labelAlunos.Text = "Alunos";
            labelAlunos.Visible = false;
            // 
            // labelQtdAlunos
            // 
            labelQtdAlunos.AutoSize = true;
            labelQtdAlunos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelQtdAlunos.Location = new Point(400, 302);
            labelQtdAlunos.Name = "labelQtdAlunos";
            labelQtdAlunos.Size = new Size(226, 30);
            labelQtdAlunos.TabIndex = 8;
            labelQtdAlunos.Text = "Quantidade de Alunos:";
            labelQtdAlunos.Visible = false;
            // 
            // labelQtdPessoas
            // 
            labelQtdPessoas.AutoSize = true;
            labelQtdPessoas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelQtdPessoas.Location = new Point(400, 332);
            labelQtdPessoas.Name = "labelQtdPessoas";
            labelQtdPessoas.Size = new Size(234, 30);
            labelQtdPessoas.TabIndex = 9;
            labelQtdPessoas.Text = "Quantidade de Pessoas:";
            labelQtdPessoas.Visible = false;
            // 
            // labelQtdAlunosValor
            // 
            labelQtdAlunosValor.AutoSize = true;
            labelQtdAlunosValor.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelQtdAlunosValor.Location = new Point(632, 302);
            labelQtdAlunosValor.Name = "labelQtdAlunosValor";
            labelQtdAlunosValor.Size = new Size(72, 30);
            labelQtdAlunosValor.TabIndex = 10;
            labelQtdAlunosValor.Text = "label5";
            labelQtdAlunosValor.Visible = false;
            // 
            // labelQtdPessoasValor
            // 
            labelQtdPessoasValor.AutoSize = true;
            labelQtdPessoasValor.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelQtdPessoasValor.Location = new Point(632, 332);
            labelQtdPessoasValor.Name = "labelQtdPessoasValor";
            labelQtdPessoasValor.Size = new Size(72, 30);
            labelQtdPessoasValor.TabIndex = 11;
            labelQtdPessoasValor.Text = "label3";
            labelQtdPessoasValor.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(830, 471);
            Controls.Add(labelQtdPessoasValor);
            Controls.Add(labelQtdAlunosValor);
            Controls.Add(labelQtdPessoas);
            Controls.Add(labelQtdAlunos);
            Controls.Add(labelAlunos);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBoxArquivo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxArquivo;
        private Button button1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label labelAlunos;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Curso;
        private Label labelQtdAlunos;
        private Label labelQtdPessoas;
        private Label labelQtdAlunosValor;
        private Label labelQtdPessoasValor;
    }
}