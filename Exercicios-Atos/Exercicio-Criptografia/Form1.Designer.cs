namespace Exercicio_Criptografia
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
            textBoxMensagem = new TextBox();
            label1 = new Label();
            button1 = new Button();
            labelCriptografada = new Label();
            labelTitulo = new Label();
            buttonDescript = new Button();
            labelDescrypt = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // textBoxMensagem
            // 
            textBoxMensagem.Location = new Point(107, 81);
            textBoxMensagem.Name = "textBoxMensagem";
            textBoxMensagem.Size = new Size(100, 23);
            textBoxMensagem.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 85);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Mensagem";
            // 
            // button1
            // 
            button1.Location = new Point(225, 81);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 2;
            button1.Text = "Criptografar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelCriptografada
            // 
            labelCriptografada.AutoSize = true;
            labelCriptografada.Location = new Point(12, 156);
            labelCriptografada.Name = "labelCriptografada";
            labelCriptografada.Size = new Size(80, 15);
            labelCriptografada.TabIndex = 3;
            labelCriptografada.Text = "Criptografada";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(186, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(152, 32);
            labelTitulo.TabIndex = 4;
            labelTitulo.Text = "Criptografia";
            // 
            // buttonDescript
            // 
            buttonDescript.Location = new Point(333, 81);
            buttonDescript.Name = "buttonDescript";
            buttonDescript.Size = new Size(145, 23);
            buttonDescript.TabIndex = 5;
            buttonDescript.Text = "Descriptografar";
            buttonDescript.UseVisualStyleBackColor = true;
            buttonDescript.Click += buttonDescript_Click;
            // 
            // labelDescrypt
            // 
            labelDescrypt.Location = new Point(12, 187);
            labelDescrypt.Name = "labelDescrypt";
            labelDescrypt.Size = new Size(97, 15);
            labelDescrypt.TabIndex = 6;
            labelDescrypt.Text = "Descriptografada";
            // 
            // button2
            // 
            button2.Location = new Point(333, 110);
            button2.Name = "button2";
            button2.Size = new Size(145, 23);
            button2.TabIndex = 7;
            button2.Text = "Descriptografar Arquivo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(298, 156);
            button3.Name = "button3";
            button3.Size = new Size(180, 23);
            button3.TabIndex = 8;
            button3.Text = "Criptografia Assimétrica";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(298, 181);
            button4.Name = "button4";
            button4.Size = new Size(180, 23);
            button4.TabIndex = 9;
            button4.Text = "Descriptografia Assimetrica";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(508, 346);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(labelDescrypt);
            Controls.Add(buttonDescript);
            Controls.Add(labelTitulo);
            Controls.Add(labelCriptografada);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBoxMensagem);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMensagem;
        private Label label1;
        private Button button1;
        private Label labelCriptografada;
        private Label labelTitulo;
        private Button buttonDescript;
        private Label labelDescrypt;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}