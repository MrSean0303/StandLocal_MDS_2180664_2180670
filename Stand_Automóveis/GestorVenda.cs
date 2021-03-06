﻿using System;
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

            tbxFiltrarClientes.ForeColor = SystemColors.GrayText;
            tbxFiltrarClientes.Text = "Filtrar";
            tbxFiltrarClientes.Leave += new System.EventHandler(TbxFiltrarClientes_Leave);
            tbxFiltrarClientes.Enter += new System.EventHandler(TbxFiltrarClientes_Enter);

            tbxFiltrarCarrosVenda.ForeColor = SystemColors.GrayText;
            tbxFiltrarCarrosVenda.Text = "Filtrar";
            tbxFiltrarCarrosVenda.Leave += new System.EventHandler(TbxFiltrarCarrosVenda_Leave);
            tbxFiltrarCarrosVenda.Enter += new System.EventHandler(TbxFiltrarCarrosVenda_Enter);

            CarregarBD carregar = new CarregarBD();
            carregar.Show();
            Application.DoEvents();

            StandLocalDB = new StandLocalDBContainer();
            LerDados();
            carregar.Close();
            LimparSelecao();
            lbxVendas.DataSource = null;

        }

        #region AtualizarDados

        //Lê os dados da base de dados e adiciona-os às listas
        private void LerDados()
        {
            listaClientes = StandLocalDB.Clientes.ToList();
            listaCarrosVenda = StandLocalDB.Carro.OfType<CarrosVenda>().ToList();

            AtualizarListaCarrosVenda();
            AtualizarClientes();
        }

        //Atualiza a listBoxCarrosVenda
        private void AtualizarListaCarrosVenda()
        {
            lbxCarrosVenda.DataSource = null;
            lbxCarrosVenda.DataSource = listaCarrosVenda;
        }

        //Atualiza a listBoxClientes
        private void AtualizarClientes()
        {
            lbxClientes.DataSource = null;
            lbxClientes.DataSource = listaClientes;
        }

        //Limpa as seleções no Form
        public void LimparSelecao()
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

        //Atualiza a listBoxVenda
        public void AtualizarListaVenda(Clientes cliente) {
            lbxVendas.DataSource = null;
            lbxVendas.DataSource = cliente.Venda.ToList();
        }
        #endregion

        #region CarrosParaVenda

        //Ordena os Carros por ordem Crescente
        private void ButtonOrdenarAscCarros_Click(object sender, EventArgs e)
        {
            List<CarrosVenda> carros = listaCarrosVenda.OrderBy(carro => carro.Marca).ToList();
            lbxCarrosVenda.DataSource = null;
            lbxCarrosVenda.DataSource = carros;
        }

        //Ordena os Carros por ordem Decrescente
        private void ButtonOrdenarDescCarros_Click(object sender, EventArgs e)
        {
            List<CarrosVenda> carros = listaCarrosVenda.OrderByDescending(carro => carro.Marca).ToList();
            lbxCarrosVenda.DataSource = null;
            lbxCarrosVenda.DataSource = carros;
        }

        //Filtra os Carros pela Marca
        private void TbxFiltrarCarrosVenda_TextChanged(object sender, EventArgs e)
        {
            string nome = tbxFiltrarCarrosVenda.Text;

            if (nome != string.Empty)
            {
                List<CarrosVenda> carrosVenda = listaCarrosVenda.Where(carro => carro.Marca.ToUpper().Contains(nome.ToUpper())).ToList();
                lbxCarrosVenda.DataSource = null;
                lbxCarrosVenda.DataSource = carrosVenda;
            }
            else
                AtualizarListaCarrosVenda();
        }

        //Evento entrar na textBoxFiltrarCarrosVenda
        private void TbxFiltrarCarrosVenda_Enter(object sender, EventArgs e)
        {
            if (tbxFiltrarCarrosVenda.Text == "Filtrar")
            {
                tbxFiltrarCarrosVenda.Text = "";
                tbxFiltrarCarrosVenda.ForeColor = SystemColors.WindowText;
            }
        }

        //Evento sair da textBoxFiltrarCarrosVenda
        private void TbxFiltrarCarrosVenda_Leave(object sender, EventArgs e)
        {
            if (tbxFiltrarCarrosVenda.Text.Length == 0)
            {
                tbxFiltrarCarrosVenda.Text = "Filtrar";
                tbxFiltrarCarrosVenda.ForeColor = SystemColors.GrayText;
                AtualizarListaCarrosVenda();
            }
        }

        //Adiciona um novo carro
        private void btnAddCarro_Click(object sender, EventArgs e)
        {
            CriarCarro();
        }

        //Edita o Carro selecionado
        private void btnEditarCarroVenda_Click(object sender, EventArgs e)
        {
            EditarCarro();
        }

        //Elimina o Carro Selecionado
        private void btnEliminarCarroVenda_Click(object sender, EventArgs e)
        {
            EliminarCarro();
        }

        //Verifica qual o Carro selecionado
        private void lbxCarrosVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarrosVenda carroVendaSelecionado = (CarrosVenda)lbxCarrosVenda.SelectedItem;

            if (carroVendaSelecionado == null)
            {
                btnEditarCarroVenda.Enabled = false;
                btnEliminarCarroVenda.Enabled = false;
                return;
            }

            btnEditarCarroVenda.Enabled = true;
            btnEliminarCarroVenda.Enabled = true;
        }

        //Adicionar um novo carro
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

        //Editar o Carro Selecionado
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
            EditarCarroVenda.Text = "Editar Carro (venda)";
            EditarCarroVenda.ShowDialog();

            if (EditarCarroVenda.DialogResult == DialogResult.OK)
            {
                carroVendaSelecionado.Marca = EditarCarroVenda.marca;
                carroVendaSelecionado.Modelo = EditarCarroVenda.modelo;
                carroVendaSelecionado.NumeroChassis = EditarCarroVenda.numeroChassis;
                carroVendaSelecionado.Extras = EditarCarroVenda.extra;
                carroVendaSelecionado.Combustivel = EditarCarroVenda.combustivel;

                dadosGuardados = false;               
            }

            AtualizarListaCarrosVenda();
            LimparSelecao();
        }

        //Elimina o Carro Selecionado
        public void EliminarCarro()
        {
            CarrosVenda carroVendaSelecionado = lbxCarrosVenda.SelectedItem as CarrosVenda;

            if (carroVendaSelecionado == null)
            {
                MessageBox.Show("Nenhum Carro selecionado", "Carro por selecionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Deseja mesmo eliminar este carro ?", "Deseja eliminar Carro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (carroVendaSelecionado.Venda == null)
                {
                    listaCarrosVenda.Remove(carroVendaSelecionado);
                    StandLocalDB.Carro.Remove(carroVendaSelecionado);
                    AtualizarListaCarrosVenda();
                    dadosGuardados = false;
                }
                else
                {
                    MessageBox.Show("O Carro selecionado ja se encontra vendido. Por favor elimine a venda antes de eliminar o carro.", "Carro nao pode ser apagado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        #endregion

        #region Vendas

        //Verifica qual a venda selecionada
        private void lbxVendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vendas VendaSelecionado = (Vendas)lbxVendas.SelectedItem;

            if (VendaSelecionado == null)
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

        //Mostra a informação da Venda
        private void btnInfVenda_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = lbxClientes.SelectedItem as Clientes;
            Vendas vendaSelecionada = (Vendas)lbxVendas.SelectedItem;

            if (vendaSelecionada == null || clienteSelecionado == null)
            {
                MessageBox.Show("ERRO: Tem de selecionar o aluguer e o cliente para consultar informações.", "Cliente ou aluguer Errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form_VendaInformacoes vendaInformacoes = new Form_VendaInformacoes(clienteSelecionado, vendaSelecionada);
            vendaInformacoes.Show();

        }

        //Adiciona uma nova venda
        private void btnAddVenda_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;
            CarrosVenda carroVendaSelecionado = (CarrosVenda)lbxCarrosVenda.SelectedItem;

            if (clienteSelecionado == null || carroVendaSelecionado == null)
            {
                MessageBox.Show("ERRO: Não tem o cliente ou o carro selecionado", "Venda nao sucedida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Add_Edit_Venda();
            if (valorVenda == true && dataVenda == true)
            {
                Vendas tempvenda = new Vendas
                {
                    Estado = tbxestadoVenda.Text,
                    Valor = double.Parse(tbxValorVenda.Text),
                    Data = dtpdataVenda.Value.Date,
                    CarroVenda = carroVendaSelecionado,
                };

                StandLocalDB.Clientes.Find(clienteSelecionado.IdCliente).Venda.Add(tempvenda);

                lbxVendas.DataSource = null;
                lbxVendas.DataSource = StandLocalDB.Clientes.Find(clienteSelecionado.IdCliente).Venda.ToList();
                dadosGuardados = false;

                tbxestadoVenda.Clear();
                tbxValorVenda.Clear();
                dtpdataVenda.Value = DateTime.Now;

            }

            valorVenda = false;
            dataVenda = false;

        }

        //Elimina a venda selecionada
        private void btnEliminarVenda_Click(object sender, EventArgs e)
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

            tbxestadoVenda.Clear();
            tbxValorVenda.Clear();
            dtpdataVenda.Value = DateTime.Now;
        }

        //Editar a venda selecionada
        private void btnEditarVenda_Click(object sender, EventArgs e)
        {
            Vendas vendaSelecionada = (Vendas)lbxVendas.SelectedItem;
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;

            if (vendaSelecionada == null || clienteSelecionado == null)
            {
                MessageBox.Show("Selecione uma venda para que possa ser editada", "Venda não selecionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Add_Edit_Venda();
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

        //Adiciona ou edita uma venda
        public void Add_Edit_Venda() {   
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
        #endregion

        #region toolStrip

        //Elimina o Carro Selecionado
        private void eliminarCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCarro();
        }

        //Adiciona um novo cliente
        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Add_Cliente novocliente = new Form_Add_Cliente();
            novocliente.ShowDialog();
            Clientes clienteTemp = new Clientes
            {
                Nome = novocliente.nome,
                NIF = novocliente.nif,
                Morada = novocliente.morada,
                Contacto = novocliente.contacto
            };

            if (novocliente.DialogResult == DialogResult.OK)
            {
                listaClientes.Add(clienteTemp);
                StandLocalDB.Clientes.Add(clienteTemp);
                AtualizarClientes();
                dadosGuardados = false;
            }
        }

        //Adiciona um novo carro
        private void criarCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarCarro();
        }

        //Editar o carro selecionado
        private void editarCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarCarro();
        }

        //Imprime todas as ações do cliente em relação à venda por .txt
        private void imprimirHistoricoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;

            if (clienteSelecionado == null)
            {
                MessageBox.Show("ERRO: Tem de ter um cliente selecionado para poder obter o seu Historico.", "Nenhum cliente selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ImprimirDocumentos imprimir = new ImprimirDocumentos();
            imprimir.VendaHistorico(clienteSelecionado);
        }

        //Guarda as alterações na base de dados
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool carroSemVenda = false;
            List<CarrosVenda> carrosParaEliminar = new List<CarrosVenda>();
            foreach (CarrosVenda carro in listaCarrosVenda)
            {
                if (carro.Venda == null)
                {
                    carroSemVenda = true;
                    carrosParaEliminar.Add(carro);
                }
            }

            if (dadosGuardados == false)
            {
                if (MessageBox.Show("Não guardou as suas ultimas alterações.", "Guardar Alterações?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (carroSemVenda == true)
                    {
                        MessageBox.Show("Não pode ter carros para Venda sem estarem associados a vendas", "Carros sem vendas", MessageBoxButtons.OK);
                        if (MessageBox.Show("Deseja apagar os carros sem venda?", "Eliminar Carros sem venda?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            foreach (CarrosVenda carrosEliminar in carrosParaEliminar)
                            {
                                StandLocalDB.Carro.Remove(carrosEliminar);
                                listaCarrosVenda.Remove(carrosEliminar);
                            }
                            StandLocalDB.SaveChanges();
                            dadosGuardados = true;
                        }
                        else {
                            MessageBox.Show("Os dados nao foram guardados.", "Dados por Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dadosGuardados = false;
                        }
                    }
                    else
                    {
                        StandLocalDB.SaveChanges();
                        dadosGuardados = true;
                    }
                }
            }
            AtualizarListaCarrosVenda();
            
        }

        //Fecha o Form
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        } 

        //Limpa as seleções no Form
        private void limparSelecaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimparSelecao();
        }
        #endregion

        #region Clientes
        
        //Verifica qual o cliente selecionado
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

        //Filtra os cliente por nome
        private void TbxFiltrarClientes_TextChanged(object sender, EventArgs e)
        {
            string nome = tbxFiltrarClientes.Text;

            if (nome != string.Empty)
            {
                List<Clientes> clientes = listaClientes.Where(cliente => cliente.Nome.ToUpper().Contains(nome.ToUpper())).ToList();
                lbxClientes.DataSource = null;
                lbxClientes.DataSource = clientes;
            }
            else
                AtualizarClientes();
        }

        //Evento entrar na textBoxFiltrarClientes
        private void TbxFiltrarClientes_Enter(object sender, EventArgs e)
        {
            if (tbxFiltrarClientes.Text == "Filtrar")
            {
                tbxFiltrarClientes.Text = "";
                tbxFiltrarClientes.ForeColor = SystemColors.WindowText;
            }
        }

        //Evento sair da textBoxFiltrarClientes
        private void TbxFiltrarClientes_Leave(object sender, EventArgs e)
        {
            if (tbxFiltrarClientes.Text.Length == 0)
            {
                tbxFiltrarClientes.Text = "Filtrar";
                tbxFiltrarClientes.ForeColor = SystemColors.GrayText;
                AtualizarClientes();
            }
        }

        //Ordenar os clientes por ordem decrescente
        private void ButtonOrdenarDescClientes_Click(object sender, EventArgs e)
        {
            List<Clientes> clientes = listaClientes.OrderByDescending(cliente => cliente.Nome).ToList();
            lbxClientes.DataSource = null;
            lbxClientes.DataSource = clientes;
        }

        //Ordenar os clientes por ordem crescente
        private void ButtonOrdenarCresClientes_Click(object sender, EventArgs e)
        {
            List<Clientes> clientes = listaClientes.OrderBy(cliente => cliente.Nome).ToList();
            lbxClientes.DataSource = null;
            lbxClientes.DataSource = clientes;
        }
        #endregion

        //Evento do Form "enquanto" a fechar
        private void GestorVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool carroSemVenda = false;
            List<CarrosVenda> carrosParaEliminar = new List<CarrosVenda>();
            foreach (CarrosVenda carro in listaCarrosVenda)
            {
                if (carro.Venda == null)
                {
                    carroSemVenda = true;
                    carrosParaEliminar.Add(carro);
                }
            }

            if (dadosGuardados == false)
            {
                if (MessageBox.Show("Não guardou as suas ultimas alterações.", "Guardar Alterações?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (carroSemVenda == true)
                    {
                        MessageBox.Show("Não pode ter carros para Venda sem estarem associados a vendas", "Carros sem vendas", MessageBoxButtons.OK);
                        if (MessageBox.Show("Deseja apagar os carros sem venda?", "Eliminar Carros sem venda?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            foreach (CarrosVenda carrosEliminar in carrosParaEliminar)
                            {
                                StandLocalDB.Carro.Remove(carrosEliminar);
                            }
                            StandLocalDB.SaveChanges();
                        }
                        else
                        {
                            e.Cancel = true;
                            return;
                        }

                    }
                    else
                    {
                        StandLocalDB.SaveChanges();
                    }
                }
            }
            StandLocalDB.Dispose();
        }
    }
}
