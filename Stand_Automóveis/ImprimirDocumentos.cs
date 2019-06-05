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
        public void CarroOficinaHistorico(Clientes clienteSelecionado, CarrosOficina carroSelecionado) {

            double valorTotal=0;

            SaveFileDialog save = new SaveFileDialog();

            save.InitialDirectory = @"C:/";
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save.FileName = "Serviços no Carro: " + carroSelecionado.Matricula;
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
                sw.WriteLine("Serviço Inicializado no dia: " + s.DataEntrada);
                sw.WriteLine("Serviço finalizada no dia: " + s.DataSaida);
                sw.WriteLine("___________________________________________________");
                sw.WriteLine(" ");
                sw.WriteLine(" ");
                sw.WriteLine("Serviços Efetuados no carro:");
                foreach (Parcelas ps in s.Parcela)
                {
                    sw.WriteLine("              Descrição:" + ps.Descricao + " Valor: " + ps.Valor.ToString() + "€");
                    valorTotal += ps.Valor;
                }
                sw.WriteLine("Valor Total pago em Serviços: "+ valorTotal + "€");
            }
            sw.Close();

            MessageBox.Show("Dados guadados com sucesso!");
        }

        public void Aluguereshistorico(Clientes clienteSelecionado) {


        }

        public void AluguerImprimir(Clientes clienteSelecionado)
        {


        }
    }
}
