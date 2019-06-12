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
    public partial class Form_AluguerInformacoes : Form
    {
        public Clientes cliente;
        public Alugueres aluguer;
        public CarrosAluguer carro;

        //Mostra as informações relacionadas com o aluguer
        public Form_AluguerInformacoes(object clienteSelecionado, object aluguerSelecionado)
        {
            InitializeComponent();

            cliente = clienteSelecionado as Clientes;
            aluguer = aluguerSelecionado as Alugueres;
            carro = aluguer.CarroAluguer;

            lblNomeCliente.Text = cliente.Nome;
            lblCombustivel.Text = carro.Combustivel;
            lblContactoCliente.Text = cliente.Contacto;
            lblDtaEntrega.Text = aluguer.DataFim.ToString("dd-MM-yy");
            lblEstado.Text = carro.Estado;
            lblMarca.Text = carro.Marca;
            lblMatricula.Text = carro.Matricula;
            lblModelo.Text = carro.Modelo;
            lblMoradaCliente.Text = cliente.Morada;
            lblNifCliente.Text = cliente.NIF;
            lblNumChassis.Text = carro.NumeroChassis;
            lblNumKms.Text = aluguer.Kms;
            lblValor.Text = aluguer.Valor.ToString();
            lblDataInicio.Text = aluguer.DataInicio.ToString("dd-MM-yy");
        }

        //Retorna ao Form Gestão Alugueres
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Imprime uma fatura em .txt
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirDocumentos imprimir = new ImprimirDocumentos();
            imprimir.AluguerUnico(cliente, aluguer);
        }
    }
}
