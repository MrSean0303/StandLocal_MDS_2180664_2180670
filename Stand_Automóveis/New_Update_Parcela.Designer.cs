namespace Stand_Automoveis
{
    partial class New_Update_Parcela
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
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddParcela = new System.Windows.Forms.Button();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.toolTipValor = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxValor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValor)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(83, 38);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(220, 20);
            this.tbxDescricao.TabIndex = 1;
            this.tbxDescricao.TextChanged += new System.EventHandler(this.TbxDescricao_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição:";
            // 
            // buttonAddParcela
            // 
            this.buttonAddParcela.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddParcela.Enabled = false;
            this.buttonAddParcela.Location = new System.Drawing.Point(202, 64);
            this.buttonAddParcela.Name = "buttonAddParcela";
            this.buttonAddParcela.Size = new System.Drawing.Size(101, 32);
            this.buttonAddParcela.TabIndex = 4;
            this.buttonAddParcela.Text = "Adicionar Parcela";
            this.buttonAddParcela.UseVisualStyleBackColor = true;
            this.buttonAddParcela.Click += new System.EventHandler(this.ButtonAddParcela_Click);
            // 
            // numValor
            // 
            this.numValor.DecimalPlaces = 2;
            this.numValor.Location = new System.Drawing.Point(83, 12);
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(220, 20);
            this.numValor.TabIndex = 5;
            this.numValor.ValueChanged += new System.EventHandler(this.NumValor_ValueChanged);
            // 
            // toolTipValor
            // 
            this.toolTipValor.AutoPopDelay = 5000;
            this.toolTipValor.InitialDelay = 1000;
            this.toolTipValor.IsBalloon = true;
            this.toolTipValor.ReshowDelay = 100;
            this.toolTipValor.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipValor.ToolTipTitle = "Valor nulo";
            // 
            // pictureBoxValor
            // 
            this.pictureBoxValor.Image = global::Stand_Automoveis.Properties.Resources.StatusWarning_exp_16x;
            this.pictureBoxValor.Location = new System.Drawing.Point(305, 14);
            this.pictureBoxValor.Name = "pictureBoxValor";
            this.pictureBoxValor.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxValor.TabIndex = 6;
            this.pictureBoxValor.TabStop = false;
            this.toolTipValor.SetToolTip(this.pictureBoxValor, "Atenção! O valor introduzido é nulo.\r\n");
            this.pictureBoxValor.Visible = false;
            // 
            // New_Update_Parcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 111);
            this.Controls.Add(this.pictureBoxValor);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.buttonAddParcela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDescricao);
            this.Name = "New_Update_Parcela";
            this.Text = "Nova Parcela";
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddParcela;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.ToolTip toolTipValor;
        private System.Windows.Forms.PictureBox pictureBoxValor;
    }
}