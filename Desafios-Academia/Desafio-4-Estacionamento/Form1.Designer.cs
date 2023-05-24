namespace Desafio_4_Estacionamento
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
            label1 = new Label();
            textBoxPlacaCarro = new TextBox();
            buttonEntrada = new Button();
            button2 = new Button();
            textBoxVeiculosSaida = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBoxVeiculosGaragem = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(280, 88);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 0;
            label1.Text = "Placa do Carro";
            // 
            // textBoxPlacaCarro
            // 
            textBoxPlacaCarro.Location = new Point(256, 112);
            textBoxPlacaCarro.Name = "textBoxPlacaCarro";
            textBoxPlacaCarro.Size = new Size(164, 23);
            textBoxPlacaCarro.TabIndex = 1;
            // 
            // buttonEntrada
            // 
            buttonEntrada.Location = new Point(256, 154);
            buttonEntrada.Name = "buttonEntrada";
            buttonEntrada.Size = new Size(70, 23);
            buttonEntrada.TabIndex = 2;
            buttonEntrada.Text = "Entrada";
            buttonEntrada.UseVisualStyleBackColor = true;
            buttonEntrada.Click += EntradaCarro;
            // 
            // button2
            // 
            button2.Location = new Point(345, 154);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Saída";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SaidaCarro;
            // 
            // textBoxVeiculosSaida
            // 
            textBoxVeiculosSaida.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxVeiculosSaida.Enabled = false;
            textBoxVeiculosSaida.Location = new Point(355, 243);
            textBoxVeiculosSaida.MinimumSize = new Size(100, 100);
            textBoxVeiculosSaida.Multiline = true;
            textBoxVeiculosSaida.Name = "textBoxVeiculosSaida";
            textBoxVeiculosSaida.Size = new Size(298, 310);
            textBoxVeiculosSaida.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 219);
            label2.Name = "label2";
            label2.Size = new Size(213, 21);
            label2.TabIndex = 6;
            label2.Text = "Lista de Veículos na Garagem";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(355, 219);
            label3.Name = "label3";
            label3.Size = new Size(294, 21);
            label3.TabIndex = 7;
            label3.Text = "Lista de Veículos que saíram da Garagem";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(171, 27);
            label4.Name = "label4";
            label4.Size = new Size(370, 37);
            label4.TabIndex = 8;
            label4.Text = "Gestão de estacionamentos";
            // 
            // listBoxVeiculosGaragem
            // 
            listBoxVeiculosGaragem.FormattingEnabled = true;
            listBoxVeiculosGaragem.ItemHeight = 15;
            listBoxVeiculosGaragem.Location = new Point(12, 243);
            listBoxVeiculosGaragem.Name = "listBoxVeiculosGaragem";
            listBoxVeiculosGaragem.Size = new Size(295, 304);
            listBoxVeiculosGaragem.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(701, 582);
            Controls.Add(listBoxVeiculosGaragem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxVeiculosSaida);
            Controls.Add(button2);
            Controls.Add(buttonEntrada);
            Controls.Add(textBoxPlacaCarro);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPlacaCarro;
        private Button button2;
        private Button buttonEntrada;
        private TextBox textBoxVeiculosSaida;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBoxVeiculosGaragem;
    }
}