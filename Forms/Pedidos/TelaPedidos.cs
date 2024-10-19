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

        private void btnPesquisarPedido_Click(object sender, EventArgs e)
        {
            string filtro = txtPesquisarPedido.Text; // Pegando o filtro da TextBox
            var pedidos = BancoDeDados.BuscarPedidos(filtro); // Buscando os pedidos no banco

            dgvPedidos.DataSource = pedidos; // Preenchendo o DataGridView
        }

        private void TelaPedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaEstoqueDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.sistemaEstoqueDataSet.Clientes);

        }
        private void btnPesquisarPedidos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisar pedidos de " + dtpDePedidos.Value.ToShortDateString() + " até " + dtpAtePedidos.Value.ToShortDateString());
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir tela de novos pedidos.");
        }

        private void btnDetalhesPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                // Obter o pedido selecionado
                int numeroPedido = Convert.ToInt32(dgvPedidos.SelectedRows[0].Cells["NumeroPedido"].Value);
                string nomeCliente = dgvPedidos.SelectedRows[0].Cells["NomeCliente"].Value.ToString();
                string emailCliente = dgvPedidos.SelectedRows[0].Cells["Email"].Value.ToString();

                // Abrir a TelaDetalhesPedido com os dados do pedido
                TelaDetalhesPedidos detalhesPedidos = new TelaDetalhesPedidos(numeroPedido, nomeCliente, emailCliente);
                detalhesPedidos.Show();
            }
        }
    }
}
