namespace Stand_Automoveis
{
    partial class GestorOficina
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
            this.gbxClientes = new System.Windows.Forms.GroupBox();
            this.tbxFiltrar = new System.Windows.Forms.TextBox();
            this.lbxClientes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbxParcelas = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxServicos = new System.Windows.Forms.ListBox();
            this.lbxCarros = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparSelecaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonEditarParcela = new System.Windows.Forms.Button();
            this.buttonEliminarParcela = new System.Windows.Forms.Button();
            this.buttonAddParcela = new System.Windows.Forms.Button();
            this.buttonEditarCarro = new System.Windows.Forms.Button();
            this.buttonEditarServico = new System.Windows.Forms.Button();
            this.buttonEliminarServico = new System.Windows.Forms.Button();
            this.buttonAddServico = new System.Windows.Forms.Button();
            this.buttonEliminarCarro = new System.Windows.Forms.Button();
            this.buttonAddCarro = new System.Windows.Forms.Button();
            this.buttonOrdenarDesc = new System.Windows.Forms.Button();
            this.buttonOrdenarCres = new System.Windows.Forms.Button();
            this.buttonServicoOkay = new System.Windows.Forms.Button();
            this.gbxClientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxClientes
            // 
            this.gbxClientes.Controls.Add(this.buttonOrdenarDesc);
            this.gbxClientes.Controls.Add(this.buttonOrdenarCres);
            this.gbxClientes.Controls.Add(this.tbxFiltrar);
            this.gbxClientes.Controls.Add(this.lbxClientes);
            this.gbxClientes.Location = new System.Drawing.Point(12, 27);
            this.gbxClientes.Name = "gbxClientes";
            this.gbxClientes.Size = new System.Drawing.Size(343, 461);
            this.gbxClientes.TabIndex = 0;
            this.gbxClientes.TabStop = false;
            this.gbxClientes.Text = "Clientes";
            // 
            // tbxFiltrar
            // 
            this.tbxFiltrar.Location = new System.Drawing.Point(7, 22);
            this.tbxFiltrar.Name = "tbxFiltrar";
            this.tbxFiltrar.Size = new System.Drawing.Size(270, 20);
            this.tbxFiltrar.TabIndex = 1;
            this.tbxFiltrar.TextChanged += new System.EventHandler(this.TbxFiltrar_TextChanged);
            // 
            // lbxClientes
            // 
            this.lbxClientes.FormattingEnabled = true;
            this.lbxClientes.HorizontalScrollbar = true;
            this.lbxClientes.Location = new System.Drawing.Point(6, 48);
            this.lbxClientes.Name = "lbxClientes";
            this.lbxClientes.Size = new System.Drawing.Size(331, 407);
            this.lbxClientes.TabIndex = 0;
            this.lbxClientes.SelectedIndexChanged += new System.EventHandler(this.LbxClientes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.buttonEditarCarro);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonEliminarCarro);
            this.groupBox1.Controls.Add(this.buttonAddCarro);
            this.groupBox1.Controls.Add(this.lbxCarros);
            this.groupBox1.Location = new System.Drawing.Point(361, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 461);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carros";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonEditarParcela);
            this.groupBox3.Controls.Add(this.buttonEliminarParcela);
            this.groupBox3.Controls.Add(this.buttonAddParcela);
            this.groupBox3.Controls.Add(this.lbxParcelas);
            this.groupBox3.Location = new System.Drawing.Point(484, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 271);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parcelas";
            // 
            // lbxParcelas
            // 
            this.lbxParcelas.FormattingEnabled = true;
            this.lbxParcelas.HorizontalScrollbar = true;
            this.lbxParcelas.Location = new System.Drawing.Point(6, 19);
            this.lbxParcelas.Name = "lbxParcelas";
            this.lbxParcelas.Size = new System.Drawing.Size(251, 212);
            this.lbxParcelas.TabIndex = 0;
            this.lbxParcelas.SelectedIndexChanged += new System.EventHandler(this.LbxParcelas_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonServicoOkay);
            this.groupBox2.Controls.Add(this.buttonEditarServico);
            this.groupBox2.Controls.Add(this.buttonEliminarServico);
            this.groupBox2.Controls.Add(this.lbxServicos);
            this.groupBox2.Controls.Add(this.buttonAddServico);
            this.groupBox2.Location = new System.Drawing.Point(6, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 271);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviços";
            // 
            // lbxServicos
            // 
            this.lbxServicos.FormattingEnabled = true;
            this.lbxServicos.HorizontalScrollbar = true;
            this.lbxServicos.Location = new System.Drawing.Point(36, 19);
            this.lbxServicos.Name = "lbxServicos";
            this.lbxServicos.Size = new System.Drawing.Size(430, 238);
            this.lbxServicos.TabIndex = 0;
            this.lbxServicos.SelectedIndexChanged += new System.EventHandler(this.LbxServicos_SelectedIndexChanged);
            // 
            // lbxCarros
            // 
            this.lbxCarros.FormattingEnabled = true;
            this.lbxCarros.HorizontalScrollbar = true;
            this.lbxCarros.Location = new System.Drawing.Point(6, 18);
            this.lbxCarros.Name = "lbxCarros";
            this.lbxCarros.Size = new System.Drawing.Size(711, 160);
            this.lbxCarros.TabIndex = 0;
            this.lbxCarros.SelectedIndexChanged += new System.EventHandler(this.LbxCarros_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.limparSelecaoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.NovoClienteToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // limparSelecaoToolStripMenuItem
            // 
            this.limparSelecaoToolStripMenuItem.Name = "limparSelecaoToolStripMenuItem";
            this.limparSelecaoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.limparSelecaoToolStripMenuItem.Text = "Limpar Seleções";
            this.limparSelecaoToolStripMenuItem.Click += new System.EventHandler(this.LimparSelecaoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // buttonEditarParcela
            // 
            this.buttonEditarParcela.Enabled = false;
            this.buttonEditarParcela.Image = global::Stand_Automoveis.Properties.Resources.Edit_straight_16xLG;
            this.buttonEditarParcela.Location = new System.Drawing.Point(176, 242);
            this.buttonEditarParcela.Name = "buttonEditarParcela";
            this.buttonEditarParcela.Size = new System.Drawing.Size(81, 23);
            this.buttonEditarParcela.TabIndex = 7;
            this.buttonEditarParcela.Text = "Editar";
            this.buttonEditarParcela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEditarParcela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditarParcela.UseVisualStyleBackColor = true;
            this.buttonEditarParcela.Click += new System.EventHandler(this.ButtonEditarParcelas_Click);
            // 
            // buttonEliminarParcela
            // 
            this.buttonEliminarParcela.Enabled = false;
            this.buttonEliminarParcela.Image = global::Stand_Automoveis.Properties.Resources.Cancel_16x;
            this.buttonEliminarParcela.Location = new System.Drawing.Point(91, 242);
            this.buttonEliminarParcela.Name = "buttonEliminarParcela";
            this.buttonEliminarParcela.Size = new System.Drawing.Size(79, 23);
            this.buttonEliminarParcela.TabIndex = 6;
            this.buttonEliminarParcela.Text = "Eliminar";
            this.buttonEliminarParcela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminarParcela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEliminarParcela.UseVisualStyleBackColor = true;
            this.buttonEliminarParcela.Click += new System.EventHandler(this.ButtonEliminarParcelas_Click);
            // 
            // buttonAddParcela
            // 
            this.buttonAddParcela.Enabled = false;
            this.buttonAddParcela.Image = global::Stand_Automoveis.Properties.Resources.Add_grey_16x;
            this.buttonAddParcela.Location = new System.Drawing.Point(6, 242);
            this.buttonAddParcela.Name = "buttonAddParcela";
            this.buttonAddParcela.Size = new System.Drawing.Size(79, 23);
            this.buttonAddParcela.TabIndex = 5;
            this.buttonAddParcela.Text = "Adicionar";
            this.buttonAddParcela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddParcela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddParcela.UseVisualStyleBackColor = true;
            this.buttonAddParcela.Click += new System.EventHandler(this.ButtonAddParcela_Click);
            // 
            // buttonEditarCarro
            // 
            this.buttonEditarCarro.Enabled = false;
            this.buttonEditarCarro.Image = global::Stand_Automoveis.Properties.Resources.Edit_straight_16xLG;
            this.buttonEditarCarro.Location = new System.Drawing.Point(723, 77);
            this.buttonEditarCarro.Name = "buttonEditarCarro";
            this.buttonEditarCarro.Size = new System.Drawing.Size(24, 23);
            this.buttonEditarCarro.TabIndex = 3;
            this.buttonEditarCarro.UseVisualStyleBackColor = true;
            this.buttonEditarCarro.Click += new System.EventHandler(this.ButtonEditarCarro_Click);
            // 
            // buttonEditarServico
            // 
            this.buttonEditarServico.Enabled = false;
            this.buttonEditarServico.Image = global::Stand_Automoveis.Properties.Resources.Edit_straight_16xLG;
            this.buttonEditarServico.Location = new System.Drawing.Point(6, 79);
            this.buttonEditarServico.Name = "buttonEditarServico";
            this.buttonEditarServico.Size = new System.Drawing.Size(24, 24);
            this.buttonEditarServico.TabIndex = 4;
            this.buttonEditarServico.UseVisualStyleBackColor = true;
            this.buttonEditarServico.Click += new System.EventHandler(this.ButtonEditarServicos_Click);
            // 
            // buttonEliminarServico
            // 
            this.buttonEliminarServico.Enabled = false;
            this.buttonEliminarServico.Image = global::Stand_Automoveis.Properties.Resources.Cancel_16x;
            this.buttonEliminarServico.Location = new System.Drawing.Point(6, 49);
            this.buttonEliminarServico.Name = "buttonEliminarServico";
            this.buttonEliminarServico.Size = new System.Drawing.Size(24, 24);
            this.buttonEliminarServico.TabIndex = 3;
            this.buttonEliminarServico.UseVisualStyleBackColor = true;
            this.buttonEliminarServico.Click += new System.EventHandler(this.ButtonEliminarServicos_Click);
            // 
            // buttonAddServico
            // 
            this.buttonAddServico.Enabled = false;
            this.buttonAddServico.Image = global::Stand_Automoveis.Properties.Resources.Add_grey_16x;
            this.buttonAddServico.Location = new System.Drawing.Point(6, 19);
            this.buttonAddServico.Name = "buttonAddServico";
            this.buttonAddServico.Size = new System.Drawing.Size(24, 24);
            this.buttonAddServico.TabIndex = 2;
            this.buttonAddServico.UseVisualStyleBackColor = true;
            this.buttonAddServico.Click += new System.EventHandler(this.ButtonAddServico_Click);
            // 
            // buttonEliminarCarro
            // 
            this.buttonEliminarCarro.Enabled = false;
            this.buttonEliminarCarro.Image = global::Stand_Automoveis.Properties.Resources.Cancel_16x;
            this.buttonEliminarCarro.Location = new System.Drawing.Point(723, 48);
            this.buttonEliminarCarro.Name = "buttonEliminarCarro";
            this.buttonEliminarCarro.Size = new System.Drawing.Size(24, 23);
            this.buttonEliminarCarro.TabIndex = 2;
            this.buttonEliminarCarro.UseVisualStyleBackColor = true;
            this.buttonEliminarCarro.Click += new System.EventHandler(this.ButtonEliminarCarro_Click);
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.Image = global::Stand_Automoveis.Properties.Resources.Add_grey_16x;
            this.buttonAddCarro.Location = new System.Drawing.Point(723, 18);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(24, 24);
            this.buttonAddCarro.TabIndex = 1;
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            this.buttonAddCarro.Click += new System.EventHandler(this.ButtonAddCarro_Click);
            // 
            // buttonOrdenarDesc
            // 
            this.buttonOrdenarDesc.Image = global::Stand_Automoveis.Properties.Resources.Download_grey_16x;
            this.buttonOrdenarDesc.Location = new System.Drawing.Point(311, 20);
            this.buttonOrdenarDesc.Name = "buttonOrdenarDesc";
            this.buttonOrdenarDesc.Size = new System.Drawing.Size(26, 23);
            this.buttonOrdenarDesc.TabIndex = 4;
            this.buttonOrdenarDesc.UseVisualStyleBackColor = true;
            this.buttonOrdenarDesc.Click += new System.EventHandler(this.ButtonOrdenarDesc_Click);
            // 
            // buttonOrdenarCres
            // 
            this.buttonOrdenarCres.Image = global::Stand_Automoveis.Properties.Resources.Upload_gray_16x;
            this.buttonOrdenarCres.Location = new System.Drawing.Point(283, 20);
            this.buttonOrdenarCres.Name = "buttonOrdenarCres";
            this.buttonOrdenarCres.Size = new System.Drawing.Size(26, 23);
            this.buttonOrdenarCres.TabIndex = 3;
            this.buttonOrdenarCres.UseVisualStyleBackColor = true;
            this.buttonOrdenarCres.Click += new System.EventHandler(this.ButtonOrdenarCres_Click);
            // 
            // buttonServicoOkay
            // 
            this.buttonServicoOkay.Image = global::Stand_Automoveis.Properties.Resources.Checkmark_16x;
            this.buttonServicoOkay.Location = new System.Drawing.Point(6, 109);
            this.buttonServicoOkay.Name = "buttonServicoOkay";
            this.buttonServicoOkay.Size = new System.Drawing.Size(24, 24);
            this.buttonServicoOkay.TabIndex = 5;
            this.buttonServicoOkay.UseVisualStyleBackColor = true;
            this.buttonServicoOkay.Click += new System.EventHandler(this.ButtonServicoOkay_Click);
            // 
            // GestorOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 504);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxClientes);
            this.Name = "GestorOficina";
            this.Text = "GestorOficina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestorOficina_FormClosing);
            this.gbxClientes.ResumeLayout(false);
            this.gbxClientes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxClientes;
        private System.Windows.Forms.TextBox tbxFiltrar;
        private System.Windows.Forms.ListBox lbxClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxCarros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxServicos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparSelecaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button buttonEditarCarro;
        private System.Windows.Forms.Button buttonEliminarCarro;
        private System.Windows.Forms.Button buttonAddCarro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbxParcelas;
        private System.Windows.Forms.Button buttonEditarServico;
        private System.Windows.Forms.Button buttonEliminarServico;
        private System.Windows.Forms.Button buttonAddServico;
        private System.Windows.Forms.Button buttonEditarParcela;
        private System.Windows.Forms.Button buttonEliminarParcela;
        private System.Windows.Forms.Button buttonAddParcela;
        private System.Windows.Forms.Button buttonOrdenarDesc;
        private System.Windows.Forms.Button buttonOrdenarCres;
        private System.Windows.Forms.Button buttonServicoOkay;
    }
}