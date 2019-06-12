using System;
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
    public partial class Form_AddEdit_Parcela : Form
    {
        public string descricao;
        public double valor;
        public bool valorCheck = false, descricaoCheck = false;

        public Form_AddEdit_Parcela()
        {
            InitializeComponent();
        }

        //Verifica se a Descrição está inserida na textBox
        private void TbxDescricao_TextChanged(object sender, EventArgs e)
        {
            if (tbxDescricao.Text.Length == 0)
                descricaoCheck = false;
            else
                descricaoCheck = true;
            buttonCheck();
        }

        //Passa os dados inseridos nas textBoxes pelas variáveis globais
        private void ButtonAddParcela_Click(object sender, EventArgs e)
        {
            valor = (double)numValor.Value;
            descricao = tbxDescricao.Text;

            Close();
        }

        //Verifica se o valor está inserido na textBox
        private void NumValor_ValueChanged(object sender, EventArgs e)
        {
            if (numValor.Value == 0)
                pictureBoxValor.Visible = true;
            else
                pictureBoxValor.Visible = false;
        }

        //Verifica se o botão pode ficar ativo
        private void buttonCheck()
        {
            if (descricaoCheck != true)
                buttonAddParcela.Enabled = false;
            else
                buttonAddParcela.Enabled = true;
        }
    }
}
