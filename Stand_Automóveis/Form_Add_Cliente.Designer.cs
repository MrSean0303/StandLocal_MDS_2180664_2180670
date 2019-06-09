namespace Stand_Automoveis
{
    partial class Form_Add_Cliente
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
            this.buttonCriarCliente = new System.Windows.Forms.Button();
            this.tbxNifCliente = new System.Windows.Forms.TextBox();
            this.lblNif = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.tbxMoradaCliente = new System.Windows.Forms.TextBox();
            this.tbxContactoCliente = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.tbxNomeCliente = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.toolTipNIF = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxNIF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNIF)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCriarCliente
            // 
            this.buttonCriarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.buttonCriarCliente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCriarCliente.Enabled = false;
            this.buttonCriarCliente.FlatAppearance.BorderSize = 0;
            this.buttonCriarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
            this.buttonCriarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(156)))), ((int)(((byte)(178)))));
            this.buttonCriarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCriarCliente.Location = new System.Drawing.Point(299, 119);
            this.buttonCriarCliente.Margin = new System.Windows.Forms.Padding(6, 6, 3, 6);
            this.buttonCriarCliente.Name = "buttonCriarCliente";
            this.buttonCriarCliente.Size = new System.Drawing.Size(101, 28);
            this.buttonCriarCliente.TabIndex = 4;
            this.buttonCriarCliente.Text = "Continuar";
            this.buttonCriarCliente.UseVisualStyleBackColor = false;
            this.buttonCriarCliente.Click += new System.EventHandler(this.ButtonCriarCliente_Click);
            // 
            // tbxNifCliente
            // 
            this.tbxNifCliente.Location = new System.Drawing.Point(99, 38);
            this.tbxNifCliente.Name = "tbxNifCliente";
            this.tbxNifCliente.Size = new System.Drawing.Size(301, 20);
            this.tbxNifCliente.TabIndex = 1;
            this.tbxNifCliente.TextChanged += new System.EventHandler(this.TbxNifCliente_TextChanged);
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNif.Location = new System.Drawing.Point(64, 39);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(29, 15);
            this.lblNif.TabIndex = 24;
            this.lblNif.Text = "NIF:";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorada.Location = new System.Drawing.Point(40, 91);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(53, 15);
            this.lblMorada.TabIndex = 22;
            this.lblMorada.Text = "Morada:";
            // 
            // tbxMoradaCliente
            // 
            this.tbxMoradaCliente.Location = new System.Drawing.Point(99, 90);
            this.tbxMoradaCliente.Name = "tbxMoradaCliente";
            this.tbxMoradaCliente.Size = new System.Drawing.Size(301, 20);
            this.tbxMoradaCliente.TabIndex = 3;
            this.tbxMoradaCliente.TextChanged += new System.EventHandler(this.TbxMoradaCliente_TextChanged);
            // 
            // tbxContactoCliente
            // 
            this.tbxContactoCliente.Location = new System.Drawing.Point(99, 64);
            this.tbxContactoCliente.Name = "tbxContactoCliente";
            this.tbxContactoCliente.Size = new System.Drawing.Size(301, 20);
            this.tbxContactoCliente.TabIndex = 2;
            this.tbxContactoCliente.TextChanged += new System.EventHandler(this.TbxContactoCliente_TextChanged);
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(37, 65);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(58, 15);
            this.lblContacto.TabIndex = 20;
            this.lblContacto.Text = "Contacto:";
            // 
            // tbxNomeCliente
            // 
            this.tbxNomeCliente.Location = new System.Drawing.Point(99, 12);
            this.tbxNomeCliente.Name = "tbxNomeCliente";
            this.tbxNomeCliente.Size = new System.Drawing.Size(301, 20);
            this.tbxNomeCliente.TabIndex = 0;
            this.tbxNomeCliente.TextChanged += new System.EventHandler(this.TbxNomeCliente_TextChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(10, 13);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(85, 15);
            this.labelNome.TabIndex = 18;
            this.labelNome.Text = "Nome Cliente:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(189, 119);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 28);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // toolTipNIF
            // 
            this.toolTipNIF.AutoPopDelay = 5000;
            this.toolTipNIF.InitialDelay = 400;
            this.toolTipNIF.IsBalloon = true;
            this.toolTipNIF.ReshowDelay = 100;
            this.toolTipNIF.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTipNIF.ToolTipTitle = "NIF Inválido!";
            // 
            // pictureBoxNIF
            // 
            this.pictureBoxNIF.Image = global::Stand_Automoveis.Properties.Resources.StatusCriticalError_16x;
            this.pictureBoxNIF.Location = new System.Drawing.Point(402, 40);
            this.pictureBoxNIF.Name = "pictureBoxNIF";
            this.pictureBoxNIF.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxNIF.TabIndex = 25;
            this.pictureBoxNIF.TabStop = false;
            this.toolTipNIF.SetToolTip(this.pictureBoxNIF, "O NIF introduzido não está correto.");
            this.pictureBoxNIF.Visible = false;
            // 
            // Form_Add_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 155);
            this.Controls.Add(this.pictureBoxNIF);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCriarCliente);
            this.Controls.Add(this.tbxNifCliente);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.tbxMoradaCliente);
            this.Controls.Add(this.tbxContactoCliente);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.tbxNomeCliente);
            this.Controls.Add(this.labelNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Add_Cliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCriarCliente;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.Label lblContacto;
        public System.Windows.Forms.TextBox tbxNomeCliente;
        private System.Windows.Forms.Label labelNome;
        public System.Windows.Forms.TextBox tbxNifCliente;
        public System.Windows.Forms.TextBox tbxMoradaCliente;
        public System.Windows.Forms.TextBox tbxContactoCliente;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ToolTip toolTipNIF;
        private System.Windows.Forms.PictureBox pictureBoxNIF;
    }
}