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
    public partial class GestorCliente : Form
    {
        private StandLocalDBContainer StandLocalDB;
        List<Clientes> listaCliente = new List<Clientes>();
        bool conteudoNovo = false;

        public GestorCliente()
        {
            InitializeComponent();
            StandLocalDB = new StandLocalDBContainer();
            LerDados();
        }

        private void lblListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbListaClientes.SelectedItem;

            if (clienteSelecionado == null)
            {
                return;
            }

            tbAlterarNome.Text = clienteSelecionado.Nome;
            tbAlterarNif.Text = clienteSelecionado.NIF;
            tbAlterarContacto.Text = clienteSelecionado.Contacto;
            tbAlterarMorada.Text = clienteSelecionado.Morada;

            //apresenta o numero de registos de carros vendidos, comprados e consertados do cliente.
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
            lbListaClientes.DataSource = null;
            lbListaClientes.DataSource = listaCliente;
        }

        private void BtnCriarCliente_Click(object sender, EventArgs e)
        {      
            NovoCliente novocliente = new NovoCliente();
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
            Clientes clienteSelecionado = (Clientes)lbListaClientes.SelectedItem;

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
            Clientes clienteSelecionado = (Clientes)lbListaClientes.SelectedItem;

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

            lbListaClientes.SelectedIndex = -1;
        }

        private void NovoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoCliente novocliente = new NovoCliente();
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
    }
}
