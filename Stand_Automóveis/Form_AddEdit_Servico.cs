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
    public partial class Form_AddEdit_Servico : Form
    {
        public string tipo;
        public DateTime dataEntrada, dataSaida;
        public bool tipoCheck = false, dataEntradaCheck = true, dataSaidaCheck = true;
        public Form_AddEdit_Servico()
        {
            InitializeComponent();
        }

        //Verifica se o Tipo está inserido na textBox
        private void TbxTipo_TextChanged(object sender, EventArgs e)
        {
            if (tbxTipo.Text.Length == 0)
                tipoCheck = false;
            else
                tipoCheck = true;
            buttonCheck();
        }

        //Verifica se a Data de Entrada está inserida na textBox
        private void DtpDataEntrada_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDataEntrada.Value.Date > DateTime.Now.Date)
                dataEntradaCheck = false;
            else
                dataEntradaCheck = true;
            buttonCheck();
        }

        //Verifica se a Data de Saída está inserida na textBox
        private void DtpDataSaida_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDataSaida.Value.Date < DateTime.Now.Date)
                dataSaidaCheck = false;
            else
                dataSaidaCheck = true;
            buttonCheck();
        }

        //Passa os dados inseridos nas textBoxes pelas variáveis globais
        private void ButtonAddServico_Click(object sender, EventArgs e)
        {
            tipo = tbxTipo.Text;
            dataEntrada = dtpDataEntrada.Value.Date;
            dataSaida = dtpDataSaida.Value.Date;
            Close();
        }

        //Verifica se o botão pode ficar ativo
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
