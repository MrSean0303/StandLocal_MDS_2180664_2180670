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
    public partial class New_Update_Carro : Form
    {
        public string marca, modelo, matricula, numeroChassis, combustivel, kms;
        public bool marcaCheck = false, modeloCheck = false, matriculaCheck = false, numChassisCheck = false, combustivelCheck = false, kmsCheck = false;

        public New_Update_Carro()
        {
            InitializeComponent();
        }

        private void TbxKms_TextChanged(object sender, EventArgs e)
        {
            if (tbxKms.Text.Length == 0)
                kmsCheck = false;
            else
                kmsCheck = true;
            buttonCheck();
        }

        private void TbxCombustivelCarro_TextChanged(object sender, EventArgs e)
        {
            if (tbxCombustivelCarro.Text.Length == 0)
                combustivelCheck = false;
            else
                combustivelCheck = true;
            buttonCheck();
        }

        private void TbxNumChassis_TextChanged(object sender, EventArgs e)
        {
            if (tbxNumChassis.Text.Length == 0)
                numChassisCheck = false;
            else
                numChassisCheck = true;
            buttonCheck();
        }
        private void TbxMatriculaCarro_TextChanged(object sender, EventArgs e)
        {
            if (tbxMatriculaCarro.Text.Length == 0)
                matriculaCheck = false;
            else
                matriculaCheck = true;
            buttonCheck();
        }

        private void TbxModeloCarro_TextChanged(object sender, EventArgs e)
        {
            if (tbxModeloCarro.Text.Length == 0)
                modeloCheck = false;
            else
                modeloCheck = true;
            buttonCheck();
        }

        private void TbxMarcaCarro_TextChanged(object sender, EventArgs e)
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
            matricula = tbxMatriculaCarro.Text;
            numeroChassis = tbxNumChassis.Text;
            combustivel = tbxCombustivelCarro.Text;
            kms = tbxKms.Text;

            Close();
        }
        private void buttonCheck()
        {
            if (marcaCheck != true || modeloCheck != true || matriculaCheck != true || numChassisCheck != true || combustivelCheck != true || kmsCheck != true)
            {
                buttonAddCarro.Enabled = false;
            }
            else
                buttonAddCarro.Enabled = true;
        }
    }
}

