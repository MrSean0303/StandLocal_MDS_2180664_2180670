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
        public bool valorVenda = false, dataVenda = false;

        bool dadosGuardados = true;

        public GestorVenda()
        {
            InitializeComponent();

            CarregarBD carregar = new CarregarBD();
            carregar.Show();
            Application.DoEvents();

            StandLocalDB = new StandLocalDBContainer();
            LerDados();
            carregar.Close();
            LimparDados();
            lbxVendas.DataSource = null;

        }

        private void LerDados()
        {
            listaClientes = StandLocalDB.Clientes.ToList();
            listaCarrosVenda = StandLocalDB.Carro.OfType<CarrosVenda>().ToList();

            AtualizarListaCarrosVenda();
            AtualizarClientes();
        }

        private void AtualizarListaCarrosVenda()
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
            tbxestadoVenda.Clear();
            tbxValorVenda.Clear();

            btnEditarVenda.Enabled = false;
            btnEditarCarroVenda.Enabled = false;
            btnEliminarVenda.Enabled = false;
            btnEliminarCarroVenda.Enabled = false;
            btnInfVenda.Enabled = false;
        }

        public void AtualizarListaVenda(Clientes cliente) {

            lbxVendas.DataSource = null;
            lbxVendas.DataSource = cliente.Venda.ToList();
        }

        public void CriarCarro()
        {
            Form_AddEdit_CarroVenda novoCarroVenda = new Form_AddEdit_CarroVenda();
            novoCarroVenda.ShowDialog();

            CarrosVenda tempCarroVenda = new CarrosVenda
            {
                Marca = novoCarroVenda.marca,
                Modelo = novoCarroVenda.modelo,
                Extras = novoCarroVenda.extra,
                NumeroChassis = novoCarroVenda.numeroChassis,
                Combustivel = novoCarroVenda.combustivel,
            };

            if (novoCarroVenda.DialogResult == DialogResult.OK)
            {
                listaCarrosVenda.Add(tempCarroVenda);
                StandLocalDB.Carro.Add(tempCarroVenda);
                AtualizarListaCarrosVenda();
                dadosGuardados = false;
            }
            
        }

        public void EditarCarro()
        {
            
            CarrosVenda carroVendaSelecionado = lbxCarrosVenda.SelectedItem as CarrosVenda;

            if (carroVendaSelecionado == null) {
                MessageBox.Show("Nenhum Carro selecionado", "Carro por selecionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form_AddEdit_CarroVenda EditarCarroVenda = new Form_AddEdit_CarroVenda();
            EditarCarroVenda.tbxCombustivelCarro.Text = carroVendaSelecionado.Combustivel;
            EditarCarroVenda.tbxExtras.Text = carroVendaSelecionado.Extras;
            EditarCarroVenda.tbxMarcaCarro.Text = carroVendaSelecionado.Marca;
            EditarCarroVenda.tbxModeloCarro.Text = carroVendaSelecionado.Modelo;
            EditarCarroVenda.tbxNumChassis.Text = carroVendaSelecionado.NumeroChassis;
            EditarCarroVenda.ShowDialog();

            carroVendaSelecionado.Marca = EditarCarroVenda.marca;
            carroVendaSelecionado.Modelo = EditarCarroVenda.modelo;
            carroVendaSelecionado.NumeroChassis = EditarCarroVenda.numeroChassis;
            carroVendaSelecionado.Extras = EditarCarroVenda.extra;
            carroVendaSelecionado.Combustivel = EditarCarroVenda.combustivel;

            AtualizarListaCarrosVenda();
            dadosGuardados = false;
            LimparDados();
        }

        public void EliminarCarro()
        {
            CarrosVenda carroVendaSelecionado = lbxCarrosVenda.SelectedItem as CarrosVenda;

            if (carroVendaSelecionado == null)
            {
                MessageBox.Show("Nenhum Carro selecionado", "Carro por selecionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listaCarrosVenda.Remove(carroVendaSelecionado);
            StandLocalDB.Carro.Remove(carroVendaSelecionado);
            AtualizarListaCarrosVenda();
            dadosGuardados = false;
        }

        public void testarVenda() {   
            double valor;

            valorVenda = double.TryParse(tbxValorVenda.Text, out valor);

            if (valorVenda == false) {
                MessageBox.Show("ERRO: Valor mal introduzido.", "Valor Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxValorVenda.Clear();
            }

            if (dtpdataVenda.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("ERRO: Não e possivel inserir vendas em datas anteriores a de hoje (" + DateTime.Now.Date + ")", "Data Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpdataVenda.Value = DateTime.Now.Date;
                dataVenda = false;
            }
            else {
                dataVenda = true;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dadosGuardados == false)
                StandLocalDB.SaveChanges();

            dadosGuardados = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GestorVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dadosGuardados == false)
            {
                if (MessageBox.Show("Não guardou as suas ultimas alterações.", "Guardar Alterações?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    StandLocalDB.SaveChanges();
                }
            }

            StandLocalDB.Dispose();
        }

        private void limparDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnEliminarAluguer_Click(object sender, EventArgs e)
        {
            Vendas vendaSelecionada = (Vendas)lbxVendas.SelectedItem;
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;

            if (vendaSelecionada == null || clienteSelecionado == null)
            {
                MessageBox.Show("Selecione uma venda para que possa ser eliminada", "Venda não selecionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StandLocalDB.Vendas.Remove(vendaSelecionada);
            AtualizarListaVenda(clienteSelecionado);
            dadosGuardados = false;
        }

        private void btnEditarVenda_Click(object sender, EventArgs e)
        {
            Vendas vendaSelecionada = (Vendas)lbxVendas.SelectedItem;
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;

            if (vendaSelecionada == null || clienteSelecionado == null)
            {
                MessageBox.Show("Selecione uma venda para que possa ser editada", "Venda não selecionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            testarVenda();
            if (valorVenda == true && dataVenda == true)
            {
                vendaSelecionada.Data = dtpdataVenda.Value.Date;
                vendaSelecionada.Estado = tbxestadoVenda.Text;
                vendaSelecionada.Valor = double.Parse(tbxValorVenda.Text);

                AtualizarListaVenda(clienteSelecionado);
                dadosGuardados = false;
                lbxVendas.ClearSelected();

                tbxestadoVenda.Clear();
                tbxValorVenda.Clear();
                dtpdataVenda.Value = DateTime.Now;
            }

            valorVenda = false;
            dataVenda = false;
        }

        private void lbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;

            if(clienteSelecionado == null)
            {
                return;
            }

            AtualizarListaVenda(clienteSelecionado);
            lbxVendas.ClearSelected();

        }

        private void lbxCarrosVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarrosVenda carroVendaSelecionado = (CarrosVenda)lbxCarrosVenda.SelectedItem;

            if (carroVendaSelecionado == null) {
                btnEditarCarroVenda.Enabled = false;
                btnEliminarCarroVenda.Enabled = false;
                return;
            }

            btnEditarCarroVenda.Enabled = true;
            btnEliminarCarroVenda.Enabled = true;
        }

        private void lbxVendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vendas VendaSelecionado = (Vendas)lbxVendas.SelectedItem;

            if(VendaSelecionado == null)
            {
                btnEditarVenda.Enabled = false;
                btnEliminarVenda.Enabled = false;
                btnInfVenda.Enabled = false;
                return;
            }

            tbxestadoVenda.Text = VendaSelecionado.Estado;
            tbxValorVenda.Text = VendaSelecionado.Valor.ToString();
            dtpdataVenda.Value = VendaSelecionado.Data;


            btnEditarVenda.Enabled = true;
            btnEliminarVenda.Enabled = true;
            btnInfVenda.Enabled = true;

        }

        private void btnInfVenda_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = lbxClientes.SelectedItem as Clientes;
            Vendas vendaSelecionada = (Vendas)lbxVendas.SelectedItem;

            if (vendaSelecionada == null || clienteSelecionado == null)
            {
                MessageBox.Show("ERRO: Tem de selecionar o aluguer e o cliente para consultar informações.", "Cliente ou aluguer Errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VendaInformacoes vendaInformacoes = new VendaInformacoes(clienteSelecionado, vendaSelecionada);
            vendaInformacoes.Show();

        }

        private void btnAddVenda_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;
            CarrosVenda carroVendaSelecionado = (CarrosVenda)lbxCarrosVenda.SelectedItem;

            if (clienteSelecionado == null || carroVendaSelecionado == null) {
                MessageBox.Show("ERRO: Não tem o cliente ou o carro selecionado", "Venda nao sucedida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            testarVenda();
            if (valorVenda == true && dataVenda == true) {  
                Vendas tempvenda = new Vendas {
                    Estado = tbxestadoVenda.Text,
                    Valor = double.Parse(tbxValorVenda.Text),
                    Data = dtpdataVenda.Value.Date,
                    CarroVenda = carroVendaSelecionado                  
                };

                StandLocalDB.Clientes.Find(clienteSelecionado.IdCliente).Venda.Add(tempvenda);

                lbxVendas.DataSource = null;
                lbxVendas.DataSource = StandLocalDB.Clientes.Find(clienteSelecionado.IdCliente).Venda.ToList();
                dadosGuardados = false;         
            }

            valorVenda = false;
            dataVenda = false;

        }

        private void btnAddCarro_Click(object sender, EventArgs e)
        {
            CriarCarro();
        }

        private void btnEditarCarroAluguer_Click(object sender, EventArgs e)
        {
            EditarCarro();
        }

        private void btnEliminarCarroAluguer_Click(object sender, EventArgs e)
        {
            EliminarCarro();
        }

        private void criarCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarCarro();
        }

        private void editarCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarCarro();
        }

        private void eliminarCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCarro();
        }
    }
}
