namespace Stand_Automoveis
{
    partial class GestorVenda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarVenda = new System.Windows.Forms.Button();
            this.dtpdataVenda = new System.Windows.Forms.DateTimePicker();
            this.btnEditarVenda = new System.Windows.Forms.Button();
            this.btnAddVenda = new System.Windows.Forms.Button();
            this.tbxValorVenda = new System.Windows.Forms.TextBox();
            this.tbxestadoVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxVendas = new System.Windows.Forms.ListBox();
            this.gbxAlugados = new System.Windows.Forms.GroupBox();
            this.btnInfVenda = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirHistoricoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxClientes = new System.Windows.Forms.GroupBox();
            this.buttonOrdenarDescClientes = new System.Windows.Forms.Button();
            this.buttonOrdenarCresClientes = new System.Windows.Forms.Button();
            this.tbxFiltrarClientes = new System.Windows.Forms.TextBox();
            this.lbxClientes = new System.Windows.Forms.ListBox();
            this.btnEditarCarroVenda = new System.Windows.Forms.Button();
            this.btnEliminarCarroVenda = new System.Windows.Forms.Button();
            this.btnAddCarroVenda = new System.Windows.Forms.Button();
            this.tbxFiltrarCarrosVenda = new System.Windows.Forms.TextBox();
            this.lbxCarrosVenda = new System.Windows.Forms.ListBox();
            this.gbxAluguer = new System.Windows.Forms.GroupBox();
            this.buttonOrdenarDescCarros = new System.Windows.Forms.Button();
            this.buttonOrdenarAscCarros = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbxAlugados.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbxClientes.SuspendLayout();
            this.gbxAluguer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnEliminarVenda);
            this.groupBox1.Controls.Add(this.dtpdataVenda);
            this.groupBox1.Controls.Add(this.btnEditarVenda);
            this.groupBox1.Controls.Add(this.btnAddVenda);
            this.groupBox1.Controls.Add(this.tbxValorVenda);
            this.groupBox1.Controls.Add(this.tbxestadoVenda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(687, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Venda";
            // 
            // btnEliminarVenda
            // 
            this.btnEliminarVenda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnEliminarVenda.FlatAppearance.BorderSize = 0;
            this.btnEliminarVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEliminarVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEliminarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVenda.Image = global::Stand_Automoveis.Properties.Resources.Cancel_16x;
            this.btnEliminarVenda.Location = new System.Drawing.Point(426, 79);
            this.btnEliminarVenda.Name = "btnEliminarVenda";
            this.btnEliminarVenda.Size = new System.Drawing.Size(26, 26);
            this.btnEliminarVenda.TabIndex = 5;
            this.btnEliminarVenda.UseVisualStyleBackColor = false;
            this.btnEliminarVenda.Click += new System.EventHandler(this.btnEliminarAluguer_Click);
            // 
            // dtpdataVenda
            // 
            this.dtpdataVenda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpdataVenda.Location = new System.Drawing.Point(110, 79);
            this.dtpdataVenda.Name = "dtpdataVenda";
            this.dtpdataVenda.Size = new System.Drawing.Size(304, 20);
            this.dtpdataVenda.TabIndex = 2;
            // 
            // btnEditarVenda
            // 
            this.btnEditarVenda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(179)))));
            this.btnEditarVenda.FlatAppearance.BorderSize = 0;
            this.btnEditarVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            this.btnEditarVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(153)))), ((int)(((byte)(42)))));
            this.btnEditarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarVenda.Image = global::Stand_Automoveis.Properties.Resources.Edit_straight_16xLG;
            this.btnEditarVenda.Location = new System.Drawing.Point(426, 49);
            this.btnEditarVenda.Name = "btnEditarVenda";
            this.btnEditarVenda.Size = new System.Drawing.Size(26, 26);
            this.btnEditarVenda.TabIndex = 4;
            this.btnEditarVenda.UseVisualStyleBackColor = false;
            this.btnEditarVenda.Click += new System.EventHandler(this.btnEditarVenda_Click);
            // 
            // btnAddVenda
            // 
            this.btnAddVenda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.btnAddVenda.FlatAppearance.BorderSize = 0;
            this.btnAddVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(202)))), ((int)(((byte)(211)))));
            this.btnAddVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(141)))), ((int)(((byte)(153)))));
            this.btnAddVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVenda.Image = global::Stand_Automoveis.Properties.Resources.Add_grey_16x;
            this.btnAddVenda.Location = new System.Drawing.Point(426, 16);
            this.btnAddVenda.Name = "btnAddVenda";
            this.btnAddVenda.Size = new System.Drawing.Size(26, 26);
            this.btnAddVenda.TabIndex = 3;
            this.btnAddVenda.UseVisualStyleBackColor = false;
            this.btnAddVenda.Click += new System.EventHandler(this.btnAddVenda_Click);
            // 
            // tbxValorVenda
            // 
            this.tbxValorVenda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxValorVenda.Location = new System.Drawing.Point(110, 53);
            this.tbxValorVenda.Name = "tbxValorVenda";
            this.tbxValorVenda.Size = new System.Drawing.Size(304, 20);
            this.tbxValorVenda.TabIndex = 1;
            // 
            // tbxestadoVenda
            // 
            this.tbxestadoVenda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxestadoVenda.Location = new System.Drawing.Point(110, 27);
            this.tbxestadoVenda.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.tbxestadoVenda.Name = "tbxestadoVenda";
            this.tbxestadoVenda.Size = new System.Drawing.Size(304, 20);
            this.tbxestadoVenda.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado da Venda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor da Venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Venda:";
            // 
            // lbxVendas
            // 
            this.lbxVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxVendas.FormattingEnabled = true;
            this.lbxVendas.HorizontalScrollbar = true;
            this.lbxVendas.Location = new System.Drawing.Point(9, 19);
            this.lbxVendas.Name = "lbxVendas";
            this.lbxVendas.Size = new System.Drawing.Size(443, 277);
            this.lbxVendas.TabIndex = 0;
            this.lbxVendas.SelectedIndexChanged += new System.EventHandler(this.lbxVendas_SelectedIndexChanged);
            // 
            // gbxAlugados
            // 
            this.gbxAlugados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAlugados.Controls.Add(this.btnInfVenda);
            this.gbxAlugados.Controls.Add(this.lbxVendas);
            this.gbxAlugados.Location = new System.Drawing.Point(687, 154);
            this.gbxAlugados.Name = "gbxAlugados";
            this.gbxAlugados.Size = new System.Drawing.Size(458, 334);
            this.gbxAlugados.TabIndex = 4;
            this.gbxAlugados.TabStop = false;
            this.gbxAlugados.Text = "Vendas";
            // 
            // btnInfVenda
            // 
            this.btnInfVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.btnInfVenda.FlatAppearance.BorderSize = 0;
            this.btnInfVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(234)))), ((int)(((byte)(146)))));
            this.btnInfVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(191)))), ((int)(((byte)(97)))));
            this.btnInfVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfVenda.Image = global::Stand_Automoveis.Properties.Resources.StatusInformation_grey_16x;
            this.btnInfVenda.Location = new System.Drawing.Point(9, 302);
            this.btnInfVenda.Name = "btnInfVenda";
            this.btnInfVenda.Size = new System.Drawing.Size(443, 26);
            this.btnInfVenda.TabIndex = 1;
            this.btnInfVenda.Text = "Informações sobre a Venda";
            this.btnInfVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfVenda.UseVisualStyleBackColor = false;
            this.btnInfVenda.Click += new System.EventHandler(this.btnInfVenda_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.aluguerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirHistoricoClienteToolStripMenuItem,
            this.novoClienteToolStripMenuItem,
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
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
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
            this.limparDadosToolStripMenuItem.Click += new System.EventHandler(this.limparDadosToolStripMenuItem_Click);
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
            this.criarCarroToolStripMenuItem.Click += new System.EventHandler(this.criarCarroToolStripMenuItem_Click);
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
            // gbxClientes
            // 
            this.gbxClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxClientes.Controls.Add(this.buttonOrdenarDescClientes);
            this.gbxClientes.Controls.Add(this.buttonOrdenarCresClientes);
            this.gbxClientes.Controls.Add(this.tbxFiltrarClientes);
            this.gbxClientes.Controls.Add(this.lbxClientes);
            this.gbxClientes.Location = new System.Drawing.Point(6, 27);
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
            this.buttonOrdenarDescClientes.Location = new System.Drawing.Point(284, 20);
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
            this.buttonOrdenarCresClientes.Location = new System.Drawing.Point(254, 20);
            this.buttonOrdenarCresClientes.Margin = new System.Windows.Forms.Padding(2, 3, 1, 3);
            this.buttonOrdenarCresClientes.Name = "buttonOrdenarCresClientes";
            this.buttonOrdenarCresClientes.Size = new System.Drawing.Size(26, 23);
            this.buttonOrdenarCresClientes.TabIndex = 1;
            this.buttonOrdenarCresClientes.UseVisualStyleBackColor = false;
            this.buttonOrdenarCresClientes.Click += new System.EventHandler(this.ButtonOrdenarCresClientes_Click);
            // 
            // tbxFiltrarClientes
            // 
            this.tbxFiltrarClientes.Location = new System.Drawing.Point(7, 22);
            this.tbxFiltrarClientes.Name = "tbxFiltrarClientes";
            this.tbxFiltrarClientes.Size = new System.Drawing.Size(242, 20);
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
            this.lbxClientes.Size = new System.Drawing.Size(304, 407);
            this.lbxClientes.TabIndex = 3;
            this.lbxClientes.SelectedIndexChanged += new System.EventHandler(this.lbxClientes_SelectedIndexChanged);
            // 
            // btnEditarCarroVenda
            // 
            this.btnEditarCarroVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(179)))));
            this.btnEditarCarroVenda.FlatAppearance.BorderSize = 0;
            this.btnEditarCarroVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            this.btnEditarCarroVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(153)))), ((int)(((byte)(42)))));
            this.btnEditarCarroVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCarroVenda.Image = global::Stand_Automoveis.Properties.Resources.Edit_straight_16xLG;
            this.btnEditarCarroVenda.Location = new System.Drawing.Point(285, 18);
            this.btnEditarCarroVenda.Name = "btnEditarCarroVenda";
            this.btnEditarCarroVenda.Size = new System.Drawing.Size(26, 26);
            this.btnEditarCarroVenda.TabIndex = 4;
            this.btnEditarCarroVenda.UseVisualStyleBackColor = false;
            this.btnEditarCarroVenda.Click += new System.EventHandler(this.btnEditarCarroAluguer_Click);
            // 
            // btnEliminarCarroVenda
            // 
            this.btnEliminarCarroVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnEliminarCarroVenda.FlatAppearance.BorderSize = 0;
            this.btnEliminarCarroVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnEliminarCarroVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEliminarCarroVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCarroVenda.Image = global::Stand_Automoveis.Properties.Resources.Cancel_16x;
            this.btnEliminarCarroVenda.Location = new System.Drawing.Point(253, 18);
            this.btnEliminarCarroVenda.Name = "btnEliminarCarroVenda";
            this.btnEliminarCarroVenda.Size = new System.Drawing.Size(26, 26);
            this.btnEliminarCarroVenda.TabIndex = 3;
            this.btnEliminarCarroVenda.UseVisualStyleBackColor = false;
            this.btnEliminarCarroVenda.Click += new System.EventHandler(this.btnEliminarCarroAluguer_Click);
            // 
            // btnAddCarroVenda
            // 
            this.btnAddCarroVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.btnAddCarroVenda.FlatAppearance.BorderSize = 0;
            this.btnAddCarroVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(202)))), ((int)(((byte)(211)))));
            this.btnAddCarroVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(141)))), ((int)(((byte)(153)))));
            this.btnAddCarroVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCarroVenda.Image = global::Stand_Automoveis.Properties.Resources.Add_grey_16x;
            this.btnAddCarroVenda.Location = new System.Drawing.Point(317, 18);
            this.btnAddCarroVenda.Name = "btnAddCarroVenda";
            this.btnAddCarroVenda.Size = new System.Drawing.Size(26, 26);
            this.btnAddCarroVenda.TabIndex = 5;
            this.btnAddCarroVenda.UseVisualStyleBackColor = false;
            this.btnAddCarroVenda.Click += new System.EventHandler(this.btnAddCarro_Click);
            // 
            // tbxFiltrarCarrosVenda
            // 
            this.tbxFiltrarCarrosVenda.Location = new System.Drawing.Point(6, 23);
            this.tbxFiltrarCarrosVenda.Name = "tbxFiltrarCarrosVenda";
            this.tbxFiltrarCarrosVenda.Size = new System.Drawing.Size(160, 20);
            this.tbxFiltrarCarrosVenda.TabIndex = 0;
            this.tbxFiltrarCarrosVenda.TextChanged += new System.EventHandler(this.TbxFiltrarCarrosVenda_TextChanged);
            this.tbxFiltrarCarrosVenda.Enter += new System.EventHandler(this.TbxFiltrarCarrosVenda_Enter);
            this.tbxFiltrarCarrosVenda.Leave += new System.EventHandler(this.TbxFiltrarCarrosVenda_Leave);
            // 
            // lbxCarrosVenda
            // 
            this.lbxCarrosVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxCarrosVenda.FormattingEnabled = true;
            this.lbxCarrosVenda.HorizontalScrollbar = true;
            this.lbxCarrosVenda.Location = new System.Drawing.Point(6, 48);
            this.lbxCarrosVenda.Name = "lbxCarrosVenda";
            this.lbxCarrosVenda.Size = new System.Drawing.Size(337, 407);
            this.lbxCarrosVenda.TabIndex = 6;
            this.lbxCarrosVenda.SelectedIndexChanged += new System.EventHandler(this.lbxCarrosVenda_SelectedIndexChanged);
            // 
            // gbxAluguer
            // 
            this.gbxAluguer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxAluguer.Controls.Add(this.buttonOrdenarDescCarros);
            this.gbxAluguer.Controls.Add(this.buttonOrdenarAscCarros);
            this.gbxAluguer.Controls.Add(this.btnEditarCarroVenda);
            this.gbxAluguer.Controls.Add(this.btnEliminarCarroVenda);
            this.gbxAluguer.Controls.Add(this.btnAddCarroVenda);
            this.gbxAluguer.Controls.Add(this.tbxFiltrarCarrosVenda);
            this.gbxAluguer.Controls.Add(this.lbxCarrosVenda);
            this.gbxAluguer.Location = new System.Drawing.Point(332, 27);
            this.gbxAluguer.Name = "gbxAluguer";
            this.gbxAluguer.Size = new System.Drawing.Size(349, 461);
            this.gbxAluguer.TabIndex = 2;
            this.gbxAluguer.TabStop = false;
            this.gbxAluguer.Text = "Carros para Vender";
            // 
            // buttonOrdenarDescCarros
            // 
            this.buttonOrdenarDescCarros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.buttonOrdenarDescCarros.FlatAppearance.BorderSize = 0;
            this.buttonOrdenarDescCarros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
            this.buttonOrdenarDescCarros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(156)))), ((int)(((byte)(178)))));
            this.buttonOrdenarDescCarros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrdenarDescCarros.Image = global::Stand_Automoveis.Properties.Resources.Download_grey_16x;
            this.buttonOrdenarDescCarros.Location = new System.Drawing.Point(201, 20);
            this.buttonOrdenarDescCarros.Name = "buttonOrdenarDescCarros";
            this.buttonOrdenarDescCarros.Size = new System.Drawing.Size(26, 23);
            this.buttonOrdenarDescCarros.TabIndex = 2;
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
            this.buttonOrdenarAscCarros.Location = new System.Drawing.Point(171, 20);
            this.buttonOrdenarAscCarros.Margin = new System.Windows.Forms.Padding(2, 3, 1, 3);
            this.buttonOrdenarAscCarros.Name = "buttonOrdenarAscCarros";
            this.buttonOrdenarAscCarros.Size = new System.Drawing.Size(26, 23);
            this.buttonOrdenarAscCarros.TabIndex = 1;
            this.buttonOrdenarAscCarros.UseVisualStyleBackColor = false;
            this.buttonOrdenarAscCarros.Click += new System.EventHandler(this.ButtonOrdenarAscCarros_Click);
            // 
            // GestorVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxAlugados);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbxClientes);
            this.Controls.Add(this.gbxAluguer);
            this.Name = "GestorVenda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Vendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestorVenda_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxAlugados.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxClientes.ResumeLayout(false);
            this.gbxClientes.PerformLayout();
            this.gbxAluguer.ResumeLayout(false);
            this.gbxAluguer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarVenda;
        private System.Windows.Forms.DateTimePicker dtpdataVenda;
        private System.Windows.Forms.Button btnEditarVenda;
        private System.Windows.Forms.Button btnAddVenda;
        private System.Windows.Forms.TextBox tbxValorVenda;
        private System.Windows.Forms.TextBox tbxestadoVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox lbxVendas;
        private System.Windows.Forms.GroupBox gbxAlugados;
        private System.Windows.Forms.Button btnInfVenda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aluguerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCarroToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxClientes;
        private System.Windows.Forms.TextBox tbxFiltrarClientes;
        private System.Windows.Forms.ListBox lbxClientes;
        private System.Windows.Forms.Button btnEditarCarroVenda;
        private System.Windows.Forms.Button btnEliminarCarroVenda;
        private System.Windows.Forms.Button btnAddCarroVenda;
        private System.Windows.Forms.TextBox tbxFiltrarCarrosVenda;
        public System.Windows.Forms.ListBox lbxCarrosVenda;
        private System.Windows.Forms.GroupBox gbxAluguer;
        private System.Windows.Forms.ToolStripMenuItem imprimirHistoricoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.Button buttonOrdenarDescClientes;
        private System.Windows.Forms.Button buttonOrdenarCresClientes;
        private System.Windows.Forms.Button buttonOrdenarDescCarros;
        private System.Windows.Forms.Button buttonOrdenarAscCarros;
    }
}