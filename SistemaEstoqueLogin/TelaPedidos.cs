using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace SistemaEstoqueLogin
{
    public partial class TelaPedidos : Form
    {
        public TelaPedidos()
        {
            InitializeComponent();
        }

        private void TelaPedidos_Load(object sender, EventArgs e)
        {

        }
        private void btnPesquisarPedidos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisar pedidos de " + dtpDePedidos.Value.ToShortDateString() + " até " + dtpAtePedidos.Value.ToShortDateString());
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir tela de novos pedidos.");
        }
    }
}
