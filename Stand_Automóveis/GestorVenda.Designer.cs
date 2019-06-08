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
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFiltrarClientes = new System.Windows.Forms.Button();
            this.gbxClientes = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbxClientes = new System.Windows.Forms.ListBox();
            this.btnEditarCarroVenda = new System.Windows.Forms.Button();
            this.btnEliminarCarroVenda = new System.Windows.Forms.Button();
            this.btnAddCarroVenda = new System.Windows.Forms.Button();
            this.btnFiltrarVenda = new System.Windows.Forms.Button();
            this.tbxFiltrarVenda = new System.Windows.Forms.TextBox();
            this.lbxCarrosVenda = new System.Windows.Forms.ListBox();
            this.gbxAluguer = new System.Windows.Forms.GroupBox();
            this.imprimirHistoricoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.gbxAlugados.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbxClientes.SuspendLayout();
            this.gbxAluguer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarVenda);
            this.groupBox1.Controls.Add(this.dtpdataVenda);
            this.groupBox1.Controls.Add(this.btnEditarVenda);
            this.groupBox1.Controls.Add(this.btnAddVenda);
            this.groupBox1.Controls.Add(this.tbxValorVenda);
            this.groupBox1.Controls.Add(this.tbxestadoVenda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(658, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 148);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Venda";
            // 
            // btnEliminarVenda
            // 
            this.btnEliminarVenda.Location = new System.Drawing.Point(370, 105);
            this.btnEliminarVenda.Name = "btnEliminarVenda";
            this.btnEliminarVenda.Size = new System.Drawing.Size(105, 22);
            this.btnEliminarVenda.TabIndex = 16;
            this.btnEliminarVenda.Text = "Eliminar Venda";
            this.btnEliminarVenda.UseVisualStyleBackColor = true;
            this.btnEliminarVenda.Click += new System.EventHandler(this.btnEliminarAluguer_Click);
            // 
            // dtpdataVenda
            // 
            this.dtpdataVenda.Location = new System.Drawing.Point(110, 106);
            this.dtpdataVenda.Name = "dtpdataVenda";
            this.dtpdataVenda.Size = new System.Drawing.Size(243, 20);
            this.dtpdataVenda.TabIndex = 14;
            // 
            // btnEditarVenda
            // 
            this.btnEditarVenda.Location = new System.Drawing.Point(370, 61);
            this.btnEditarVenda.Name = "btnEditarVenda";
            this.btnEditarVenda.Size = new System.Drawing.Size(105, 21);
            this.btnEditarVenda.TabIndex = 13;
            this.btnEditarVenda.Text = "Editar Venda";
            this.btnEditarVenda.UseVisualStyleBackColor = true;
            this.btnEditarVenda.Click += new System.EventHandler(this.btnEditarVenda_Click);
            // 
            // btnAddVenda
            // 
            this.btnAddVenda.Location = new System.Drawing.Point(370, 19);
            this.btnAddVenda.Name = "btnAddVenda";
            this.btnAddVenda.Size = new System.Drawing.Size(105, 22);
            this.btnAddVenda.TabIndex = 12;
            this.btnAddVenda.Text = "Adicionar Venda";
            this.btnAddVenda.UseVisualStyleBackColor = true;
            this.btnAddVenda.Click += new System.EventHandler(this.btnAddVenda_Click);
            // 
            // tbxValorVenda
            // 
            this.tbxValorVenda.Location = new System.Drawing.Point(110, 63);
            this.tbxValorVenda.Name = "tbxValorVenda";
            this.tbxValorVenda.Size = new System.Drawing.Size(243, 20);
            this.tbxValorVenda.TabIndex = 5;
            // 
            // tbxestadoVenda
            // 
            this.tbxestadoVenda.Location = new System.Drawing.Point(110, 21);
            this.tbxestadoVenda.Name = "tbxestadoVenda";
            this.tbxestadoVenda.Size = new System.Drawing.Size(243, 20);
            this.tbxestadoVenda.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado da Venda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor da Venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Venda:";
            // 
            // lbxVendas
            // 
            this.lbxVendas.FormattingEnabled = true;
            this.lbxVendas.HorizontalScrollbar = true;
            this.lbxVendas.Location = new System.Drawing.Point(9, 24);
            this.lbxVendas.Name = "lbxVendas";
            this.lbxVendas.Size = new System.Drawing.Size(466, 251);
            this.lbxVendas.TabIndex = 3;
            this.lbxVendas.SelectedIndexChanged += new System.EventHandler(this.lbxVendas_SelectedIndexChanged);
            // 
            // gbxAlugados
            // 
            this.gbxAlugados.Controls.Add(this.btnInfVenda);
            this.gbxAlugados.Controls.Add(this.lbxVendas);
            this.gbxAlugados.Location = new System.Drawing.Point(658, 181);
            this.gbxAlugados.Name = "gbxAlugados";
            this.gbxAlugados.Size = new System.Drawing.Size(487, 307);
            this.gbxAlugados.TabIndex = 16;
            this.gbxAlugados.TabStop = false;
            this.gbxAlugados.Text = "Vendas";
            // 
            // btnInfVenda
            // 
            this.btnInfVenda.Location = new System.Drawing.Point(9, 279);
            this.btnInfVenda.Name = "btnInfVenda";
            this.btnInfVenda.Size = new System.Drawing.Size(466, 22);
            this.btnInfVenda.TabIndex = 17;
            this.btnInfVenda.Text = "Infromações adicionais sobre a Venda";
            this.btnInfVenda.UseVisualStyleBackColor = true;
            this.btnInfVenda.Click += new System.EventHandler(this.btnInfVenda_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.aluguerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirHistoricoClienteToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.limparDadosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
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
            this.criarCarroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criarCarroToolStripMenuItem.Text = "Criar Carro";
            this.criarCarroToolStripMenuItem.Click += new System.EventHandler(this.criarCarroToolStripMenuItem_Click);
            // 
            // editarCarroToolStripMenuItem
            // 
            this.editarCarroToolStripMenuItem.Name = "editarCarroToolStripMenuItem";
            this.editarCarroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarCarroToolStripMenuItem.Text = "Editar Carro";
            this.editarCarroToolStripMenuItem.Click += new System.EventHandler(this.editarCarroToolStripMenuItem_Click);
            // 
            // eliminarCarroToolStripMenuItem
            // 
            this.eliminarCarroToolStripMenuItem.Name = "eliminarCarroToolStripMenuItem";
            this.eliminarCarroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarCarroToolStripMenuItem.Text = "Eliminar Carro";
            this.eliminarCarroToolStripMenuItem.Click += new System.EventHandler(this.eliminarCarroToolStripMenuItem_Click);
            // 
            // btnFiltrarClientes
            // 
            this.btnFiltrarClientes.Location = new System.Drawing.Point(242, 20);
            this.btnFiltrarClientes.Name = "btnFiltrarClientes";
            this.btnFiltrarClientes.Size = new System.Drawing.Size(68, 23);
            this.btnFiltrarClientes.TabIndex = 2;
            this.btnFiltrarClientes.Text = "Filtrar";
            this.btnFiltrarClientes.UseVisualStyleBackColor = true;
            // 
            // gbxClientes
            // 
            this.gbxClientes.Controls.Add(this.btnFiltrarClientes);
            this.gbxClientes.Controls.Add(this.textBox1);
            this.gbxClientes.Controls.Add(this.lbxClientes);
            this.gbxClientes.Location = new System.Drawing.Point(6, 27);
            this.gbxClientes.Name = "gbxClientes";
            this.gbxClientes.Size = new System.Drawing.Size(320, 461);
            this.gbxClientes.TabIndex = 14;
            this.gbxClientes.TabStop = false;
            this.gbxClientes.Text = "Clientes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbxClientes
            // 
            this.lbxClientes.FormattingEnabled = true;
            this.lbxClientes.Location = new System.Drawing.Point(6, 48);
            this.lbxClientes.Name = "lbxClientes";
            this.lbxClientes.Size = new System.Drawing.Size(304, 407);
            this.lbxClientes.TabIndex = 0;
            this.lbxClientes.SelectedIndexChanged += new System.EventHandler(this.lbxClientes_SelectedIndexChanged);
            // 
            // btnEditarCarroVenda
            // 
            this.btnEditarCarroVenda.Location = new System.Drawing.Point(109, 432);
            this.btnEditarCarroVenda.Name = "btnEditarCarroVenda";
            this.btnEditarCarroVenda.Size = new System.Drawing.Size(100, 23);
            this.btnEditarCarroVenda.TabIndex = 7;
            this.btnEditarCarroVenda.Text = "Editar Carro";
            this.btnEditarCarroVenda.UseVisualStyleBackColor = true;
            this.btnEditarCarroVenda.Click += new System.EventHandler(this.btnEditarCarroAluguer_Click);
            // 
            // btnEliminarCarroVenda
            // 
            this.btnEliminarCarroVenda.Location = new System.Drawing.Point(210, 432);
            this.btnEliminarCarroVenda.Name = "btnEliminarCarroVenda";
            this.btnEliminarCarroVenda.Size = new System.Drawing.Size(100, 23);
            this.btnEliminarCarroVenda.TabIndex = 6;
            this.btnEliminarCarroVenda.Text = "Eliminar Carro";
            this.btnEliminarCarroVenda.UseVisualStyleBackColor = true;
            this.btnEliminarCarroVenda.Click += new System.EventHandler(this.btnEliminarCarroAluguer_Click);
            // 
            // btnAddCarroVenda
            // 
            this.btnAddCarroVenda.Location = new System.Drawing.Point(6, 432);
            this.btnAddCarroVenda.Name = "btnAddCarroVenda";
            this.btnAddCarroVenda.Size = new System.Drawing.Size(100, 23);
            this.btnAddCarroVenda.TabIndex = 5;
            this.btnAddCarroVenda.Text = "Adicionar Carro";
            this.btnAddCarroVenda.UseVisualStyleBackColor = true;
            this.btnAddCarroVenda.Click += new System.EventHandler(this.btnAddCarro_Click);
            // 
            // btnFiltrarVenda
            // 
            this.btnFiltrarVenda.Location = new System.Drawing.Point(242, 19);
            this.btnFiltrarVenda.Name = "btnFiltrarVenda";
            this.btnFiltrarVenda.Size = new System.Drawing.Size(68, 23);
            this.btnFiltrarVenda.TabIndex = 4;
            this.btnFiltrarVenda.Text = "Filtrar";
            this.btnFiltrarVenda.UseVisualStyleBackColor = true;
            // 
            // tbxFiltrarVenda
            // 
            this.tbxFiltrarVenda.Location = new System.Drawing.Point(6, 23);
            this.tbxFiltrarVenda.Name = "tbxFiltrarVenda";
            this.tbxFiltrarVenda.Size = new System.Drawing.Size(230, 20);
            this.tbxFiltrarVenda.TabIndex = 3;
            // 
            // lbxCarrosVenda
            // 
            this.lbxCarrosVenda.FormattingEnabled = true;
            this.lbxCarrosVenda.HorizontalScrollbar = true;
            this.lbxCarrosVenda.Location = new System.Drawing.Point(6, 48);
            this.lbxCarrosVenda.Name = "lbxCarrosVenda";
            this.lbxCarrosVenda.Size = new System.Drawing.Size(304, 381);
            this.lbxCarrosVenda.TabIndex = 2;
            this.lbxCarrosVenda.SelectedIndexChanged += new System.EventHandler(this.lbxCarrosVenda_SelectedIndexChanged);
            // 
            // gbxAluguer
            // 
            this.gbxAluguer.Controls.Add(this.btnEditarCarroVenda);
            this.gbxAluguer.Controls.Add(this.btnEliminarCarroVenda);
            this.gbxAluguer.Controls.Add(this.btnAddCarroVenda);
            this.gbxAluguer.Controls.Add(this.btnFiltrarVenda);
            this.gbxAluguer.Controls.Add(this.tbxFiltrarVenda);
            this.gbxAluguer.Controls.Add(this.lbxCarrosVenda);
            this.gbxAluguer.Location = new System.Drawing.Point(332, 27);
            this.gbxAluguer.Name = "gbxAluguer";
            this.gbxAluguer.Size = new System.Drawing.Size(320, 461);
            this.gbxAluguer.TabIndex = 13;
            this.gbxAluguer.TabStop = false;
            this.gbxAluguer.Text = "Carros para Vender";
            // 
            // imprimirHistoricoClienteToolStripMenuItem
            // 
            this.imprimirHistoricoClienteToolStripMenuItem.Name = "imprimirHistoricoClienteToolStripMenuItem";
            this.imprimirHistoricoClienteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.imprimirHistoricoClienteToolStripMenuItem.Text = "Imprimir Historico Cliente";
            this.imprimirHistoricoClienteToolStripMenuItem.Click += new System.EventHandler(this.imprimirHistoricoClienteToolStripMenuItem_Click);
            // 
            // GestorVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxAlugados);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbxClientes);
            this.Controls.Add(this.gbxAluguer);
            this.Name = "GestorVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GertorVenda";
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
        private System.Windows.Forms.Button btnFiltrarClientes;
        private System.Windows.Forms.GroupBox gbxClientes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbxClientes;
        private System.Windows.Forms.Button btnEditarCarroVenda;
        private System.Windows.Forms.Button btnEliminarCarroVenda;
        private System.Windows.Forms.Button btnAddCarroVenda;
        private System.Windows.Forms.Button btnFiltrarVenda;
        private System.Windows.Forms.TextBox tbxFiltrarVenda;
        public System.Windows.Forms.ListBox lbxCarrosVenda;
        private System.Windows.Forms.GroupBox gbxAluguer;
        private System.Windows.Forms.ToolStripMenuItem imprimirHistoricoClienteToolStripMenuItem;
    }
}