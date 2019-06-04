namespace Stand_Automoveis
{
    partial class New_Update_CarroVenda
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
            this.buttonAddCarro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCombustivelCarro = new System.Windows.Forms.TextBox();
            this.tbxModeloCarro = new System.Windows.Forms.TextBox();
            this.lblNif = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.tbxNumChassis = new System.Windows.Forms.TextBox();
            this.tbxMarcaCarro = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxExtras = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddCarro.Enabled = false;
            this.buttonAddCarro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddCarro.Location = new System.Drawing.Point(256, 179);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(114, 38);
            this.buttonAddCarro.TabIndex = 79;
            this.buttonAddCarro.Text = "Adicionar Carro";
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            this.buttonAddCarro.Click += new System.EventHandler(this.ButtonAddCarro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 78;
            this.label3.Text = "Combustível:";
            // 
            // tbxCombustivelCarro
            // 
            this.tbxCombustivelCarro.Location = new System.Drawing.Point(87, 89);
            this.tbxCombustivelCarro.Name = "tbxCombustivelCarro";
            this.tbxCombustivelCarro.Size = new System.Drawing.Size(283, 20);
            this.tbxCombustivelCarro.TabIndex = 72;
            this.tbxCombustivelCarro.TextChanged += new System.EventHandler(this.tbxCombustivelCarro_TextChanged);
            // 
            // tbxModeloCarro
            // 
            this.tbxModeloCarro.Location = new System.Drawing.Point(87, 38);
            this.tbxModeloCarro.Name = "tbxModeloCarro";
            this.tbxModeloCarro.Size = new System.Drawing.Size(283, 20);
            this.tbxModeloCarro.TabIndex = 69;
            this.tbxModeloCarro.TextChanged += new System.EventHandler(this.tbxModeloCarro_TextChanged);
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNif.Location = new System.Drawing.Point(29, 40);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(52, 15);
            this.lblNif.TabIndex = 76;
            this.lblNif.Text = "Modelo:";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorada.Location = new System.Drawing.Point(12, 66);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(69, 15);
            this.lblMorada.TabIndex = 75;
            this.lblMorada.Text = "Nº Chassis:";
            // 
            // tbxNumChassis
            // 
            this.tbxNumChassis.Location = new System.Drawing.Point(87, 63);
            this.tbxNumChassis.Name = "tbxNumChassis";
            this.tbxNumChassis.Size = new System.Drawing.Size(283, 20);
            this.tbxNumChassis.TabIndex = 71;
            this.tbxNumChassis.TextChanged += new System.EventHandler(this.tbxNumChassis_TextChanged);
            // 
            // tbxMarcaCarro
            // 
            this.tbxMarcaCarro.Location = new System.Drawing.Point(87, 12);
            this.tbxMarcaCarro.Name = "tbxMarcaCarro";
            this.tbxMarcaCarro.Size = new System.Drawing.Size(283, 20);
            this.tbxMarcaCarro.TabIndex = 68;
            this.tbxMarcaCarro.TextChanged += new System.EventHandler(this.tbxMarcaCarro_TextChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(36, 14);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 15);
            this.labelNome.TabIndex = 73;
            this.labelNome.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 77;
            this.label2.Text = "Extras:";
            // 
            // tbxExtras
            // 
            this.tbxExtras.Location = new System.Drawing.Point(87, 115);
            this.tbxExtras.Multiline = true;
            this.tbxExtras.Name = "tbxExtras";
            this.tbxExtras.Size = new System.Drawing.Size(283, 58);
            this.tbxExtras.TabIndex = 80;
            this.tbxExtras.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // New_Update_CarroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 227);
            this.Controls.Add(this.tbxExtras);
            this.Controls.Add(this.buttonAddCarro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCombustivelCarro);
            this.Controls.Add(this.tbxModeloCarro);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.tbxNumChassis);
            this.Controls.Add(this.tbxMarcaCarro);
            this.Controls.Add(this.labelNome);
            this.Name = "New_Update_CarroVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddCarro;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxCombustivelCarro;
        public System.Windows.Forms.TextBox tbxModeloCarro;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label lblMorada;
        public System.Windows.Forms.TextBox tbxNumChassis;
        public System.Windows.Forms.TextBox tbxMarcaCarro;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxExtras;
    }
}