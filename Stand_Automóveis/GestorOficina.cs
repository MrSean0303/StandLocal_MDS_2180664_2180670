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
        List<Clientes> listaClientes = new List<Clientes>();
        List<Carros> listaCarros = new List<Carros>();
        List<Servicos> listaServicos = new List<Servicos>();
        bool conteudoNovo = false;

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
        }
        #region AtualizaçãoDados

        //Lê os dados da Base de Dados e adiciona-os à lista Clientes
        private void LerDados()
        {
            listaClientes = StandLocalDB.Clientes.ToList();

            AtualizarClientes();
        }

        //Atualiza a listBoxCarros
        private void AtualizarCarros()
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;
            lbxCarros.DataSource = null;
            lbxCarros.DataSource = clienteSelecionado.CarroOficina.ToList();
        }

        //Atualiza a ListBoxClientes
        private void AtualizarClientes()
        {
            lbxClientes.DataSource = null;
            lbxClientes.DataSource = listaClientes;
        }

        //Atualiza a listBoxServicos
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

        //Atualiza a listBoxParcelas
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
        #endregion

        #region GroupBoxClientes

        //Função de Filtrar Clientes
        private void TbxFiltrar_TextChanged(object sender, EventArgs e)
        {
            string nome = tbxFiltrar.Text;

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

        //Evento sair da textBox Filtar
        private void TbxFiltrar_Leave(object sender, EventArgs e)
        {
            if (tbxFiltrar.Text.Length == 0)
            {
                tbxFiltrar.Text = "Filtrar";
                tbxFiltrar.ForeColor = SystemColors.GrayText;
                AtualizarClientes();
            }
        }

        //Evento entrar da textBox Filtar
        private void TbxFiltrar_Enter(object sender, EventArgs e)
        {
            if (tbxFiltrar.Text == "Filtrar")
            {
                tbxFiltrar.Text = "";
                tbxFiltrar.ForeColor = SystemColors.WindowText;
            }
        }

        //Função Ordenar Clientes por ordem Crescente
        private void ButtonOrdenarCres_Click(object sender, EventArgs e)
        {
            List<Clientes> clientes = listaClientes.OrderBy(cliente => cliente.Nome).ToList();
            lbxClientes.DataSource = null;
            lbxClientes.DataSource = clientes;
        }

        //Função Ordenar Clientes por ordem Decrescente
        private void ButtonOrdenarDesc_Click(object sender, EventArgs e)
        {
            List<Clientes> clientes = listaClientes.OrderByDescending(cliente => cliente.Nome).ToList();
            lbxClientes.DataSource = null;
            lbxClientes.DataSource = clientes;
        }
        #endregion

        #region GroupBoxCarrosOficina

        //Função Adicionar Carro para Oficina
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
                listaCarros.Add(carroTemp);
                StandLocalDB.Clientes.Find(clienteSelecionado.IdCliente).CarroOficina.Add(carroTemp);
                AtualizarCarros();
                conteudoNovo = true;
            }
        }

        //Função Eliminar Carro da Oficina
        private void ButtonEliminarCarro_Click(object sender, EventArgs e)
        {
            CarrosOficina carroSelecionado = (CarrosOficina)lbxCarros.SelectedItem;
            DialogResult dialogResult;

            if (carroSelecionado == null)
            {
                MessageBox.Show("Nenhum Carro Selecionado", "Erro: Carro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dialogResult = MessageBox.Show("Pretende eliminar o Carro selecionada?.", "Eliminar Carro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (carroSelecionado.Servico.Count == 0 && dialogResult == DialogResult.Yes)
            {
                listaCarros.Remove(carroSelecionado);
                StandLocalDB.Carro.Remove(carroSelecionado);
                AtualizarCarros();
                conteudoNovo = true;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("O carro selecionado tem serviços associados. Elimine primeiro os Serviços para prosseguir.", "Erro ao Eliminar Carro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Verifica qual o Carro selecionado
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

        //Função Editar Carro 
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
        #endregion

        #region ToolStripOptions

        //Imprimir todas as ações do cliente 
        private void imprimirHistoricoCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;
            CarrosOficina carroOficinaSelecionado = (CarrosOficina)lbxCarros.SelectedItem;

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Para imprimir por favor selecione um cliente.", "Cliente por selecionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (carroOficinaSelecionado == null)
            {
                MessageBox.Show("Para imprimir por favor selecione um carro", "Carro por selecionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (clienteSelecionado == null || carroOficinaSelecionado == null)
            {
                return;
            }

            ImprimirDocumentos imprimir = new ImprimirDocumentos();
            imprimir.CarroOficinaHistorico(clienteSelecionado, carroOficinaSelecionado);
        }

        //Inserção de novo cliente
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
                listaClientes.Add(clienteTemp);
                StandLocalDB.Clientes.Add(clienteTemp);
                AtualizarClientes();
                conteudoNovo = true;
            }
        }

        //Função Guardar os dados na base de dados
        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StandLocalDB.SaveChanges();
            conteudoNovo = false;
        }

        //Função Sair da Gestão de Oficina
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Limpa as seleções do gestor de Oficinas
        private void LimparSelecaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbxClientes.ClearSelected();
            lbxCarros.DataSource = null;
            lbxServicos.DataSource = null;
            lbxParcelas.DataSource = null;
        }
        #endregion

        #region GroupBoxServiços

        //Função Imprimir Fatura
        private void ButtonFatura_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)lbxClientes.SelectedItem;
            CarrosOficina carroOficinaSelecionado = (CarrosOficina)lbxCarros.SelectedItem;
            Servicos ServicoSelecionada = (Servicos)lbxServicos.SelectedItem;

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Para imprimir por favor selecione um cliente.", "Cliente por selecionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (carroOficinaSelecionado == null)
            {
                MessageBox.Show("Para imprimir por favor selecione um carro", "Carro por selecionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ServicoSelecionada == null)
            {
                MessageBox.Show("Para imprimir por favor selecione um Servico", "Servico por selecionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (clienteSelecionado == null || carroOficinaSelecionado == null || ServicoSelecionada == null)
            {
                return;
            }

            ImprimirDocumentos imprimir = new ImprimirDocumentos();
            imprimir.carroOficinaUnica(clienteSelecionado, carroOficinaSelecionado, ServicoSelecionada);
        }

        //Função Serviço terminado (data de saída é alterada para o dia atual)
        private void ButtonServicoOkay_Click(object sender, EventArgs e)
        {
            Servicos servicoSelecionado = (Servicos)lbxServicos.SelectedItem;
            string done = "(ACABADO) ";

            if (servicoSelecionado.ToString().Contains(done) == false)
            {
                servicoSelecionado.DataSaida = DateTime.Now.Date;
                servicoSelecionado.Tipo = done + servicoSelecionado.Tipo;
            }

            conteudoNovo = true;
            AtualizarServicos();
        }

        //Adicionar Serviço ao Carro selecionado
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
                listaServicos.Add(servicoTemp);
                ((CarrosOficina)StandLocalDB.Carro.Find(carroSelecionado.idCarro)).Servico.Add(servicoTemp);
                carroSelecionado.Servico.Add(servicoTemp);
                conteudoNovo = true;
                AtualizarServicos();
            }   
        }

        //Eliminar Serviços Selecionado
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
                listaServicos.Remove(servicoSelecionado);
                StandLocalDB.Servico.Remove(servicoSelecionado);
                AtualizarServicos();
                conteudoNovo = true;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("O serviço selecionado tem parcelas associadas. Elimine primeiro as Parcelas para prosseguir.", "Erro ao Eliminar Serviço", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Editar o Serviço Selecionado
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

        //Verifica qual o serviço selecionado
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
        #endregion

        #region GroupBoxParcelas

        //Adicionar Parcela ao Serviço Selecionado
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
        //Elimina a Parcela Selecionada
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

        //Editar a parcela selecionada
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

        //Verifica qual a parcela selecionada
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
        #endregion

        #region DisableButtons

        //Desativa os botões das Parcelas
        private void DisableParcelas()
        {
            buttonEliminarParcela.Enabled = false;
            buttonEditarParcela.Enabled = false;
        }

        //Desativa os botões dos Carros
        private void DisableCarros()
        {
            buttonAddServico.Enabled = false;
            buttonEliminarCarro.Enabled = false;
            buttonEditarCarro.Enabled = false;
        }

        //Desativa os botões dos Serviços
        private void DisableServicos()
        {
            buttonServicoOkay.Enabled = false;
            buttonAddParcela.Enabled = false;
            buttonEliminarServico.Enabled = false;
            buttonEditarServico.Enabled = false;
        }
        #endregion

        #region EnableButtons

        //Ativa os botões das Parcelas
        private void EnableParcelas()
        {
            buttonEliminarParcela.Enabled = true;
            buttonEditarParcela.Enabled = true;
        }

        //Ativa os botões dos Carros
        private void EnableCarros()
        {
            buttonAddServico.Enabled = true;
            buttonEliminarCarro.Enabled = true;
            buttonEditarCarro.Enabled = true;
        }

        //Ativa os botões dos Serviços
        private void EnableServicos()
        {
            buttonServicoOkay.Enabled = true;
            buttonAddParcela.Enabled = true;
            buttonEliminarServico.Enabled = true;
            buttonEditarServico.Enabled = true;
        }
        #endregion

        //Evento do Form "enquanto" a fechar
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
    }
}