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
    public partial class Form_AddEdit_CarroVenda : Form
    {
        public string marca, modelo, extra, numeroChassis, combustivel;
        public bool marcaCheck = false, modeloCheck = false, extrasCheck = false, numChassisCheck = false, combustivelCheck = false;

        public Form_AddEdit_CarroVenda()
        {
            InitializeComponent();
        }

        private void tbxModeloCarro_TextChanged(object sender, EventArgs e)
        {
            if (tbxModeloCarro.Text.Length == 0)
                modeloCheck = false;
            else
                modeloCheck = true;
            buttonCheck();
        }

        private void tbxNumChassis_TextChanged(object sender, EventArgs e)
        {
            if (tbxNumChassis.Text.Length == 0)
                numChassisCheck = false;
            else
                numChassisCheck = true;
            buttonCheck();
        }

        private void tbxCombustivelCarro_TextChanged(object sender, EventArgs e)
        {
            if (tbxCombustivelCarro.Text.Length == 0)
                combustivelCheck = false;
            else
                combustivelCheck = true;
            buttonCheck();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbxExtras.Text.Length == 0)
                extrasCheck = false;
            else
                extrasCheck = true;
            buttonCheck();
        }

        private void tbxMarcaCarro_TextChanged(object sender, EventArgs e)
        {
            if (tbxMarcaCarro.Text.Length == 0)
                marcaCheck = false;
            else
                marcaCheck = true;
            buttonCheck();
        }

        private void ButtonAddCarro_Click(object sender, EventArgs e)
        {
            marca = tbxMarcaCarro.Text;
            modelo = tbxModeloCarro.Text;
            extra = tbxExtras.Text;
            numeroChassis = tbxNumChassis.Text;
            combustivel = tbxCombustivelCarro.Text;

            Close();
        }

        private void buttonCheck()
        {
            if (marcaCheck != true || modeloCheck != true || extrasCheck != true || numChassisCheck != true || combustivelCheck != true || extrasCheck != true)
            {
                buttonAddCarro.Enabled = false;
            }
            else
                buttonAddCarro.Enabled = true;
        }
    }
}

