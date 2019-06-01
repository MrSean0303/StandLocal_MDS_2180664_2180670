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
            this.btnEliminarAluguer = new System.Windows.Forms.Button();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnEditarAluguer = new System.Windows.Forms.Button();
            this.btnAddVenda = new System.Windows.Forms.Button();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.tbxKms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxVendas = new System.Windows.Forms.ListBox();
            this.gbxAlugados = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btnEditarCarroAluguer = new System.Windows.Forms.Button();
            this.btnEliminarCarroAluguer = new System.Windows.Forms.Button();
            this.btnAddCarro = new System.Windows.Forms.Button();
            this.btnFiltrarVenda = new System.Windows.Forms.Button();
            this.tbxFiltrarVenda = new System.Windows.Forms.TextBox();
            this.lbxCarrosVenda = new System.Windows.Forms.ListBox();
            this.gbxAluguer = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gbxAlugados.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbxClientes.SuspendLayout();
            this.gbxAluguer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarAluguer);
            this.groupBox1.Controls.Add(this.dtpEntrega);
            this.groupBox1.Controls.Add(this.btnEditarAluguer);
            this.groupBox1.Controls.Add(this.btnAddVenda);
            this.groupBox1.Controls.Add(this.tbxValor);
            this.groupBox1.Controls.Add(this.tbxKms);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(664, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 148);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Venda";
            // 
            // btnEliminarAluguer
            // 
            this.btnEliminarAluguer.Location = new System.Drawing.Point(370, 105);
            this.btnEliminarAluguer.Name = "btnEliminarAluguer";
            this.btnEliminarAluguer.Size = new System.Drawing.Size(105, 22);
            this.btnEliminarAluguer.TabIndex = 16;
            this.btnEliminarAluguer.Text = "Eliminar Venda";
            this.btnEliminarAluguer.UseVisualStyleBackColor = true;
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Location = new System.Drawing.Point(110, 106);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(243, 20);
            this.dtpEntrega.TabIndex = 14;
            // 
            // btnEditarAluguer
            // 
            this.btnEditarAluguer.Location = new System.Drawing.Point(370, 61);
            this.btnEditarAluguer.Name = "btnEditarAluguer";
            this.btnEditarAluguer.Size = new System.Drawing.Size(105, 21);
            this.btnEditarAluguer.TabIndex = 13;
            this.btnEditarAluguer.Text = "Editar Venda";
            this.btnEditarAluguer.UseVisualStyleBackColor = true;
            // 
            // btnAddVenda
            // 
            this.btnAddVenda.Location = new System.Drawing.Point(370, 19);
            this.btnAddVenda.Name = "btnAddVenda";
            this.btnAddVenda.Size = new System.Drawing.Size(105, 22);
            this.btnAddVenda.TabIndex = 12;
            this.btnAddVenda.Text = "Adicionar Venda";
            this.btnAddVenda.UseVisualStyleBackColor = true;
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(110, 63);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(243, 20);
            this.tbxValor.TabIndex = 5;
            // 
            // tbxKms
            // 
            this.tbxKms.Location = new System.Drawing.Point(110, 21);
            this.tbxKms.Name = "tbxKms";
            this.tbxKms.Size = new System.Drawing.Size(243, 20);
            this.tbxKms.TabIndex = 4;
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
            // 
            // gbxAlugados
            // 
            this.gbxAlugados.Controls.Add(this.button1);
            this.gbxAlugados.Controls.Add(this.lbxVendas);
            this.gbxAlugados.Location = new System.Drawing.Point(664, 181);
            this.gbxAlugados.Name = "gbxAlugados";
            this.gbxAlugados.Size = new System.Drawing.Size(487, 307);
            this.gbxAlugados.TabIndex = 16;
            this.gbxAlugados.TabStop = false;
            this.gbxAlugados.Text = "Vendas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(466, 22);
            this.button1.TabIndex = 17;
            this.button1.Text = "Infromações adicionais sobre o aluguer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.aluguerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1268, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
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
            // 
            // editarCarroToolStripMenuItem
            // 
            this.editarCarroToolStripMenuItem.Name = "editarCarroToolStripMenuItem";
            this.editarCarroToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editarCarroToolStripMenuItem.Text = "Editar Carro";
            // 
            // eliminarCarroToolStripMenuItem
            // 
            this.eliminarCarroToolStripMenuItem.Name = "eliminarCarroToolStripMenuItem";
            this.eliminarCarroToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.eliminarCarroToolStripMenuItem.Text = "Eliminar Carro";
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
            this.gbxClientes.Location = new System.Drawing.Point(12, 27);
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
            // 
            // btnEditarCarroAluguer
            // 
            this.btnEditarCarroAluguer.Location = new System.Drawing.Point(109, 432);
            this.btnEditarCarroAluguer.Name = "btnEditarCarroAluguer";
            this.btnEditarCarroAluguer.Size = new System.Drawing.Size(100, 23);
            this.btnEditarCarroAluguer.TabIndex = 7;
            this.btnEditarCarroAluguer.Text = "Editar Carro";
            this.btnEditarCarroAluguer.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCarroAluguer
            // 
            this.btnEliminarCarroAluguer.Location = new System.Drawing.Point(210, 432);
            this.btnEliminarCarroAluguer.Name = "btnEliminarCarroAluguer";
            this.btnEliminarCarroAluguer.Size = new System.Drawing.Size(100, 23);
            this.btnEliminarCarroAluguer.TabIndex = 6;
            this.btnEliminarCarroAluguer.Text = "Eliminar Carro";
            this.btnEliminarCarroAluguer.UseVisualStyleBackColor = true;
            // 
            // btnAddCarro
            // 
            this.btnAddCarro.Location = new System.Drawing.Point(6, 432);
            this.btnAddCarro.Name = "btnAddCarro";
            this.btnAddCarro.Size = new System.Drawing.Size(100, 23);
            this.btnAddCarro.TabIndex = 5;
            this.btnAddCarro.Text = "Adicionar Carro";
            this.btnAddCarro.UseVisualStyleBackColor = true;
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
            // 
            // gbxAluguer
            // 
            this.gbxAluguer.Controls.Add(this.btnEditarCarroAluguer);
            this.gbxAluguer.Controls.Add(this.btnEliminarCarroAluguer);
            this.gbxAluguer.Controls.Add(this.btnAddCarro);
            this.gbxAluguer.Controls.Add(this.btnFiltrarVenda);
            this.gbxAluguer.Controls.Add(this.tbxFiltrarVenda);
            this.gbxAluguer.Controls.Add(this.lbxCarrosVenda);
            this.gbxAluguer.Location = new System.Drawing.Point(338, 27);
            this.gbxAluguer.Name = "gbxAluguer";
            this.gbxAluguer.Size = new System.Drawing.Size(320, 461);
            this.gbxAluguer.TabIndex = 13;
            this.gbxAluguer.TabStop = false;
            this.gbxAluguer.Text = "Carros para Vender";
            // 
            // GestorVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxAlugados);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbxClientes);
            this.Controls.Add(this.gbxAluguer);
            this.Name = "GestorVenda";
            this.Text = "GertorVenda";
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
        private System.Windows.Forms.Button btnEliminarAluguer;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.Button btnEditarAluguer;
        private System.Windows.Forms.Button btnAddVenda;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.TextBox tbxKms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox lbxVendas;
        private System.Windows.Forms.GroupBox gbxAlugados;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button btnEditarCarroAluguer;
        private System.Windows.Forms.Button btnEliminarCarroAluguer;
        private System.Windows.Forms.Button btnAddCarro;
        private System.Windows.Forms.Button btnFiltrarVenda;
        private System.Windows.Forms.TextBox tbxFiltrarVenda;
        public System.Windows.Forms.ListBox lbxCarrosVenda;
        private System.Windows.Forms.GroupBox gbxAluguer;
    }
}