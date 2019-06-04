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
        List<CarrosAluguer> ListacarrosAluguer = new List<CarrosAluguer>();
        List<Clientes> ListaClientes = new List<Clientes>();
        public bool kmspassou, valorpassou, dataCerta = true;
        bool dadosGuardados = true;

        public GestorAluguer()
        {
            InitializeComponent();
            CarregarBD carregar = new CarregarBD();
            carregar.Show();
            Application.DoEvents();

            StandLocalDB = new StandLocalDBContainer();
            LerDados();
            carregar.Close();

            LimparDados();
        }

        private void LerDados()
        {
            ListaClientes = StandLocalDB.Clientes.ToList();
            ListacarrosAluguer = StandLocalDB.Carro.OfType<CarrosAluguer>().ToList();

            AtualizarClientes();
            AtualizarListaCarrosAluguer();
        }

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

        private void AtualizarListaCarrosAluguer()
        {
            lbxCarrosAluguer.DataSource = null;
            lbxCarrosAluguer.DataSource = ListacarrosAluguer;
        }

        private void AtualizarClientes()
        {
            lbxClientes.DataSource = null;
            lbxClientes.DataSource = ListaClientes;
        }

        private void LimparDados()
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
        public void TesteAluguer()
        {
            double kms, valor;
            DateTime dataEntrega = dtpEntrega.Value.Date;
            DateTime dataRececao = dtpRececao.Value.Date;
            kmspassou = double.TryParse(tbxKms.Text, out kms);
            valorpassou = double.TryParse(tbxValor.Text, out valor);

            if (kmspassou == false)
            {
                MessageBox.Show("Erro kilometros errados", "kms incorretos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxKms.Clear();
            }

            if (valorpassou == false)
            {
                MessageBox.Show("Erro preço invalido", "preço incorretos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxValor.Clear();
            }

            if (dataEntrega.Date > dataRececao.Date)
            {
                MessageBox.Show("A data de Entrega e maior que a data de Receção.", "Datas Invalidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataCerta = false;
                dtpEntrega.Value = DateTime.Now;
                dtpRececao.Value = DateTime.Now;
            }
        }

        public void CriarCarro()
        {
            Form_Add_Edit_CarroAluguer novocarroAluguer = new Form_Add_Edit_CarroAluguer();
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
                ListacarrosAluguer.Add(carroTemp);
                StandLocalDB.Carro.Add(carroTemp);
                AtualizarListaCarrosAluguer();
                dadosGuardados = false;
            }
        }

        public void EditarCarro()
        {
            CarrosAluguer carrosAluguerSelecionado = lbxCarrosAluguer.SelectedItem as CarrosAluguer;

            if (carrosAluguerSelecionado == null)
            {
                MessageBox.Show("ERRO: Nenhum carro selecionado", "Impossivel Eiminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form_Add_Edit_CarroAluguer EditarcarroAluguer = new Form_Add_Edit_CarroAluguer();
            EditarcarroAluguer.tbxMarcaCarro.Text = carrosAluguerSelecionado.Marca;
            EditarcarroAluguer.tbxMatriculaCarro.Text = carrosAluguerSelecionado.Matricula;
            EditarcarroAluguer.tbxModeloCarro.Text = carrosAluguerSelecionado.Modelo;
            EditarcarroAluguer.tbxNumChassis.Text = carrosAluguerSelecionado.NumeroChassis;
            EditarcarroAluguer.tbxCombustivelCarro.Text = carrosAluguerSelecionado.Combustivel.ToString();
            EditarcarroAluguer.ShowDialog();

            carrosAluguerSelecionado.Marca = EditarcarroAluguer.marca;
            carrosAluguerSelecionado.Matricula = EditarcarroAluguer.matricula;
            carrosAluguerSelecionado.Modelo = EditarcarroAluguer.modelo;
            carrosAluguerSelecionado.NumeroChassis = EditarcarroAluguer.numeroChassis;
            carrosAluguerSelecionado.Estado = EditarcarroAluguer.estado;
            carrosAluguerSelecionado.Combustivel = EditarcarroAluguer.combustivel;

            AtualizarListaCarrosAluguer();
            dadosGuardados = false;
        }

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
                    if (DateTime.Now.Date < aluguer.DataFim) {
                        carroAlugado = true;
                    }               
                }
            }

            if (carroAlugado == false)
            {
                ListacarrosAluguer.Remove(carrosAluguerSelecionado);
                StandLocalDB.Carro.Remove(carrosAluguerSelecionado);
                AtualizarListaCarrosAluguer();
                dadosGuardados = false;
            }
            else {
                MessageBox.Show("O Carro selecionado esta alugado neste momento", "Carro nao pode ser eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbxCarrosAluguer.ClearSelected();
                return;
            }
        }


        private void btnAddCarro_Click(object sender, EventArgs e)
        {
            CriarCarro();
        }

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

        private void btnEditarCarroAluguer_Click(object sender, EventArgs e)
        {
            EditarCarro();
        }

        private void btnEliminarCarroAluguer_Click(object sender, EventArgs e)
        {
            EliminarCarro();
        }

        private void btnAddAluguer_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;
            CarrosAluguer carroAluguerSelecionado = lbxCarrosAluguer.SelectedItem as CarrosAluguer;


            if (clienteSelecionado == null || carroAluguerSelecionado == null)
            {
                MessageBox.Show("Selecione o cliente e o carro antes de adicionar o aluguer", "Aluguer Errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            TesteAluguer();

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Alugueres aluguerSelecionado = (Alugueres)lbxAluguer.SelectedItem;

            if (aluguerSelecionado == null)
            {
                MessageBox.Show("Selecione um aluguer para o poder eliminar", "Aluguer nao selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            StandLocalDB.Aluguer.Remove(aluguerSelecionado);

            AtualizarListaAluguer();
            dadosGuardados = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;
            Alugueres aluguerSelecionado = (Alugueres)lbxAluguer.SelectedItem;

            if (clienteSelecionado == null || aluguerSelecionado == null)
            {
                return;
            }

            AluguerInformacoes informacoes = new AluguerInformacoes(clienteSelecionado, aluguerSelecionado);
            informacoes.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limparDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StandLocalDB.SaveChanges();
            dadosGuardados = true;
            LimparDados();
        }

        private void adicionarCarroToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void btnEditarAluguer_Click(object sender, EventArgs e)
        {
            Alugueres aluguerSelecionado = (Alugueres)lbxAluguer.SelectedItem;

            TesteAluguer();
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


    }
}