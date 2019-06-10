namespace Stand_Automoveis
{
    partial class Form_AddEdit_Parcela
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
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.buttonAddParcela = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.pictureBoxValor = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTipValor = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValor)).BeginInit();
            this.SuspendLayout();
            // 
            // numValor
            // 
            this.numValor.DecimalPlaces = 2;
            this.numValor.Location = new System.Drawing.Point(83, 7);
            this.numValor.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(220, 20);
            this.numValor.TabIndex = 0;
            this.numValor.ValueChanged += new System.EventHandler(this.NumValor_ValueChanged);
            // 
            // buttonAddParcela
            // 
            this.buttonAddParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddParcela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.buttonAddParcela.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddParcela.Enabled = false;
            this.buttonAddParcela.FlatAppearance.BorderSize = 0;
            this.buttonAddParcela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
            this.buttonAddParcela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(156)))), ((int)(((byte)(178)))));
            this.buttonAddParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddParcela.Location = new System.Drawing.Point(202, 62);
            this.buttonAddParcela.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAddParcela.Name = "buttonAddParcela";
            this.buttonAddParcela.Size = new System.Drawing.Size(101, 28);
            this.buttonAddParcela.TabIndex = 2;
            this.buttonAddParcela.Text = "Continuar";
            this.buttonAddParcela.UseVisualStyleBackColor = false;
            this.buttonAddParcela.Click += new System.EventHandler(this.ButtonAddParcela_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valor:";
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(83, 33);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(220, 20);
            this.tbxDescricao.TabIndex = 1;
            this.tbxDescricao.TextChanged += new System.EventHandler(this.TbxDescricao_TextChanged);
            // 
            // pictureBoxValor
            // 
            this.pictureBoxValor.Image = global::Stand_Automoveis.Properties.Resources.StatusWarning_exp_16x;
            this.pictureBoxValor.Location = new System.Drawing.Point(305, 9);
            this.pictureBoxValor.Name = "pictureBoxValor";
            this.pictureBoxValor.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxValor.TabIndex = 12;
            this.pictureBoxValor.TabStop = false;
            this.toolTipValor.SetToolTip(this.pictureBoxValor, "Atenção! O valor introduzido é nulo.");
            this.pictureBoxValor.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(92, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // toolTipValor
            // 
            this.toolTipValor.AutoPopDelay = 5000;
            this.toolTipValor.InitialDelay = 400;
            this.toolTipValor.IsBalloon = true;
            this.toolTipValor.ReshowDelay = 100;
            this.toolTipValor.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipValor.ToolTipTitle = "Valor nulo";
            // 
            // Form_AddEdit_Parcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 98);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxValor);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.buttonAddParcela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AddEdit_Parcela";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Parcela";
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxValor;
        public System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Button buttonAddParcela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTipValor;
    }
}