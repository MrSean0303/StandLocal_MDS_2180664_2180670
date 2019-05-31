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
    public partial class NovoCliente : Form
    {
        public string nome, nif, morada, contacto;
        public bool nomeCheck = false, nifCheck = false, moradaCheck = false, contactoCheck = false;

        public NovoCliente()
        {
            InitializeComponent();
        }

        private void TbxMoradaCliente_TextChanged(object sender, EventArgs e)
        {
            if (tbxMoradaCliente.Text.Length == 0)
                moradaCheck =false;
            else
                moradaCheck = true;
            buttonCheck();
        }

        private void TbxContactoCliente_TextChanged(object sender, EventArgs e)
        {
            if (tbxContactoCliente.Text.Length == 0)
                contactoCheck = false;
            else
                contactoCheck = true;
            buttonCheck();
        }

        private void TbxNifCliente_TextChanged(object sender, EventArgs e)
        {
            if (tbxNifCliente.Text.Length == 0)
                nifCheck = false;
            else
                nifCheck = true;
            buttonCheck();
        }

        private void TbxNomeCliente_TextChanged(object sender, EventArgs e)
        {
            if (tbxNomeCliente.Text.Length == 0)
                nomeCheck = false;
            else
                nomeCheck = true;
            buttonCheck();
        }

        private void ButtonCriarCliente_Click(object sender, EventArgs e)
        {
            nome = tbxNomeCliente.Text;
            nif = tbxNifCliente.Text;
            morada = tbxMoradaCliente.Text;
            contacto = tbxContactoCliente.Text;

            Close();
        }

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
