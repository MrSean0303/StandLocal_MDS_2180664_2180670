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
    public partial class Form_AddEdit_CarroAluguer : Form
    {
        public string marca, modelo, matricula, numeroChassis, combustivel, estado;
        public bool marcaCheck = false, modeloCheck = false, matriculaCheck = false, numChassisCheck = false, combustivelCheck = false, estadoCheck = false;

        public enum estadoCarro { Novo, Usado };
        string estadoCarroAluguer;

        public Form_AddEdit_CarroAluguer()
        {
            InitializeComponent();
            buttonAddCarro.Enabled = false;
            cbxEstadoCarro.Items.Add(estadoCarro.Novo);
            cbxEstadoCarro.Items.Add(estadoCarro.Usado);
            cbxEstadoCarro.Items.Add("Por Avaliar");

        }

        //Verifica se o Estado está inserido na textBox
        private void cbxEstadoCarro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEstadoCarro.SelectedIndex < 0)
            {
                estadoCheck = false;
            }
            else
            {
                estadoCheck = true;
            }
            buttonCheck();
        }

        //Verifica se o Combustivel está inserido na textBox
        private void TbxCombustivelCarro_TextChanged(object sender, EventArgs e)
        {
            if (tbxCombustivelCarro.Text.Length == 0)
            {
                combustivelCheck = false;
            }
            else
            {
                combustivelCheck = true;
            }
            buttonCheck();
        }

        //Verifica se o Numero de Chassis está inserido na textBox
        private void TbxNumChassis_TextChanged(object sender, EventArgs e)
        {
            if (tbxNumChassis.Text.Length == 0)
                numChassisCheck = false;
            else
                numChassisCheck = true;
            buttonCheck();
        }

        //Verifica se a Matricula está inserida na textBox
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
        private void buttonAddCarro_Click(object sender, EventArgs e)
        {
            estadoCarroAluguer = cbxEstadoCarro.Items[cbxEstadoCarro.SelectedIndex].ToString();
            marca = tbxMarcaCarro.Text;
            modelo = tbxModeloCarro.Text;
            matricula = tbxMatriculaCarro.Text;
            numeroChassis = tbxNumChassis.Text;
            combustivel = tbxCombustivelCarro.Text;
            estado = estadoCarroAluguer;

            Close();
        }

        //Verifica se o botão pode ficar ativo
        private void buttonCheck()
        {
            if (marcaCheck != true || modeloCheck != true || matriculaCheck != true || numChassisCheck != true || combustivelCheck != true || estadoCheck != true)
            {
                buttonAddCarro.Enabled = false;
            }
            else
            {
                buttonAddCarro.Enabled = true;
            }
        }
    }
}
