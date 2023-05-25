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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBoxPlacaCarro = new TextBox();
            buttonEntrada = new Button();
            button2 = new Button();
            labelListaVeiculosGaragem = new Label();
            label3 = new Label();
            label4 = new Label();
            listBoxVeiculosGaragem = new ListBox();
            listBoxVeiculosSaida = new ListBox();
            labelHoraAtual = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            labelValorPagar = new Label();
            textBoxValorPagar = new TextBox();
            textBoxTempoPermanencia = new TextBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(7, 120);
            label1.Name = "label1";
            label1.Size = new Size(175, 32);
            label1.TabIndex = 0;
            label1.Text = "Placa do Carro";
            // 
            // textBoxPlacaCarro
            // 
            textBoxPlacaCarro.CharacterCasing = CharacterCasing.Upper;
            textBoxPlacaCarro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPlacaCarro.Location = new Point(188, 129);
            textBoxPlacaCarro.MaxLength = 7;
            textBoxPlacaCarro.Name = "textBoxPlacaCarro";
            textBoxPlacaCarro.Size = new Size(164, 35);
            textBoxPlacaCarro.TabIndex = 1;
            // 
            // buttonEntrada
            // 
            buttonEntrada.Location = new Point(358, 130);
            buttonEntrada.Name = "buttonEntrada";
            buttonEntrada.Size = new Size(70, 34);
            buttonEntrada.TabIndex = 2;
            buttonEntrada.Text = "Entrada";
            buttonEntrada.UseVisualStyleBackColor = true;
            buttonEntrada.Click += EntradaCarro;
            // 
            // button2
            // 
            button2.Location = new Point(434, 129);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 3;
            button2.Text = "Saída";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SaidaCarro;
            // 
            // labelListaVeiculosGaragem
            // 
            labelListaVeiculosGaragem.AutoSize = true;
            labelListaVeiculosGaragem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelListaVeiculosGaragem.Location = new Point(12, 201);
            labelListaVeiculosGaragem.Name = "labelListaVeiculosGaragem";
            labelListaVeiculosGaragem.Size = new Size(299, 30);
            labelListaVeiculosGaragem.TabIndex = 6;
            labelListaVeiculosGaragem.Text = "Lista de Veículos na Garagem";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(439, 201);
            label3.Name = "label3";
            label3.Size = new Size(412, 30);
            label3.TabIndex = 7;
            label3.Text = "Lista de Veículos que saíram da Garagem";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(109, 30);
            label4.Name = "label4";
            label4.Size = new Size(673, 65);
            label4.TabIndex = 8;
            label4.Text = "Gestão de estacionamentos";
            // 
            // listBoxVeiculosGaragem
            // 
            listBoxVeiculosGaragem.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxVeiculosGaragem.FormattingEnabled = true;
            listBoxVeiculosGaragem.ItemHeight = 25;
            listBoxVeiculosGaragem.Location = new Point(12, 234);
            listBoxVeiculosGaragem.Name = "listBoxVeiculosGaragem";
            listBoxVeiculosGaragem.Size = new Size(288, 229);
            listBoxVeiculosGaragem.TabIndex = 9;
            // 
            // listBoxVeiculosSaida
            // 
            listBoxVeiculosSaida.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxVeiculosSaida.FormattingEnabled = true;
            listBoxVeiculosSaida.HorizontalScrollbar = true;
            listBoxVeiculosSaida.ItemHeight = 25;
            listBoxVeiculosSaida.Location = new Point(439, 234);
            listBoxVeiculosSaida.Name = "listBoxVeiculosSaida";
            listBoxVeiculosSaida.Size = new Size(363, 129);
            listBoxVeiculosSaida.TabIndex = 10;
            // 
            // labelHoraAtual
            // 
            labelHoraAtual.AutoSize = true;
            labelHoraAtual.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelHoraAtual.Location = new Point(52, 507);
            labelHoraAtual.Name = "labelHoraAtual";
            labelHoraAtual.Size = new Size(51, 25);
            labelHoraAtual.TabIndex = 11;
            labelHoraAtual.Text = "hora";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 507);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // labelValorPagar
            // 
            labelValorPagar.AutoSize = true;
            labelValorPagar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelValorPagar.Location = new Point(499, 385);
            labelValorPagar.Name = "labelValorPagar";
            labelValorPagar.Size = new Size(172, 32);
            labelValorPagar.TabIndex = 13;
            labelValorPagar.Text = "Valor a pagar:";
            // 
            // textBoxValorPagar
            // 
            textBoxValorPagar.CharacterCasing = CharacterCasing.Upper;
            textBoxValorPagar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxValorPagar.Location = new Point(677, 385);
            textBoxValorPagar.MaxLength = 7;
            textBoxValorPagar.Name = "textBoxValorPagar";
            textBoxValorPagar.Size = new Size(126, 35);
            textBoxValorPagar.TabIndex = 14;
            // 
            // textBoxTempoPermanencia
            // 
            textBoxTempoPermanencia.CharacterCasing = CharacterCasing.Upper;
            textBoxTempoPermanencia.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTempoPermanencia.Location = new Point(677, 428);
            textBoxTempoPermanencia.MaxLength = 7;
            textBoxTempoPermanencia.Name = "textBoxTempoPermanencia";
            textBoxTempoPermanencia.Size = new Size(126, 35);
            textBoxTempoPermanencia.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(396, 431);
            label5.Name = "label5";
            label5.Size = new Size(275, 32);
            label5.TabIndex = 15;
            label5.Text = "Tempo de permanência:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(772, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 16);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(91, 79);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(907, 582);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(textBoxTempoPermanencia);
            Controls.Add(label5);
            Controls.Add(textBoxValorPagar);
            Controls.Add(labelValorPagar);
            Controls.Add(pictureBox1);
            Controls.Add(labelHoraAtual);
            Controls.Add(listBoxVeiculosSaida);
            Controls.Add(listBoxVeiculosGaragem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelListaVeiculosGaragem);
            Controls.Add(button2);
            Controls.Add(buttonEntrada);
            Controls.Add(textBoxPlacaCarro);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPlacaCarro;
        private Button button2;
        private Button buttonEntrada;
        private Label labelListaVeiculosGaragem;
        private Label label3;
        private Label label4;
        private ListBox listBoxVeiculosGaragem;
        private ListBox listBoxVeiculosSaida;
        private Label labelHoraAtual;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label labelValorPagar;
        private TextBox textBoxValorPagar;
        private TextBox textBoxTempoPermanencia;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}