namespace Stand_Automoveis
{
    partial class GestorCliente
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbxClientes = new System.Windows.Forms.ListBox();
            this.gbxClientes = new System.Windows.Forms.GroupBox();
            this.buttonOrdenarDesc = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.buttonOrdenarCres = new System.Windows.Forms.Button();
            this.btnCriarCliente = new System.Windows.Forms.Button();
            this.tbxFiltrar = new System.Windows.Forms.TextBox();
            this.gbxDadosCliente = new System.Windows.Forms.GroupBox();
            this.gbxInformacaoCliente = new System.Windows.Forms.GroupBox();
            this.lblShowNif = new System.Windows.Forms.Label();
            this.lblShowNome = new System.Windows.Forms.Label();
            this.lblShowMorada = new System.Windows.Forms.Label();
            this.lblShowContacto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumCarrosComprados = new System.Windows.Forms.Label();
            this.lblNumCarroAluguer = new System.Windows.Forms.Label();
            this.lblNumCarrosOficina = new System.Windows.Forms.Label();
            this.lblNumCarrosCompradosTexto = new System.Windows.Forms.Label();
            this.lblNumCarroAluguerText = new System.Windows.Forms.Label();
            this.lblNumCarrosOficinaText = new System.Windows.Forms.Label();
            this.panelEditarCliente = new System.Windows.Forms.Panel();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.tbAlterarNif = new System.Windows.Forms.TextBox();
            this.lblNif = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.tbAlterarMorada = new System.Windows.Forms.TextBox();
            this.tbAlterarContacto = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.tbAlterarNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbxClientes.SuspendLayout();
            this.gbxDadosCliente.SuspendLayout();
            this.gbxInformacaoCliente.SuspendLayout();
            this.panelEditarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.limparDadosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.NovoClienteToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // limparDadosToolStripMenuItem
            // 
            this.limparDadosToolStripMenuItem.Name = "limparDadosToolStripMenuItem";
            this.limparDadosToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.limparDadosToolStripMenuItem.Text = "Limpar Dados";
            this.limparDadosToolStripMenuItem.Click += new System.EventHandler(this.LimparDadosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // lbxClientes
            // 
            this.lbxClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxClientes.FormattingEnabled = true;
            this.lbxClientes.HorizontalScrollbar = true;
            this.lbxClientes.Location = new System.Drawing.Point(6, 39);
            this.lbxClientes.Name = "lbxClientes";
            this.lbxClientes.Size = new System.Drawing.Size(275, 368);
            this.lbxClientes.TabIndex = 0;
            this.lbxClientes.SelectedIndexChanged += new System.EventHandler(this.lblListaClientes_SelectedIndexChanged);
            // 
            // gbxClientes
            // 
            this.gbxClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxClientes.Controls.Add(this.buttonOrdenarDesc);
            this.gbxClientes.Controls.Add(this.btnEliminarCliente);
            this.gbxClientes.Controls.Add(this.buttonOrdenarCres);
            this.gbxClientes.Controls.Add(this.lbxClientes);
            this.gbxClientes.Controls.Add(this.btnCriarCliente);
            this.gbxClientes.Controls.Add(this.tbxFiltrar);
            this.gbxClientes.Location = new System.Drawing.Point(12, 27);
            this.gbxClientes.Name = "gbxClientes";
            this.gbxClientes.Size = new System.Drawing.Size(287, 419);
            this.gbxClientes.TabIndex = 2;
            this.gbxClientes.TabStop = false;
            this.gbxClientes.Text = "Clientes";
            // 
            // buttonOrdenarDesc
            // 
            this.buttonOrdenarDesc.Image = global::Stand_Automoveis.Properties.Resources.Download_grey_16x;
            this.buttonOrdenarDesc.Location = new System.Drawing.Point(185, 12);
            this.buttonOrdenarDesc.Name = "buttonOrdenarDesc";
            this.buttonOrdenarDesc.Size = new System.Drawing.Size(26, 23);
            this.buttonOrdenarDesc.TabIndex = 8;
            this.buttonOrdenarDesc.UseVisualStyleBackColor = true;
            this.buttonOrdenarDesc.Click += new System.EventHandler(this.ButtonOrdenarDesc_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarCliente.Image = global::Stand_Automoveis.Properties.Resources.Cancel_16x;
            this.btnEliminarCliente.Location = new System.Drawing.Point(227, 11);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(24, 24);
            this.btnEliminarCliente.TabIndex = 1;
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.BtnEliminarCliente_Click);
            // 
            // buttonOrdenarCres
            // 
            this.buttonOrdenarCres.Image = global::Stand_Automoveis.Properties.Resources.Upload_gray_16x;
            this.buttonOrdenarCres.Location = new System.Drawing.Point(153, 12);
            this.buttonOrdenarCres.Name = "buttonOrdenarCres";
            this.buttonOrdenarCres.Size = new System.Drawing.Size(26, 23);
            this.buttonOrdenarCres.TabIndex = 7;
            this.buttonOrdenarCres.UseVisualStyleBackColor = true;
            this.buttonOrdenarCres.Click += new System.EventHandler(this.ButtonOrdenarCres_Click);
            // 
            // btnCriarCliente
            // 
            this.btnCriarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCriarCliente.Image = global::Stand_Automoveis.Properties.Resources.Add_grey_16x;
            this.btnCriarCliente.Location = new System.Drawing.Point(257, 11);
            this.btnCriarCliente.Name = "btnCriarCliente";
            this.btnCriarCliente.Size = new System.Drawing.Size(24, 24);
            this.btnCriarCliente.TabIndex = 2;
            this.btnCriarCliente.UseVisualStyleBackColor = true;
            this.btnCriarCliente.Click += new System.EventHandler(this.BtnCriarCliente_Click);
            // 
            // tbxFiltrar
            // 
            this.tbxFiltrar.Location = new System.Drawing.Point(6, 14);
            this.tbxFiltrar.Name = "tbxFiltrar";
            this.tbxFiltrar.Size = new System.Drawing.Size(141, 20);
            this.tbxFiltrar.TabIndex = 5;
            this.tbxFiltrar.TextChanged += new System.EventHandler(this.TbxFiltrar_TextChanged);
            this.tbxFiltrar.Enter += new System.EventHandler(this.TbxFiltrar_Enter);
            this.tbxFiltrar.Leave += new System.EventHandler(this.TbxFiltrar_Leave);
            // 
            // gbxDadosCliente
            // 
            this.gbxDadosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDadosCliente.Controls.Add(this.gbxInformacaoCliente);
            this.gbxDadosCliente.Controls.Add(this.panelEditarCliente);
            this.gbxDadosCliente.Location = new System.Drawing.Point(305, 27);
            this.gbxDadosCliente.Name = "gbxDadosCliente";
            this.gbxDadosCliente.Size = new System.Drawing.Size(575, 419);
            this.gbxDadosCliente.TabIndex = 3;
            this.gbxDadosCliente.TabStop = false;
            this.gbxDadosCliente.Text = "Dados do Cliente";
            // 
            // gbxInformacaoCliente
            // 
            this.gbxInformacaoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxInformacaoCliente.Controls.Add(this.lblShowNif);
            this.gbxInformacaoCliente.Controls.Add(this.lblShowNome);
            this.gbxInformacaoCliente.Controls.Add(this.lblShowMorada);
            this.gbxInformacaoCliente.Controls.Add(this.lblShowContacto);
            this.gbxInformacaoCliente.Controls.Add(this.label4);
            this.gbxInformacaoCliente.Controls.Add(this.label3);
            this.gbxInformacaoCliente.Controls.Add(this.label2);
            this.gbxInformacaoCliente.Controls.Add(this.label1);
            this.gbxInformacaoCliente.Controls.Add(this.lblNumCarrosComprados);
            this.gbxInformacaoCliente.Controls.Add(this.lblNumCarroAluguer);
            this.gbxInformacaoCliente.Controls.Add(this.lblNumCarrosOficina);
            this.gbxInformacaoCliente.Controls.Add(this.lblNumCarrosCompradosTexto);
            this.gbxInformacaoCliente.Controls.Add(this.lblNumCarroAluguerText);
            this.gbxInformacaoCliente.Controls.Add(this.lblNumCarrosOficinaText);
            this.gbxInformacaoCliente.Location = new System.Drawing.Point(7, 151);
            this.gbxInformacaoCliente.Name = "gbxInformacaoCliente";
            this.gbxInformacaoCliente.Size = new System.Drawing.Size(562, 262);
            this.gbxInformacaoCliente.TabIndex = 1;
            this.gbxInformacaoCliente.TabStop = false;
            this.gbxInformacaoCliente.Text = "Informacão do Cliente";
            // 
            // lblShowNif
            // 
            this.lblShowNif.AutoSize = true;
            this.lblShowNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNif.Location = new System.Drawing.Point(119, 129);
            this.lblShowNif.Margin = new System.Windows.Forms.Padding(18, 0, 3, 0);
            this.lblShowNif.Name = "lblShowNif";
            this.lblShowNif.Size = new System.Drawing.Size(168, 15);
            this.lblShowNif.TabIndex = 13;
            this.lblShowNif.Text = "Nenhum Cliente Selecionado";
            // 
            // lblShowNome
            // 
            this.lblShowNome.AutoSize = true;
            this.lblShowNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNome.Location = new System.Drawing.Point(119, 36);
            this.lblShowNome.Margin = new System.Windows.Forms.Padding(18, 0, 3, 0);
            this.lblShowNome.Name = "lblShowNome";
            this.lblShowNome.Size = new System.Drawing.Size(168, 15);
            this.lblShowNome.TabIndex = 12;
            this.lblShowNome.Text = "Nenhum Cliente Selecionado";
            // 
            // lblShowMorada
            // 
            this.lblShowMorada.AutoSize = true;
            this.lblShowMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowMorada.Location = new System.Drawing.Point(119, 67);
            this.lblShowMorada.Margin = new System.Windows.Forms.Padding(18, 0, 3, 0);
            this.lblShowMorada.Name = "lblShowMorada";
            this.lblShowMorada.Size = new System.Drawing.Size(168, 15);
            this.lblShowMorada.TabIndex = 11;
            this.lblShowMorada.Text = "Nenhum Cliente Selecionado";
            // 
            // lblShowContacto
            // 
            this.lblShowContacto.AutoSize = true;
            this.lblShowContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowContacto.Location = new System.Drawing.Point(119, 98);
            this.lblShowContacto.Margin = new System.Windows.Forms.Padding(18, 0, 3, 0);
            this.lblShowContacto.Name = "lblShowContacto";
            this.lblShowContacto.Size = new System.Drawing.Size(168, 15);
            this.lblShowContacto.TabIndex = 10;
            this.lblShowContacto.Text = "Nenhum Cliente Selecionado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "NIF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contacto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Morada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome Cliente:";
            // 
            // lblNumCarrosComprados
            // 
            this.lblNumCarrosComprados.AutoSize = true;
            this.lblNumCarrosComprados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCarrosComprados.Location = new System.Drawing.Point(210, 228);
            this.lblNumCarrosComprados.Margin = new System.Windows.Forms.Padding(18, 0, 3, 0);
            this.lblNumCarrosComprados.Name = "lblNumCarrosComprados";
            this.lblNumCarrosComprados.Size = new System.Drawing.Size(168, 15);
            this.lblNumCarrosComprados.TabIndex = 5;
            this.lblNumCarrosComprados.Text = "Nenhum Cliente Selecionado";
            // 
            // lblNumCarroAluguer
            // 
            this.lblNumCarroAluguer.AutoSize = true;
            this.lblNumCarroAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCarroAluguer.Location = new System.Drawing.Point(210, 195);
            this.lblNumCarroAluguer.Margin = new System.Windows.Forms.Padding(18, 0, 3, 0);
            this.lblNumCarroAluguer.Name = "lblNumCarroAluguer";
            this.lblNumCarroAluguer.Size = new System.Drawing.Size(168, 15);
            this.lblNumCarroAluguer.TabIndex = 4;
            this.lblNumCarroAluguer.Text = "Nenhum Cliente Selecionado";
            // 
            // lblNumCarrosOficina
            // 
            this.lblNumCarrosOficina.AutoSize = true;
            this.lblNumCarrosOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCarrosOficina.Location = new System.Drawing.Point(210, 162);
            this.lblNumCarrosOficina.Margin = new System.Windows.Forms.Padding(18, 0, 3, 0);
            this.lblNumCarrosOficina.Name = "lblNumCarrosOficina";
            this.lblNumCarrosOficina.Size = new System.Drawing.Size(168, 15);
            this.lblNumCarrosOficina.TabIndex = 3;
            this.lblNumCarrosOficina.Text = "Nenhum Cliente Selecionado";
            // 
            // lblNumCarrosCompradosTexto
            // 
            this.lblNumCarrosCompradosTexto.AutoSize = true;
            this.lblNumCarrosCompradosTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCarrosCompradosTexto.Location = new System.Drawing.Point(6, 228);
            this.lblNumCarrosCompradosTexto.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.lblNumCarrosCompradosTexto.Name = "lblNumCarrosCompradosTexto";
            this.lblNumCarrosCompradosTexto.Size = new System.Drawing.Size(195, 16);
            this.lblNumCarrosCompradosTexto.TabIndex = 2;
            this.lblNumCarrosCompradosTexto.Text = "Numero de Carros Comprados:";
            // 
            // lblNumCarroAluguerText
            // 
            this.lblNumCarroAluguerText.AutoSize = true;
            this.lblNumCarroAluguerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCarroAluguerText.Location = new System.Drawing.Point(6, 195);
            this.lblNumCarroAluguerText.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.lblNumCarroAluguerText.Name = "lblNumCarroAluguerText";
            this.lblNumCarroAluguerText.Size = new System.Drawing.Size(182, 16);
            this.lblNumCarroAluguerText.TabIndex = 1;
            this.lblNumCarroAluguerText.Text = "Numero de Carros Alugados:";
            // 
            // lblNumCarrosOficinaText
            // 
            this.lblNumCarrosOficinaText.AutoSize = true;
            this.lblNumCarrosOficinaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCarrosOficinaText.Location = new System.Drawing.Point(6, 162);
            this.lblNumCarrosOficinaText.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.lblNumCarrosOficinaText.Name = "lblNumCarrosOficinaText";
            this.lblNumCarrosOficinaText.Size = new System.Drawing.Size(183, 16);
            this.lblNumCarrosOficinaText.TabIndex = 0;
            this.lblNumCarrosOficinaText.Text = "Numero de Carros na Oficina:";
            // 
            // panelEditarCliente
            // 
            this.panelEditarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditarCliente.Controls.Add(this.btnEditarCliente);
            this.panelEditarCliente.Controls.Add(this.tbAlterarNif);
            this.panelEditarCliente.Controls.Add(this.lblNif);
            this.panelEditarCliente.Controls.Add(this.lblMorada);
            this.panelEditarCliente.Controls.Add(this.tbAlterarMorada);
            this.panelEditarCliente.Controls.Add(this.tbAlterarContacto);
            this.panelEditarCliente.Controls.Add(this.lblContacto);
            this.panelEditarCliente.Controls.Add(this.tbAlterarNome);
            this.panelEditarCliente.Controls.Add(this.labelNome);
            this.panelEditarCliente.Location = new System.Drawing.Point(7, 20);
            this.panelEditarCliente.Name = "panelEditarCliente";
            this.panelEditarCliente.Size = new System.Drawing.Size(562, 125);
            this.panelEditarCliente.TabIndex = 0;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditarCliente.Image = global::Stand_Automoveis.Properties.Resources.Edit_straight_16xLG;
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCliente.Location = new System.Drawing.Point(426, 86);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(126, 33);
            this.btnEditarCliente.TabIndex = 4;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.BtnEditarCliente_Click);
            // 
            // tbAlterarNif
            // 
            this.tbAlterarNif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlterarNif.Location = new System.Drawing.Point(415, 31);
            this.tbAlterarNif.Name = "tbAlterarNif";
            this.tbAlterarNif.Size = new System.Drawing.Size(137, 20);
            this.tbAlterarNif.TabIndex = 2;
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(382, 34);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(27, 13);
            this.lblNif.TabIndex = 6;
            this.lblNif.Text = "NIF:";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(3, 60);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(43, 13);
            this.lblMorada.TabIndex = 4;
            this.lblMorada.Text = "Morada";
            // 
            // tbAlterarMorada
            // 
            this.tbAlterarMorada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlterarMorada.Location = new System.Drawing.Point(92, 57);
            this.tbAlterarMorada.Name = "tbAlterarMorada";
            this.tbAlterarMorada.Size = new System.Drawing.Size(460, 20);
            this.tbAlterarMorada.TabIndex = 3;
            // 
            // tbAlterarContacto
            // 
            this.tbAlterarContacto.Location = new System.Drawing.Point(92, 31);
            this.tbAlterarContacto.Name = "tbAlterarContacto";
            this.tbAlterarContacto.Size = new System.Drawing.Size(219, 20);
            this.tbAlterarContacto.TabIndex = 1;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(3, 34);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(50, 13);
            this.lblContacto.TabIndex = 2;
            this.lblContacto.Text = "Contacto";
            // 
            // tbAlterarNome
            // 
            this.tbAlterarNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlterarNome.Location = new System.Drawing.Point(92, 6);
            this.tbAlterarNome.Name = "tbAlterarNome";
            this.tbAlterarNome.Size = new System.Drawing.Size(460, 20);
            this.tbAlterarNome.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(3, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(70, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome Cliente";
            // 
            // GestorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.gbxDadosCliente);
            this.Controls.Add(this.gbxClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestorCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestorClientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestorCliente_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxClientes.ResumeLayout(false);
            this.gbxClientes.PerformLayout();
            this.gbxDadosCliente.ResumeLayout(false);
            this.gbxInformacaoCliente.ResumeLayout(false);
            this.gbxInformacaoCliente.PerformLayout();
            this.panelEditarCliente.ResumeLayout(false);
            this.panelEditarCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparDadosToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxClientes;
        private System.Windows.Forms.Button btnCriarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.GroupBox gbxDadosCliente;
        private System.Windows.Forms.Panel panelEditarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.TextBox tbAlterarNif;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.TextBox tbAlterarMorada;
        private System.Windows.Forms.TextBox tbAlterarContacto;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.TextBox tbAlterarNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.GroupBox gbxInformacaoCliente;
        private System.Windows.Forms.Label lblNumCarrosCompradosTexto;
        private System.Windows.Forms.Label lblNumCarroAluguerText;
        private System.Windows.Forms.Label lblNumCarrosOficinaText;
        private System.Windows.Forms.Label lblNumCarrosOficina;
        private System.Windows.Forms.Label lblNumCarroAluguer;
        private System.Windows.Forms.Label lblNumCarrosComprados;
        public System.Windows.Forms.ListBox lbxClientes;
        private System.Windows.Forms.Button buttonOrdenarDesc;
        private System.Windows.Forms.Button buttonOrdenarCres;
        private System.Windows.Forms.TextBox tbxFiltrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShowNif;
        private System.Windows.Forms.Label lblShowNome;
        private System.Windows.Forms.Label lblShowMorada;
        private System.Windows.Forms.Label lblShowContacto;
    }
}