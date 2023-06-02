namespace Exercicio_WinForms_MiniERP
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
            panelMenu = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnFornecedores = new Button();
            btnProdutos = new Button();
            panelLogo = new Panel();
            panelTitleBar = new Panel();
            label1 = new Label();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(50, 50, 76);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(btnFornecedores);
            panelMenu.Controls.Add(btnProdutos);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 579);
            panelMenu.TabIndex = 0;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Gainsboro;
            button5.Image = Properties.Resources.shopping_cart__1_;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 380);
            button5.Name = "button5";
            button5.Padding = new Padding(12, 0, 0, 0);
            button5.Size = new Size(220, 60);
            button5.TabIndex = 5;
            button5.Text = "  Products";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Gainsboro;
            button4.Image = Properties.Resources.shopping_cart__1_;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 320);
            button4.Name = "button4";
            button4.Padding = new Padding(12, 0, 0, 0);
            button4.Size = new Size(220, 60);
            button4.TabIndex = 4;
            button4.Text = "  Products";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Gainsboro;
            button3.Image = Properties.Resources.shopping_cart__1_;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 260);
            button3.Name = "button3";
            button3.Padding = new Padding(12, 0, 0, 0);
            button3.Size = new Size(220, 60);
            button3.TabIndex = 3;
            button3.Text = "  Products";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Gainsboro;
            button2.Image = Properties.Resources.value__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 200);
            button2.Name = "button2";
            button2.Padding = new Padding(12, 0, 0, 0);
            button2.Size = new Size(220, 60);
            button2.TabIndex = 2;
            button2.Text = "  Clientes";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnFornecedores
            // 
            btnFornecedores.Dock = DockStyle.Top;
            btnFornecedores.FlatAppearance.BorderSize = 0;
            btnFornecedores.FlatStyle = FlatStyle.Flat;
            btnFornecedores.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFornecedores.ForeColor = Color.Gainsboro;
            btnFornecedores.Image = Properties.Resources.shopping_list;
            btnFornecedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnFornecedores.Location = new Point(0, 140);
            btnFornecedores.Name = "btnFornecedores";
            btnFornecedores.Padding = new Padding(12, 0, 0, 0);
            btnFornecedores.Size = new Size(220, 60);
            btnFornecedores.TabIndex = 1;
            btnFornecedores.Text = "  Fornecedores";
            btnFornecedores.TextAlign = ContentAlignment.MiddleLeft;
            btnFornecedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFornecedores.UseVisualStyleBackColor = true;
            btnFornecedores.Click += btnFornecedores_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Dock = DockStyle.Top;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnProdutos.ForeColor = Color.Gainsboro;
            btnProdutos.Image = Properties.Resources.shopping_cart__1_;
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.Location = new Point(0, 80);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Padding = new Padding(12, 0, 0, 0);
            btnProdutos.Size = new Size(220, 60);
            btnProdutos.TabIndex = 0;
            btnProdutos.Text = "  Produtos";
            btnProdutos.TextAlign = ContentAlignment.MiddleLeft;
            btnProdutos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(40, 40, 60);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 140);
            panelTitleBar.Controls.Add(label1);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(580, 100);
            panelTitleBar.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(264, 39);
            label1.Name = "label1";
            label1.Size = new Size(71, 26);
            label1.TabIndex = 2;
            label1.Text = "Home";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 579);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnProdutos;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnFornecedores;
        private Panel panelTitleBar;
        private Label label1;
    }
}