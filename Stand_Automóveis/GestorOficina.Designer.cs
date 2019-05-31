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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbxClientes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAddParcela = new System.Windows.Forms.Button();
            this.lbxParcelas = new System.Windows.Forms.ListBox();
            this.buttonEditarCarro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEditarServicos = new System.Windows.Forms.Button();
            this.buttonEliminarServicos = new System.Windows.Forms.Button();
            this.lbxServicos = new System.Windows.Forms.ListBox();
            this.buttonAddServico = new System.Windows.Forms.Button();
            this.buttonEliminarCarro = new System.Windows.Forms.Button();
            this.buttonAddCarro = new System.Windows.Forms.Button();
            this.lbxCarros = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxClientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxClientes
            // 
            this.gbxClientes.Controls.Add(this.btnFiltrar);
            this.gbxClientes.Controls.Add(this.textBox1);
            this.gbxClientes.Controls.Add(this.lbxClientes);
            this.gbxClientes.Location = new System.Drawing.Point(12, 27);
            this.gbxClientes.Name = "gbxClientes";
            this.gbxClientes.Size = new System.Drawing.Size(277, 461);
            this.gbxClientes.TabIndex = 0;
            this.gbxClientes.TabStop = false;
            this.gbxClientes.Text = "Clientes";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(213, 20);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(58, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbxClientes
            // 
            this.lbxClientes.FormattingEnabled = true;
            this.lbxClientes.HorizontalScrollbar = true;
            this.lbxClientes.Location = new System.Drawing.Point(6, 48);
            this.lbxClientes.Name = "lbxClientes";
            this.lbxClientes.Size = new System.Drawing.Size(265, 407);
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
            this.groupBox1.Location = new System.Drawing.Point(295, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 461);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carros";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.buttonAddParcela);
            this.groupBox3.Controls.Add(this.lbxParcelas);
            this.groupBox3.Location = new System.Drawing.Point(484, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 242);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parcelas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonAddParcela
            // 
            this.buttonAddParcela.Location = new System.Drawing.Point(6, 208);
            this.buttonAddParcela.Name = "buttonAddParcela";
            this.buttonAddParcela.Size = new System.Drawing.Size(79, 23);
            this.buttonAddParcela.TabIndex = 5;
            this.buttonAddParcela.Text = "Adicionar";
            this.buttonAddParcela.UseVisualStyleBackColor = true;
            this.buttonAddParcela.Click += new System.EventHandler(this.ButtonAddParcela_Click);
            // 
            // lbxParcelas
            // 
            this.lbxParcelas.FormattingEnabled = true;
            this.lbxParcelas.HorizontalScrollbar = true;
            this.lbxParcelas.Location = new System.Drawing.Point(6, 19);
            this.lbxParcelas.Name = "lbxParcelas";
            this.lbxParcelas.Size = new System.Drawing.Size(251, 186);
            this.lbxParcelas.TabIndex = 0;
            // 
            // buttonEditarCarro
            // 
            this.buttonEditarCarro.Location = new System.Drawing.Point(662, 184);
            this.buttonEditarCarro.Name = "buttonEditarCarro";
            this.buttonEditarCarro.Size = new System.Drawing.Size(85, 23);
            this.buttonEditarCarro.TabIndex = 3;
            this.buttonEditarCarro.Text = "Editar";
            this.buttonEditarCarro.UseVisualStyleBackColor = true;
            this.buttonEditarCarro.Click += new System.EventHandler(this.ButtonEditarCarro_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEditarServicos);
            this.groupBox2.Controls.Add(this.buttonEliminarServicos);
            this.groupBox2.Controls.Add(this.lbxServicos);
            this.groupBox2.Controls.Add(this.buttonAddServico);
            this.groupBox2.Location = new System.Drawing.Point(6, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 271);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviços";
            // 
            // buttonEditarServicos
            // 
            this.buttonEditarServicos.Location = new System.Drawing.Point(366, 237);
            this.buttonEditarServicos.Name = "buttonEditarServicos";
            this.buttonEditarServicos.Size = new System.Drawing.Size(100, 23);
            this.buttonEditarServicos.TabIndex = 4;
            this.buttonEditarServicos.Text = "Editar";
            this.buttonEditarServicos.UseVisualStyleBackColor = true;
            this.buttonEditarServicos.Click += new System.EventHandler(this.ButtonEditarServicos_Click);
            // 
            // buttonEliminarServicos
            // 
            this.buttonEliminarServicos.Location = new System.Drawing.Point(257, 237);
            this.buttonEliminarServicos.Name = "buttonEliminarServicos";
            this.buttonEliminarServicos.Size = new System.Drawing.Size(100, 23);
            this.buttonEliminarServicos.TabIndex = 3;
            this.buttonEliminarServicos.Text = "Eliminar";
            this.buttonEliminarServicos.UseVisualStyleBackColor = true;
            this.buttonEliminarServicos.Click += new System.EventHandler(this.ButtonEliminarServicos_Click);
            // 
            // lbxServicos
            // 
            this.lbxServicos.FormattingEnabled = true;
            this.lbxServicos.HorizontalScrollbar = true;
            this.lbxServicos.Location = new System.Drawing.Point(6, 19);
            this.lbxServicos.Name = "lbxServicos";
            this.lbxServicos.Size = new System.Drawing.Size(460, 212);
            this.lbxServicos.TabIndex = 0;
            this.lbxServicos.SelectedIndexChanged += new System.EventHandler(this.LbxServicos_SelectedIndexChanged);
            // 
            // buttonAddServico
            // 
            this.buttonAddServico.Location = new System.Drawing.Point(147, 237);
            this.buttonAddServico.Name = "buttonAddServico";
            this.buttonAddServico.Size = new System.Drawing.Size(100, 23);
            this.buttonAddServico.TabIndex = 2;
            this.buttonAddServico.Text = "Adicionar";
            this.buttonAddServico.UseVisualStyleBackColor = true;
            this.buttonAddServico.Click += new System.EventHandler(this.ButtonAddServico_Click);
            // 
            // buttonEliminarCarro
            // 
            this.buttonEliminarCarro.Location = new System.Drawing.Point(573, 184);
            this.buttonEliminarCarro.Name = "buttonEliminarCarro";
            this.buttonEliminarCarro.Size = new System.Drawing.Size(85, 23);
            this.buttonEliminarCarro.TabIndex = 2;
            this.buttonEliminarCarro.Text = "Eliminar";
            this.buttonEliminarCarro.UseVisualStyleBackColor = true;
            this.buttonEliminarCarro.Click += new System.EventHandler(this.ButtonEliminarCarro_Click);
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.Location = new System.Drawing.Point(484, 184);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(85, 23);
            this.buttonAddCarro.TabIndex = 1;
            this.buttonAddCarro.Text = "Adicionar";
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            this.buttonAddCarro.Click += new System.EventHandler(this.ButtonAddCarro_Click);
            // 
            // lbxCarros
            // 
            this.lbxCarros.FormattingEnabled = true;
            this.lbxCarros.HorizontalScrollbar = true;
            this.lbxCarros.Location = new System.Drawing.Point(6, 18);
            this.lbxCarros.Name = "lbxCarros";
            this.lbxCarros.Size = new System.Drawing.Size(741, 160);
            this.lbxCarros.TabIndex = 0;
            this.lbxCarros.SelectedIndexChanged += new System.EventHandler(this.LbxCarros_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 24);
            this.menuStrip1.TabIndex = 3;
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
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // GestorOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 489);
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
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbxClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxCarros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxServicos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button buttonEditarCarro;
        private System.Windows.Forms.Button buttonEliminarCarro;
        private System.Windows.Forms.Button buttonAddCarro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbxParcelas;
        private System.Windows.Forms.Button buttonEditarServicos;
        private System.Windows.Forms.Button buttonEliminarServicos;
        private System.Windows.Forms.Button buttonAddServico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAddParcela;
    }
}