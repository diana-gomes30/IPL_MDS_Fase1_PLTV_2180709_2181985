namespace Projeto
{
    partial class FormularioProdutosVendidosLoja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioProdutosVendidosLoja));
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.buttonAdicionarProduto = new System.Windows.Forms.Button();
            this.numericUpDownPreco = new System.Windows.Forms.NumericUpDown();
            this.buttonApagarProduto = new System.Windows.Forms.Button();
            this.buttonAlterarProduto = new System.Windows.Forms.Button();
            this.tbDesignacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApagarTipo = new System.Windows.Forms.Button();
            this.listBoxTipoProduto = new System.Windows.Forms.ListBox();
            this.buttonAdicionarTipo = new System.Windows.Forms.Button();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTiposProduto = new System.Windows.Forms.ComboBox();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreco)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Tipo de Produto:";
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.Location = new System.Drawing.Point(317, 215);
            this.numericUpDownStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownStock.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownStock.TabIndex = 80;
            this.numericUpDownStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonAdicionarProduto
            // 
            this.buttonAdicionarProduto.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarProduto.Image")));
            this.buttonAdicionarProduto.Location = new System.Drawing.Point(139, 243);
            this.buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            this.buttonAdicionarProduto.Size = new System.Drawing.Size(43, 35);
            this.buttonAdicionarProduto.TabIndex = 79;
            this.buttonAdicionarProduto.UseVisualStyleBackColor = true;
            this.buttonAdicionarProduto.Click += new System.EventHandler(this.buttonAdicionarProduto_Click);
            // 
            // numericUpDownPreco
            // 
            this.numericUpDownPreco.DecimalPlaces = 2;
            this.numericUpDownPreco.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPreco.Location = new System.Drawing.Point(115, 216);
            this.numericUpDownPreco.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPreco.Name = "numericUpDownPreco";
            this.numericUpDownPreco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownPreco.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownPreco.TabIndex = 78;
            this.numericUpDownPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonApagarProduto
            // 
            this.buttonApagarProduto.Image = ((System.Drawing.Image)(resources.GetObject("buttonApagarProduto.Image")));
            this.buttonApagarProduto.Location = new System.Drawing.Point(288, 243);
            this.buttonApagarProduto.Name = "buttonApagarProduto";
            this.buttonApagarProduto.Size = new System.Drawing.Size(36, 35);
            this.buttonApagarProduto.TabIndex = 77;
            this.buttonApagarProduto.UseVisualStyleBackColor = true;
            this.buttonApagarProduto.Click += new System.EventHandler(this.buttonApagarProduto_Click);
            // 
            // buttonAlterarProduto
            // 
            this.buttonAlterarProduto.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlterarProduto.Image")));
            this.buttonAlterarProduto.Location = new System.Drawing.Point(220, 243);
            this.buttonAlterarProduto.Name = "buttonAlterarProduto";
            this.buttonAlterarProduto.Size = new System.Drawing.Size(34, 35);
            this.buttonAlterarProduto.TabIndex = 76;
            this.buttonAlterarProduto.UseVisualStyleBackColor = true;
            this.buttonAlterarProduto.Click += new System.EventHandler(this.buttonAlterarProduto_Click);
            // 
            // tbDesignacao
            // 
            this.tbDesignacao.Location = new System.Drawing.Point(115, 163);
            this.tbDesignacao.Name = "tbDesignacao";
            this.tbDesignacao.Size = new System.Drawing.Size(280, 20);
            this.tbDesignacao.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(211, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Stock Existente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(61, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Preço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(27, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Designação:";
            // 
            // buttonApagarTipo
            // 
            this.buttonApagarTipo.Location = new System.Drawing.Point(481, 466);
            this.buttonApagarTipo.Name = "buttonApagarTipo";
            this.buttonApagarTipo.Size = new System.Drawing.Size(217, 22);
            this.buttonApagarTipo.TabIndex = 88;
            this.buttonApagarTipo.Text = "Apagar";
            this.buttonApagarTipo.UseVisualStyleBackColor = true;
            this.buttonApagarTipo.Click += new System.EventHandler(this.buttonApagarTipo_Click);
            // 
            // listBoxTipoProduto
            // 
            this.listBoxTipoProduto.FormattingEnabled = true;
            this.listBoxTipoProduto.Location = new System.Drawing.Point(481, 261);
            this.listBoxTipoProduto.Name = "listBoxTipoProduto";
            this.listBoxTipoProduto.Size = new System.Drawing.Size(217, 199);
            this.listBoxTipoProduto.TabIndex = 87;
            // 
            // buttonAdicionarTipo
            // 
            this.buttonAdicionarTipo.Location = new System.Drawing.Point(504, 198);
            this.buttonAdicionarTipo.Name = "buttonAdicionarTipo";
            this.buttonAdicionarTipo.Size = new System.Drawing.Size(94, 22);
            this.buttonAdicionarTipo.TabIndex = 86;
            this.buttonAdicionarTipo.Text = "Adicionar";
            this.buttonAdicionarTipo.UseVisualStyleBackColor = true;
            this.buttonAdicionarTipo.Click += new System.EventHandler(this.buttonAdicionarTipo_Click);
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(504, 172);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(194, 20);
            this.tbTipo.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(467, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(249, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 31);
            this.label6.TabIndex = 89;
            this.label6.Text = "Produtos Vendidos ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(536, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 90;
            this.label7.Text = "Tipo de Produtos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(193, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 91;
            this.label8.Text = "Produtos";
            // 
            // cbTiposProduto
            // 
            this.cbTiposProduto.FormattingEnabled = true;
            this.cbTiposProduto.Location = new System.Drawing.Point(115, 189);
            this.cbTiposProduto.Name = "cbTiposProduto";
            this.cbTiposProduto.Size = new System.Drawing.Size(280, 21);
            this.cbTiposProduto.TabIndex = 92;
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader14,
            this.columnHeader17,
            this.columnHeader18});
            this.listViewProdutos.FullRowSelect = true;
            this.listViewProdutos.GridLines = true;
            this.listViewProdutos.Location = new System.Drawing.Point(30, 321);
            this.listViewProdutos.MultiSelect = false;
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(371, 167);
            this.listViewProdutos.TabIndex = 101;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.View = System.Windows.Forms.View.Details;
            this.listViewProdutos.SelectedIndexChanged += new System.EventHandler(this.listViewProdutos_SelectedIndexChanged);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Designação";
            this.columnHeader11.Width = 118;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Tipo Produto";
            this.columnHeader14.Width = 116;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Preço";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Stock";
            this.columnHeader18.Width = 135;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(604, 198);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(94, 23);
            this.buttonAlterar.TabIndex = 102;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 103;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoProdutoToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // tipoProdutoToolStripMenuItem
            // 
            this.tipoProdutoToolStripMenuItem.Name = "tipoProdutoToolStripMenuItem";
            this.tipoProdutoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.tipoProdutoToolStripMenuItem.Text = "Tipo Produto";
            this.tipoProdutoToolStripMenuItem.Click += new System.EventHandler(this.tipoProdutoToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(27, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 15);
            this.label9.TabIndex = 104;
            this.label9.Text = "Lista de Produtos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(501, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 15);
            this.label10.TabIndex = 105;
            this.label10.Text = "Lista de Tipo de Produtos";
            // 
            // FormularioProdutosVendidosLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 514);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.listViewProdutos);
            this.Controls.Add(this.cbTiposProduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonApagarTipo);
            this.Controls.Add(this.listBoxTipoProduto);
            this.Controls.Add(this.buttonAdicionarTipo);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownStock);
            this.Controls.Add(this.buttonAdicionarProduto);
            this.Controls.Add(this.numericUpDownPreco);
            this.Controls.Add(this.buttonApagarProduto);
            this.Controls.Add(this.buttonAlterarProduto);
            this.Controls.Add(this.tbDesignacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormularioProdutosVendidosLoja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Produtos Vendidos pela Loja";
            this.Activated += new System.EventHandler(this.FormularioProdutosVendidosLoja_Activated);
            this.Load += new System.EventHandler(this.FormularioProdutosVendidosLoja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreco)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.Button buttonAdicionarProduto;
        private System.Windows.Forms.NumericUpDown numericUpDownPreco;
        private System.Windows.Forms.Button buttonApagarProduto;
        private System.Windows.Forms.Button buttonAlterarProduto;
        private System.Windows.Forms.TextBox tbDesignacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApagarTipo;
        private System.Windows.Forms.ListBox listBoxTipoProduto;
        private System.Windows.Forms.Button buttonAdicionarTipo;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTiposProduto;
        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}