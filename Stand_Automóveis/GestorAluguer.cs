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
    public partial class GestorAluguer : Form
    {
        private StandLocalDBContainer StandLocalDB;
        List<CarrosAluguer> listacarrosAluguer = new List<CarrosAluguer>();
        List<Clientes> listaClientes = new List<Clientes>();
        public bool kmspassou, valorpassou, dataCerta = true;
        bool dadosGuardados = true;

        public GestorAluguer()
        {
            InitializeComponent();

            tbxFiltrarClientes.ForeColor = SystemColors.GrayText;
            tbxFiltrarClientes.Text = "Filtrar";
            tbxFiltrarClientes.Leave += new System.EventHandler(TbxFiltrarClientes_Leave);
            tbxFiltrarClientes.Enter += new System.EventHandler(TbxFiltrarClientes_Enter);

            tbxFiltrarCarrosAluguer.ForeColor = SystemColors.GrayText;
            tbxFiltrarCarrosAluguer.Text = "Filtrar";
            tbxFiltrarCarrosAluguer.Leave += new System.EventHandler(TbxFiltrarCarrosAluguer_Leave);
            tbxFiltrarCarrosAluguer.Enter += new System.EventHandler(TbxFiltrarCarrosAluguer_Enter);

            CarregarBD carregar = new CarregarBD();
            carregar.Show();
            Application.DoEvents();

            StandLocalDB = new StandLocalDBContainer();
            LerDados();
            carregar.Close();

            LimparSelecao();
        }

        #region AtualizarDados

        //Lê os dados da base de dados e adiciona-os à lista Clientes
        private void LerDados()
        {
            listaClientes = StandLocalDB.Clientes.ToList();
            listacarrosAluguer = StandLocalDB.Carro.OfType<CarrosAluguer>().ToList();

            AtualizarClientes();
            AtualizarListaCarrosAluguer();
        }

        //Atualiza a listBox dos Alugueres
        private void AtualizarListaAluguer()
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;

            if (clienteSelecionado == null)
            {
                return;
            }

            lbxAluguer.DataSource = null;
            lbxAluguer.DataSource = clienteSelecionado.Aluguer.ToList();
        }

        //Atualiza a listBox dos carros de aluguer
        private void AtualizarListaCarrosAluguer()
        {
            lbxCarrosAluguer.DataSource = null;
            lbxCarrosAluguer.DataSource = listacarrosAluguer;
        }

        //Atualiza a listBox Clientes
        private void AtualizarClientes()
        {
            lbxClientes.DataSource = null;
            lbxClientes.DataSource = listaClientes;
        }

        //Limpa as seleções do Form
        private void LimparSelecao()
        {
            lbxCarrosAluguer.ClearSelected();
            lbxClientes.ClearSelected();
            lbxAluguer.ClearSelected();
            btnEditarAluguer.Enabled = false;
            btnEliminarAluguer.Enabled = false;
            btnEditarCarroAluguer.Enabled = false;
            btnEliminarCarroAluguer.Enabled = false;
            btnInfAluguer.Enabled = false;
            tbxKms.Clear();
            tbxValor.Clear();
            dtpEntrega.Value = DateTime.Now;
            dtpRececao.Value = DateTime.Now;
            lbxAluguer.DataSource = null;

        }
        #endregion

        #region Alugueres

        //Verifica qual o aluguer selecionado
        private void lbxAluguer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alugueres aluguerSelecionado = (Alugueres)lbxAluguer.SelectedItem;

            if (aluguerSelecionado == null)
            {
                btnEditarAluguer.Enabled = false;
                btnEliminarAluguer.Enabled = false;
                return;
            }

            btnEditarAluguer.Enabled = true;
            btnEliminarAluguer.Enabled = true;
            btnInfAluguer.Enabled = true;

            tbxKms.Text = aluguerSelecionado.Kms;
            tbxValor.Text = aluguerSelecionado.Valor.ToString();
            dtpEntrega.Value = aluguerSelecionado.DataInicio;

        }

        //Editar o aluguer selecionado
        private void btnEditarAluguer_Click(object sender, EventArgs e)
        {
            Alugueres aluguerSelecionado = (Alugueres)lbxAluguer.SelectedItem;

            Add_Edit_Aluguer();
            if (valorpassou == true && kmspassou == true && dataCerta == true)
            {
                aluguerSelecionado.Kms = tbxKms.Text;
                aluguerSelecionado.Valor = double.Parse(tbxValor.Text);
                aluguerSelecionado.DataInicio = dtpEntrega.Value;
                aluguerSelecionado.DataFim = dtpRececao.Value;

                AtualizarListaAluguer();
                dadosGuardados = false;
                lbxAluguer.ClearSelected();

                tbxValor.Clear();
                tbxKms.Clear();
                dtpEntrega.Value = DateTime.Now;
                dtpRececao.Value = DateTime.Now;
            }

            valorpassou = false;
            kmspassou = false;
            dataCerta = true;
        }

        //Elimina o aluguer selecionado
        private void BtnEliminarAluguer_Click(object sender, EventArgs e)
        {
            Alugueres aluguerSelecionado = (Alugueres)lbxAluguer.SelectedItem;

            if (aluguerSelecionado == null)
            {
                MessageBox.Show("Selecione um aluguer para o poder eliminar", "Aluguer não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StandLocalDB.Aluguer.Remove(aluguerSelecionado);

            AtualizarListaAluguer();
            dadosGuardados = false;
        }

        //Mostra as informações do aluguer
        private void ButtonInformacoesAluguer_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;
            Alugueres aluguerSelecionado = (Alugueres)lbxAluguer.SelectedItem;

            if (clienteSelecionado == null || aluguerSelecionado == null)
            {
                return;
            }

            Form_AluguerInformacoes informacoes = new Form_AluguerInformacoes(clienteSelecionado, aluguerSelecionado);
            informacoes.Show();
        }

        //Adiciona um novo aluguer ao cliente selecionado
        private void btnAddAluguer_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;
            CarrosAluguer carroAluguerSelecionado = lbxCarrosAluguer.SelectedItem as CarrosAluguer;


            if (clienteSelecionado == null || carroAluguerSelecionado == null)
            {
                MessageBox.Show("Selecione o cliente e o carro antes de adicionar o aluguer", "Aluguer Errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            Add_Edit_Aluguer();

            if (valorpassou == true && kmspassou == true && dataCerta == true)
            {
                Alugueres aluguerTemp = new Alugueres
                {
                    DataInicio = dtpEntrega.Value.Date,
                    DataFim = dtpRececao.Value.Date,
                    Valor = double.Parse(tbxValor.Text),
                    Kms = tbxKms.Text,
                    CarroAluguer = carroAluguerSelecionado,
                    Cliente = clienteSelecionado,
                    ClienteIdCliente = clienteSelecionado.IdCliente,
                };

                StandLocalDB.Clientes.Find(clienteSelecionado.IdCliente).Aluguer.Add(aluguerTemp);
                AtualizarListaAluguer();
                dadosGuardados = false;
                lbxAluguer.ClearSelected();

                tbxValor.Clear();
                tbxKms.Clear();
                dtpEntrega.Value = DateTime.Now;
                dtpRececao.Value = DateTime.Now;
            }

            valorpassou = false;
            kmspassou = false;
            dataCerta = true;
        }

        //Função adicionar ou editar Alugueres
        public void Add_Edit_Aluguer()
        {
            double kms, valor;
            DateTime dataEntrega = dtpEntrega.Value.Date;
            DateTime dataRececao = dtpRececao.Value.Date;
            kmspassou = double.TryParse(tbxKms.Text, out kms);
            valorpassou = double.TryParse(tbxValor.Text, out valor);

            if (kmspassou == false)
            {
                MessageBox.Show("Erro Quilómetros errados", "kms incorretos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxKms.Clear();
            }

            if (valorpassou == false)
            {
                MessageBox.Show("Erro preço invalido", "preço incorretos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxValor.Clear();
            }

            if (dataEntrega.Date > dataRececao.Date)
            {
                MessageBox.Show("A data de Entrega é mais recente que a data de Receção.", "Datas Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataCerta = false;
                dtpEntrega.Value = DateTime.Now;
                dtpRececao.Value = DateTime.Now;
            }
        }
        #endregion

        #region CarrosParaAluguer

        //Evento sair da textBoxFiltrarCarros
        private void TbxFiltrarCarrosAluguer_Enter(object sender, EventArgs e)
        {
            if (tbxFiltrarCarrosAluguer.Text == "Filtrar")
            {
                tbxFiltrarCarrosAluguer.Text = "";
                tbxFiltrarCarrosAluguer.ForeColor = SystemColors.WindowText;
            }
        }

        //Evento entrar na textBoxFiltrarCarros
        private void TbxFiltrarCarrosAluguer_Leave(object sender, EventArgs e)
        {
            if (tbxFiltrarCarrosAluguer.Text.Length == 0)
            {
                tbxFiltrarCarrosAluguer.Text = "Filtrar";
                tbxFiltrarCarrosAluguer.ForeColor = SystemColors.GrayText;
                AtualizarListaCarrosAluguer();
            }
        }

        //Ordena os Carros por ordem decrescente
        private void ButtonOrdenarDescCarros_Click(object sender, EventArgs e)
        {
            List<CarrosAluguer> carros = listacarrosAluguer.OrderByDescending(carro => carro.Marca).ToList();
            lbxCarrosAluguer.DataSource = null;
            lbxCarrosAluguer.DataSource = carros;
        }

        //Ordena os Carros por ordem crescente
        private void ButtonOrdenarAscCarros_Click(object sender, EventArgs e)
        {
            List<CarrosAluguer> carros = listacarrosAluguer.OrderBy(carro => carro.Marca).ToList();
            lbxCarrosAluguer.DataSource = null;
            lbxCarrosAluguer.DataSource = carros;
        }

        //Filtra os carros pela Marca
        private void TbxFiltrarCarrosAluguer_TextChanged(object sender, EventArgs e)
        {
            string nome = tbxFiltrarCarrosAluguer.Text;

            if (nome != string.Empty)
            {
                List<CarrosAluguer> carrosAluguer = listacarrosAluguer.Where(carro => carro.Marca.ToUpper().Contains(nome.ToUpper())).ToList();
                lbxCarrosAluguer.DataSource = null;
                lbxCarrosAluguer.DataSource = carrosAluguer;
            }
            else
                AtualizarListaCarrosAluguer();
        }

        //Verifica qual o Carro selecionado
        private void lbxListaCarrosAluguer_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarrosAluguer carrosAluguerSelecionado = new CarrosAluguer();

            if (carrosAluguerSelecionado == null)
            {
                btnEditarCarroAluguer.Enabled = false;
                btnEliminarCarroAluguer.Enabled = false;
                return;
            }

            btnEditarCarroAluguer.Enabled = true;
            btnEliminarCarroAluguer.Enabled = true;

            lbxAluguer.ClearSelected();
            tbxKms.Clear();
            tbxValor.Clear();
            dtpEntrega.Value = DateTime.Now;
            dtpRececao.Value = DateTime.Now;
        }

        //Adiciona um Carro à lista de Carros
        public void CriarCarro()
        {
            Form_AddEdit_CarroAluguer novocarroAluguer = new Form_AddEdit_CarroAluguer();
            novocarroAluguer.ShowDialog();

            CarrosAluguer carroTemp = new CarrosAluguer
            {
                Marca = novocarroAluguer.marca,
                Modelo = novocarroAluguer.modelo,
                Matricula = novocarroAluguer.matricula,
                NumeroChassis = novocarroAluguer.numeroChassis,
                Combustivel = novocarroAluguer.combustivel,
                Estado = novocarroAluguer.estado
            };

            if (novocarroAluguer.DialogResult == DialogResult.OK)
            {
                listacarrosAluguer.Add(carroTemp);
                StandLocalDB.Carro.Add(carroTemp);
                AtualizarListaCarrosAluguer();
                dadosGuardados = false;
            }
        }

        //Edita o Carro selecionado
        public void EditarCarro()
        {
            CarrosAluguer carrosAluguerSelecionado = lbxCarrosAluguer.SelectedItem as CarrosAluguer;

            if (carrosAluguerSelecionado == null)
            {
                MessageBox.Show("ERRO: Nenhum carro selecionado", "Impossivel Eiminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form_AddEdit_CarroAluguer EditarcarroAluguer = new Form_AddEdit_CarroAluguer();
            EditarcarroAluguer.tbxMarcaCarro.Text = carrosAluguerSelecionado.Marca;
            EditarcarroAluguer.tbxMatriculaCarro.Text = carrosAluguerSelecionado.Matricula;
            EditarcarroAluguer.tbxModeloCarro.Text = carrosAluguerSelecionado.Modelo;
            EditarcarroAluguer.tbxNumChassis.Text = carrosAluguerSelecionado.NumeroChassis;
            EditarcarroAluguer.tbxCombustivelCarro.Text = carrosAluguerSelecionado.Combustivel;
            EditarcarroAluguer.Text = "Editar Carro (Aluguer)";
            EditarcarroAluguer.ShowDialog();

            if (EditarcarroAluguer.DialogResult == DialogResult.OK) { 
                carrosAluguerSelecionado.Marca = EditarcarroAluguer.marca;
                carrosAluguerSelecionado.Matricula = EditarcarroAluguer.matricula;
                carrosAluguerSelecionado.Modelo = EditarcarroAluguer.modelo;
                carrosAluguerSelecionado.NumeroChassis = EditarcarroAluguer.numeroChassis;
                carrosAluguerSelecionado.Estado = EditarcarroAluguer.estado;
                carrosAluguerSelecionado.Combustivel = EditarcarroAluguer.combustivel;
            }

            AtualizarListaCarrosAluguer();
            dadosGuardados = false;
        }

        //Elimina o Carro Selecionado
        public void EliminarCarro()
        {
            CarrosAluguer carrosAluguerSelecionado = lbxCarrosAluguer.SelectedItem as CarrosAluguer;
            bool carroAlugado = false;

            if (carrosAluguerSelecionado == null)
            {
                MessageBox.Show("Não tem um carro de aluguer selecionado", "Sem carro selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Alugueres> AlugueresLista = StandLocalDB.Aluguer.Local.ToList();

            foreach (Alugueres aluguer in AlugueresLista) {

                if (aluguer.CarroAluguer == carrosAluguerSelecionado) {
                    carroAlugado = true;
                }
            }

            if (carroAlugado == true)
            {
                MessageBox.Show("O Carro selecionado tem alugueres associados neste momento", "Carro nao pode ser eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbxCarrosAluguer.ClearSelected();
                return;
            }

            if (MessageBox.Show("Deseja mesmo eliminar este carro de aluguer.", "Deseja Eliminar o carro?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                StandLocalDB.Carro.Remove(carrosAluguerSelecionado);
                listacarrosAluguer.Remove(carrosAluguerSelecionado);
                AtualizarListaCarrosAluguer();
                dadosGuardados = false;
            }

        }

        //Editar o Carro Selecionado
        private void btnEditarCarroAluguer_Click(object sender, EventArgs e)
        {
            EditarCarro();
        }

        //Elimina o Carro selecionado
        private void btnEliminarCarroAluguer_Click(object sender, EventArgs e)
        {
            EliminarCarro();
        }

        //Adiciona um novo Carro
        private void btnAddCarro_Click(object sender, EventArgs e)
        {
            CriarCarro();
        }
        #endregion

        #region Clientes

        //Evento entrar na textBoxFiltarClientes
        private void TbxFiltrarClientes_Enter(object sender, EventArgs e)
        {
            if (tbxFiltrarClientes.Text == "Filtrar")
            {
                tbxFiltrarClientes.Text = "";
                tbxFiltrarClientes.ForeColor = SystemColors.WindowText;
            }
        }

        //Evento sair da textBoxFiltarClientes
        private void TbxFiltrarClientes_Leave(object sender, EventArgs e)
        {
            if (tbxFiltrarClientes.Text.Length == 0)
            {
                tbxFiltrarClientes.Text = "Filtrar";
                tbxFiltrarClientes.ForeColor = SystemColors.GrayText;
                AtualizarClientes();
            }
        }

        //Ordenar Clientes por ordem Crescente
        private void ButtonOrdenarCresClientes_Click(object sender, EventArgs e)
        {
            List<Clientes> clientes = listaClientes.OrderBy(cliente => cliente.Nome).ToList();
            lbxClientes.DataSource = null;
            lbxClientes.DataSource = clientes;
        }

        //Ordenar Clientes por ordem Decrescente
        private void ButtonOrdenarDescClientes_Click(object sender, EventArgs e)
        {
            List<Clientes> clientes = listaClientes.OrderByDescending(cliente => cliente.Nome).ToList();
            lbxClientes.DataSource = null;
            lbxClientes.DataSource = clientes;
        }

        //Filtra os clientes pelo nome
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

        //Verifica qual o cliente selecionado
        private void lbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;

            if (clienteSelecionado == null)
            {
                return;
            }

            AtualizarListaAluguer();

            lbxAluguer.ClearSelected();
            tbxKms.Clear();
            tbxValor.Clear();
            dtpEntrega.Value = DateTime.Now;
            dtpRececao.Value = DateTime.Now;
        }
        #endregion

        #region ToolStripOptions

        //Fecha o Form
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Limpa as seleções do form
        private void limparSelecaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimparSelecao();
        }

        //Guarda os dados na base de dados
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StandLocalDB.SaveChanges();
            dadosGuardados = true;
            LimparSelecao();
        }

        //Adiciona um novo Carro
        private void adicionarCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarCarro();
        }

        //Editar Carro Selecionado
        private void editarCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EditarCarro();
        }

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
                dadosGuardados = true;
            }
        }
        
        //Imprime todas as ações do cliente por .txt
        private void imprimirHistoricoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;
            if (clienteSelecionado == null)
            {
                MessageBox.Show("ERRO: Tem de ter um cliente selecionado para poder obter o seu Historico.", "Nenhum cliente selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ImprimirDocumentos imprimir = new ImprimirDocumentos();
            imprimir.Aluguereshistorico(clienteSelecionado);

        }
        #endregion

        //Evento do Form "enquanto" a fechar
        private void GestorAluguer_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}