using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stand_Automoveis
{
    class ImprimirDocumentos
    {
        public void CarroOficinaHistorico(Clientes clienteSelecionado, CarrosOficina carroSelecionado)
        {
            double valorTotal = 0;

            SaveFileDialog save = new SaveFileDialog();

            save.InitialDirectory = @"C:/";
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save.FileName = "Serviços no Carro " + carroSelecionado.Matricula;
            save.DefaultExt = ".txt";

            if (save.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Stream caminhoFiceiro = save.OpenFile();
            StreamWriter sw = new StreamWriter(caminhoFiceiro);

            sw.WriteLine("StandLocal - Qualquer serviço tem um preço.");
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine("Nome: " + clienteSelecionado.Nome);
            sw.WriteLine("___________________________________________________");
            sw.WriteLine("Nif: " + clienteSelecionado.NIF);
            sw.WriteLine("___________________________________________________");
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine("Carro:");
            sw.WriteLine("Marca:" + carroSelecionado.Marca + " Modelo: " + carroSelecionado.Modelo);
            sw.WriteLine("Matricula:" + carroSelecionado.Matricula + " Tipo de Combustivel: " + carroSelecionado.Combustivel);

            foreach (Servicos s in carroSelecionado.Servico)
            {

                sw.WriteLine("___________________________________________________");
                sw.WriteLine("Serviço Inicializado no dia: " + s.DataEntrada.ToString("dd-MM-yy"));
                sw.WriteLine("Serviço finalizada no dia: " + s.DataSaida.ToString("dd-MM-yy"));
                sw.WriteLine("___________________________________________________");
                sw.WriteLine(" ");
                sw.WriteLine(" ");
                sw.WriteLine("Serviços Efetuados no carro:");
                foreach (Parcelas ps in s.Parcela)
                {
                    sw.WriteLine("              Descrição:" + ps.Descricao + " Valor: " + ps.Valor + "€");
                    valorTotal += ps.Valor;
                }
               
            }
            sw.WriteLine("Valor Total pago em Serviços: " + valorTotal + "€");
            sw.Close();

            MessageBox.Show("Dados guadados com sucesso!");
        }

        public void carroOficinaUnica(Clientes clienteSelecionado,CarrosOficina carrosOficina, Servicos ServicoSelecionada) {

            List<Parcelas> listaServico = new List<Parcelas>();
            double valorTotal = 0;

            foreach (Parcelas parcela in ServicoSelecionada.Parcela) {
                listaServico.Add(parcela);
            }

            SaveFileDialog save = new SaveFileDialog();

            save.InitialDirectory = @"C:/";
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save.FileName = "Servico feito no carro do cliente " + clienteSelecionado.Nome;
            save.DefaultExt = ".txt";

            if (save.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Stream caminhoFiceiro = save.OpenFile();
            StreamWriter sw = new StreamWriter(caminhoFiceiro);

            sw.WriteLine("StandLocal - Qualquer serviço tem um preço.");
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine("Nome: " + clienteSelecionado.Nome);
            sw.WriteLine("___________________________________________________");
            sw.WriteLine("Nif: " + clienteSelecionado.NIF);
            sw.WriteLine("___________________________________________________");
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine("Carro:");
            sw.WriteLine("Marca:" + carrosOficina.Marca + " Modelo: " + carrosOficina.Modelo);
            sw.WriteLine("Matricula:" + carrosOficina.Matricula + " Tipo de Combustivel: " + carrosOficina.Combustivel);
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine("___________________________________________________");
            sw.WriteLine("Tipo de Serviço: " + ServicoSelecionada.Tipo);
            sw.WriteLine("Data de inicio do Serviço: " + ServicoSelecionada.DataEntrada.ToString("dd-MM-yy"));
            sw.WriteLine("Data de finalização do Serviço: " + ServicoSelecionada.DataSaida.ToString("dd-MM-yy"));
            sw.WriteLine("___________________________________________________");

            foreach (Parcelas parcelas in listaServico)
            {
                sw.WriteLine(" ");
                sw.WriteLine(" ");
                sw.WriteLine("___________________________________________________");
                sw.WriteLine("Valor: " + parcelas.Valor);
                sw.WriteLine("Descrição: " + parcelas.Descricao);              
                sw.WriteLine("___________________________________________________");
                valorTotal += parcelas.Valor;
            }
            sw.WriteLine("              Valor Total do Serviço: " + valorTotal.ToString() + "€");

            sw.Close();

            MessageBox.Show("Dados guadados com sucesso!");

        }

        public void Aluguereshistorico(Clientes clienteSelecionado)
        {

            List<Alugueres> ListaAlugueres = new List<Alugueres>();

            foreach (Alugueres aluguer in clienteSelecionado.Aluguer)
            {
                ListaAlugueres.Add(aluguer);
            }

            SaveFileDialog save = new SaveFileDialog();

            save.InitialDirectory = @"C:/";
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save.FileName = "Alugueres feitos ao cliente " + clienteSelecionado.Nome;
            save.DefaultExt = ".txt";

            if (save.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Stream caminhoFiceiro = save.OpenFile();
            StreamWriter sw = new StreamWriter(caminhoFiceiro);

            sw.WriteLine("StandLocal - Qualquer serviço tem um preço.");
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine("Nome: " + clienteSelecionado.Nome);
            sw.WriteLine("___________________________________________________");
            sw.WriteLine("Nif: " + clienteSelecionado.NIF);
            sw.WriteLine("___________________________________________________");
            sw.WriteLine(" ");
            sw.WriteLine(" ");


            foreach (Alugueres alugueresDoCliente in ListaAlugueres)
            {
                sw.WriteLine("___________________________________________________");
                sw.WriteLine("Carro:");
                sw.WriteLine("Marca:" + alugueresDoCliente.CarroAluguer.Marca + " Modelo: " + alugueresDoCliente.CarroAluguer.Modelo);
                sw.WriteLine("Matricula:" + alugueresDoCliente.CarroAluguer.Matricula + " Tipo de Combustivel: " + alugueresDoCliente.CarroAluguer.Combustivel);
                sw.WriteLine(" ");
                sw.WriteLine(" ");
                sw.WriteLine("Kilometros do Carro antes do Aluguer: " + alugueresDoCliente.Kms);
                sw.WriteLine("Valor do Aluguer: " + alugueresDoCliente.Valor + "€");
                sw.WriteLine("Aluguer Inicializado no dia: " + alugueresDoCliente.DataInicio.ToString("dd-MM-yy"));
                sw.WriteLine("Aluguer finalizado no dia: " + alugueresDoCliente.DataFim.ToString("dd-MM-yy"));
                sw.WriteLine("___________________________________________________");
                sw.WriteLine(" ");
                sw.WriteLine(" ");
            }
            sw.Close();

            MessageBox.Show("Dados guadados com sucesso!");
        }

        public void AluguerUnico(Clientes clienteSelecionado, Alugueres AluguerSelecionado)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.InitialDirectory = @"C:/";
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save.FileName = "Alugueres feito ao cliente " + clienteSelecionado.Nome;
            save.DefaultExt = ".txt";

            if (save.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Stream caminhoFiceiro = save.OpenFile();
            StreamWriter sw = new StreamWriter(caminhoFiceiro);

            sw.WriteLine("StandLocal - Qualquer serviço tem um preço.");
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine("Nome: " + clienteSelecionado.Nome);
            sw.WriteLine("___________________________________________________");
            sw.WriteLine("Nif: " + clienteSelecionado.NIF);
            sw.WriteLine("___________________________________________________");
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine("___________________________________________________");
            sw.WriteLine("Carro: ");
            sw.WriteLine("Marca: " + AluguerSelecionado.CarroAluguer.Marca + " Modelo: " + AluguerSelecionado.CarroAluguer.Modelo);
            sw.WriteLine("Matricula: " + AluguerSelecionado.CarroAluguer.Matricula + " Tipo de Combustivel: " + AluguerSelecionado.CarroAluguer.Combustivel);
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine("Kilometros do Carro antes do Aluguer: " + AluguerSelecionado.Kms);
            sw.WriteLine("Valor do Aluguer: " + AluguerSelecionado.Valor + "€");
            sw.WriteLine("Aluguer Inicializado no dia: " + AluguerSelecionado.DataInicio.ToString("dd-MM-yy"));
            sw.WriteLine("Aluguer finalizado no dia: " + AluguerSelecionado.DataFim.ToString("dd-MM-yy"));
            sw.WriteLine("___________________________________________________");
            sw.Close();

            MessageBox.Show("Dados guadados com sucesso!");
        }

        public void VendaHistorico(Clientes clienteSelecionado)
        {

            List<Vendas> listaVenda = new List<Vendas>();

            foreach (Vendas venda in clienteSelecionado.Venda)
            {
                listaVenda.Add(venda);
            }

            SaveFileDialog save = new SaveFileDialog();

            save.InitialDirectory = @"C:/";
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save.FileName = "Vendas feitas ao cliente " + clienteSelecionado.Nome;
            save.DefaultExt = ".txt";

            if (save.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Stream caminhoFiceiro = save.OpenFile();
            StreamWriter sw = new StreamWriter(caminhoFiceiro);

            sw.WriteLine("StandLocal - Qualquer serviço tem um preço.");
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine("Nome: " + clienteSelecionado.Nome);
            sw.WriteLine("___________________________________________________");
            sw.WriteLine("Nif: " + clienteSelecionado.NIF);
            sw.WriteLine("___________________________________________________");

            foreach (Vendas vendaTodo in listaVenda)
            {
                sw.WriteLine(" ");
                sw.WriteLine(" ");
                sw.WriteLine("___________________________________________________");
                sw.WriteLine("Carro: ");
                sw.WriteLine("Marca: " + vendaTodo.CarroVenda.Marca + " Modelo: " + vendaTodo.CarroVenda.Modelo);
                sw.WriteLine("Extras: " + vendaTodo.CarroVenda.Extras);
                sw.WriteLine(" ");
                sw.WriteLine(" ");
                sw.WriteLine("Data de Venda: " + vendaTodo.Data.ToString("dd-MM-yy"));
                sw.WriteLine("Estado da Venda: " + vendaTodo.Estado);
                sw.WriteLine("Valor do Venda: " + vendaTodo.Valor + "€");
                sw.WriteLine("___________________________________________________");
            }
            sw.Close();

            MessageBox.Show("Dados guadados com sucesso!");
        }

        public void VendaUnica(Clientes clienteSelecionado, Vendas vendasDoCliente)
        {

            SaveFileDialog save = new SaveFileDialog();

            save.InitialDirectory = @"C:/";
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save.FileName = "Vendas feitas ao cliente " + clienteSelecionado.Nome;
            save.DefaultExt = ".txt";

            if (save.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Stream caminhoFiceiro = save.OpenFile();
            StreamWriter sw = new StreamWriter(caminhoFiceiro);

            sw.WriteLine("StandLocal - Qualquer serviço tem um preço.");
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine("Nome: " + clienteSelecionado.Nome);
            sw.WriteLine("___________________________________________________");
            sw.WriteLine("Nif: " + clienteSelecionado.NIF);
            sw.WriteLine("___________________________________________________");
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine("___________________________________________________");
            sw.WriteLine("Carro:");
            sw.WriteLine("Marca:" + vendasDoCliente.CarroVenda.Marca + " Modelo: " + vendasDoCliente.CarroVenda.Modelo);
            sw.WriteLine("Extras:" + vendasDoCliente.CarroVenda.Extras);
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine("Data de Venda" + vendasDoCliente.Data.ToString("dd-MM-yy"));
            sw.WriteLine("Estado da Venda:" + vendasDoCliente.Estado);
            sw.WriteLine("Valor do Venda: " + vendasDoCliente.Valor + "€");
            sw.WriteLine("___________________________________________________");

            sw.Close();

            MessageBox.Show("Dados guadados com sucesso!");
        }

    }
}
