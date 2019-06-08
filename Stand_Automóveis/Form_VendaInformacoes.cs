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
    public partial class Form_VendaInformacoes : Form
    {
        public Clientes cliente;
        public Vendas venda;
        public CarrosVenda carro;

        public Form_VendaInformacoes(object clienteSelecionado, object vendaSelecionado)
        {
            InitializeComponent();

            cliente = clienteSelecionado as Clientes;
            venda = vendaSelecionado as Vendas;
            carro = venda.CarroVenda;

            lblNomeCliente.Text = cliente.Nome;
            lblCombustivel.Text = carro.Combustivel;
            lblContactoCliente.Text = cliente.Contacto;
            lblData.Text = venda.Data.ToString("dd-MM-yy");
            lblEstado.Text = venda.Estado;
            lblMarca.Text = carro.Marca;
            lblExtras.Text = carro.Extras;
            lblModelo.Text = carro.Modelo;
            lblMoradaCliente.Text = cliente.Morada;
            lblNifCliente.Text = cliente.NIF;
            lblNumChassis.Text = carro.NumeroChassis;
            lblValor.Text = venda.Valor.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirDocumentos imprimir = new ImprimirDocumentos();
            imprimir.VendaUnica(cliente, venda);
            
        }
    }
}
