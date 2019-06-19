namespace Projeto
{
    partial class FormularioEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioEventos));
            this.buttonMaisFilhos = new System.Windows.Forms.Button();
            this.checkedListBoxFilhos = new System.Windows.Forms.CheckedListBox();
            this.cbFilhos = new System.Windows.Forms.ComboBox();
            this.buttonInscrever = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.listViewEventos = new System.Windows.Forms.ListView();
            this.columnHeaderTipoEvento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLimite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIdadeInf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIdadeSup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.buttonApagarAnimador = new System.Windows.Forms.Button();
            this.buttonAdicionarAnimador = new System.Windows.Forms.Button();
            this.cbAnimadores = new System.Windows.Forms.ComboBox();
            this.listBoxAnimadores = new System.Windows.Forms.ListBox();
            this.buttonMaisAnimadores = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonApagarEscola = new System.Windows.Forms.Button();
            this.buttonAdicionarEscola = new System.Windows.Forms.Button();
            this.cbEscolas = new System.Windows.Forms.ComboBox();
            this.buttonMaisEscolas = new System.Windows.Forms.Button();
            this.listBoxEscolas = new System.Windows.Forms.ListBox();
            this.numericUpDownLimite = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIdadeInferior = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIdadeSuperior = new System.Windows.Forms.NumericUpDown();
            this.buttonApagarEvento = new System.Windows.Forms.Button();
            this.tbHoraEvento = new System.Windows.Forms.MaskedTextBox();
            this.buttonAlterarEvento = new System.Windows.Forms.Button();
            this.buttonAdicionarEvento = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerDataEvento = new System.Windows.Forms.DateTimePicker();
            this.tbTipoEvento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLocalEvento = new System.Windows.Forms.TextBox();
            this.tbDescricaoEvento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelTotalConfirmacoes = new System.Windows.Forms.Label();
            this.buttonRetirarInscricao = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarListaDeInscriçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaDeInscriçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeInscriçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaDeInscriçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog_Save = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog_FichaInscricao = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdadeInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdadeSuperior)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMaisFilhos
            // 
            this.buttonMaisFilhos.Location = new System.Drawing.Point(947, 378);
            this.buttonMaisFilhos.Name = "buttonMaisFilhos";
            this.buttonMaisFilhos.Size = new System.Drawing.Size(24, 21);
            this.buttonMaisFilhos.TabIndex = 135;
            this.buttonMaisFilhos.Text = "...";
            this.buttonMaisFilhos.UseVisualStyleBackColor = true;
            this.buttonMaisFilhos.Click += new System.EventHandler(this.buttonMaisFilhos_Click);
            // 
            // checkedListBoxFilhos
            // 
            this.checkedListBoxFilhos.FormattingEnabled = true;
            this.checkedListBoxFilhos.Location = new System.Drawing.Point(718, 434);
            this.checkedListBoxFilhos.Name = "checkedListBoxFilhos";
            this.checkedListBoxFilhos.Size = new System.Drawing.Size(253, 184);
            this.checkedListBoxFilhos.TabIndex = 134;
            this.checkedListBoxFilhos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxFilhos_ItemCheck);
            // 
            // cbFilhos
            // 
            this.cbFilhos.FormattingEnabled = true;
            this.cbFilhos.Location = new System.Drawing.Point(718, 378);
            this.cbFilhos.Name = "cbFilhos";
            this.cbFilhos.Size = new System.Drawing.Size(223, 21);
            this.cbFilhos.TabIndex = 132;
            // 
            // buttonInscrever
            // 
            this.buttonInscrever.Location = new System.Drawing.Point(718, 405);
            this.buttonInscrever.Name = "buttonInscrever";
            this.buttonInscrever.Size = new System.Drawing.Size(116, 23);
            this.buttonInscrever.TabIndex = 133;
            this.buttonInscrever.Text = "Inscrever";
            this.buttonInscrever.UseVisualStyleBackColor = true;
            this.buttonInscrever.Click += new System.EventHandler(this.buttonInscrever_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(715, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 131;
            this.label11.Text = "Filhos:";
            // 
            // listViewEventos
            // 
            this.listViewEventos.BackColor = System.Drawing.SystemColors.Window;
            this.listViewEventos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTipoEvento,
            this.columnHeaderDescricao,
            this.columnHeaderLocal,
            this.columnHeaderData,
            this.columnHeaderLimite,
            this.columnHeaderIdadeInf,
            this.columnHeaderIdadeSup});
            this.listViewEventos.FullRowSelect = true;
            this.listViewEventos.GridLines = true;
            this.listViewEventos.Location = new System.Drawing.Point(26, 364);
            this.listViewEventos.MultiSelect = false;
            this.listViewEventos.Name = "listViewEventos";
            this.listViewEventos.Size = new System.Drawing.Size(633, 269);
            this.listViewEventos.TabIndex = 130;
            this.listViewEventos.UseCompatibleStateImageBehavior = false;
            this.listViewEventos.View = System.Windows.Forms.View.Details;
            this.listViewEventos.SelectedIndexChanged += new System.EventHandler(this.listViewEventos_SelectedIndexChanged);
            // 
            // columnHeaderTipoEvento
            // 
            this.columnHeaderTipoEvento.Text = "Tipo de Evento";
            this.columnHeaderTipoEvento.Width = 99;
            // 
            // columnHeaderDescricao
            // 
            this.columnHeaderDescricao.Text = "Descrição";
            this.columnHeaderDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDescricao.Width = 104;
            // 
            // columnHeaderLocal
            // 
            this.columnHeaderLocal.Text = "Local";
            this.columnHeaderLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderLocal.Width = 74;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data / Hora";
            this.columnHeaderData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderData.Width = 106;
            // 
            // columnHeaderLimite
            // 
            this.columnHeaderLimite.Text = "Limite Participação";
            this.columnHeaderLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderLimite.Width = 110;
            // 
            // columnHeaderIdadeInf
            // 
            this.columnHeaderIdadeInf.Text = "Idade Inferior";
            this.columnHeaderIdadeInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderIdadeInf.Width = 100;
            // 
            // columnHeaderIdadeSup
            // 
            this.columnHeaderIdadeSup.Text = "Idade Superior";
            this.columnHeaderIdadeSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderIdadeSup.Width = 98;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(776, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 129;
            this.label10.Text = "Animadores:";
            // 
            // buttonApagarAnimador
            // 
            this.buttonApagarAnimador.Location = new System.Drawing.Point(885, 171);
            this.buttonApagarAnimador.Name = "buttonApagarAnimador";
            this.buttonApagarAnimador.Size = new System.Drawing.Size(95, 23);
            this.buttonApagarAnimador.TabIndex = 127;
            this.buttonApagarAnimador.Text = "Apagar";
            this.buttonApagarAnimador.UseVisualStyleBackColor = true;
            this.buttonApagarAnimador.Click += new System.EventHandler(this.buttonApagarAnimador_Click);
            // 
            // buttonAdicionarAnimador
            // 
            this.buttonAdicionarAnimador.Location = new System.Drawing.Point(779, 171);
            this.buttonAdicionarAnimador.Name = "buttonAdicionarAnimador";
            this.buttonAdicionarAnimador.Size = new System.Drawing.Size(99, 23);
            this.buttonAdicionarAnimador.TabIndex = 126;
            this.buttonAdicionarAnimador.Text = "Adicionar";
            this.buttonAdicionarAnimador.UseVisualStyleBackColor = true;
            this.buttonAdicionarAnimador.Click += new System.EventHandler(this.buttonAdicionarAnimador_Click);
            // 
            // cbAnimadores
            // 
            this.cbAnimadores.FormattingEnabled = true;
            this.cbAnimadores.Location = new System.Drawing.Point(779, 145);
            this.cbAnimadores.Name = "cbAnimadores";
            this.cbAnimadores.Size = new System.Drawing.Size(171, 21);
            this.cbAnimadores.TabIndex = 124;
            // 
            // listBoxAnimadores
            // 
            this.listBoxAnimadores.FormattingEnabled = true;
            this.listBoxAnimadores.Location = new System.Drawing.Point(779, 198);
            this.listBoxAnimadores.Name = "listBoxAnimadores";
            this.listBoxAnimadores.Size = new System.Drawing.Size(201, 108);
            this.listBoxAnimadores.TabIndex = 128;
            // 
            // buttonMaisAnimadores
            // 
            this.buttonMaisAnimadores.Location = new System.Drawing.Point(956, 145);
            this.buttonMaisAnimadores.Name = "buttonMaisAnimadores";
            this.buttonMaisAnimadores.Size = new System.Drawing.Size(24, 23);
            this.buttonMaisAnimadores.TabIndex = 125;
            this.buttonMaisAnimadores.Text = "...";
            this.buttonMaisAnimadores.UseVisualStyleBackColor = true;
            this.buttonMaisAnimadores.Click += new System.EventHandler(this.buttonMaisAnimadores_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(538, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 123;
            this.label6.Text = "Escolas:";
            // 
            // buttonApagarEscola
            // 
            this.buttonApagarEscola.Location = new System.Drawing.Point(643, 169);
            this.buttonApagarEscola.Name = "buttonApagarEscola";
            this.buttonApagarEscola.Size = new System.Drawing.Size(101, 23);
            this.buttonApagarEscola.TabIndex = 121;
            this.buttonApagarEscola.Text = "Apagar";
            this.buttonApagarEscola.UseVisualStyleBackColor = true;
            this.buttonApagarEscola.Click += new System.EventHandler(this.buttonApagarEscola_Click);
            // 
            // buttonAdicionarEscola
            // 
            this.buttonAdicionarEscola.Location = new System.Drawing.Point(541, 169);
            this.buttonAdicionarEscola.Name = "buttonAdicionarEscola";
            this.buttonAdicionarEscola.Size = new System.Drawing.Size(96, 23);
            this.buttonAdicionarEscola.TabIndex = 120;
            this.buttonAdicionarEscola.Text = "Adicionar";
            this.buttonAdicionarEscola.UseVisualStyleBackColor = true;
            this.buttonAdicionarEscola.Click += new System.EventHandler(this.buttonAdicionarEscola_Click);
            // 
            // cbEscolas
            // 
            this.cbEscolas.FormattingEnabled = true;
            this.cbEscolas.Location = new System.Drawing.Point(541, 143);
            this.cbEscolas.Name = "cbEscolas";
            this.cbEscolas.Size = new System.Drawing.Size(171, 21);
            this.cbEscolas.TabIndex = 118;
            // 
            // buttonMaisEscolas
            // 
            this.buttonMaisEscolas.Location = new System.Drawing.Point(718, 142);
            this.buttonMaisEscolas.Name = "buttonMaisEscolas";
            this.buttonMaisEscolas.Size = new System.Drawing.Size(26, 23);
            this.buttonMaisEscolas.TabIndex = 119;
            this.buttonMaisEscolas.Text = "...";
            this.buttonMaisEscolas.UseVisualStyleBackColor = true;
            this.buttonMaisEscolas.Click += new System.EventHandler(this.buttonMaisEscolas_Click);
            // 
            // listBoxEscolas
            // 
            this.listBoxEscolas.FormattingEnabled = true;
            this.listBoxEscolas.Location = new System.Drawing.Point(541, 198);
            this.listBoxEscolas.Name = "listBoxEscolas";
            this.listBoxEscolas.Size = new System.Drawing.Size(203, 108);
            this.listBoxEscolas.TabIndex = 122;
            // 
            // numericUpDownLimite
            // 
            this.numericUpDownLimite.Location = new System.Drawing.Point(161, 226);
            this.numericUpDownLimite.Name = "numericUpDownLimite";
            this.numericUpDownLimite.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownLimite.TabIndex = 109;
            // 
            // numericUpDownIdadeInferior
            // 
            this.numericUpDownIdadeInferior.Location = new System.Drawing.Point(296, 226);
            this.numericUpDownIdadeInferior.Name = "numericUpDownIdadeInferior";
            this.numericUpDownIdadeInferior.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownIdadeInferior.TabIndex = 110;
            // 
            // numericUpDownIdadeSuperior
            // 
            this.numericUpDownIdadeSuperior.Location = new System.Drawing.Point(444, 226);
            this.numericUpDownIdadeSuperior.Name = "numericUpDownIdadeSuperior";
            this.numericUpDownIdadeSuperior.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownIdadeSuperior.TabIndex = 111;
            // 
            // buttonApagarEvento
            // 
            this.buttonApagarEvento.Image = ((System.Drawing.Image)(resources.GetObject("buttonApagarEvento.Image")));
            this.buttonApagarEvento.Location = new System.Drawing.Point(372, 265);
            this.buttonApagarEvento.Name = "buttonApagarEvento";
            this.buttonApagarEvento.Size = new System.Drawing.Size(33, 39);
            this.buttonApagarEvento.TabIndex = 114;
            this.buttonApagarEvento.UseVisualStyleBackColor = true;
            this.buttonApagarEvento.Click += new System.EventHandler(this.buttonApagarEvento_Click);
            // 
            // tbHoraEvento
            // 
            this.tbHoraEvento.Location = new System.Drawing.Point(410, 200);
            this.tbHoraEvento.Mask = "00 h : 00 min";
            this.tbHoraEvento.Name = "tbHoraEvento";
            this.tbHoraEvento.Size = new System.Drawing.Size(76, 20);
            this.tbHoraEvento.TabIndex = 108;
            // 
            // buttonAlterarEvento
            // 
            this.buttonAlterarEvento.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlterarEvento.Image")));
            this.buttonAlterarEvento.Location = new System.Drawing.Point(296, 267);
            this.buttonAlterarEvento.Name = "buttonAlterarEvento";
            this.buttonAlterarEvento.Size = new System.Drawing.Size(34, 35);
            this.buttonAlterarEvento.TabIndex = 113;
            this.buttonAlterarEvento.UseVisualStyleBackColor = true;
            this.buttonAlterarEvento.Click += new System.EventHandler(this.buttonAlterarEvento_Click);
            // 
            // buttonAdicionarEvento
            // 
            this.buttonAdicionarEvento.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarEvento.Image")));
            this.buttonAdicionarEvento.Location = new System.Drawing.Point(193, 267);
            this.buttonAdicionarEvento.Name = "buttonAdicionarEvento";
            this.buttonAdicionarEvento.Size = new System.Drawing.Size(43, 35);
            this.buttonAdicionarEvento.TabIndex = 112;
            this.buttonAdicionarEvento.UseVisualStyleBackColor = true;
            this.buttonAdicionarEvento.Click += new System.EventHandler(this.buttonAdicionarEvento_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(351, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 117;
            this.label9.Text = "Hora:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(117, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 116;
            this.label8.Text = "Data:";
            // 
            // dateTimePickerDataEvento
            // 
            this.dateTimePickerDataEvento.Location = new System.Drawing.Point(161, 200);
            this.dateTimePickerDataEvento.Name = "dateTimePickerDataEvento";
            this.dateTimePickerDataEvento.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerDataEvento.TabIndex = 107;
            // 
            // tbTipoEvento
            // 
            this.tbTipoEvento.Location = new System.Drawing.Point(161, 122);
            this.tbTipoEvento.Name = "tbTipoEvento";
            this.tbTipoEvento.Size = new System.Drawing.Size(325, 20);
            this.tbTipoEvento.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(57, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 115;
            this.label7.Text = "Tipo de Evento:";
            // 
            // tbLocalEvento
            // 
            this.tbLocalEvento.Location = new System.Drawing.Point(161, 174);
            this.tbLocalEvento.Name = "tbLocalEvento";
            this.tbLocalEvento.Size = new System.Drawing.Size(325, 20);
            this.tbLocalEvento.TabIndex = 105;
            // 
            // tbDescricaoEvento
            // 
            this.tbDescricaoEvento.Location = new System.Drawing.Point(161, 148);
            this.tbDescricaoEvento.Name = "tbDescricaoEvento";
            this.tbDescricaoEvento.Size = new System.Drawing.Size(325, 20);
            this.tbDescricaoEvento.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(344, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "Idade Superior:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(203, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 104;
            this.label4.Text = "Idade Inferior:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(13, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "Limite de Confirmações:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(113, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "Local:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(94, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Desrição:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(462, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 31);
            this.label12.TabIndex = 136;
            this.label12.Text = "Eventos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(593, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 137;
            this.label13.Text = "Participações";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(817, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 16);
            this.label14.TabIndex = 138;
            this.label14.Text = "Colaborações";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(807, 330);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 16);
            this.label15.TabIndex = 139;
            this.label15.Text = "Incrições";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(23, 345);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 16);
            this.label16.TabIndex = 140;
            this.label16.Text = "Lista de Eventos:";
            // 
            // labelTotalConfirmacoes
            // 
            this.labelTotalConfirmacoes.AutoSize = true;
            this.labelTotalConfirmacoes.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalConfirmacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalConfirmacoes.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalConfirmacoes.Location = new System.Drawing.Point(760, 623);
            this.labelTotalConfirmacoes.Name = "labelTotalConfirmacoes";
            this.labelTotalConfirmacoes.Size = new System.Drawing.Size(163, 13);
            this.labelTotalConfirmacoes.TabIndex = 141;
            this.labelTotalConfirmacoes.Text = "Número de Confirmações: 0";
            // 
            // buttonRetirarInscricao
            // 
            this.buttonRetirarInscricao.Location = new System.Drawing.Point(864, 405);
            this.buttonRetirarInscricao.Name = "buttonRetirarInscricao";
            this.buttonRetirarInscricao.Size = new System.Drawing.Size(107, 23);
            this.buttonRetirarInscricao.TabIndex = 142;
            this.buttonRetirarInscricao.Text = "Retirar Inscrição";
            this.buttonRetirarInscricao.UseVisualStyleBackColor = true;
            this.buttonRetirarInscricao.Click += new System.EventHandler(this.buttonRetirarInscricao_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
            this.menuStrip1.TabIndex = 143;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarListaDeInscriçõesToolStripMenuItem,
            this.fichaDeInscriçõesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // criarListaDeInscriçõesToolStripMenuItem
            // 
            this.criarListaDeInscriçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventoToolStripMenuItem});
            this.criarListaDeInscriçõesToolStripMenuItem.Name = "criarListaDeInscriçõesToolStripMenuItem";
            this.criarListaDeInscriçõesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.criarListaDeInscriçõesToolStripMenuItem.Text = "Novo";
            // 
            // eventoToolStripMenuItem
            // 
            this.eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            this.eventoToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.eventoToolStripMenuItem.Text = "Evento";
            this.eventoToolStripMenuItem.Click += new System.EventHandler(this.eventoToolStripMenuItem_Click);
            // 
            // fichaDeInscriçõesToolStripMenuItem
            // 
            this.fichaDeInscriçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeInscriçõesToolStripMenuItem,
            this.fichaDeInscriçõesToolStripMenuItem1});
            this.fichaDeInscriçõesToolStripMenuItem.Name = "fichaDeInscriçõesToolStripMenuItem";
            this.fichaDeInscriçõesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.fichaDeInscriçõesToolStripMenuItem.Text = "Guardar";
            // 
            // listaDeInscriçõesToolStripMenuItem
            // 
            this.listaDeInscriçõesToolStripMenuItem.Name = "listaDeInscriçõesToolStripMenuItem";
            this.listaDeInscriçõesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.listaDeInscriçõesToolStripMenuItem.Text = "Lista de Inscrições";
            this.listaDeInscriçõesToolStripMenuItem.Click += new System.EventHandler(this.listaDeInscriçõesToolStripMenuItem_Click);
            // 
            // fichaDeInscriçõesToolStripMenuItem1
            // 
            this.fichaDeInscriçõesToolStripMenuItem1.Name = "fichaDeInscriçõesToolStripMenuItem1";
            this.fichaDeInscriçõesToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.fichaDeInscriçõesToolStripMenuItem1.Text = "Ficha de Inscrições";
            this.fichaDeInscriçõesToolStripMenuItem1.Click += new System.EventHandler(this.fichaDeInscriçõesToolStripMenuItem1_Click);
            // 
            // FormularioEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 645);
            this.Controls.Add(this.buttonRetirarInscricao);
            this.Controls.Add(this.labelTotalConfirmacoes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonMaisFilhos);
            this.Controls.Add(this.checkedListBoxFilhos);
            this.Controls.Add(this.cbFilhos);
            this.Controls.Add(this.buttonInscrever);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listViewEventos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonApagarAnimador);
            this.Controls.Add(this.buttonAdicionarAnimador);
            this.Controls.Add(this.cbAnimadores);
            this.Controls.Add(this.listBoxAnimadores);
            this.Controls.Add(this.buttonMaisAnimadores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonApagarEscola);
            this.Controls.Add(this.buttonAdicionarEscola);
            this.Controls.Add(this.cbEscolas);
            this.Controls.Add(this.buttonMaisEscolas);
            this.Controls.Add(this.listBoxEscolas);
            this.Controls.Add(this.numericUpDownLimite);
            this.Controls.Add(this.numericUpDownIdadeInferior);
            this.Controls.Add(this.numericUpDownIdadeSuperior);
            this.Controls.Add(this.buttonApagarEvento);
            this.Controls.Add(this.tbHoraEvento);
            this.Controls.Add(this.buttonAlterarEvento);
            this.Controls.Add(this.buttonAdicionarEvento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerDataEvento);
            this.Controls.Add(this.tbTipoEvento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbLocalEvento);
            this.Controls.Add(this.tbDescricaoEvento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormularioEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Eventos";
            this.Activated += new System.EventHandler(this.FormularioEventos_Activated);
            this.Load += new System.EventHandler(this.FormularioEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdadeInferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdadeSuperior)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMaisFilhos;
        private System.Windows.Forms.CheckedListBox checkedListBoxFilhos;
        private System.Windows.Forms.ComboBox cbFilhos;
        private System.Windows.Forms.Button buttonInscrever;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listViewEventos;
        private System.Windows.Forms.ColumnHeader columnHeaderTipoEvento;
        private System.Windows.Forms.ColumnHeader columnHeaderDescricao;
        private System.Windows.Forms.ColumnHeader columnHeaderLocal;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.ColumnHeader columnHeaderLimite;
        private System.Windows.Forms.ColumnHeader columnHeaderIdadeInf;
        private System.Windows.Forms.ColumnHeader columnHeaderIdadeSup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonApagarAnimador;
        private System.Windows.Forms.Button buttonAdicionarAnimador;
        private System.Windows.Forms.ComboBox cbAnimadores;
        private System.Windows.Forms.ListBox listBoxAnimadores;
        private System.Windows.Forms.Button buttonMaisAnimadores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonApagarEscola;
        private System.Windows.Forms.Button buttonAdicionarEscola;
        private System.Windows.Forms.ComboBox cbEscolas;
        private System.Windows.Forms.Button buttonMaisEscolas;
        private System.Windows.Forms.ListBox listBoxEscolas;
        private System.Windows.Forms.NumericUpDown numericUpDownLimite;
        private System.Windows.Forms.NumericUpDown numericUpDownIdadeInferior;
        private System.Windows.Forms.NumericUpDown numericUpDownIdadeSuperior;
        private System.Windows.Forms.Button buttonApagarEvento;
        private System.Windows.Forms.MaskedTextBox tbHoraEvento;
        private System.Windows.Forms.Button buttonAlterarEvento;
        private System.Windows.Forms.Button buttonAdicionarEvento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataEvento;
        private System.Windows.Forms.TextBox tbTipoEvento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLocalEvento;
        private System.Windows.Forms.TextBox tbDescricaoEvento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelTotalConfirmacoes;
        private System.Windows.Forms.Button buttonRetirarInscricao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarListaDeInscriçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaDeInscriçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeInscriçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaDeInscriçõesToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_FichaInscricao;
    }
}