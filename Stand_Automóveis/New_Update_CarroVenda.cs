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
    public partial class New_Update_CarroVenda : Form
    {
        public string marca, modelo, matricula, numeroChassis, combustivel, extras;

        private void tbxModeloCarro_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxMatriculaCarro_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxMarcaCarro_TextChanged(object sender, EventArgs e)
        {

        }

        public bool marcaCheck = false, modeloCheck = false, matriculaCheck = false, numChassisCheck = false, combustivelCheck = false, extrasCheck = false;

        public New_Update_CarroVenda()
        {
            InitializeComponent();
        }

        private void ButtonAddCarro_Click(object sender, EventArgs e)
        {
            marca = tbxMarcaCarro.Text;
            modelo = tbxModeloCarro.Text;
            matricula = tbxMatriculaCarro.Text;
            numeroChassis = tbxNumChassis.Text;
            combustivel = tbxCombustivelCarro.Text;

            Close();
        }

        private void buttonCheck()
        {
            if (marcaCheck != true || modeloCheck != true || matriculaCheck != true || numChassisCheck != true || combustivelCheck != true || extrasCheck != true)
            {
                buttonAddCarro.Enabled = false;
            }
            else
                buttonAddCarro.Enabled = true;
        }
    }
}

