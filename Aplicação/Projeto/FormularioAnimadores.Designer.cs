namespace Projeto
{
    partial class FormularioAnimadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioAnimadores));
            this.listViewAnimadores = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbTelemovelAnimadores = new System.Windows.Forms.MaskedTextBox();
            this.tbTelefoneAnimadores = new System.Windows.Forms.MaskedTextBox();
            this.tbCodPostalAnimadores = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.tbEspecialidade = new System.Windows.Forms.TextBox();
            this.tbMailAnimadores = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLocalidadeAnimadores = new System.Windows.Forms.TextBox();
            this.tbMoradaAnimadores = new System.Windows.Forms.TextBox();
            this.tbNomeAnimadores = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAnimadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewAnimadores
            // 
            this.listViewAnimadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewAnimadores.FullRowSelect = true;
            this.listViewAnimadores.GridLines = true;
            this.listViewAnimadores.Location = new System.Drawing.Point(21, 264);
            this.listViewAnimadores.MultiSelect = false;
            this.listViewAnimadores.Name = "listViewAnimadores";
            this.listViewAnimadores.Size = new System.Drawing.Size(549, 108);
            this.listViewAnimadores.TabIndex = 72;
            this.listViewAnimadores.UseCompatibleStateImageBehavior = false;
            this.listViewAnimadores.View = System.Windows.Forms.View.Details;
            this.listViewAnimadores.SelectedIndexChanged += new System.EventHandler(this.listViewAnimadores_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Morada";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Localidade";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Código Postal";
            this.columnHeader4.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefone";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Telemóvel";
            this.columnHeader6.Width = 75;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mail";
            this.columnHeader7.Width = 35;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Especialidade";
            this.columnHeader8.Width = 93;
            // 
            // tbTelemovelAnimadores
            // 
            this.tbTelemovelAnimadores.Location = new System.Drawing.Point(251, 155);
            this.tbTelemovelAnimadores.Mask = "000 000 000";
            this.tbTelemovelAnimadores.Name = "tbTelemovelAnimadores";
            this.tbTelemovelAnimadores.Size = new System.Drawing.Size(74, 20);
            this.tbTelemovelAnimadores.TabIndex = 66;
            // 
            // tbTelefoneAnimadores
            // 
            this.tbTelefoneAnimadores.Location = new System.Drawing.Point(103, 155);
            this.tbTelefoneAnimadores.Mask = "000 000 000";
            this.tbTelefoneAnimadores.Name = "tbTelefoneAnimadores";
            this.tbTelefoneAnimadores.Size = new System.Drawing.Size(71, 20);
            this.tbTelefoneAnimadores.TabIndex = 65;
            // 
            // tbCodPostalAnimadores
            // 
            this.tbCodPostalAnimadores.Location = new System.Drawing.Point(485, 129);
            this.tbCodPostalAnimadores.Mask = "0000 - 000";
            this.tbCodPostalAnimadores.Name = "tbCodPostalAnimadores";
            this.tbCodPostalAnimadores.Size = new System.Drawing.Size(79, 20);
            this.tbCodPostalAnimadores.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(21, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 16);
            this.label14.TabIndex = 75;
            this.label14.Text = "Lista de Animadores";
            // 
            // buttonApagar
            // 
            this.buttonApagar.Image = ((System.Drawing.Image)(resources.GetObject("buttonApagar.Image")));
            this.buttonApagar.Location = new System.Drawing.Point(514, 196);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(50, 49);
            this.buttonApagar.TabIndex = 71;
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlterar.Image")));
            this.buttonAlterar.Location = new System.Drawing.Point(449, 196);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(47, 49);
            this.buttonAlterar.TabIndex = 70;
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionar.Image")));
            this.buttonAdicionar.Location = new System.Drawing.Point(386, 196);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(48, 49);
            this.buttonAdicionar.TabIndex = 69;
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // tbEspecialidade
            // 
            this.tbEspecialidade.Location = new System.Drawing.Point(103, 181);
            this.tbEspecialidade.Name = "tbEspecialidade";
            this.tbEspecialidade.Size = new System.Drawing.Size(268, 20);
            this.tbEspecialidade.TabIndex = 68;
            // 
            // tbMailAnimadores
            // 
            this.tbMailAnimadores.Location = new System.Drawing.Point(369, 155);
            this.tbMailAnimadores.Name = "tbMailAnimadores";
            this.tbMailAnimadores.Size = new System.Drawing.Size(195, 20);
            this.tbMailAnimadores.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(7, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Especialidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(329, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Mail:";
            // 
            // tbLocalidadeAnimadores
            // 
            this.tbLocalidadeAnimadores.Location = new System.Drawing.Point(103, 129);
            this.tbLocalidadeAnimadores.Name = "tbLocalidadeAnimadores";
            this.tbLocalidadeAnimadores.Size = new System.Drawing.Size(284, 20);
            this.tbLocalidadeAnimadores.TabIndex = 60;
            // 
            // tbMoradaAnimadores
            // 
            this.tbMoradaAnimadores.Location = new System.Drawing.Point(103, 103);
            this.tbMoradaAnimadores.Name = "tbMoradaAnimadores";
            this.tbMoradaAnimadores.Size = new System.Drawing.Size(461, 20);
            this.tbMoradaAnimadores.TabIndex = 58;
            // 
            // tbNomeAnimadores
            // 
            this.tbNomeAnimadores.Location = new System.Drawing.Point(103, 77);
            this.tbNomeAnimadores.Name = "tbNomeAnimadores";
            this.tbNomeAnimadores.Size = new System.Drawing.Size(461, 20);
            this.tbNomeAnimadores.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(180, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Telemóvel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(36, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(393, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Código Postal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(24, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Localidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(44, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Morada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(54, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nome:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(219, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 31);
            this.label9.TabIndex = 76;
            this.label9.Text = "Animadores";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 77;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAnimadorToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // novoAnimadorToolStripMenuItem
            // 
            this.novoAnimadorToolStripMenuItem.Name = "novoAnimadorToolStripMenuItem";
            this.novoAnimadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoAnimadorToolStripMenuItem.Text = "Novo";
            this.novoAnimadorToolStripMenuItem.Click += new System.EventHandler(this.novoAnimadorToolStripMenuItem_Click);
            // 
            // FormularioAnimadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 384);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listViewAnimadores);
            this.Controls.Add(this.tbTelemovelAnimadores);
            this.Controls.Add(this.tbTelefoneAnimadores);
            this.Controls.Add(this.tbCodPostalAnimadores);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.tbEspecialidade);
            this.Controls.Add(this.tbMailAnimadores);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbLocalidadeAnimadores);
            this.Controls.Add(this.tbMoradaAnimadores);
            this.Controls.Add(this.tbNomeAnimadores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormularioAnimadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Animadores";
            this.Load += new System.EventHandler(this.FormularioAnimadores_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAnimadores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.MaskedTextBox tbTelemovelAnimadores;
        private System.Windows.Forms.MaskedTextBox tbTelefoneAnimadores;
        private System.Windows.Forms.MaskedTextBox tbCodPostalAnimadores;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.TextBox tbEspecialidade;
        private System.Windows.Forms.TextBox tbMailAnimadores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLocalidadeAnimadores;
        private System.Windows.Forms.TextBox tbMoradaAnimadores;
        private System.Windows.Forms.TextBox tbNomeAnimadores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoAnimadorToolStripMenuItem;
    }
}