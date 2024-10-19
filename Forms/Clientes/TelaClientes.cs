using System;
using System.Data.SqlClient;
using System.Data;
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

        private void btnLupa_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtPesquisarCliente.Text.Trim();

            if (!string.IsNullOrEmpty(nomeCliente))
            {
                // Função para buscar clientes no banco de dados pelo nome
                BuscarClientes(nomeCliente);
            }
            else
            {
                MessageBox.Show("Por favor, insira um nome para a pesquisa.");
            }
        }

        private void BuscarClientes(string nomeCliente)
        {
            // Defina sua string de conexão com o banco de dados
            string connectionString = "Data Source=DESKTOP-5R7M76S;Initial Catalog=SistemaEstoque;Integrated Security=True;TrustServerCertificate=True";

            // Query SQL para buscar clientes pelo nome (ajuste conforme necessário)
            string query = "SELECT IdCliente, NomeCliente, Email, Telefone, Endereco, Bairro, Cidade, CEP " +
                           "FROM Clientes WHERE NomeCliente LIKE @NomeCliente";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crie um SqlCommand para executar a consulta
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Defina o parâmetro @NomeCliente para evitar SQL Injection
                        command.Parameters.AddWithValue("@NomeCliente", "%" + nomeCliente + "%");

                        // Execute a consulta e obtenha os resultados
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Atribua os resultados ao DataGridView (dgvClientes)
                            dgvClientes.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao buscar os clientes: " + ex.Message);
                }
            }
        }

    }
}
