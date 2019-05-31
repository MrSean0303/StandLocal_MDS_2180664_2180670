namespace Stand_Automoveis
{
    partial class New_Update_Carro
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
            this.tbxModeloCarro = new System.Windows.Forms.TextBox();
            this.lblNif = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.tbxNumChassis = new System.Windows.Forms.TextBox();
            this.tbxMatriculaCarro = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.tbxMarcaCarro = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCombustivelCarro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxKms = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddCarro.Enabled = false;
            this.buttonAddCarro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddCarro.Location = new System.Drawing.Point(264, 171);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(114, 38);
            this.buttonAddCarro.TabIndex = 6;
            this.buttonAddCarro.Text = "Adicionar Carro";
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            this.buttonAddCarro.Click += new System.EventHandler(this.ButtonAddCarro_Click);
            // 
            // tbxModeloCarro
            // 
            this.tbxModeloCarro.Location = new System.Drawing.Point(95, 36);
            this.tbxModeloCarro.Name = "tbxModeloCarro";
            this.tbxModeloCarro.Size = new System.Drawing.Size(283, 20);
            this.tbxModeloCarro.TabIndex = 1;
            this.tbxModeloCarro.TextChanged += new System.EventHandler(this.TbxModeloCarro_TextChanged);
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNif.Location = new System.Drawing.Point(12, 37);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(52, 15);
            this.lblNif.TabIndex = 34;
            this.lblNif.Text = "Modelo:";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorada.Location = new System.Drawing.Point(12, 88);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(69, 15);
            this.lblMorada.TabIndex = 32;
            this.lblMorada.Text = "Nº Chassis:";
            // 
            // tbxNumChassis
            // 
            this.tbxNumChassis.Location = new System.Drawing.Point(95, 87);
            this.tbxNumChassis.Name = "tbxNumChassis";
            this.tbxNumChassis.Size = new System.Drawing.Size(283, 20);
            this.tbxNumChassis.TabIndex = 3;
            this.tbxNumChassis.TextChanged += new System.EventHandler(this.TbxNumChassis_TextChanged);
            // 
            // tbxMatriculaCarro
            // 
            this.tbxMatriculaCarro.Location = new System.Drawing.Point(95, 62);
            this.tbxMatriculaCarro.Name = "tbxMatriculaCarro";
            this.tbxMatriculaCarro.Size = new System.Drawing.Size(283, 20);
            this.tbxMatriculaCarro.TabIndex = 2;
            this.tbxMatriculaCarro.TextChanged += new System.EventHandler(this.TbxMatriculaCarro_TextChanged);
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(12, 63);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(61, 15);
            this.lblContacto.TabIndex = 30;
            this.lblContacto.Text = "Matrícula:";
            // 
            // tbxMarcaCarro
            // 
            this.tbxMarcaCarro.Location = new System.Drawing.Point(95, 12);
            this.tbxMarcaCarro.Name = "tbxMarcaCarro";
            this.tbxMarcaCarro.Size = new System.Drawing.Size(283, 20);
            this.tbxMarcaCarro.TabIndex = 0;
            this.tbxMarcaCarro.TextChanged += new System.EventHandler(this.TbxMarcaCarro_TextChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(12, 13);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 15);
            this.labelNome.TabIndex = 28;
            this.labelNome.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Quilómetros:";
            // 
            // tbxCombustivelCarro
            // 
            this.tbxCombustivelCarro.Location = new System.Drawing.Point(95, 113);
            this.tbxCombustivelCarro.Name = "tbxCombustivelCarro";
            this.tbxCombustivelCarro.Size = new System.Drawing.Size(283, 20);
            this.tbxCombustivelCarro.TabIndex = 4;
            this.tbxCombustivelCarro.TextChanged += new System.EventHandler(this.TbxCombustivelCarro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Combustível:";
            // 
            // tbxKms
            // 
            this.tbxKms.Location = new System.Drawing.Point(95, 139);
            this.tbxKms.Name = "tbxKms";
            this.tbxKms.Size = new System.Drawing.Size(283, 20);
            this.tbxKms.TabIndex = 5;
            this.tbxKms.TextChanged += new System.EventHandler(this.TbxKms_TextChanged);
            // 
            // New_Update_Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 221);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxKms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCombustivelCarro);
            this.Controls.Add(this.buttonAddCarro);
            this.Controls.Add(this.tbxModeloCarro);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.tbxNumChassis);
            this.Controls.Add(this.tbxMatriculaCarro);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.tbxMarcaCarro);
            this.Controls.Add(this.labelNome);
            this.Name = "New_Update_Carro";
            this.Text = "Adicionar Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tbxModeloCarro;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label lblMorada;
        public System.Windows.Forms.TextBox tbxNumChassis;
        public System.Windows.Forms.TextBox tbxMatriculaCarro;
        private System.Windows.Forms.Label lblContacto;
        public System.Windows.Forms.TextBox tbxMarcaCarro;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxCombustivelCarro;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxKms;
        public System.Windows.Forms.Button buttonAddCarro;
    }
}