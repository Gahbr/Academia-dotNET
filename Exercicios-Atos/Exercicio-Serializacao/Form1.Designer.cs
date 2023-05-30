namespace Exercicio_Serializacao
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            txbSalario = new TextBox();
            txbIdade = new TextBox();
            txbNome = new TextBox();
            panel1 = new Panel();
            labelNome = new Label();
            labelIdade = new Label();
            labelSalario = new Label();
            buttonDess = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button5 = new Button();
            panel3 = new Panel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            buttonDJSON = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            buttonSJSON = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(3, 50);
            button1.Name = "button1";
            button1.Size = new Size(160, 50);
            button1.TabIndex = 0;
            button1.Text = "Serializar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(364, 50);
            button2.Name = "button2";
            button2.Size = new Size(167, 50);
            button2.TabIndex = 1;
            button2.Text = "Desserializar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(163, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 50);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(215, 153);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(117, 37);
            label2.Name = "label2";
            label2.Size = new Size(318, 55);
            label2.TabIndex = 4;
            label2.Text = "Serialização";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(55, 139);
            button3.Name = "button3";
            button3.Size = new Size(184, 49);
            button3.TabIndex = 5;
            button3.Text = "Serializar em XML";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txbSalario
            // 
            txbSalario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbSalario.Location = new Point(161, 88);
            txbSalario.Name = "txbSalario";
            txbSalario.Size = new Size(146, 33);
            txbSalario.TabIndex = 6;
            // 
            // txbIdade
            // 
            txbIdade.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbIdade.Location = new Point(161, 49);
            txbIdade.Name = "txbIdade";
            txbIdade.Size = new Size(146, 33);
            txbIdade.TabIndex = 7;
            // 
            // txbNome
            // 
            txbNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbNome.Location = new Point(161, 8);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(146, 33);
            txbNome.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelNome);
            panel1.Controls.Add(labelIdade);
            panel1.Controls.Add(labelSalario);
            panel1.Controls.Add(buttonDess);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbNome);
            panel1.Controls.Add(txbSalario);
            panel1.Controls.Add(txbIdade);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(7, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(552, 215);
            panel1.TabIndex = 9;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(341, 19);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(52, 21);
            labelNome.TabIndex = 15;
            labelNome.Text = "label8";
            // 
            // labelIdade
            // 
            labelIdade.AutoSize = true;
            labelIdade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdade.Location = new Point(341, 60);
            labelIdade.Name = "labelIdade";
            labelIdade.Size = new Size(52, 21);
            labelIdade.TabIndex = 14;
            labelIdade.Text = "label7";
            // 
            // labelSalario
            // 
            labelSalario.AutoSize = true;
            labelSalario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSalario.Location = new Point(341, 99);
            labelSalario.Name = "labelSalario";
            labelSalario.Size = new Size(52, 21);
            labelSalario.TabIndex = 13;
            labelSalario.Text = "label6";
            // 
            // buttonDess
            // 
            buttonDess.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDess.Location = new Point(264, 139);
            buttonDess.Name = "buttonDess";
            buttonDess.Size = new Size(164, 49);
            buttonDess.TabIndex = 12;
            buttonDess.Text = "Desserializar";
            buttonDess.UseVisualStyleBackColor = true;
            buttonDess.Click += buttonDess_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(55, 85);
            label5.Name = "label5";
            label5.Size = new Size(85, 32);
            label5.TabIndex = 11;
            label5.Text = "Salário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 50);
            label4.Name = "label4";
            label4.Size = new Size(73, 32);
            label4.TabIndex = 10;
            label4.Text = "Idade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 8);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 9;
            label3.Text = "Nome";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 214);
            panel2.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(188, 599);
            button4.Name = "button4";
            button4.Size = new Size(177, 46);
            button4.TabIndex = 10;
            button4.Text = "Serializar XML";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(7, 599);
            button5.Name = "button5";
            button5.Size = new Size(175, 46);
            button5.TabIndex = 12;
            button5.Text = "Serialização String";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(buttonDJSON);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(buttonSJSON);
            panel3.Location = new Point(7, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(534, 208);
            panel3.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(367, 25);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 26;
            label6.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(367, 66);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 25;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(367, 105);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 24;
            label8.Text = "label6";
            // 
            // buttonDJSON
            // 
            buttonDJSON.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDJSON.Location = new Point(290, 145);
            buttonDJSON.Name = "buttonDJSON";
            buttonDJSON.Size = new Size(164, 49);
            buttonDJSON.TabIndex = 23;
            buttonDJSON.Text = "Desserializar";
            buttonDJSON.UseVisualStyleBackColor = true;
            buttonDJSON.Click += buttonDJSON_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(81, 91);
            label9.Name = "label9";
            label9.Size = new Size(85, 32);
            label9.TabIndex = 22;
            label9.Text = "Salário";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(81, 56);
            label10.Name = "label10";
            label10.Size = new Size(73, 32);
            label10.TabIndex = 21;
            label10.Text = "Idade";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(81, 14);
            label11.Name = "label11";
            label11.Size = new Size(80, 32);
            label11.TabIndex = 20;
            label11.Text = "Nome";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(187, 14);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 33);
            textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(187, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(146, 33);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(187, 55);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(146, 33);
            textBox4.TabIndex = 18;
            // 
            // buttonSJSON
            // 
            buttonSJSON.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSJSON.Location = new Point(81, 145);
            buttonSJSON.Name = "buttonSJSON";
            buttonSJSON.Size = new Size(190, 49);
            buttonSJSON.TabIndex = 16;
            buttonSJSON.Text = "Serializar em JSON";
            buttonSJSON.UseVisualStyleBackColor = true;
            buttonSJSON.Click += buttonSJSON_Click;
            // 
            // button6
            // 
            button6.Location = new Point(371, 599);
            button6.Name = "button6";
            button6.Size = new Size(209, 46);
            button6.TabIndex = 14;
            button6.Text = "Serialização JSON";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 657);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button3;
        private TextBox txbSalario;
        private TextBox txbIdade;
        private TextBox txbNome;
        private Panel panel1;
        private Button button4;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button5;
        private Button buttonDess;
        private Label labelNome;
        private Label labelIdade;
        private Label labelSalario;
        private Panel panel3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button buttonDJSON;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button buttonSJSON;
        private Button button6;
    }
}