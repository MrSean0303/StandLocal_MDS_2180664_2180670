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
            this.btnEliminarCarroAluguer = new System.Windows.Forms.Button();
            this.btnAddCarro = new System.Windows.Forms.Button();
            this.btnFiltrarAluguer = new System.Windows.Forms.Button();
            this.lbxCarrosAluguer = new System.Windows.Forms.ListBox();
            this.btnEliminarAluguer = new System.Windows.Forms.Button();
            this.dtpRececao = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnEditarAluguer = new System.Windows.Forms.Button();
            this.btnAddAluguer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.tbxKms = new System.Windows.Forms.TextBox();
            this.btnEditarCarroAluguer = new System.Windows.Forms.Button();
            this.gbxAluguer = new System.Windows.Forms.GroupBox();
            this.tbxFiltrarAluguer = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbxClientes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxClientes = new System.Windows.Forms.GroupBox();
            this.btnFiltrarClientes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInfAluguer = new System.Windows.Forms.Button();
            this.lbxAluguer = new System.Windows.Forms.ListBox();
            this.gbxAlugados = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirHistoricoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxAluguer.SuspendLayout();
            this.gbxClientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxAlugados.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarCarroAluguer
            // 
            this.btnEliminarCarroAluguer.Location = new System.Drawing.Point(210, 432);
            this.btnEliminarCarroAluguer.Name = "btnEliminarCarroAluguer";
            this.btnEliminarCarroAluguer.Size = new System.Drawing.Size(100, 23);
            this.btnEliminarCarroAluguer.TabIndex = 6;
            this.btnEliminarCarroAluguer.Text = "Eliminar Carro";
            this.btnEliminarCarroAluguer.UseVisualStyleBackColor = true;
            this.btnEliminarCarroAluguer.Click += new System.EventHandler(this.btnEliminarCarroAluguer_Click);
            // 
            // btnAddCarro
            // 
            this.btnAddCarro.Location = new System.Drawing.Point(6, 432);
            this.btnAddCarro.Name = "btnAddCarro";
            this.btnAddCarro.Size = new System.Drawing.Size(100, 23);
            this.btnAddCarro.TabIndex = 5;
            this.btnAddCarro.Text = "Adicionar Carro";
            this.btnAddCarro.UseVisualStyleBackColor = true;
            this.btnAddCarro.Click += new System.EventHandler(this.btnAddCarro_Click);
            // 
            // btnFiltrarAluguer
            // 
            this.btnFiltrarAluguer.Location = new System.Drawing.Point(242, 19);
            this.btnFiltrarAluguer.Name = "btnFiltrarAluguer";
            this.btnFiltrarAluguer.Size = new System.Drawing.Size(68, 23);
            this.btnFiltrarAluguer.TabIndex = 4;
            this.btnFiltrarAluguer.Text = "Filtrar";
            this.btnFiltrarAluguer.UseVisualStyleBackColor = true;
            // 
            // lbxCarrosAluguer
            // 
            this.lbxCarrosAluguer.FormattingEnabled = true;
            this.lbxCarrosAluguer.HorizontalScrollbar = true;
            this.lbxCarrosAluguer.Location = new System.Drawing.Point(6, 48);
            this.lbxCarrosAluguer.Name = "lbxCarrosAluguer";
            this.lbxCarrosAluguer.Size = new System.Drawing.Size(304, 381);
            this.lbxCarrosAluguer.TabIndex = 2;
            this.lbxCarrosAluguer.SelectedIndexChanged += new System.EventHandler(this.lbxListaCarrosAluguer_SelectedIndexChanged);
            // 
            // btnEliminarAluguer
            // 
            this.btnEliminarAluguer.Location = new System.Drawing.Point(370, 134);
            this.btnEliminarAluguer.Name = "btnEliminarAluguer";
            this.btnEliminarAluguer.Size = new System.Drawing.Size(105, 22);
            this.btnEliminarAluguer.TabIndex = 16;
            this.btnEliminarAluguer.Text = "Eliminar Aluguer";
            this.btnEliminarAluguer.UseVisualStyleBackColor = true;
            this.btnEliminarAluguer.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtpRececao
            // 
            this.dtpRececao.Location = new System.Drawing.Point(153, 149);
            this.dtpRececao.Name = "dtpRececao";
            this.dtpRececao.Size = new System.Drawing.Size(200, 20);
            this.dtpRececao.TabIndex = 15;
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Location = new System.Drawing.Point(153, 106);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(200, 20);
            this.dtpEntrega.TabIndex = 14;
            // 
            // btnEditarAluguer
            // 
            this.btnEditarAluguer.Location = new System.Drawing.Point(370, 90);
            this.btnEditarAluguer.Name = "btnEditarAluguer";
            this.btnEditarAluguer.Size = new System.Drawing.Size(105, 21);
            this.btnEditarAluguer.TabIndex = 13;
            this.btnEditarAluguer.Text = "Editar Aluguer";
            this.btnEditarAluguer.UseVisualStyleBackColor = true;
            this.btnEditarAluguer.Click += new System.EventHandler(this.btnEditarAluguer_Click);
            // 
            // btnAddAluguer
            // 
            this.btnAddAluguer.Location = new System.Drawing.Point(370, 48);
            this.btnAddAluguer.Name = "btnAddAluguer";
            this.btnAddAluguer.Size = new System.Drawing.Size(105, 22);
            this.btnAddAluguer.TabIndex = 12;
            this.btnAddAluguer.Text = "Adicionar Aluguer";
            this.btnAddAluguer.UseVisualStyleBackColor = true;
            this.btnAddAluguer.Click += new System.EventHandler(this.btnAddAluguer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 152);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data de Receção do veículo";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(153, 63);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(200, 20);
            this.tbxValor.TabIndex = 5;
            // 
            // tbxKms
            // 
            this.tbxKms.Location = new System.Drawing.Point(153, 21);
            this.tbxKms.Name = "tbxKms";
            this.tbxKms.Size = new System.Drawing.Size(200, 20);
            this.tbxKms.TabIndex = 4;
            // 
            // btnEditarCarroAluguer
            // 
            this.btnEditarCarroAluguer.Location = new System.Drawing.Point(109, 432);
            this.btnEditarCarroAluguer.Name = "btnEditarCarroAluguer";
            this.btnEditarCarroAluguer.Size = new System.Drawing.Size(100, 23);
            this.btnEditarCarroAluguer.TabIndex = 7;
            this.btnEditarCarroAluguer.Text = "Editar Carro";
            this.btnEditarCarroAluguer.UseVisualStyleBackColor = true;
            this.btnEditarCarroAluguer.Click += new System.EventHandler(this.btnEditarCarroAluguer_Click);
            // 
            // gbxAluguer
            // 
            this.gbxAluguer.Controls.Add(this.btnEditarCarroAluguer);
            this.gbxAluguer.Controls.Add(this.btnEliminarCarroAluguer);
            this.gbxAluguer.Controls.Add(this.btnAddCarro);
            this.gbxAluguer.Controls.Add(this.btnFiltrarAluguer);
            this.gbxAluguer.Controls.Add(this.tbxFiltrarAluguer);
            this.gbxAluguer.Controls.Add(this.lbxCarrosAluguer);
            this.gbxAluguer.Location = new System.Drawing.Point(331, 27);
            this.gbxAluguer.Name = "gbxAluguer";
            this.gbxAluguer.Size = new System.Drawing.Size(320, 461);
            this.gbxAluguer.TabIndex = 8;
            this.gbxAluguer.TabStop = false;
            this.gbxAluguer.Text = "Carros para Aluguer";
            // 
            // tbxFiltrarAluguer
            // 
            this.tbxFiltrarAluguer.Location = new System.Drawing.Point(6, 23);
            this.tbxFiltrarAluguer.Name = "tbxFiltrarAluguer";
            this.tbxFiltrarAluguer.Size = new System.Drawing.Size(230, 20);
            this.tbxFiltrarAluguer.TabIndex = 3;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de Kilimetros";
            // 
            // gbxClientes
            // 
            this.gbxClientes.Controls.Add(this.btnFiltrarClientes);
            this.gbxClientes.Controls.Add(this.textBox1);
            this.gbxClientes.Controls.Add(this.lbxClientes);
            this.gbxClientes.Location = new System.Drawing.Point(5, 27);
            this.gbxClientes.Name = "gbxClientes";
            this.gbxClientes.Size = new System.Drawing.Size(320, 461);
            this.gbxClientes.TabIndex = 9;
            this.gbxClientes.TabStop = false;
            this.gbxClientes.Text = "Clientes";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor do Aluguer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Entrega do veículo";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(657, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 183);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do aluguer";
            // 
            // btnInfAluguer
            // 
            this.btnInfAluguer.Location = new System.Drawing.Point(9, 237);
            this.btnInfAluguer.Name = "btnInfAluguer";
            this.btnInfAluguer.Size = new System.Drawing.Size(466, 22);
            this.btnInfAluguer.TabIndex = 17;
            this.btnInfAluguer.Text = "Infromações adicionais sobre o aluguer";
            this.btnInfAluguer.UseVisualStyleBackColor = true;
            this.btnInfAluguer.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxAluguer
            // 
            this.lbxAluguer.FormattingEnabled = true;
            this.lbxAluguer.HorizontalScrollbar = true;
            this.lbxAluguer.Location = new System.Drawing.Point(9, 19);
            this.lbxAluguer.Name = "lbxAluguer";
            this.lbxAluguer.Size = new System.Drawing.Size(466, 212);
            this.lbxAluguer.TabIndex = 3;
            this.lbxAluguer.SelectedIndexChanged += new System.EventHandler(this.lbxAluguer_SelectedIndexChanged);
            // 
            // gbxAlugados
            // 
            this.gbxAlugados.Controls.Add(this.btnInfAluguer);
            this.gbxAlugados.Controls.Add(this.lbxAluguer);
            this.gbxAlugados.Location = new System.Drawing.Point(657, 216);
            this.gbxAlugados.Name = "gbxAlugados";
            this.gbxAlugados.Size = new System.Drawing.Size(487, 272);
            this.gbxAlugados.TabIndex = 11;
            this.gbxAlugados.TabStop = false;
            this.gbxAlugados.Text = "Carros Alugados";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.aluguerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 24);
            this.menuStrip1.TabIndex = 12;
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
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // limparDadosToolStripMenuItem
            // 
            this.limparDadosToolStripMenuItem.Name = "limparDadosToolStripMenuItem";
            this.limparDadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.limparDadosToolStripMenuItem.Text = "Limpar Dados";
            this.limparDadosToolStripMenuItem.Click += new System.EventHandler(this.limparDadosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.criarCarroToolStripMenuItem.Click += new System.EventHandler(this.adicionarCarroToolStripMenuItem_Click);
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
            // imprimirHistoricoClienteToolStripMenuItem
            // 
            this.imprimirHistoricoClienteToolStripMenuItem.Name = "imprimirHistoricoClienteToolStripMenuItem";
            this.imprimirHistoricoClienteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.imprimirHistoricoClienteToolStripMenuItem.Text = "Imprimir Historico Cliente";
            this.imprimirHistoricoClienteToolStripMenuItem.Click += new System.EventHandler(this.imprimirHistoricoClienteToolStripMenuItem_Click);
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
            this.Text = "GestorAluguer";
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
        private System.Windows.Forms.Button btnFiltrarAluguer;
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
        private System.Windows.Forms.TextBox tbxFiltrarAluguer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbxClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxClientes;
        private System.Windows.Forms.Button btnFiltrarClientes;
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
    }
}