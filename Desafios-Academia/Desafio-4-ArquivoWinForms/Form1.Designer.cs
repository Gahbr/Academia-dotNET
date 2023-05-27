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
            listBoxArquivo = new ListBox();
            listBoxResult = new ListBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
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
            // listBoxResult
            // 
            listBoxResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 25;
            listBoxResult.Location = new Point(404, 121);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(414, 379);
            listBoxResult.TabIndex = 1;
            listBoxResult.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(404, 77);
            button1.Name = "button1";
            button1.Size = new Size(414, 38);
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
            label2.Location = new Point(22, 79);
            label2.Name = "label2";
            label2.Size = new Size(170, 34);
            label2.TabIndex = 5;
            label2.Text = "Dados brutos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(830, 504);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBoxResult);
            Controls.Add(listBoxArquivo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxArquivo;
        private ListBox listBoxResult;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}