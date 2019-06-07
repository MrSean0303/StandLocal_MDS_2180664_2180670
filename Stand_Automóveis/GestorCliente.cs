using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Stand_Automoveis
{
    public partial class GestorCliente : Form
    {
        private StandLocalDBContainer StandLocalDB;
        List<Clientes> listaCliente = new List<Clientes>();
        bool conteudoNovo = false;

        public GestorCliente()
        {
            InitializeComponent();
            tbxFiltrar.ForeColor = SystemColors.GrayText;
            tbxFiltrar.Text = "Filtrar";
            tbxFiltrar.Leave += new System.EventHandler(TbxFiltrar_Leave);
            tbxFiltrar.Enter += new System.EventHandler(TbxFiltrar_Enter);

            StandLocalDB = new StandLocalDBContainer();
            LerDados();
        }
        private void lblListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;

            if (clienteSelecionado == null)
            {
                lblShowNome.Text = null;
                lblShowMorada.Text = null;
                lblShowContacto.Text = null;
                lblShowNif.Text = "(Nenhum Cliente Selecionado)";
                lblNumCarrosOficina.Text = null;
                lblNumCarrosComprados.Text = null;
                lblNumCarroAluguer.Text = null;
                btnEditarCliente.Enabled = false;
                return;
            }

            btnEditarCliente.Enabled = true;

            tbAlterarNome.Text = clienteSelecionado.Nome;
            tbAlterarNif.Text = clienteSelecionado.NIF;
            tbAlterarContacto.Text = clienteSelecionado.Contacto;
            tbAlterarMorada.Text = clienteSelecionado.Morada;

            //apresenta o numero de registos de carros vendidos, comprados e consertados do cliente.
            lblShowNome.Text = clienteSelecionado.Nome;
            lblShowMorada.Text = clienteSelecionado.Morada;
            lblShowContacto.Text = clienteSelecionado.Contacto;
            lblShowNif.Text = clienteSelecionado.NIF;
            lblNumCarrosOficina.Text = clienteSelecionado.CarroOficina.Count.ToString();
            lblNumCarrosComprados.Text = clienteSelecionado.Venda.Count.ToString();
            lblNumCarroAluguer.Text = clienteSelecionado.Aluguer.Count.ToString();
        }
        private void LerDados()
        {
                listaCliente = StandLocalDB.Clientes.ToList();
                AtualizarClientes();      
        }
        private void AtualizarClientes()
        {
            lbxClientes.DataSource = null;
            lbxClientes.DataSource = listaCliente;
        }

        private void BtnCriarCliente_Click(object sender, EventArgs e)
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

            if(novocliente.DialogResult == DialogResult.OK)
            {
                listaCliente.Add(clienteTemp);
                StandLocalDB.Clientes.Add(clienteTemp);
                AtualizarClientes();
            }
            conteudoNovo = true;
        }

        private void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Nenhum Cliente Selecionado", "Erro Cliente Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //verifica se o cliente tem algum carro registado 
            if (clienteSelecionado.CarroOficina.Count == 0 && clienteSelecionado.Venda.Count == 0 && clienteSelecionado.Aluguer.Count == 0)
            {
                //Remove cliente da lista clientes e da "base de dados"
                listaCliente.Remove(clienteSelecionado);
                StandLocalDB.Clientes.Remove(clienteSelecionado);
                AtualizarClientes();
                conteudoNovo = true;
            }
            else
            {
                MessageBox.Show("O cliente tem dados introduzidos, por isso nao pode ser apagado", "Erro ao Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StandLocalDB.SaveChanges();
            conteudoNovo = false;
        }

        private void BtnEditarCliente_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Nenhum Cliente Selecionado", "Erro Cliente Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Efetuar as alterações no cliente
                clienteSelecionado.Nome = tbAlterarNome.Text;
                clienteSelecionado.NIF = tbAlterarNif.Text;
                clienteSelecionado.Morada = tbAlterarMorada.Text;
                clienteSelecionado.Contacto = tbAlterarContacto.Text;
                AtualizarClientes();
                conteudoNovo = true;
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimparDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbAlterarNome.Text = null;
            tbAlterarNif.Text = null;
            tbAlterarContacto.Text = null;
            tbAlterarMorada.Text = null;

            lbxClientes.SelectedIndex = -1;
        }

        private void NovoClienteToolStripMenuItem_Click(object sender, EventArgs e)
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
                listaCliente.Add(clienteTemp);
                StandLocalDB.Clientes.Add(clienteTemp);
                AtualizarClientes();
            }
            conteudoNovo = true;
        }

        private void GestorCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Se o utilizador ainda nao guardou, guarda
            if (conteudoNovo == true)
            {
                if (MessageBox.Show("Não guardou as suas ultimas alterações.", "Guardar Alterações ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    StandLocalDB.SaveChanges();
                }
            }
            StandLocalDB.Dispose();
        }

        private void TbxFiltrar_TextChanged(object sender, EventArgs e)
        {
            string nome = tbxFiltrar.Text;

            if (nome != string.Empty)
            {
                List<Clientes> clientes = listaCliente.Where(cliente => cliente.Nome.ToUpper().Contains(nome.ToUpper())).ToList();
                lbxClientes.DataSource = null;
                lbxClientes.DataSource = clientes;
            }
            else
                AtualizarClientes();
        }

        private void ButtonOrdenarCres_Click(object sender, EventArgs e)
        {
            List<Clientes> clientes = listaCliente.OrderBy(cliente => cliente.Nome).ToList();
            lbxClientes.DataSource = null;
            lbxClientes.DataSource = clientes;
        }

        private void ButtonOrdenarDesc_Click(object sender, EventArgs e)
        {
            List<Clientes> clientes = listaCliente.OrderByDescending(cliente => cliente.Nome).ToList();
            lbxClientes.DataSource = null;
            lbxClientes.DataSource = clientes;
        }

        private void TbxFiltrar_Leave(object sender, EventArgs e)
        {
            if (tbxFiltrar.Text.Length == 0)
            {
                tbxFiltrar.Text = "Filtrar";
                tbxFiltrar.ForeColor = SystemColors.GrayText;
                AtualizarClientes();
            }
        }

        private void TbxFiltrar_Enter(object sender, EventArgs e)
        {
            if (tbxFiltrar.Text == "Filtrar")
            {
                tbxFiltrar.Text = "";
                tbxFiltrar.ForeColor = SystemColors.WindowText;
            }
        }

        private void TbAlterarNif_TextChanged(object sender, EventArgs e)
        {
            if(tbAlterarNif.Text.Length < 9 || tbAlterarNif.Text.Length > 9)
            {
                pictureBoxNIF.Visible = true;
                btnEditarCliente.Enabled = false;
            }
            else
            {
                pictureBoxNIF.Visible = false;
                btnEditarCliente.Enabled = true;
            }
        }
    }
}
