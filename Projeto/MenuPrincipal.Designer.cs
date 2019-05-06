namespace Projeto
{
    partial class MenuPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAnimadores = new System.Windows.Forms.Button();
            this.buttonEscolas = new System.Windows.Forms.Button();
            this.buttonProdutosVendidosLoja = new System.Windows.Forms.Button();
            this.buttonEventos = new System.Windows.Forms.Button();
            this.buttonVendasProdutos = new System.Windows.Forms.Button();
            this.buttonClientesFilhos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 41);
            this.label1.TabIndex = 13;
            this.label1.Text = "BooKids";
            // 
            // buttonAnimadores
            // 
            this.buttonAnimadores.Location = new System.Drawing.Point(354, 240);
            this.buttonAnimadores.Name = "buttonAnimadores";
            this.buttonAnimadores.Size = new System.Drawing.Size(113, 54);
            this.buttonAnimadores.TabIndex = 12;
            this.buttonAnimadores.Text = "Animadores";
            this.buttonAnimadores.UseVisualStyleBackColor = true;
            this.buttonAnimadores.Click += new System.EventHandler(this.buttonAnimadores_Click);
            // 
            // buttonEscolas
            // 
            this.buttonEscolas.Location = new System.Drawing.Point(195, 240);
            this.buttonEscolas.Name = "buttonEscolas";
            this.buttonEscolas.Size = new System.Drawing.Size(113, 54);
            this.buttonEscolas.TabIndex = 11;
            this.buttonEscolas.Text = "Escolas";
            this.buttonEscolas.UseVisualStyleBackColor = true;
            this.buttonEscolas.Click += new System.EventHandler(this.buttonEscolas_Click);
            // 
            // buttonProdutosVendidosLoja
            // 
            this.buttonProdutosVendidosLoja.Location = new System.Drawing.Point(34, 240);
            this.buttonProdutosVendidosLoja.Name = "buttonProdutosVendidosLoja";
            this.buttonProdutosVendidosLoja.Size = new System.Drawing.Size(113, 54);
            this.buttonProdutosVendidosLoja.TabIndex = 10;
            this.buttonProdutosVendidosLoja.Text = "Produtos Vendidos pela Loja ";
            this.buttonProdutosVendidosLoja.UseVisualStyleBackColor = true;
            this.buttonProdutosVendidosLoja.Click += new System.EventHandler(this.buttonProdutosVendidosLoja_Click);
            // 
            // buttonEventos
            // 
            this.buttonEventos.Location = new System.Drawing.Point(354, 138);
            this.buttonEventos.Name = "buttonEventos";
            this.buttonEventos.Size = new System.Drawing.Size(113, 54);
            this.buttonEventos.TabIndex = 9;
            this.buttonEventos.Text = "Eventos";
            this.buttonEventos.UseVisualStyleBackColor = true;
            this.buttonEventos.Click += new System.EventHandler(this.buttonEventos_Click);
            // 
            // buttonVendasProdutos
            // 
            this.buttonVendasProdutos.Location = new System.Drawing.Point(195, 138);
            this.buttonVendasProdutos.Name = "buttonVendasProdutos";
            this.buttonVendasProdutos.Size = new System.Drawing.Size(113, 54);
            this.buttonVendasProdutos.TabIndex = 8;
            this.buttonVendasProdutos.Text = "Vendas de Produtos";
            this.buttonVendasProdutos.UseVisualStyleBackColor = true;
            this.buttonVendasProdutos.Click += new System.EventHandler(this.buttonVendasProdutos_Click);
            // 
            // buttonClientesFilhos
            // 
            this.buttonClientesFilhos.Location = new System.Drawing.Point(34, 138);
            this.buttonClientesFilhos.Name = "buttonClientesFilhos";
            this.buttonClientesFilhos.Size = new System.Drawing.Size(113, 54);
            this.buttonClientesFilhos.TabIndex = 7;
            this.buttonClientesFilhos.Text = "Clientes e Filhos";
            this.buttonClientesFilhos.UseVisualStyleBackColor = true;
            this.buttonClientesFilhos.Click += new System.EventHandler(this.buttonClientesFilhos_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAnimadores);
            this.Controls.Add(this.buttonEscolas);
            this.Controls.Add(this.buttonProdutosVendidosLoja);
            this.Controls.Add(this.buttonEventos);
            this.Controls.Add(this.buttonVendasProdutos);
            this.Controls.Add(this.buttonClientesFilhos);
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAnimadores;
        private System.Windows.Forms.Button buttonEscolas;
        private System.Windows.Forms.Button buttonProdutosVendidosLoja;
        private System.Windows.Forms.Button buttonEventos;
        private System.Windows.Forms.Button buttonVendasProdutos;
        private System.Windows.Forms.Button buttonClientesFilhos;
    }
}

