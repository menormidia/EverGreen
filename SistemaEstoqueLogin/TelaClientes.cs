using System;
using System.Windows.Forms;

namespace SistemaEstoqueLogin
{
    public partial class TelaClientes : Form
    {
        public TelaClientes()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisar clientes de " + dtpDe.Value.ToShortDateString() + " até " + dtpAte.Value.ToShortDateString());
        }

        private void BtnNovoCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir tela de cadastro de novo cliente.");
        }

        private void TelaClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
