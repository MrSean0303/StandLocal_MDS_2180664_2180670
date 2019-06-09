namespace Stand_Automoveis
{
    partial class Form_AddEdit_Carro
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
            this.nudKms = new System.Windows.Forms.NumericUpDown();
            this.toolTipKms = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxKms = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKms)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.buttonAddCarro.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddCarro.Enabled = false;
            this.buttonAddCarro.FlatAppearance.BorderSize = 0;
            this.buttonAddCarro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
            this.buttonAddCarro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(156)))), ((int)(((byte)(178)))));
            this.buttonAddCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCarro.Location = new System.Drawing.Point(277, 168);
            this.buttonAddCarro.Margin = new System.Windows.Forms.Padding(6, 6, 3, 6);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(101, 28);
            this.buttonAddCarro.TabIndex = 6;
            this.buttonAddCarro.Text = "Continuar";
            this.buttonAddCarro.UseVisualStyleBackColor = false;
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
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Quilómetros:";
            // 
            // tbxCombustivelCarro
            // 
            this.tbxCombustivelCarro.Location = new System.Drawing.Point(95, 139);
            this.tbxCombustivelCarro.Name = "tbxCombustivelCarro";
            this.tbxCombustivelCarro.Size = new System.Drawing.Size(283, 20);
            this.tbxCombustivelCarro.TabIndex = 5;
            this.tbxCombustivelCarro.TextChanged += new System.EventHandler(this.TbxCombustivelCarro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Combustível:";
            // 
            // nudKms
            // 
            this.nudKms.Location = new System.Drawing.Point(95, 113);
            this.nudKms.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudKms.Name = "nudKms";
            this.nudKms.Size = new System.Drawing.Size(283, 20);
            this.nudKms.TabIndex = 4;
            this.nudKms.ValueChanged += new System.EventHandler(this.NudKms_ValueChanged);
            // 
            // toolTipKms
            // 
            this.toolTipKms.AutoPopDelay = 5000;
            this.toolTipKms.InitialDelay = 400;
            this.toolTipKms.IsBalloon = true;
            this.toolTipKms.ReshowDelay = 100;
            this.toolTipKms.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipKms.ToolTipTitle = "Valor é nulo";
            // 
            // pictureBoxKms
            // 
            this.pictureBoxKms.Image = global::Stand_Automoveis.Properties.Resources.StatusWarning_exp_16x;
            this.pictureBoxKms.Location = new System.Drawing.Point(381, 115);
            this.pictureBoxKms.Name = "pictureBoxKms";
            this.pictureBoxKms.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxKms.TabIndex = 43;
            this.pictureBoxKms.TabStop = false;
            this.toolTipKms.SetToolTip(this.pictureBoxKms, "Atenção! O valor introduzido é nulo.");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(167, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form_AddEdit_Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 204);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBoxKms);
            this.Controls.Add(this.nudKms);
            this.Controls.Add(this.label3);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AddEdit_Carro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Carro (Oficina)";
            ((System.ComponentModel.ISupportInitialize)(this.nudKms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKms)).EndInit();
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
        public System.Windows.Forms.Button buttonAddCarro;
        public System.Windows.Forms.NumericUpDown nudKms;
        private System.Windows.Forms.ToolTip toolTipKms;
        private System.Windows.Forms.PictureBox pictureBoxKms;
        public System.Windows.Forms.Button button2;
    }
}