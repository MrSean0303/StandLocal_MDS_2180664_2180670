namespace Stand_Automoveis
{
    partial class Form_AddEdit_Servico
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
            this.lblNif = new System.Windows.Forms.Label();
            this.tbxTipo = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonAddServico = new System.Windows.Forms.Button();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Provisorio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNif.Location = new System.Drawing.Point(7, 37);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(83, 15);
            this.lblNif.TabIndex = 40;
            this.lblNif.Text = "Data-Entrada:";
            // 
            // tbxTipo
            // 
            this.tbxTipo.Location = new System.Drawing.Point(96, 7);
            this.tbxTipo.Name = "tbxTipo";
            this.tbxTipo.Size = new System.Drawing.Size(227, 20);
            this.tbxTipo.TabIndex = 35;
            this.tbxTipo.TextChanged += new System.EventHandler(this.TbxTipo_TextChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(56, 8);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(34, 15);
            this.labelNome.TabIndex = 38;
            this.labelNome.Text = "Tipo:";
            // 
            // buttonAddServico
            // 
            this.buttonAddServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.buttonAddServico.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddServico.Enabled = false;
            this.buttonAddServico.FlatAppearance.BorderSize = 0;
            this.buttonAddServico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
            this.buttonAddServico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(156)))), ((int)(((byte)(178)))));
            this.buttonAddServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddServico.Location = new System.Drawing.Point(222, 90);
            this.buttonAddServico.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAddServico.Name = "buttonAddServico";
            this.buttonAddServico.Size = new System.Drawing.Size(101, 28);
            this.buttonAddServico.TabIndex = 41;
            this.buttonAddServico.Text = "Continuar";
            this.buttonAddServico.UseVisualStyleBackColor = false;
            this.buttonAddServico.Click += new System.EventHandler(this.ButtonAddServico_Click);
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Location = new System.Drawing.Point(96, 33);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(227, 20);
            this.dtpDataEntrada.TabIndex = 43;
            this.dtpDataEntrada.ValueChanged += new System.EventHandler(this.DtpDataEntrada_ValueChanged);
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Location = new System.Drawing.Point(96, 61);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(227, 20);
            this.dtpDataSaida.TabIndex = 45;
            this.dtpDataSaida.ValueChanged += new System.EventHandler(this.DtpDataSaida_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Data-Saida:";
            // 
            // label_Provisorio
            // 
            this.label_Provisorio.AutoSize = true;
            this.label_Provisorio.Location = new System.Drawing.Point(23, 82);
            this.label_Provisorio.Name = "label_Provisorio";
            this.label_Provisorio.Size = new System.Drawing.Size(59, 13);
            this.label_Provisorio.TabIndex = 46;
            this.label_Provisorio.Text = "(Provisória)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(112, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 47;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form_AddEdit_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 129);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Provisorio);
            this.Controls.Add(this.dtpDataSaida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataEntrada);
            this.Controls.Add(this.buttonAddServico);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.tbxTipo);
            this.Controls.Add(this.labelNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AddEdit_Servico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Serviço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNif;
        public System.Windows.Forms.TextBox tbxTipo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button buttonAddServico;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label_Provisorio;
        public System.Windows.Forms.DateTimePicker dtpDataEntrada;
        public System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.Button button1;
    }
}