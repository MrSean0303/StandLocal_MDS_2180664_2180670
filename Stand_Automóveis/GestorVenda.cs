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
    public partial class GestorVenda : Form
    {
        private StandLocalDBContainer StandLocalDB;
        List<CarrosVenda> listaCarrosVenda = new List<CarrosVenda>();
        List<Clientes> listaClientes = new List<Clientes>();

        public GestorVenda()
        {
            InitializeComponent();

            CarregarBD carregar = new CarregarBD();
            carregar.Show();
            Application.DoEvents();

            StandLocalDB = new StandLocalDBContainer();
            LerDados();
            AtualizarClientes();
            carregar.Close();

            LimparDados();
        }

        private void LerDados()
        {
            listaClientes = StandLocalDB.Clientes.ToList();
            listaCarrosVenda = StandLocalDB.Carro.OfType<CarrosVenda>().ToList();

            AtualizarCarrosVenda();
        }

        private void AtualizarCarrosVenda()
        {
            lbxCarrosVenda.DataSource = null;
            lbxCarrosVenda.DataSource = listaCarrosVenda;
        }

        private void AtualizarClientes()
        {
            lbxClientes.DataSource = null;
            lbxClientes.DataSource = listaClientes;
        }

        public void LimparDados()
        {
            lbxCarrosVenda.ClearSelected();
            lbxClientes.ClearSelected();
            lbxVendas.ClearSelected();
            tbxKms.Clear();
            tbxValor.Clear();
        }
    }
}
