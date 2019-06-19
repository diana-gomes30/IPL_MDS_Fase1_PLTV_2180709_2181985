namespace Projeto
{
    partial class FormularioEscolas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioEscolas));
            this.listViewEscolas = new System.Windows.Forms.ListView();
            this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMorada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLocalidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCodPost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.tbCodPostalEscola = new System.Windows.Forms.MaskedTextBox();
            this.tbTelefoneEscola = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMailEscola = new System.Windows.Forms.TextBox();
            this.tbMoradaEscola = new System.Windows.Forms.TextBox();
            this.tbLocalidadeEscola = new System.Windows.Forms.TextBox();
            this.tbNomeEscola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaEscolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewEscolas
            // 
            this.listViewEscolas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNome,
            this.columnMorada,
            this.columnLocalidade,
            this.columnCodPost,
            this.columnTelefone,
            this.columnMail});
            this.listViewEscolas.FullRowSelect = true;
            this.listViewEscolas.GridLines = true;
            this.listViewEscolas.Location = new System.Drawing.Point(40, 265);
            this.listViewEscolas.MultiSelect = false;
            this.listViewEscolas.Name = "listViewEscolas";
            this.listViewEscolas.Size = new System.Drawing.Size(439, 97);
            this.listViewEscolas.TabIndex = 64;
            this.listViewEscolas.UseCompatibleStateImageBehavior = false;
            this.listViewEscolas.View = System.Windows.Forms.View.Details;
            this.listViewEscolas.SelectedIndexChanged += new System.EventHandler(this.listViewEscolas_SelectedIndexChanged);
            // 
            // columnNome
            // 
            this.columnNome.Text = "Nome";
            this.columnNome.Width = 156;
            // 
            // columnMorada
            // 
            this.columnMorada.Text = "Morada";
            this.columnMorada.Width = 125;
            // 
            // columnLocalidade
            // 
            this.columnLocalidade.Text = "Localidade";
            this.columnLocalidade.Width = 98;
            // 
            // columnCodPost
            // 
            this.columnCodPost.Text = "Código Postal";
            this.columnCodPost.Width = 77;
            // 
            // columnTelefone
            // 
            this.columnTelefone.Text = "Telefone";
            this.columnTelefone.Width = 97;
            // 
            // columnMail
            // 
            this.columnMail.Text = "Mail";
            this.columnMail.Width = 161;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Image = ((System.Drawing.Image)(resources.GetObject("buttonApagar.Image")));
            this.buttonApagar.Location = new System.Drawing.Point(430, 210);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(50, 49);
            this.buttonApagar.TabIndex = 63;
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlterar.Image")));
            this.buttonAlterar.Location = new System.Drawing.Point(358, 210);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(47, 49);
            this.buttonAlterar.TabIndex = 62;
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionar.Image")));
            this.buttonAdicionar.Location = new System.Drawing.Point(280, 210);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(48, 49);
            this.buttonAdicionar.TabIndex = 61;
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // tbCodPostalEscola
            // 
            this.tbCodPostalEscola.Location = new System.Drawing.Point(413, 142);
            this.tbCodPostalEscola.Mask = "0000 - 000";
            this.tbCodPostalEscola.Name = "tbCodPostalEscola";
            this.tbCodPostalEscola.Size = new System.Drawing.Size(66, 20);
            this.tbCodPostalEscola.TabIndex = 58;
            // 
            // tbTelefoneEscola
            // 
            this.tbTelefoneEscola.Location = new System.Drawing.Point(96, 168);
            this.tbTelefoneEscola.Mask = "000 000 000";
            this.tbTelefoneEscola.Name = "tbTelefoneEscola";
            this.tbTelefoneEscola.Size = new System.Drawing.Size(78, 20);
            this.tbTelefoneEscola.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(37, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Lista de Escolas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(17, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Localidade:";
            // 
            // tbMailEscola
            // 
            this.tbMailEscola.Location = new System.Drawing.Point(232, 168);
            this.tbMailEscola.Name = "tbMailEscola";
            this.tbMailEscola.Size = new System.Drawing.Size(247, 20);
            this.tbMailEscola.TabIndex = 60;
            // 
            // tbMoradaEscola
            // 
            this.tbMoradaEscola.Location = new System.Drawing.Point(95, 113);
            this.tbMoradaEscola.Name = "tbMoradaEscola";
            this.tbMoradaEscola.Size = new System.Drawing.Size(384, 20);
            this.tbMoradaEscola.TabIndex = 54;
            // 
            // tbLocalidadeEscola
            // 
            this.tbLocalidadeEscola.Location = new System.Drawing.Point(95, 139);
            this.tbLocalidadeEscola.Name = "tbLocalidadeEscola";
            this.tbLocalidadeEscola.Size = new System.Drawing.Size(220, 20);
            this.tbLocalidadeEscola.TabIndex = 56;
            // 
            // tbNomeEscola
            // 
            this.tbNomeEscola.Location = new System.Drawing.Point(95, 87);
            this.tbNomeEscola.Name = "tbNomeEscola";
            this.tbNomeEscola.Size = new System.Drawing.Size(384, 20);
            this.tbNomeEscola.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(321, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Código Postal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(192, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(29, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(37, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Morada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(43, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(198, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 31);
            this.label6.TabIndex = 67;
            this.label6.Text = "Escolas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 68;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaEscolaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // novaEscolaToolStripMenuItem
            // 
            this.novaEscolaToolStripMenuItem.Name = "novaEscolaToolStripMenuItem";
            this.novaEscolaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaEscolaToolStripMenuItem.Text = "Nova";
            this.novaEscolaToolStripMenuItem.Click += new System.EventHandler(this.novaEscolaToolStripMenuItem_Click);
            // 
            // FormularioEscolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 374);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listViewEscolas);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.tbCodPostalEscola);
            this.Controls.Add(this.tbTelefoneEscola);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbMailEscola);
            this.Controls.Add(this.tbMoradaEscola);
            this.Controls.Add(this.tbLocalidadeEscola);
            this.Controls.Add(this.tbNomeEscola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormularioEscolas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Escolas";
            this.Load += new System.EventHandler(this.FormularioEscolas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEscolas;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.ColumnHeader columnMorada;
        private System.Windows.Forms.ColumnHeader columnLocalidade;
        private System.Windows.Forms.ColumnHeader columnCodPost;
        private System.Windows.Forms.ColumnHeader columnTelefone;
        private System.Windows.Forms.ColumnHeader columnMail;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.MaskedTextBox tbCodPostalEscola;
        private System.Windows.Forms.MaskedTextBox tbTelefoneEscola;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMailEscola;
        private System.Windows.Forms.TextBox tbMoradaEscola;
        private System.Windows.Forms.TextBox tbLocalidadeEscola;
        private System.Windows.Forms.TextBox tbNomeEscola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaEscolaToolStripMenuItem;
    }
}