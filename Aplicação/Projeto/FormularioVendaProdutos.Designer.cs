namespace Projeto
{
    partial class FormularioVendaProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioVendaProdutos));
            this.buttonMaisProdutos = new System.Windows.Forms.Button();
            this.buttonAdicionarProduto = new System.Windows.Forms.Button();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonN = new System.Windows.Forms.RadioButton();
            this.radioButtonS = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonApagarCompra = new System.Windows.Forms.Button();
            this.buttonAdicionarCompra = new System.Windows.Forms.Button();
            this.buttonApagarProduto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxProdutos = new System.Windows.Forms.ListBox();
            this.listBoxCompra = new System.Windows.Forms.ListBox();
            this.buttonMaisCliente = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotalCliente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTotalDetalhesCompra = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog_Save = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMaisProdutos
            // 
            this.buttonMaisProdutos.Location = new System.Drawing.Point(657, 318);
            this.buttonMaisProdutos.Name = "buttonMaisProdutos";
            this.buttonMaisProdutos.Size = new System.Drawing.Size(26, 19);
            this.buttonMaisProdutos.TabIndex = 81;
            this.buttonMaisProdutos.Text = "...";
            this.buttonMaisProdutos.UseVisualStyleBackColor = true;
            this.buttonMaisProdutos.Click += new System.EventHandler(this.buttonMaisProdutos_Click);
            // 
            // buttonAdicionarProduto
            // 
            this.buttonAdicionarProduto.Location = new System.Drawing.Point(507, 370);
            this.buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            this.buttonAdicionarProduto.Size = new System.Drawing.Size(121, 33);
            this.buttonAdicionarProduto.TabIndex = 78;
            this.buttonAdicionarProduto.Text = "Adicionar produto";
            this.buttonAdicionarProduto.UseVisualStyleBackColor = true;
            this.buttonAdicionarProduto.Click += new System.EventHandler(this.buttonAdicionarProduto_Click);
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(539, 315);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(117, 21);
            this.cbProduto.TabIndex = 77;
            // 
            // numericUpDownQuantidade
            // 
            this.numericUpDownQuantidade.Location = new System.Drawing.Point(539, 287);
            this.numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            this.numericUpDownQuantidade.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownQuantidade.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(478, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Produto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(457, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Quantidade:";
            // 
            // radioButtonN
            // 
            this.radioButtonN.AutoSize = true;
            this.radioButtonN.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonN.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonN.Location = new System.Drawing.Point(163, 431);
            this.radioButtonN.Name = "radioButtonN";
            this.radioButtonN.Size = new System.Drawing.Size(48, 17);
            this.radioButtonN.TabIndex = 91;
            this.radioButtonN.TabStop = true;
            this.radioButtonN.Text = "Não";
            this.radioButtonN.UseVisualStyleBackColor = false;
            // 
            // radioButtonS
            // 
            this.radioButtonS.AutoSize = true;
            this.radioButtonS.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonS.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonS.Location = new System.Drawing.Point(120, 431);
            this.radioButtonS.Name = "radioButtonS";
            this.radioButtonS.Size = new System.Drawing.Size(45, 17);
            this.radioButtonS.TabIndex = 90;
            this.radioButtonS.TabStop = true;
            this.radioButtonS.Text = "Sim";
            this.radioButtonS.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(30, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "Usou Cartão?";
            // 
            // buttonApagarCompra
            // 
            this.buttonApagarCompra.Location = new System.Drawing.Point(136, 464);
            this.buttonApagarCompra.Name = "buttonApagarCompra";
            this.buttonApagarCompra.Size = new System.Drawing.Size(75, 23);
            this.buttonApagarCompra.TabIndex = 92;
            this.buttonApagarCompra.Text = "Apagar";
            this.buttonApagarCompra.UseVisualStyleBackColor = true;
            this.buttonApagarCompra.Click += new System.EventHandler(this.buttonApagarCompra_Click);
            // 
            // buttonAdicionarCompra
            // 
            this.buttonAdicionarCompra.Location = new System.Drawing.Point(26, 464);
            this.buttonAdicionarCompra.Name = "buttonAdicionarCompra";
            this.buttonAdicionarCompra.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarCompra.TabIndex = 84;
            this.buttonAdicionarCompra.Text = "Adicionar";
            this.buttonAdicionarCompra.UseVisualStyleBackColor = true;
            this.buttonAdicionarCompra.Click += new System.EventHandler(this.buttonAdicionarCompra_Click);
            // 
            // buttonApagarProduto
            // 
            this.buttonApagarProduto.Location = new System.Drawing.Point(268, 473);
            this.buttonApagarProduto.Name = "buttonApagarProduto";
            this.buttonApagarProduto.Size = new System.Drawing.Size(172, 23);
            this.buttonApagarProduto.TabIndex = 87;
            this.buttonApagarProduto.Text = "Apagar";
            this.buttonApagarProduto.UseVisualStyleBackColor = true;
            this.buttonApagarProduto.Click += new System.EventHandler(this.buttonApagarProduto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(279, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 86;
            this.label4.Text = "Detalhes da Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(80, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 85;
            this.label3.Text = "Compras";
            // 
            // listBoxProdutos
            // 
            this.listBoxProdutos.FormattingEnabled = true;
            this.listBoxProdutos.Location = new System.Drawing.Point(268, 206);
            this.listBoxProdutos.Name = "listBoxProdutos";
            this.listBoxProdutos.Size = new System.Drawing.Size(172, 238);
            this.listBoxProdutos.TabIndex = 83;
            // 
            // listBoxCompra
            // 
            this.listBoxCompra.FormattingEnabled = true;
            this.listBoxCompra.Location = new System.Drawing.Point(26, 206);
            this.listBoxCompra.Name = "listBoxCompra";
            this.listBoxCompra.Size = new System.Drawing.Size(218, 212);
            this.listBoxCompra.TabIndex = 82;
            this.listBoxCompra.SelectedIndexChanged += new System.EventHandler(this.listBoxCompra_SelectedIndexChanged);
            // 
            // buttonMaisCliente
            // 
            this.buttonMaisCliente.Location = new System.Drawing.Point(432, 133);
            this.buttonMaisCliente.Name = "buttonMaisCliente";
            this.buttonMaisCliente.Size = new System.Drawing.Size(26, 21);
            this.buttonMaisCliente.TabIndex = 98;
            this.buttonMaisCliente.Text = "...";
            this.buttonMaisCliente.UseVisualStyleBackColor = true;
            this.buttonMaisCliente.Click += new System.EventHandler(this.buttonMaisCliente_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(40, 133);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(386, 21);
            this.cbCliente.TabIndex = 95;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(37, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 94;
            this.label1.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(200, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 31);
            this.label5.TabIndex = 99;
            this.label5.Text = "Vendas de Produtos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(471, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 16);
            this.label6.TabIndex = 100;
            this.label6.Text = "Adicionar Detalhe de Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(507, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 101;
            this.label2.Text = "Total:";
            // 
            // labelTotalCliente
            // 
            this.labelTotalCliente.AutoSize = true;
            this.labelTotalCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalCliente.Location = new System.Drawing.Point(556, 135);
            this.labelTotalCliente.Name = "labelTotalCliente";
            this.labelTotalCliente.Size = new System.Drawing.Size(0, 15);
            this.labelTotalCliente.TabIndex = 102;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(305, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 103;
            this.label9.Text = "Total:";
            // 
            // labelTotalDetalhesCompra
            // 
            this.labelTotalDetalhesCompra.AutoSize = true;
            this.labelTotalDetalhesCompra.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalDetalhesCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDetalhesCompra.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalDetalhesCompra.Location = new System.Drawing.Point(345, 454);
            this.labelTotalDetalhesCompra.Name = "labelTotalDetalhesCompra";
            this.labelTotalDetalhesCompra.Size = new System.Drawing.Size(0, 13);
            this.labelTotalDetalhesCompra.TabIndex = 104;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 105;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturaToolStripMenuItem,
            this.printToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faturaToolStripMenuItem.Text = "Fatura da Compra";
            this.faturaToolStripMenuItem.Click += new System.EventHandler(this.faturaToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "Guardar Compras";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // FormularioVendaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 519);
            this.Controls.Add(this.labelTotalDetalhesCompra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelTotalCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonMaisCliente);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonN);
            this.Controls.Add(this.radioButtonS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonApagarCompra);
            this.Controls.Add(this.buttonAdicionarCompra);
            this.Controls.Add(this.buttonApagarProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxProdutos);
            this.Controls.Add(this.listBoxCompra);
            this.Controls.Add(this.buttonMaisProdutos);
            this.Controls.Add(this.buttonAdicionarProduto);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.numericUpDownQuantidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormularioVendaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Venda de Produtos";
            this.Activated += new System.EventHandler(this.FormularioVendaProdutos_Activated);
            this.Load += new System.EventHandler(this.FormularioVendaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMaisProdutos;
        private System.Windows.Forms.Button buttonAdicionarProduto;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonN;
        private System.Windows.Forms.RadioButton radioButtonS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonApagarCompra;
        private System.Windows.Forms.Button buttonAdicionarCompra;
        private System.Windows.Forms.Button buttonApagarProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxProdutos;
        private System.Windows.Forms.ListBox listBoxCompra;
        private System.Windows.Forms.Button buttonMaisCliente;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTotalDetalhesCompra;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Save;
    }
}