using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Stand_Automoveis
{
    public partial class GestorOficina : Form
    {
        private StandLocalDBContainer StandLocalDB;
        List<Clientes> listaCliente = new List<Clientes>();
        List<Carros> listaCarro = new List<Carros>();
        List<Servicos> listaServico = new List<Servicos>();
        bool conteudoNovo = false;
        private IEnumerable<string> clientes;

        public GestorOficina()
        {
            InitializeComponent();
            StandLocalDB = new StandLocalDBContainer();
            LerDados();
        }

        private void LbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;

            if (clienteSelecionado == null)
            {
                return;
            }

            AtualizarCarros();
        }
        private void LerDados()
        {
            listaCliente = StandLocalDB.Clientes.ToList();

            AtualizarClientes();
        }
        private void AtualizarCarros()
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;
            lbxCarros.DataSource = null;
            lbxCarros.DataSource = clienteSelecionado.CarroOficina.ToList();
        }
        private void AtualizarClientes()
        {
            lbxClientes.DataSource = null;
            lbxClientes.DataSource = listaCliente;
        }
        private void AtualizarServicos()
        {
            CarrosOficina carroSelecionado = (CarrosOficina)lbxCarros.SelectedItem;
            if (carroSelecionado == null)
            {
                lbxServicos.DataSource = null;
                return;
            }
            else
            {
                lbxServicos.DataSource = null;
                lbxServicos.DataSource = carroSelecionado.Servico.ToList();
            }
        }

        private void AtualizarParcelas()
        {
            Servicos servicoSelecionado = (Servicos)lbxServicos.SelectedItem;
            if (servicoSelecionado == null)
            {
                lbxParcelas.DataSource = null;
                return;
            }
            else
            {
                lbxParcelas.DataSource = null;
                lbxParcelas.DataSource = servicoSelecionado.Parcela.ToList();
            }
        }

        private void ButtonAddCarro_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;
            New_Update_Carro novocarro = new New_Update_Carro();
            novocarro.ShowDialog();
            CarrosOficina carroTemp = new CarrosOficina
            {
                Marca = novocarro.marca,
                Modelo = novocarro.modelo,
                Matricula = novocarro.matricula,
                NumeroChassis = novocarro.numeroChassis,
                Combustivel = novocarro.combustivel,
                Kms = novocarro.kms
            };

            if (novocarro.DialogResult == DialogResult.OK)
            {
                listaCarro.Add(carroTemp);
                StandLocalDB.Clientes.Find(clienteSelecionado.IdCliente).CarroOficina.Add(carroTemp);
                AtualizarCarros();
                conteudoNovo = true;
            }
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
                conteudoNovo = true;
            }
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StandLocalDB.SaveChanges();
            conteudoNovo = false;
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GestorOficina_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Se o utilizador ainda nao guardou, guarda
            if (conteudoNovo == true)
            {
                if (MessageBox.Show("Não guardou as suas ultimas alterações.", "Guardar Alterações?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    StandLocalDB.SaveChanges();
                }
            }
            StandLocalDB.Dispose();
        }

        private void ButtonEliminarCarro_Click(object sender, EventArgs e)
        {
            CarrosOficina carroSelecionado = (CarrosOficina)lbxCarros.SelectedItem;
            bool servicoCheck = true;
            if (carroSelecionado == null)
            {
                MessageBox.Show("Nenhum Carro Selecionado", "Erro: Carro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Servicos servicos in carroSelecionado.Servico)
            {
                if (servicos.DataSaida != null)
                    servicoCheck = false;
            }
            if (servicoCheck == true)
            {
                listaCarro.Remove(carroSelecionado);
                StandLocalDB.Carro.Remove(carroSelecionado);
                AtualizarCarros();
                conteudoNovo = true;
            }
            else
            {
                MessageBox.Show("O carro tem serviços em execução, não é possível a sua eliminação.", "Erro ao Eliminar Carro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAddServico_Click(object sender, EventArgs e)
        {
            CarrosOficina carroSelecionado = (CarrosOficina)lbxCarros.SelectedItem;
            New_Update_Servico novoServico = new New_Update_Servico();
            novoServico.ShowDialog();

            Servicos servicoTemp = new Servicos
            {
                Tipo = novoServico.tipo,
                DataEntrada = novoServico.dataEntrada,
                DataSaida = novoServico.dataSaida
            };

            if (novoServico.DialogResult == DialogResult.OK)
            {
                listaServico.Add(servicoTemp);
                ((CarrosOficina)StandLocalDB.Carro.Find(carroSelecionado.idCarro)).Servico.Add(servicoTemp);
                carroSelecionado.Servico.Add(servicoTemp);
                conteudoNovo = true;
                AtualizarServicos();
            }   
        }

        private void LbxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarrosOficina carroSelecionado = (CarrosOficina)lbxCarros.SelectedItem;

            if (carroSelecionado == null)
            {
                return;
            }

            AtualizarServicos();
        }

        private void ButtonEliminarServicos_Click(object sender, EventArgs e)
        {
            Servicos servicoSelecionado = (Servicos)lbxServicos.SelectedItem;
            if (servicoSelecionado == null)
            {
                MessageBox.Show("Nenhum Serviço Selecionado", "Erro: Serviço Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (servicoSelecionado.Parcela.Count == 0)
            {
                listaServico.Remove(servicoSelecionado);
                StandLocalDB.Servico.Remove(servicoSelecionado);
                AtualizarServicos();
                conteudoNovo = true;
            }
            else
            {
                MessageBox.Show("O serviço selecionado tem parcelas associadas. Elimine primeiro as Parcelas para prosseguir.", "Erro ao Eliminar Serviço", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEditarServicos_Click(object sender, EventArgs e)
        {
            Servicos servicoSelecionado = (Servicos)lbxServicos.SelectedItem;
            New_Update_Servico novoServico = new New_Update_Servico();

            novoServico.label_Provisorio.Visible = false;
            novoServico.tbxTipo.Text = servicoSelecionado.Tipo;
            novoServico.dtpDataEntrada.Value = servicoSelecionado.DataEntrada;
            novoServico.dtpDataSaida.Value = servicoSelecionado.DataSaida;

            novoServico.ShowDialog();

            if (novoServico.DialogResult == DialogResult.OK)
            {
                servicoSelecionado.Tipo = novoServico.tipo;
                servicoSelecionado.DataEntrada = novoServico.dataEntrada;
                servicoSelecionado.DataSaida = novoServico.dataSaida;
                conteudoNovo = true;
                AtualizarServicos();
            }
        }

        private void ButtonEditarCarro_Click(object sender, EventArgs e)
        {
            CarrosOficina carroSelecionado = (CarrosOficina)lbxCarros.SelectedItem;
            New_Update_Carro edicaoCarro = new New_Update_Carro();
            edicaoCarro.Text = "Edição do Carro Selecionado";

            edicaoCarro.tbxMarcaCarro.Text = carroSelecionado.Marca;
            edicaoCarro.tbxModeloCarro.Text = carroSelecionado.Modelo;
            edicaoCarro.tbxMatriculaCarro.Text = carroSelecionado.Matricula;
            edicaoCarro.tbxNumChassis.Text = carroSelecionado.NumeroChassis;
            edicaoCarro.tbxKms.Text = carroSelecionado.Kms;
            edicaoCarro.tbxCombustivelCarro.Text = carroSelecionado.Combustivel;

            edicaoCarro.ShowDialog();

            if (edicaoCarro.DialogResult == DialogResult.OK)
            {
                carroSelecionado.Marca = edicaoCarro.marca;
                carroSelecionado.Modelo = edicaoCarro.modelo;
                carroSelecionado.Matricula = edicaoCarro.matricula;
                carroSelecionado.NumeroChassis = edicaoCarro.numeroChassis;
                carroSelecionado.Kms = edicaoCarro.kms;
                carroSelecionado.Combustivel = edicaoCarro.combustivel;

                conteudoNovo = true;
                AtualizarCarros();
            }
        }

        private void ButtonAddParcela_Click(object sender, EventArgs e)
        {
            Servicos servicoSelecionado = (Servicos)lbxServicos.SelectedItem;
            New_Update_Parcela newParcela = new New_Update_Parcela();
            newParcela.ShowDialog();

            Parcelas novaParcela = new Parcelas
            {
                Valor = newParcela.valor,
                Descricao = newParcela.descricao,
                ServicoIdServico = servicoSelecionado.IdServico
            };

            if (newParcela.DialogResult == DialogResult.OK)
            {
                StandLocalDB.Servico.Find(servicoSelecionado.IdServico).Parcela.Add(novaParcela);
                servicoSelecionado.Parcela.Add(novaParcela);
                conteudoNovo = true;
                AtualizarParcelas();
            }
        }

        private void LbxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servicos servicoSelecionado = (Servicos)lbxServicos.SelectedItem;

            if (servicoSelecionado == null)
            {
                return;
            }

            AtualizarParcelas(); 
        }

        private void ButtonEliminarParcelas_Click(object sender, EventArgs e)
        {
            Parcelas parcelaSelecionada = (Parcelas)lbxParcelas.SelectedItem;
            DialogResult dialogResult;
            if (parcelaSelecionada == null)
            {
                MessageBox.Show("Nenhum Serviço Selecionado", "Erro: Serviço Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dialogResult = MessageBox.Show("Pretende eliminar a Parcela selecionada?.", "Eliminar Parcela?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                StandLocalDB.Parcela.Remove(parcelaSelecionada);
                AtualizarParcelas();
                conteudoNovo = true;
            }
        }

        private void ButtonEditarParcelas_Click(object sender, EventArgs e)
        {
            Parcelas parcelaSelecionada = (Parcelas)lbxParcelas.SelectedItem;
            New_Update_Parcela edicaoParcela = new New_Update_Parcela();
            edicaoParcela.Text = "Edição da Parcela Selecionada";

            edicaoParcela.numValor.Value = (decimal)parcelaSelecionada.Valor;
            edicaoParcela.tbxDescricao.Text = parcelaSelecionada.Descricao;

            edicaoParcela.ShowDialog();

            if (edicaoParcela.DialogResult == DialogResult.OK)
            {
                parcelaSelecionada.Valor = edicaoParcela.valor;
                parcelaSelecionada.Descricao = edicaoParcela.descricao;

                conteudoNovo = true;
                AtualizarParcelas();
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            string nome = tbxFiltrar.Text;

            if (nome != string.Empty)
            {
                List<Clientes> clientes = listaCliente.Where(cliente => cliente.Nome.Contains(nome)).ToList();
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
    }
}