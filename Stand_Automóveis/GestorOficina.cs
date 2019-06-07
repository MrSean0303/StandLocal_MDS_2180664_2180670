using System;
using System.Collections.Generic;
using System.Drawing;
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

            tbxFiltrar.ForeColor = SystemColors.GrayText;
            tbxFiltrar.Text = "Filtrar";
            tbxFiltrar.Leave += new System.EventHandler(TbxFiltrar_Leave);
            tbxFiltrar.Enter += new System.EventHandler(TbxFiltrar_Enter);

            CarregarBD carregar = new CarregarBD();
            carregar.Show();
            Application.DoEvents();

            StandLocalDB = new StandLocalDBContainer();
            LerDados();
            carregar.Close();
            carregar.Close();
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
        private void LbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;

            if (clienteSelecionado == null)
            {
                buttonAddCarro.Enabled = false;
                return;
            }
            else
            {
                buttonAddCarro.Enabled = true;
                AtualizarCarros();
                AtualizarServicos();
                AtualizarParcelas();
            }
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
            Form_AddEdit_Carro novocarro = new Form_AddEdit_Carro();
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
            DialogResult dialogResult;

            if (carroSelecionado == null)
            {
                MessageBox.Show("Nenhum Carro Selecionado", "Erro: Carro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dialogResult = MessageBox.Show("Pretende eliminar a Parcela selecionada?.", "Eliminar Parcela?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                listaCarro.Remove(carroSelecionado);
                StandLocalDB.Carro.Remove(carroSelecionado);
                AtualizarCarros();
                conteudoNovo = true;
            }
            else
            {
                return;
            }
        }

        private void ButtonAddServico_Click(object sender, EventArgs e)
        {
            CarrosOficina carroSelecionado = (CarrosOficina)lbxCarros.SelectedItem;
            Form_AddEdit_Servico novoServico = new Form_AddEdit_Servico();
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
                DisableCarros();
                return;  
            }
            else
            {
                EnableCarros();
                AtualizarServicos();
                AtualizarParcelas();
            }       
        }

        private void ButtonEliminarServicos_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            Servicos servicoSelecionado = (Servicos)lbxServicos.SelectedItem;
            if (servicoSelecionado == null)
            {
                MessageBox.Show("Nenhum Serviço Selecionado", "Erro: Serviço Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (servicoSelecionado.DataSaida > DateTime.Now.Date)
            {
                MessageBox.Show("O serviço não está concluido! Termine primeiro o serviço para continuar.", "Erro: Serviço não terminado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            dialogResult = MessageBox.Show("Pretende eliminar o Serviço selecionada?.", "Eliminar Serviço?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (servicoSelecionado.Parcela.Count == 0 && dialogResult == DialogResult.Yes)
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
            Form_AddEdit_Servico novoServico = new Form_AddEdit_Servico();

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
            Form_AddEdit_Carro edicaoCarro = new Form_AddEdit_Carro();
            edicaoCarro.Text = "Edição do Carro Selecionado";

            edicaoCarro.tbxMarcaCarro.Text = carroSelecionado.Marca;
            edicaoCarro.tbxModeloCarro.Text = carroSelecionado.Modelo;
            edicaoCarro.tbxMatriculaCarro.Text = carroSelecionado.Matricula;
            edicaoCarro.tbxNumChassis.Text = carroSelecionado.NumeroChassis;
            edicaoCarro.nudKms.Value = decimal.Parse(carroSelecionado.Kms);
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
            Form_AddEdit_Parcela newParcela = new Form_AddEdit_Parcela();
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
                DisableServicos();
                return;
            }
            else
            {
                EnableServicos();
                AtualizarParcelas(); 
            }
            
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
            Form_AddEdit_Parcela edicaoParcela = new Form_AddEdit_Parcela();
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

        private void LbxParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parcelas parcelaSelecionado = (Parcelas)lbxParcelas.SelectedItem;

            if (parcelaSelecionado == null)
            {
                DisableParcelas();
                return;
            }
            else
                EnableParcelas();
        }

        private void LimparSelecaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbxClientes.ClearSelected();
            lbxCarros.DataSource = null;
            lbxServicos.DataSource = null;
            lbxParcelas.DataSource = null;
        }

        #region DisableButtons
        private void DisableParcelas()
        {
            buttonEliminarParcela.Enabled = false;
            buttonEditarParcela.Enabled = false;
        }
        private void DisableCarros()
        {
            buttonAddServico.Enabled = false;
            buttonEliminarCarro.Enabled = false;
            buttonEditarCarro.Enabled = false;
        }
        private void DisableServicos()
        {
            buttonAddParcela.Enabled = false;
            buttonEliminarServico.Enabled = false;
            buttonEditarServico.Enabled = false;
        }
        #endregion

        #region EnableButtons
        private void EnableParcelas()
        {
            buttonEliminarParcela.Enabled = true;
            buttonEditarParcela.Enabled = true;
        }
        private void EnableCarros()
        {
            buttonAddServico.Enabled = true;
            buttonEliminarCarro.Enabled = true;
            buttonEditarCarro.Enabled = true;
        }
        private void EnableServicos()
        {
            buttonAddParcela.Enabled = true;
            buttonEliminarServico.Enabled = true;
            buttonEditarServico.Enabled = true;
        }
        #endregion

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

        private void ButtonServicoOkay_Click(object sender, EventArgs e)
        {
            Servicos servicoSelecionado = (Servicos)lbxServicos.SelectedItem;

        }
    }
}