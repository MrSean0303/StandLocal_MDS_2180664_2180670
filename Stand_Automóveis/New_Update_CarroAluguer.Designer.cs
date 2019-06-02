namespace Stand_Automoveis
{
    partial class New_Update_CarroAluguer
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
            this.cbxEstadoCarro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCombustivelCarro = new System.Windows.Forms.TextBox();
            this.tbxModeloCarro = new System.Windows.Forms.TextBox();
            this.lblNif = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.tbxNumChassis = new System.Windows.Forms.TextBox();
            this.tbxMatriculaCarro = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.tbxMarcaCarro = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddCarro.Enabled = false;
            this.buttonAddCarro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddCarro.Location = new System.Drawing.Point(248, 166);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(114, 38);
            this.buttonAddCarro.TabIndex = 66;
            this.buttonAddCarro.Text = "Adicionar Carro";
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            this.buttonAddCarro.Click += new System.EventHandler(this.buttonAddCarro_Click);
            // 
            // cbxEstadoCarro
            // 
            this.cbxEstadoCarro.FormattingEnabled = true;
            this.cbxEstadoCarro.Location = new System.Drawing.Point(79, 139);
            this.cbxEstadoCarro.Name = "cbxEstadoCarro";
            this.cbxEstadoCarro.Size = new System.Drawing.Size(283, 21);
            this.cbxEstadoCarro.TabIndex = 92;
            this.cbxEstadoCarro.TextChanged += new System.EventHandler(this.cbxEstadoCarro_SelectedIndexChanged);
            this.cbxEstadoCarro.Click += new System.EventHandler(this.cbxEstadoCarro_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 91;
            this.label3.Text = "Combustível:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 90;
            this.label2.Text = "Estado:";
            // 
            // tbxCombustivelCarro
            // 
            this.tbxCombustivelCarro.Location = new System.Drawing.Point(79, 110);
            this.tbxCombustivelCarro.Name = "tbxCombustivelCarro";
            this.tbxCombustivelCarro.Size = new System.Drawing.Size(283, 20);
            this.tbxCombustivelCarro.TabIndex = 85;
            this.tbxCombustivelCarro.Click += new System.EventHandler(this.TbxCombustivelCarro_TextChanged);
            this.tbxCombustivelCarro.TextChanged += new System.EventHandler(this.TbxCombustivelCarro_TextChanged);
            // 
            // tbxModeloCarro
            // 
            this.tbxModeloCarro.Location = new System.Drawing.Point(79, 33);
            this.tbxModeloCarro.Name = "tbxModeloCarro";
            this.tbxModeloCarro.Size = new System.Drawing.Size(283, 20);
            this.tbxModeloCarro.TabIndex = 82;
            this.tbxModeloCarro.Click += new System.EventHandler(this.TbxModeloCarro_TextChanged);
            this.tbxModeloCarro.TextChanged += new System.EventHandler(this.TbxModeloCarro_TextChanged);
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNif.Location = new System.Drawing.Point(21, 35);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(52, 15);
            this.lblNif.TabIndex = 89;
            this.lblNif.Text = "Modelo:";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorada.Location = new System.Drawing.Point(4, 87);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(69, 15);
            this.lblMorada.TabIndex = 88;
            this.lblMorada.Text = "Nº Chassis:";
            // 
            // tbxNumChassis
            // 
            this.tbxNumChassis.Location = new System.Drawing.Point(79, 84);
            this.tbxNumChassis.Name = "tbxNumChassis";
            this.tbxNumChassis.Size = new System.Drawing.Size(283, 20);
            this.tbxNumChassis.TabIndex = 84;
            this.tbxNumChassis.Click += new System.EventHandler(this.TbxNumChassis_TextChanged);
            this.tbxNumChassis.TextChanged += new System.EventHandler(this.TbxNumChassis_TextChanged);
            // 
            // tbxMatriculaCarro
            // 
            this.tbxMatriculaCarro.Location = new System.Drawing.Point(79, 59);
            this.tbxMatriculaCarro.Name = "tbxMatriculaCarro";
            this.tbxMatriculaCarro.Size = new System.Drawing.Size(283, 20);
            this.tbxMatriculaCarro.TabIndex = 83;
            this.tbxMatriculaCarro.Click += new System.EventHandler(this.TbxMatriculaCarro_TextChanged);
            this.tbxMatriculaCarro.TextChanged += new System.EventHandler(this.TbxMatriculaCarro_TextChanged);
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(12, 62);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(61, 15);
            this.lblContacto.TabIndex = 87;
            this.lblContacto.Text = "Matrícula:";
            // 
            // tbxMarcaCarro
            // 
            this.tbxMarcaCarro.Location = new System.Drawing.Point(79, 7);
            this.tbxMarcaCarro.Name = "tbxMarcaCarro";
            this.tbxMarcaCarro.Size = new System.Drawing.Size(283, 20);
            this.tbxMarcaCarro.TabIndex = 81;
            this.tbxMarcaCarro.Click += new System.EventHandler(this.TbxMarcaCarro_TextChanged);
            this.tbxMarcaCarro.TextChanged += new System.EventHandler(this.TbxMarcaCarro_TextChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(28, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 15);
            this.labelNome.TabIndex = 86;
            this.labelNome.Text = "Marca:";
            // 
            // New_Update_CarroAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 216);
            this.Controls.Add(this.cbxEstadoCarro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCombustivelCarro);
            this.Controls.Add(this.tbxModeloCarro);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.tbxNumChassis);
            this.Controls.Add(this.tbxMatriculaCarro);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.tbxMarcaCarro);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonAddCarro);
            this.Name = "New_Update_CarroAluguer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddCarro;
        private System.Windows.Forms.ComboBox cbxEstadoCarro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxCombustivelCarro;
        public System.Windows.Forms.TextBox tbxModeloCarro;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label lblMorada;
        public System.Windows.Forms.TextBox tbxNumChassis;
        public System.Windows.Forms.TextBox tbxMatriculaCarro;
        private System.Windows.Forms.Label lblContacto;
        public System.Windows.Forms.TextBox tbxMarcaCarro;
        private System.Windows.Forms.Label labelNome;
    }
}