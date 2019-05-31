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
    public partial class New_Update_Servico : Form
    {
        public string tipo;
        public DateTime dataEntrada, dataSaida;
        public bool tipoCheck = false, dataEntradaCheck, dataSaidaCheck;
        public New_Update_Servico()
        {
            InitializeComponent();
        }

        private void TbxTipo_TextChanged(object sender, EventArgs e)
        {
            if (tbxTipo.Text.Length == 0)
                tipoCheck = false;
            else
                tipoCheck = true;
            buttonCheck();
        }

        private void DtpDataEntrada_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDataEntrada.Value.Date >= DateTime.Now)
                dataEntradaCheck = false;
            else
                dataEntradaCheck = true;
            buttonCheck();
        }

        private void DtpDataSaida_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDataSaida.Value.Date <= DateTime.Now)
                dataSaidaCheck = false;
            else
                dataSaidaCheck = true;
            buttonCheck();
        }

        private void ButtonAddServico_Click(object sender, EventArgs e)
        {
            tipo = tbxTipo.Text;
            dataEntrada = dtpDataEntrada.Value.Date;
            dataSaida = dtpDataSaida.Value.Date;
            Close();
        }

        private void buttonCheck()
        {
            if (tipoCheck != true || dataEntradaCheck != true || dataSaidaCheck != true)
            {
                buttonAddServico.Enabled = false;
            }
            else
                buttonAddServico.Enabled = true;
        }
    }
}
