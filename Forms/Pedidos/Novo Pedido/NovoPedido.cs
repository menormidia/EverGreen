using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaEstoqueLogin.Forms.Pedidos.Adicionar_Pedidos
{
    public partial class NovoPedido : Form
    {
        public NovoPedido()
        {
            InitializeComponent();
        }

        private void btnadicionarProduto_Click(object sender, EventArgs e)
        {
            // Captura os dados da interface (TextBox)
            string descricaoProduto = txtDescricaoProduto.Text;
            int quantidade;
            decimal valorUnitario;

            // Verificação básica para garantir que os campos não estão vazios
            if (string.IsNullOrWhiteSpace(descricaoProduto) ||
                !int.TryParse(txtQuantidade.Text, out quantidade) ||
                !decimal.TryParse(txtValorUnitario.Text, out valorUnitario))
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.");
                return;
            }

            // Calcula o valor total para o item adicionado
            decimal valorTotalItem = quantidade * valorUnitario;

            // Adiciona uma nova linha ao DataGridView com os dados do item
            dgvNovoPedido.Rows.Add(descricaoProduto, quantidade, valorUnitario.ToString("C"), valorTotalItem.ToString("C"));

            // Atualiza o total geral após a adição de um novo item
            AtualizartotalPedido();

            // Limpa os campos de entrada após adicionar o item
            txtDescricaoProduto.Clear();
            txtQuantidade.Clear();
            txtValorUnitario.Clear();
            txtDescricaoProduto.Focus(); // Volta o foco para a primeira TextBox
        }

        // Evento de alteração no DataGridView para atualizar o total
        private void dgvPedidos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula alterada está na coluna de Quantidade ou Valor Unitário
            if (e.ColumnIndex == dgvNovoPedido.Columns["Quantidade"].Index ||
                e.ColumnIndex == dgvNovoPedido.Columns["ValorUnitario"].Index)
            {
                // Captura os valores de Quantidade e Valor Unitário
                int quantidade = Convert.ToInt32(dgvNovoPedido.Rows[e.RowIndex].Cells["Quantidade"].Value);
                decimal valorUnitario = Convert.ToDecimal(dgvNovoPedido.Rows[e.RowIndex].Cells["ValorUnitario"].Value);

                // Calcula o total da linha
                decimal valorTotal = quantidade * valorUnitario;

                // Atualiza a célula de Total
                dgvNovoPedido.Rows[e.RowIndex].Cells["Total"].Value = valorTotal.ToString("C");
            }

            // Atualiza o total geral após cada modificação
            AtualizartotalPedido();
        }

        // Função para atualizar o total geral (igual ao exemplo anterior)
        private void AtualizartotalPedido()
        {
            decimal totalPedido = 0;

            foreach (DataGridViewRow row in dgvNovoPedido.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    totalPedido += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }

            // Atualiza a TextBox do total geral
            txttotalPedido.Text = totalPedido.ToString("C");
        }

        public class Pedido
        {
            public int PedidoId { get; set; }
            public DateTime DataEntrada { get; set; }
            public string IdCliente { get; set; }
            public string Observacoes { get; set; }
            public List<ItemPedido> Itens { get; set; }
        }

        public class ItemPedido
        {
            public string Descricao { get; set; }
            public int Quantidade { get; set; }
            public decimal ValorUnitario { get; set; }
        }

        private void btnAdicionarPedido_Click(object sender, EventArgs e)
        {
            // Cria o objeto Pedido
            Pedido novoPedido = new Pedido
            {
                IdCliente = txtidCliente.Text,
                Itens = new List<ItemPedido>()
            };

            // Adiciona os itens do DataGridView ao pedido
            foreach (DataGridViewRow row in dgvNovoPedido.Rows)
            {
                if (row.Cells["Descricao"].Value != null)
                {
                    novoPedido.Itens.Add(new ItemPedido
                    {
                        Descricao = row.Cells["Descricao"].Value.ToString(),
                        Quantidade = int.Parse(row.Cells["Quantidade"].Value.ToString()),
                        ValorUnitario = decimal.Parse(row.Cells["ValorUnitario"].Value.ToString())
                    });
                }
            }

            try
            {
                // Chama o método de inserção no banco de dados
                int pedidoId = BancoDeDados.InserirPedido(novoPedido);

                MessageBox.Show("Pedido inserido com sucesso! ID do Pedido: " + pedidoId, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Volta para a tela de pedidos
                this.Close();
                // Supondo que você tenha uma tela de Pedidos que precisa ser atualizada
                TelaPedidos telaPedidos = new TelaPedidos();
                telaPedidos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o pedido: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
