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
    public partial class Form_AddEdit_Carro : Form
    {
        public string marca, modelo, matricula, numeroChassis, combustivel, kms;
        public bool marcaCheck = false, modeloCheck = false, matriculaCheck = false, numChassisCheck = false, combustivelCheck = false;

        public Form_AddEdit_Carro()
        {
            InitializeComponent();
            kmsCheck();
        }

        //Caso o Valor seja alterado
        private void NudKms_ValueChanged(object sender, EventArgs e)
        {
            kmsCheck();
        }

        //Verifica se os kms estão ou não a 0
        private void kmsCheck()
        {
            if (nudKms.Value == 0)
                pictureBoxKms.Visible = true;
            else
                pictureBoxKms.Visible = false;
        }

        //Verifica se o Combustivel está inserido na textBox
        private void TbxCombustivelCarro_TextChanged(object sender, EventArgs e)
        {
            if (tbxCombustivelCarro.Text.Length == 0)
                combustivelCheck = false;
            else
                combustivelCheck = true;
            buttonCheck();
        }

        //Verifica se o numero de Chassis está inserido na textBox
        private void TbxNumChassis_TextChanged(object sender, EventArgs e)
        {
            if (tbxNumChassis.Text.Length == 0)
                numChassisCheck = false;
            else
                numChassisCheck = true;
            buttonCheck();
        }

        //Verifica se a Matrícula está inserida na textBox
        private void TbxMatriculaCarro_TextChanged(object sender, EventArgs e)
        {
            if (tbxMatriculaCarro.Text.Length == 0)
                matriculaCheck = false;
            else
                matriculaCheck = true;
            buttonCheck();
        }

        //Verifica se o Modelo está inserido na textBox
        private void TbxModeloCarro_TextChanged(object sender, EventArgs e)
        {
            if (tbxModeloCarro.Text.Length == 0)
                modeloCheck = false;
            else
                modeloCheck = true;
            buttonCheck();
        }

        //Verifica se a Marca está inserida na textBox
        private void TbxMarcaCarro_TextChanged(object sender, EventArgs e)
        {
            if (tbxMarcaCarro.Text.Length == 0)
                marcaCheck = false;
            else
                marcaCheck = true;
            buttonCheck();
        }

        //Passa os dados inseridos nas textBoxes pelas variáveis globais
        private void ButtonAddCarro_Click(object sender, EventArgs e)
        {
            marca = tbxMarcaCarro.Text;
            modelo = tbxModeloCarro.Text;
            matricula = tbxMatriculaCarro.Text;
            numeroChassis = tbxNumChassis.Text;
            combustivel = tbxCombustivelCarro.Text;
            kms = nudKms.Value.ToString();

            Close();
        }

        //Verifica se o botão pode ficar ativo
        private void buttonCheck()
        {
            if (marcaCheck != true || modeloCheck != true || matriculaCheck != true || numChassisCheck != true || combustivelCheck != true)
            {
                buttonAddCarro.Enabled = false;
            }
            else
                buttonAddCarro.Enabled = true;
        }
    }
}

