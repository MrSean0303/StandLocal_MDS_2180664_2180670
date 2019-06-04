namespace Stand_Automoveis
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnGestaoVenda = new System.Windows.Forms.Button();
            this.btnGestaoAluguer = new System.Windows.Forms.Button();
            this.btnGestaoOficina = new System.Windows.Forms.Button();
            this.btnGestaoClientes = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 341);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(763, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHora
            // 
            this.toolStripStatusLabelHora.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabelHora.Name = "toolStripStatusLabelHora";
            this.toolStripStatusLabelHora.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabelHora.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Olá! Selecione uma opção para continuar.";
            // 
            // btnGestaoVenda
            // 
            this.btnGestaoVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestaoVenda.FlatAppearance.BorderSize = 0;
            this.btnGestaoVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnGestaoVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(45)))));
            this.btnGestaoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestaoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestaoVenda.ForeColor = System.Drawing.Color.White;
            this.btnGestaoVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnGestaoVenda.Image")));
            this.btnGestaoVenda.Location = new System.Drawing.Point(532, 93);
            this.btnGestaoVenda.Name = "btnGestaoVenda";
            this.btnGestaoVenda.Size = new System.Drawing.Size(143, 164);
            this.btnGestaoVenda.TabIndex = 9;
            this.btnGestaoVenda.Text = " Gestão de Vendas";
            this.btnGestaoVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnGestaoVenda.UseVisualStyleBackColor = true;
            this.btnGestaoVenda.Click += new System.EventHandler(this.BtnGestaoVenda_Click_1);
            // 
            // btnGestaoAluguer
            // 
            this.btnGestaoAluguer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestaoAluguer.FlatAppearance.BorderSize = 0;
            this.btnGestaoAluguer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnGestaoAluguer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(45)))));
            this.btnGestaoAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestaoAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestaoAluguer.ForeColor = System.Drawing.Color.White;
            this.btnGestaoAluguer.Image = ((System.Drawing.Image)(resources.GetObject("btnGestaoAluguer.Image")));
            this.btnGestaoAluguer.Location = new System.Drawing.Point(383, 93);
            this.btnGestaoAluguer.Name = "btnGestaoAluguer";
            this.btnGestaoAluguer.Size = new System.Drawing.Size(143, 164);
            this.btnGestaoAluguer.TabIndex = 8;
            this.btnGestaoAluguer.Text = " Gestão de Aluguer ";
            this.btnGestaoAluguer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnGestaoAluguer.UseVisualStyleBackColor = true;
            this.btnGestaoAluguer.Click += new System.EventHandler(this.BtnGestaoAluguer_Click_1);
            // 
            // btnGestaoOficina
            // 
            this.btnGestaoOficina.BackColor = System.Drawing.Color.Transparent;
            this.btnGestaoOficina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestaoOficina.FlatAppearance.BorderSize = 0;
            this.btnGestaoOficina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnGestaoOficina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(45)))));
            this.btnGestaoOficina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestaoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestaoOficina.ForeColor = System.Drawing.Color.White;
            this.btnGestaoOficina.Image = ((System.Drawing.Image)(resources.GetObject("btnGestaoOficina.Image")));
            this.btnGestaoOficina.Location = new System.Drawing.Point(234, 93);
            this.btnGestaoOficina.Name = "btnGestaoOficina";
            this.btnGestaoOficina.Size = new System.Drawing.Size(143, 164);
            this.btnGestaoOficina.TabIndex = 7;
            this.btnGestaoOficina.Text = " Gestão de Oficina ";
            this.btnGestaoOficina.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnGestaoOficina.UseVisualStyleBackColor = false;
            this.btnGestaoOficina.Click += new System.EventHandler(this.BtnGestaoOficina_Click_1);
            // 
            // btnGestaoClientes
            // 
            this.btnGestaoClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(28)))));
            this.btnGestaoClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestaoClientes.FlatAppearance.BorderSize = 0;
            this.btnGestaoClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnGestaoClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(45)))));
            this.btnGestaoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestaoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestaoClientes.ForeColor = System.Drawing.Color.White;
            this.btnGestaoClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnGestaoClientes.Image")));
            this.btnGestaoClientes.Location = new System.Drawing.Point(88, 93);
            this.btnGestaoClientes.Name = "btnGestaoClientes";
            this.btnGestaoClientes.Size = new System.Drawing.Size(143, 164);
            this.btnGestaoClientes.TabIndex = 6;
            this.btnGestaoClientes.Text = " Gestão de Clientes ";
            this.btnGestaoClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnGestaoClientes.UseVisualStyleBackColor = false;
            this.btnGestaoClientes.Click += new System.EventHandler(this.BtnGestaoClientes_Click_1);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(763, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGestaoVenda);
            this.Controls.Add(this.btnGestaoAluguer);
            this.Controls.Add(this.btnGestaoOficina);
            this.Controls.Add(this.btnGestaoClientes);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stand Local";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestaoVenda;
        private System.Windows.Forms.Button btnGestaoAluguer;
        private System.Windows.Forms.Button btnGestaoOficina;
        private System.Windows.Forms.Button btnGestaoClientes;
    }
}

