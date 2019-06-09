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
    public partial class MenuPrincipal : Form
    {
        private StandLocalDBContainer StandLocalDB;
        
        public MenuPrincipal()
        {
            InitializeComponent();
            StandLocalDB = new StandLocalDBContainer();
            AtualizarMenu();
        }

        public void AtualizarMenu()
        {
            List<Clientes> listaClientes = StandLocalDB.Clientes.ToList();
            int numeroClientes = StandLocalDB.Clientes.Count();
            int aluguerNumero = StandLocalDB.Aluguer.Count();
            int vendasNumero = StandLocalDB.Vendas.Count();
            int CarroOficinaNumero = 0;

            foreach (Clientes c in listaClientes)
            {
                CarroOficinaNumero += c.CarroOficina.Count();
            }

            Numeros.Text = "| Clientes: " + numeroClientes + "  | Vendas: " + vendasNumero + " | Carros alugados: " + aluguerNumero + " | Carros na Oficina: " + CarroOficinaNumero;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string hora = DateTime.Now.ToLongTimeString(), data = DateTime.Now.ToString("dd/MM/yyyy");
            toolStripStatusLabelHora.Text ="Data: " + data + " | Hora: " + hora; 

        }

        private void BtnGestaoClientes_Click_1(object sender, EventArgs e)
        {
            GestorCliente gestorCliente = new GestorCliente();
            gestorCliente.ShowDialog();
            AtualizarMenu();

        }

        private void BtnGestaoOficina_Click_1(object sender, EventArgs e)
        {
            GestorOficina gestorOficina = new GestorOficina();
            gestorOficina.ShowDialog();
            AtualizarMenu();
        }

        private void BtnGestaoAluguer_Click_1(object sender, EventArgs e)
        {
            GestorAluguer gestorAluguer = new GestorAluguer();
            gestorAluguer.ShowDialog();
            AtualizarMenu();
        }

        private void BtnGestaoVenda_Click_1(object sender, EventArgs e)
        {
            GestorVenda gestorVenda = new GestorVenda();
            gestorVenda.ShowDialog();
            AtualizarMenu();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
