namespace Stand_Automoveis
{
    partial class GestorAluguer
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
            this.lbxCarrosAluguer = new System.Windows.Forms.ListBox();
            this.dtpRececao = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.tbxKms = new System.Windows.Forms.TextBox();
            this.gbxAluguer = new System.Windows.Forms.GroupBox();
            this.buttonOrdenarDescCarros = new System.Windows.Forms.Button();
            this.buttonOrdenarAscCarros = new System.Windows.Forms.Button();
            this.btnEditarCarroAluguer = new System.Windows.Forms.Button();
            this.btnEliminarCarroAluguer = new System.Windows.Forms.Button();
            this.btnAddCarro = new System.Windows.Forms.Button();
            this.tbxFiltrarCarrosAluguer = new System.Windows.Forms.TextBox();
            this.tbxFiltrarClientes = new System.Windows.Forms.TextBox();
            this.lbxClientes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxClientes = new System.Windows.Forms.GroupBox();
            this.buttonOrdenarDescClientes = new System.Windows.Forms.Button();
            this.buttonOrdenarCresClientes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarAluguer = new System.Windows.Forms.Button();
            this.btnEditarAluguer = new System.Windows.Forms.Button();
            this.btnAddAluguer = new System.Windows.Forms.Button();
            this.lbxAluguer = new System.Windows.Forms.ListBox();
            this.gbxAlugados = new System.Windows.Forms.GroupBox();
            this.btnInfAluguer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirHistoricoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxAluguer.SuspendLayout();
            this.gbxClientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxAlugados.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxCarrosAluguer
            // 
            this.lbxCarrosAluguer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxCarrosAluguer.FormattingEnabled = true;
            this.lbxCarrosAluguer.HorizontalScrollbar = true;
            this.lbxCarrosAluguer.Location = new System.Drawing.Point(6, 48);
            this.lbxCarrosAluguer.Name = "lbxCarrosAluguer";
            this.lbxCarrosAluguer.Size = new System.Drawing.Size(328, 407);
            this.lbxCarrosAluguer.TabIndex = 10;
            this.lbxCarrosAluguer.SelectedIndexChanged += new System.EventHandler(this.lbxListaCarrosAluguer_SelectedIndexChanged);
            // 
            // dtpRececao
            // 
            this.dtpRececao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpRececao.Location = new System.Drawing.Point(161, 101);
            this.dtpRececao.Name = "dtpRececao";
            this.dtpRececao.Size = new System.Drawing.Size(262, 20);
            this.dtpRececao.TabIndex = 3;
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEntrega.Location = new System.Drawing.Point(161, 75);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(262, 20);
            this.dtpEntrega.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data de Receção do veículo:";
            // 
            // tbxValor
            // 
            this.tbxValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxValor.Location = new System.Drawing.Point(161, 49);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(262, 20);
            this.tbxValor.TabIndex = 1;
            // 
            // tbxKms
            // 
            this.tbxKms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxKms.Location = new System.Drawing.Point(161, 21);
            this.tbxKms.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.tbxKms.Name = "tbxKms";
            this.tbxKms.Size = new System.Drawing.Size(262, 20);
            this.tbxKms.TabIndex = 0;
            // 
            // gbxAluguer
            // 
            this.gbxAluguer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxAluguer.Controls.Add(this.buttonOrdenarDescCarros);
            this.gbxAluguer.Controls.Add(this.buttonOrdenarAscCarros);
            this.gbxAluguer.Controls.Add(this.btnEditarCarroAluguer);
            this.gbxAluguer.Controls.Add(this.btnEliminarCarroAluguer);
            this.gbxAluguer.Controls.Add(this.btnAddCarro);
            this.gbxAluguer.Controls.Add(this.tbxFiltrarCarrosAluguer);
            this.gbxAluguer.Controls.Add(this.lbxCarrosAluguer);
            this.gbxAluguer.Location = new System.Drawing.Point(331, 27);
            this.gbxAluguer.Name = "gbxAluguer";
            this.gbxAluguer.Size = new System.Drawing.Size(340, 461);
            this.gbxAluguer.TabIndex = 2;
            this.gbxAluguer.TabStop = false;
            this.gbxAluguer.Text = "Carros para Aluguer";
            // 
            // buttonOrdenarDescCarros
            // 
            this.buttonOrdenarDescCarros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.buttonOrdenarDescCarros.FlatAppearance.BorderSize = 0;
            this.buttonOrdenarDescCarros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
            this.buttonOrdenarDescCarros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(156)))), ((int)(((byte)(178)))));
            this.buttonOrdenarDescCarros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrdenarDescCarros.Image = global::Stand_Automoveis.Properties.Resources.Download_grey_16x;
            this.buttonOrdenarDescCarros.Location = new System.Drawing.Point(191, 20);
            this.buttonOrdenarDescCarros.Name = "buttonOrdenarDescCarros";
            this.buttonOrdenarDescCarros.Size = new System.Drawing.Size(26, 23);
            this.buttonOrdenarDescCarros.TabIndex = 6;
            this.buttonOrdenarDescCarros.UseVisualStyleBackColor = false;
            this.buttonOrdenarDescCarros.Click += new System.EventHandler(this.ButtonOrdenarDescCarros_Click);
            // 
            // buttonOrdenarAscCarros
            // 
            this.buttonOrdenarAscCarros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.buttonOrdenarAscCarros.FlatAppearance.BorderSize = 0;
            this.buttonOrdenarAscCarros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
            this.buttonOrdenarAscCarros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(156)))), ((int)(((byte)(178)))));
            this.buttonOrdenarAscCarros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrdenarAscCarros.Image = global::Stand_Automoveis.Properties.Resources.Upload_gray_16x;
            this.buttonOrdenarAscCarros.Location = new System.Drawing.Point(161, 20);
            this.buttonOrdenarAscCarros.Margin = new System.Windows.Forms.Padding(2, 3, 1, 3);
            this.buttonOrdenarAscCarros.Name = "buttonOrdenarAscCarros";
            this.buttonOrdenarAscCarros.Size = new System.Drawing.Size(26, 23);
            this.buttonOrdenarAscCarros.TabIndex = 5;
            this.buttonOrdenarAscCarros.UseVisualStyleBackColor = false;
            this.buttonOrdenarAscCarros.Click += new System.EventHandler(this.ButtonOrdenarAscCarros_Click);
            // 
            // btnEditarCarroAluguer
            // 
            this.btnEditarCarroAluguer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarCarroAluguer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(179)))));
            this.btnEditarCarroAluguer.FlatAppearance.BorderSize = 0;
            this.btnEditarCarroAluguer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            this.btnEditarCarroAluguer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(153)))), ((int)(((byte)(42)))));
            this.btnEditarCarroAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCarroAluguer.Image = global::Stand_Automoveis.Properties.Resources.Edit_straight_16xLG;
            this.btnEditarCarroAluguer.Location = new System.Drawing.Point(276, 18);
            this.btnEditarCarroAluguer.Name = "btnEditarCarroAluguer";
            this.btnEditarCarroAluguer.Size = new System.Drawing.Size(26, 26);
            this.btnEditarCarroAluguer.TabIndex = 8;
            this.btnEditarCarroAluguer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCarroAluguer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarCarroAluguer.UseVisualStyleBackColor = false;
            this.btnEditarCarroAluguer.Click += new System.EventHandler(this.btnEditarCarroAluguer_Click);
            // 
            // btnEliminarCarroAluguer
            // 
            this.btnEliminarCarroAluguer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCarroAluguer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnEliminarCarroAluguer.FlatAppearance.BorderSize = 0;
            this.btnEliminarCarroAluguer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEliminarCarroAluguer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEliminarCarroAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCarroAluguer.Image = global::Stand_Automoveis.Properties.Resources.Cancel_16x;
            this.btnEliminarCarroAluguer.Location = new System.Drawing.Point(244, 18);
            this.btnEliminarCarroAluguer.Name = "btnEliminarCarroAluguer";
            this.btnEliminarCarroAluguer.Size = new System.Drawing.Size(26, 26);
            this.btnEliminarCarroAluguer.TabIndex = 7;
            this.btnEliminarCarroAluguer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarCarroAluguer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarCarroAluguer.UseVisualStyleBackColor = false;
            this.btnEliminarCarroAluguer.Click += new System.EventHandler(this.btnEliminarCarroAluguer_Click);
            // 
            // btnAddCarro
            // 
            this.btnAddCarro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.btnAddCarro.FlatAppearance.BorderSize = 0;
            this.btnAddCarro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(202)))), ((int)(((byte)(211)))));
            this.btnAddCarro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(141)))), ((int)(((byte)(153)))));
            this.btnAddCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCarro.Image = global::Stand_Automoveis.Properties.Resources.Add_grey_16x;
            this.btnAddCarro.Location = new System.Drawing.Point(308, 18);
            this.btnAddCarro.Name = "btnAddCarro";
            this.btnAddCarro.Size = new System.Drawing.Size(26, 26);
            this.btnAddCarro.TabIndex = 9;
            this.btnAddCarro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCarro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCarro.UseVisualStyleBackColor = false;
            this.btnAddCarro.Click += new System.EventHandler(this.btnAddCarro_Click);
            // 
            // tbxFiltrarCarrosAluguer
            // 
            this.tbxFiltrarCarrosAluguer.Location = new System.Drawing.Point(6, 22);
            this.tbxFiltrarCarrosAluguer.Name = "tbxFiltrarCarrosAluguer";
            this.tbxFiltrarCarrosAluguer.Size = new System.Drawing.Size(150, 20);
            this.tbxFiltrarCarrosAluguer.TabIndex = 4;
            this.tbxFiltrarCarrosAluguer.TextChanged += new System.EventHandler(this.TbxFiltrarCarrosAluguer_TextChanged);
            this.tbxFiltrarCarrosAluguer.Enter += new System.EventHandler(this.TbxFiltrarCarrosAluguer_Enter);
            this.tbxFiltrarCarrosAluguer.Leave += new System.EventHandler(this.TbxFiltrarCarrosAluguer_Leave);
            // 
            // tbxFiltrarClientes
            // 
            this.tbxFiltrarClientes.Location = new System.Drawing.Point(7, 22);
            this.tbxFiltrarClientes.Name = "tbxFiltrarClientes";
            this.tbxFiltrarClientes.Size = new System.Drawing.Size(246, 20);
            this.tbxFiltrarClientes.TabIndex = 0;
            this.tbxFiltrarClientes.TextChanged += new System.EventHandler(this.TbxFiltrarClientes_TextChanged);
            this.tbxFiltrarClientes.Enter += new System.EventHandler(this.TbxFiltrarClientes_Enter);
            this.tbxFiltrarClientes.Leave += new System.EventHandler(this.TbxFiltrarClientes_Leave);
            // 
            // lbxClientes
            // 
            this.lbxClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxClientes.FormattingEnabled = true;
            this.lbxClientes.Location = new System.Drawing.Point(6, 48);
            this.lbxClientes.Name = "lbxClientes";
            this.lbxClientes.Size = new System.Drawing.Size(308, 407);
            this.lbxClientes.TabIndex = 3;
            this.lbxClientes.SelectedIndexChanged += new System.EventHandler(this.lbxClientes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de Quilómetros:";
            // 
            // gbxClientes
            // 
            this.gbxClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxClientes.Controls.Add(this.buttonOrdenarDescClientes);
            this.gbxClientes.Controls.Add(this.buttonOrdenarCresClientes);
            this.gbxClientes.Controls.Add(this.tbxFiltrarClientes);
            this.gbxClientes.Controls.Add(this.lbxClientes);
            this.gbxClientes.Location = new System.Drawing.Point(5, 27);
            this.gbxClientes.Name = "gbxClientes";
            this.gbxClientes.Size = new System.Drawing.Size(320, 461);
            this.gbxClientes.TabIndex = 1;
            this.gbxClientes.TabStop = false;
            this.gbxClientes.Text = "Clientes";
            // 
            // buttonOrdenarDescClientes
            // 
            this.buttonOrdenarDescClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.buttonOrdenarDescClientes.FlatAppearance.BorderSize = 0;
            this.buttonOrdenarDescClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
            this.buttonOrdenarDescClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(156)))), ((int)(((byte)(178)))));
            this.buttonOrdenarDescClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrdenarDescClientes.Image = global::Stand_Automoveis.Properties.Resources.Download_grey_16x;
            this.buttonOrdenarDescClientes.Location = new System.Drawing.Point(288, 20);
            this.buttonOrdenarDescClientes.Name = "buttonOrdenarDescClientes";
            this.buttonOrdenarDescClientes.Size = new System.Drawing.Size(26, 23);
            this.buttonOrdenarDescClientes.TabIndex = 2;
            this.buttonOrdenarDescClientes.UseVisualStyleBackColor = false;
            this.buttonOrdenarDescClientes.Click += new System.EventHandler(this.ButtonOrdenarDescClientes_Click);
            // 
            // buttonOrdenarCresClientes
            // 
            this.buttonOrdenarCresClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.buttonOrdenarCresClientes.FlatAppearance.BorderSize = 0;
            this.buttonOrdenarCresClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
            this.buttonOrdenarCresClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(156)))), ((int)(((byte)(178)))));
            this.buttonOrdenarCresClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrdenarCresClientes.Image = global::Stand_Automoveis.Properties.Resources.Upload_gray_16x;
            this.buttonOrdenarCresClientes.Location = new System.Drawing.Point(258, 20);
            this.buttonOrdenarCresClientes.Margin = new System.Windows.Forms.Padding(2, 3, 1, 3);
            this.buttonOrdenarCresClientes.Name = "buttonOrdenarCresClientes";
            this.buttonOrdenarCresClientes.Size = new System.Drawing.Size(26, 23);
            this.buttonOrdenarCresClientes.TabIndex = 1;
            this.buttonOrdenarCresClientes.UseVisualStyleBackColor = false;
            this.buttonOrdenarCresClientes.Click += new System.EventHandler(this.ButtonOrdenarCresClientes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor do Aluguer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Entrega do veículo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnEliminarAluguer);
            this.groupBox1.Controls.Add(this.dtpRececao);
            this.groupBox1.Controls.Add(this.dtpEntrega);
            this.groupBox1.Controls.Add(this.btnEditarAluguer);
            this.groupBox1.Controls.Add(this.btnAddAluguer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxValor);
            this.groupBox1.Controls.Add(this.tbxKms);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(677, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do aluguer";
            // 
            // btnEliminarAluguer
            // 
            this.btnEliminarAluguer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarAluguer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnEliminarAluguer.FlatAppearance.BorderSize = 0;
            this.btnEliminarAluguer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEliminarAluguer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEliminarAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAluguer.Image = global::Stand_Automoveis.Properties.Resources.Cancel_16x;
            this.btnEliminarAluguer.Location = new System.Drawing.Point(435, 81);
            this.btnEliminarAluguer.Name = "btnEliminarAluguer";
            this.btnEliminarAluguer.Size = new System.Drawing.Size(26, 26);
            this.btnEliminarAluguer.TabIndex = 6;
            this.btnEliminarAluguer.UseVisualStyleBackColor = false;
            this.btnEliminarAluguer.Click += new System.EventHandler(this.BtnEliminarAluguer_Click);
            // 
            // btnEditarAluguer
            // 
            this.btnEditarAluguer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditarAluguer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(179)))));
            this.btnEditarAluguer.FlatAppearance.BorderSize = 0;
            this.btnEditarAluguer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            this.btnEditarAluguer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(153)))), ((int)(((byte)(42)))));
            this.btnEditarAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAluguer.Image = global::Stand_Automoveis.Properties.Resources.Edit_straight_16xLG;
            this.btnEditarAluguer.Location = new System.Drawing.Point(435, 49);
            this.btnEditarAluguer.Name = "btnEditarAluguer";
            this.btnEditarAluguer.Size = new System.Drawing.Size(26, 26);
            this.btnEditarAluguer.TabIndex = 5;
            this.btnEditarAluguer.UseVisualStyleBackColor = false;
            this.btnEditarAluguer.Click += new System.EventHandler(this.btnEditarAluguer_Click);
            // 
            // btnAddAluguer
            // 
            this.btnAddAluguer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddAluguer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.btnAddAluguer.FlatAppearance.BorderSize = 0;
            this.btnAddAluguer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(202)))), ((int)(((byte)(211)))));
            this.btnAddAluguer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(141)))), ((int)(((byte)(153)))));
            this.btnAddAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAluguer.Image = global::Stand_Automoveis.Properties.Resources.Add_grey_16x;
            this.btnAddAluguer.Location = new System.Drawing.Point(435, 17);
            this.btnAddAluguer.Name = "btnAddAluguer";
            this.btnAddAluguer.Size = new System.Drawing.Size(26, 26);
            this.btnAddAluguer.TabIndex = 4;
            this.btnAddAluguer.UseVisualStyleBackColor = false;
            this.btnAddAluguer.Click += new System.EventHandler(this.btnAddAluguer_Click);
            // 
            // lbxAluguer
            // 
            this.lbxAluguer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxAluguer.FormattingEnabled = true;
            this.lbxAluguer.HorizontalScrollbar = true;
            this.lbxAluguer.Location = new System.Drawing.Point(9, 19);
            this.lbxAluguer.Name = "lbxAluguer";
            this.lbxAluguer.Size = new System.Drawing.Size(446, 264);
            this.lbxAluguer.TabIndex = 0;
            this.lbxAluguer.SelectedIndexChanged += new System.EventHandler(this.lbxAluguer_SelectedIndexChanged);
            // 
            // gbxAlugados
            // 
            this.gbxAlugados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAlugados.Controls.Add(this.btnInfAluguer);
            this.gbxAlugados.Controls.Add(this.lbxAluguer);
            this.gbxAlugados.Location = new System.Drawing.Point(677, 163);
            this.gbxAlugados.Name = "gbxAlugados";
            this.gbxAlugados.Size = new System.Drawing.Size(467, 325);
            this.gbxAlugados.TabIndex = 4;
            this.gbxAlugados.TabStop = false;
            this.gbxAlugados.Text = "Carros Alugados";
            // 
            // btnInfAluguer
            // 
            this.btnInfAluguer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfAluguer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.btnInfAluguer.FlatAppearance.BorderSize = 0;
            this.btnInfAluguer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(234)))), ((int)(((byte)(146)))));
            this.btnInfAluguer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(191)))), ((int)(((byte)(97)))));
            this.btnInfAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfAluguer.Image = global::Stand_Automoveis.Properties.Resources.StatusInformation_grey_16x;
            this.btnInfAluguer.Location = new System.Drawing.Point(9, 294);
            this.btnInfAluguer.Name = "btnInfAluguer";
            this.btnInfAluguer.Size = new System.Drawing.Size(446, 26);
            this.btnInfAluguer.TabIndex = 1;
            this.btnInfAluguer.Text = "Informações sobre o aluguer";
            this.btnInfAluguer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfAluguer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfAluguer.UseVisualStyleBackColor = false;
            this.btnInfAluguer.Click += new System.EventHandler(this.ButtonInformacoesAluguer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.aluguerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem,
            this.imprimirHistoricoClienteToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.limparDadosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // imprimirHistoricoClienteToolStripMenuItem
            // 
            this.imprimirHistoricoClienteToolStripMenuItem.Name = "imprimirHistoricoClienteToolStripMenuItem";
            this.imprimirHistoricoClienteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.imprimirHistoricoClienteToolStripMenuItem.Text = "Imprimir Historico Cliente";
            this.imprimirHistoricoClienteToolStripMenuItem.Click += new System.EventHandler(this.imprimirHistoricoClienteToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // limparDadosToolStripMenuItem
            // 
            this.limparDadosToolStripMenuItem.Name = "limparDadosToolStripMenuItem";
            this.limparDadosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.limparDadosToolStripMenuItem.Text = "Limpar Dados";
            this.limparDadosToolStripMenuItem.Click += new System.EventHandler(this.limparSelecaoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // aluguerToolStripMenuItem
            // 
            this.aluguerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarCarroToolStripMenuItem,
            this.editarCarroToolStripMenuItem,
            this.eliminarCarroToolStripMenuItem});
            this.aluguerToolStripMenuItem.Name = "aluguerToolStripMenuItem";
            this.aluguerToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aluguerToolStripMenuItem.Text = "Carro";
            // 
            // criarCarroToolStripMenuItem
            // 
            this.criarCarroToolStripMenuItem.Name = "criarCarroToolStripMenuItem";
            this.criarCarroToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.criarCarroToolStripMenuItem.Text = "Criar Carro";
            this.criarCarroToolStripMenuItem.Click += new System.EventHandler(this.adicionarCarroToolStripMenuItem_Click);
            // 
            // editarCarroToolStripMenuItem
            // 
            this.editarCarroToolStripMenuItem.Name = "editarCarroToolStripMenuItem";
            this.editarCarroToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editarCarroToolStripMenuItem.Text = "Editar Carro";
            this.editarCarroToolStripMenuItem.Click += new System.EventHandler(this.editarCarroToolStripMenuItem_Click);
            // 
            // eliminarCarroToolStripMenuItem
            // 
            this.eliminarCarroToolStripMenuItem.Name = "eliminarCarroToolStripMenuItem";
            this.eliminarCarroToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.eliminarCarroToolStripMenuItem.Text = "Eliminar Carro";
            this.eliminarCarroToolStripMenuItem.Click += new System.EventHandler(this.eliminarCarroToolStripMenuItem_Click);
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // GestorAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 491);
            this.Controls.Add(this.gbxAluguer);
            this.Controls.Add(this.gbxClientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxAlugados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestorAluguer";
            this.ShowIcon = false;
            this.Text = "Gestão de Alugueres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestorAluguer_FormClosing);
            this.gbxAluguer.ResumeLayout(false);
            this.gbxAluguer.PerformLayout();
            this.gbxClientes.ResumeLayout(false);
            this.gbxClientes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxAlugados.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarCarroAluguer;
        private System.Windows.Forms.Button btnAddCarro;
        public System.Windows.Forms.ListBox lbxCarrosAluguer;
        private System.Windows.Forms.Button btnEliminarAluguer;
        private System.Windows.Forms.DateTimePicker dtpRececao;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.Button btnEditarAluguer;
        private System.Windows.Forms.Button btnAddAluguer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.TextBox tbxKms;
        private System.Windows.Forms.Button btnEditarCarroAluguer;
        private System.Windows.Forms.GroupBox gbxAluguer;
        private System.Windows.Forms.TextBox tbxFiltrarCarrosAluguer;
        private System.Windows.Forms.TextBox tbxFiltrarClientes;
        private System.Windows.Forms.ListBox lbxClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInfAluguer;
        public System.Windows.Forms.ListBox lbxAluguer;
        private System.Windows.Forms.GroupBox gbxAlugados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aluguerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirHistoricoClienteToolStripMenuItem;
        private System.Windows.Forms.Button buttonOrdenarDescClientes;
        private System.Windows.Forms.Button buttonOrdenarCresClientes;
        private System.Windows.Forms.Button buttonOrdenarDescCarros;
        private System.Windows.Forms.Button buttonOrdenarAscCarros;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
    }
}