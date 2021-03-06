﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stand_Automoveis
{
    public partial class Form_Add_Edit_Parcela : Form
    {
        public string descricao;
        public double valor;
        public bool valorCheck = false, descricaoCheck = false;

        public Form_Add_Edit_Parcela()
        {
            InitializeComponent();
            NumValorCheck();
        }

        private void TbxDescricao_TextChanged(object sender, EventArgs e)
        {
            if (tbxDescricao.Text.Length == 0)
                descricaoCheck = false;
            else
                descricaoCheck = true;
            buttonCheck();
        }

        private void ButtonAddParcela_Click(object sender, EventArgs e)
        {
            valor = (double)numValor.Value;
            descricao = tbxDescricao.Text;

            Close();
        }

        private void NumValor_ValueChanged(object sender, EventArgs e)
        {
            NumValorCheck();
        }

        private void NumValorCheck()
        {
            if (numValor.Value == 0)
                pictureBoxValor.Visible = true;
            else
                pictureBoxValor.Visible = false;
        }
        private void buttonCheck()
        {
            if (descricaoCheck != true)
                buttonAddParcela.Enabled = false;
            else
                buttonAddParcela.Enabled = true;
        }
    }
}
