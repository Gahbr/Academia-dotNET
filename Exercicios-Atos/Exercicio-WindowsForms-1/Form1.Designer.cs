namespace WinFormsApp1
{
    partial class FormPrincipal
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
            labelNomeJogador = new Label();
            textBoxNome = new TextBox();
            buttonGerarEmail = new Button();
            label1 = new Label();
            textBoxSobrenome = new TextBox();
            textBoxEmail = new TextBox();
            label2 = new Label();
            textBoxListaEmails = new TextBox();
            LabelListaPessoasCadastradas = new Label();
            LimparLista = new Button();
            SuspendLayout();
            // 
            // labelNomeJogador
            // 
            labelNomeJogador.AutoSize = true;
            labelNomeJogador.Location = new Point(12, 9);
            labelNomeJogador.Name = "labelNomeJogador";
            labelNomeJogador.Size = new Size(40, 15);
            labelNomeJogador.TabIndex = 0;
            labelNomeJogador.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 29);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(193, 23);
            textBoxNome.TabIndex = 1;
            // 
            // buttonGerarEmail
            // 
            buttonGerarEmail.BackColor = SystemColors.ButtonShadow;
            buttonGerarEmail.Cursor = Cursors.Hand;
            buttonGerarEmail.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            buttonGerarEmail.FlatStyle = FlatStyle.Flat;
            buttonGerarEmail.Location = new Point(12, 169);
            buttonGerarEmail.Name = "buttonGerarEmail";
            buttonGerarEmail.Size = new Size(193, 23);
            buttonGerarEmail.TabIndex = 2;
            buttonGerarEmail.Text = "Gerar Email";
            buttonGerarEmail.UseVisualStyleBackColor = false;
            buttonGerarEmail.Click += buttonGerarEmail_Click2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 3;
            label1.Text = "Sobrenome";
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Location = new Point(12, 73);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(193, 23);
            textBoxSobrenome.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 126);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(193, 23);
            textBoxEmail.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // textBoxListaEmails
            // 
            textBoxListaEmails.Cursor = Cursors.IBeam;
            textBoxListaEmails.Location = new Point(225, 29);
            textBoxListaEmails.Margin = new Padding(0);
            textBoxListaEmails.MaximumSize = new Size(500, 500);
            textBoxListaEmails.Multiline = true;
            textBoxListaEmails.Name = "textBoxListaEmails";
            textBoxListaEmails.ReadOnly = true;
            textBoxListaEmails.ScrollBars = ScrollBars.Both;
            textBoxListaEmails.Size = new Size(342, 163);
            textBoxListaEmails.TabIndex = 7;
            textBoxListaEmails.WordWrap = false;
            textBoxListaEmails.TextChanged += textBoxListaEmails_TextChanged;
            // 
            // LabelListaPessoasCadastradas
            // 
            LabelListaPessoasCadastradas.AutoSize = true;
            LabelListaPessoasCadastradas.Location = new Point(337, 11);
            LabelListaPessoasCadastradas.Name = "LabelListaPessoasCadastradas";
            LabelListaPessoasCadastradas.Size = new Size(158, 15);
            LabelListaPessoasCadastradas.TabIndex = 8;
            LabelListaPessoasCadastradas.Text = "Lista de Pessoas Cadastradas";
            LabelListaPessoasCadastradas.Click += label3_Click;
            // 
            // LimparLista
            // 
            LimparLista.BackColor = SystemColors.Control;
            LimparLista.Location = new Point(12, 198);
            LimparLista.Name = "LimparLista";
            LimparLista.Size = new Size(193, 23);
            LimparLista.TabIndex = 9;
            LimparLista.Text = "Limpar Lista";
            LimparLista.UseVisualStyleBackColor = false;
            LimparLista.Click += ButtonLimparLista;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 234);
            Controls.Add(LimparLista);
            Controls.Add(LabelListaPessoasCadastradas);
            Controls.Add(textBoxListaEmails);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(textBoxSobrenome);
            Controls.Add(label1);
            Controls.Add(buttonGerarEmail);
            Controls.Add(textBoxNome);
            Controls.Add(labelNomeJogador);
            Name = "FormPrincipal";
            Text = "Título";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNomeJogador;
        private TextBox textBoxNome;
        private Button buttonGerarEmail;
        private Label label1;
        private TextBox textBoxSobrenome;
        private TextBox textBoxEmail;
        private Label label2;
        private TextBox textBoxListaEmails;
        private Label LabelListaPessoasCadastradas;
        private Button LimparLista;
    }
}