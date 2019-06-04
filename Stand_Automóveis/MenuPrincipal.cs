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
        public MenuPrincipal()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string hora = DateTime.Now.ToLongTimeString(), data = DateTime.Now.ToString("dd/MM/yyyy");
            toolStripStatusLabelHora.Text ="Data: " + data + " Hora: " + hora; 

        }

        private void BtnGestaoClientes_Click_1(object sender, EventArgs e)
        {
            GestorCliente gestorCliente = new GestorCliente();
            gestorCliente.Show();
        }

        private void BtnGestaoOficina_Click_1(object sender, EventArgs e)
        {
            GestorOficina gestorOficina = new GestorOficina();
            gestorOficina.Show();
        }

        private void BtnGestaoAluguer_Click_1(object sender, EventArgs e)
        {
            GestorAluguer gestorAluguer = new GestorAluguer();
            gestorAluguer.Show();
        }

        private void BtnGestaoVenda_Click_1(object sender, EventArgs e)
        {
            GestorVenda gestorVenda = new GestorVenda();
            gestorVenda.Show();
        }
    }
}
