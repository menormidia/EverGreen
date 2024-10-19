using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstoqueLogin
{
    public partial class TelaDetalhesPedidos : Form
    {
        public TelaDetalhesPedidos()
        {
            InitializeComponent();
        }

        public TelaDetalhesPedidos(int numeroPedido, string nomeCliente, string emailCliente)
        {
            // Preencha os campos com os dados recebidos
            txtNumeroPedidoCliente.Text = numeroPedido.ToString();
            txtNomeClientePedido.Text = nomeCliente;
            txtEmailPedidoCliente.Text = emailCliente;

            // Carregar produtos relacionados ao pedido do banco de dados
            CarregarProdutos(numeroPedido);
        }

        private void CarregarProdutos(int numeroPedido)
        {
            var produtos = BancoDeDados.BuscarProdutosPorPedido(numeroPedido);
            dgvDetalhesPedidos.DataSource = produtos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNumeroPedidoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaDetalhesPedidos_Load(object sender, EventArgs e)
        {

        }
    }
}
