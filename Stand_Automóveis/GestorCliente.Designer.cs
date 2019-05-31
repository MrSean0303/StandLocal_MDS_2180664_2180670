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
            this.lbListaClientes = new System.Windows.Forms.ListBox();
            this.gbxClientes = new System.Windows.Forms.GroupBox();
            this.btnCriarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.gbxDadosCliente = new System.Windows.Forms.GroupBox();
            this.gbxInformacaoCliente = new System.Windows.Forms.GroupBox();
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
            // lbListaClientes
            // 
            this.lbListaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbListaClientes.FormattingEnabled = true;
            this.lbListaClientes.HorizontalScrollbar = true;
            this.lbListaClientes.Location = new System.Drawing.Point(6, 19);
            this.lbListaClientes.Name = "lbListaClientes";
            this.lbListaClientes.Size = new System.Drawing.Size(275, 355);
            this.lbListaClientes.TabIndex = 0;
            this.lbListaClientes.SelectedIndexChanged += new System.EventHandler(this.lblListaClientes_SelectedIndexChanged);
            // 
            // gbxClientes
            // 
            this.gbxClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxClientes.Controls.Add(this.btnCriarCliente);
            this.gbxClientes.Controls.Add(this.btnEliminarCliente);
            this.gbxClientes.Controls.Add(this.lbListaClientes);
            this.gbxClientes.Location = new System.Drawing.Point(12, 27);
            this.gbxClientes.Name = "gbxClientes";
            this.gbxClientes.Size = new System.Drawing.Size(287, 411);
            this.gbxClientes.TabIndex = 2;
            this.gbxClientes.TabStop = false;
            this.gbxClientes.Text = "Clientes";
            // 
            // btnCriarCliente
            // 
            this.btnCriarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCriarCliente.Location = new System.Drawing.Point(190, 379);
            this.btnCriarCliente.Name = "btnCriarCliente";
            this.btnCriarCliente.Size = new System.Drawing.Size(91, 22);
            this.btnCriarCliente.TabIndex = 2;
            this.btnCriarCliente.Text = "Novo Cliente";
            this.btnCriarCliente.UseVisualStyleBackColor = true;
            this.btnCriarCliente.Click += new System.EventHandler(this.BtnCriarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarCliente.Location = new System.Drawing.Point(6, 379);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(91, 22);
            this.btnEliminarCliente.TabIndex = 1;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.BtnEliminarCliente_Click);
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
            this.gbxDadosCliente.Size = new System.Drawing.Size(575, 411);
            this.gbxDadosCliente.TabIndex = 3;
            this.gbxDadosCliente.TabStop = false;
            this.gbxDadosCliente.Text = "Dados do Cliente";
            // 
            // gbxInformacaoCliente
            // 
            this.gbxInformacaoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxInformacaoCliente.Controls.Add(this.lblNumCarrosComprados);
            this.gbxInformacaoCliente.Controls.Add(this.lblNumCarroAluguer);
            this.gbxInformacaoCliente.Controls.Add(this.lblNumCarrosOficina);
            this.gbxInformacaoCliente.Controls.Add(this.lblNumCarrosCompradosTexto);
            this.gbxInformacaoCliente.Controls.Add(this.lblNumCarroAluguerText);
            this.gbxInformacaoCliente.Controls.Add(this.lblNumCarrosOficinaText);
            this.gbxInformacaoCliente.Location = new System.Drawing.Point(7, 151);
            this.gbxInformacaoCliente.Name = "gbxInformacaoCliente";
            this.gbxInformacaoCliente.Size = new System.Drawing.Size(553, 250);
            this.gbxInformacaoCliente.TabIndex = 1;
            this.gbxInformacaoCliente.TabStop = false;
            this.gbxInformacaoCliente.Text = "Informacão do Cliente";
            // 
            // lblNumCarrosComprados
            // 
            this.lblNumCarrosComprados.AutoSize = true;
            this.lblNumCarrosComprados.Location = new System.Drawing.Point(180, 170);
            this.lblNumCarrosComprados.Name = "lblNumCarrosComprados";
            this.lblNumCarrosComprados.Size = new System.Drawing.Size(144, 13);
            this.lblNumCarrosComprados.TabIndex = 5;
            this.lblNumCarrosComprados.Text = "Nenhum Cliente Selecionado";
            // 
            // lblNumCarroAluguer
            // 
            this.lblNumCarroAluguer.AutoSize = true;
            this.lblNumCarroAluguer.Location = new System.Drawing.Point(167, 105);
            this.lblNumCarroAluguer.Name = "lblNumCarroAluguer";
            this.lblNumCarroAluguer.Size = new System.Drawing.Size(144, 13);
            this.lblNumCarroAluguer.TabIndex = 4;
            this.lblNumCarroAluguer.Text = "Nenhum Cliente Selecionado";
            // 
            // lblNumCarrosOficina
            // 
            this.lblNumCarrosOficina.AutoSize = true;
            this.lblNumCarrosOficina.Location = new System.Drawing.Point(171, 40);
            this.lblNumCarrosOficina.Name = "lblNumCarrosOficina";
            this.lblNumCarrosOficina.Size = new System.Drawing.Size(144, 13);
            this.lblNumCarrosOficina.TabIndex = 3;
            this.lblNumCarrosOficina.Text = "Nenhum Cliente Selecionado";
            // 
            // lblNumCarrosCompradosTexto
            // 
            this.lblNumCarrosCompradosTexto.AutoSize = true;
            this.lblNumCarrosCompradosTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCarrosCompradosTexto.Location = new System.Drawing.Point(6, 168);
            this.lblNumCarrosCompradosTexto.Name = "lblNumCarrosCompradosTexto";
            this.lblNumCarrosCompradosTexto.Size = new System.Drawing.Size(178, 15);
            this.lblNumCarrosCompradosTexto.TabIndex = 2;
            this.lblNumCarrosCompradosTexto.Text = "Numero de Carros Comprados:";
            // 
            // lblNumCarroAluguerText
            // 
            this.lblNumCarroAluguerText.AutoSize = true;
            this.lblNumCarroAluguerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCarroAluguerText.Location = new System.Drawing.Point(6, 103);
            this.lblNumCarroAluguerText.Name = "lblNumCarroAluguerText";
            this.lblNumCarroAluguerText.Size = new System.Drawing.Size(165, 15);
            this.lblNumCarroAluguerText.TabIndex = 1;
            this.lblNumCarroAluguerText.Text = "Numero de Carros Alugados:";
            // 
            // lblNumCarrosOficinaText
            // 
            this.lblNumCarrosOficinaText.AutoSize = true;
            this.lblNumCarrosOficinaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCarrosOficinaText.Location = new System.Drawing.Point(6, 38);
            this.lblNumCarrosOficinaText.Name = "lblNumCarrosOficinaText";
            this.lblNumCarrosOficinaText.Size = new System.Drawing.Size(169, 15);
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
            this.panelEditarCliente.Size = new System.Drawing.Size(553, 125);
            this.panelEditarCliente.TabIndex = 0;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditarCliente.Location = new System.Drawing.Point(417, 86);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(126, 33);
            this.btnEditarCliente.TabIndex = 4;
            this.btnEditarCliente.Text = "Editar Dados do Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.BtnEditarCliente_Click);
            // 
            // tbAlterarNif
            // 
            this.tbAlterarNif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlterarNif.Location = new System.Drawing.Point(415, 31);
            this.tbAlterarNif.Name = "tbAlterarNif";
            this.tbAlterarNif.Size = new System.Drawing.Size(128, 20);
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
            this.tbAlterarMorada.Size = new System.Drawing.Size(451, 20);
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
            this.lblContacto.Location = new System.Drawing.Point(6, 34);
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
            this.tbAlterarNome.Size = new System.Drawing.Size(451, 20);
            this.tbAlterarNome.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(6, 6);
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
            this.Text = "GestorClientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestorCliente_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxClientes.ResumeLayout(false);
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
        public System.Windows.Forms.ListBox lbListaClientes;
    }
}