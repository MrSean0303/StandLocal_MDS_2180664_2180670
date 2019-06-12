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
    public partial class Form_Add_Cliente : Form
    {
        public string nome, nif, morada, contacto;
        public bool nomeCheck = false, nifCheck = false, moradaCheck = false, contactoCheck = false;

        public Form_Add_Cliente()
        {
            InitializeComponent();
        }

        //Botão Cancelar
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Verifica se a Morada está inserida na textBox
        private void TbxMoradaCliente_TextChanged(object sender, EventArgs e)
        {
            if (tbxMoradaCliente.Text.Length == 0)
                moradaCheck =false;
            else
                moradaCheck = true;
            buttonCheck();
        }

        //Verifica se o Contacto está inserido na textBox
        private void TbxContactoCliente_TextChanged(object sender, EventArgs e)
        {
            if (tbxContactoCliente.Text.Length == 0)
                contactoCheck = false;
            else
                contactoCheck = true;
            buttonCheck();
        }

        //Verifica se o NIF está inserido na textBox e se está correto
        private void TbxNifCliente_TextChanged(object sender, EventArgs e)
        {
            double nif;
            bool testNif = double.TryParse(tbxNifCliente.Text, out nif);
            if (tbxNifCliente.Text.Length == 0)
                nifCheck = false;
            else if(tbxNifCliente.Text.Length < 9 || tbxNifCliente.Text.Length > 9 || !testNif)
            {
                pictureBoxNIF.Visible = true;
                nifCheck = false;
            }
            else
            {
                pictureBoxNIF.Visible = false;
                nifCheck = true;
            } 
            buttonCheck();
        }

        //Verifica se o Nome está inserido na textBox
        private void TbxNomeCliente_TextChanged(object sender, EventArgs e)
        {
            if (tbxNomeCliente.Text.Length == 0)
                nomeCheck = false;
            else
                nomeCheck = true;
            buttonCheck();
        }

        //Passa os dados inseridos nas textBoxes pelas variáveis globais
        private void ButtonCriarCliente_Click(object sender, EventArgs e)
        {
            nome = tbxNomeCliente.Text;
            nif = tbxNifCliente.Text;
            morada = tbxMoradaCliente.Text;
            contacto = tbxContactoCliente.Text;

            Close();
        }

        //Verifica se o botão pode ficar ativo
        private void buttonCheck()
        {
            if (nomeCheck != true || nifCheck != true || contactoCheck != true || moradaCheck != true)
            {
                buttonCriarCliente.Enabled = false;
            }
            else
                buttonCriarCliente.Enabled = true;
        }
    }
}
