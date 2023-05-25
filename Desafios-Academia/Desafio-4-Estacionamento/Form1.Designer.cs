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
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // textBoxPlacaCarro
            // 
            resources.ApplyResources(textBoxPlacaCarro, "textBoxPlacaCarro");
            textBoxPlacaCarro.CharacterCasing = CharacterCasing.Upper;
            textBoxPlacaCarro.Name = "textBoxPlacaCarro";
            // 
            // buttonEntrada
            // 
            resources.ApplyResources(buttonEntrada, "buttonEntrada");
            buttonEntrada.Name = "buttonEntrada";
            buttonEntrada.UseVisualStyleBackColor = true;
            buttonEntrada.Click += EntradaCarro;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SaidaCarro;
            // 
            // labelListaVeiculosGaragem
            // 
            resources.ApplyResources(labelListaVeiculosGaragem, "labelListaVeiculosGaragem");
            labelListaVeiculosGaragem.Name = "labelListaVeiculosGaragem";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // listBoxVeiculosGaragem
            // 
            resources.ApplyResources(listBoxVeiculosGaragem, "listBoxVeiculosGaragem");
            listBoxVeiculosGaragem.FormattingEnabled = true;
            listBoxVeiculosGaragem.Name = "listBoxVeiculosGaragem";
            // 
            // listBoxVeiculosSaida
            // 
            resources.ApplyResources(listBoxVeiculosSaida, "listBoxVeiculosSaida");
            listBoxVeiculosSaida.FormattingEnabled = true;
            listBoxVeiculosSaida.Name = "listBoxVeiculosSaida";
            // 
            // labelHoraAtual
            // 
            resources.ApplyResources(labelHoraAtual, "labelHoraAtual");
            labelHoraAtual.Name = "labelHoraAtual";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // labelValorPagar
            // 
            resources.ApplyResources(labelValorPagar, "labelValorPagar");
            labelValorPagar.Name = "labelValorPagar";
            // 
            // textBoxValorPagar
            // 
            resources.ApplyResources(textBoxValorPagar, "textBoxValorPagar");
            textBoxValorPagar.CharacterCasing = CharacterCasing.Upper;
            textBoxValorPagar.Name = "textBoxValorPagar";
            // 
            // textBoxTempoPermanencia
            // 
            resources.ApplyResources(textBoxTempoPermanencia, "textBoxTempoPermanencia");
            textBoxTempoPermanencia.CharacterCasing = CharacterCasing.Upper;
            textBoxTempoPermanencia.Name = "textBoxTempoPermanencia";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
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