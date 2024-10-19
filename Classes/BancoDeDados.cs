using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstoqueLogin
{
    public class BancoDeDados
    {
        // String de conexão com o banco de dados
        private static string connectionString = "Data Source=DESKTOP-5R7M76S;Initial Catalog=SistemaEstoque;Integrated Security=True;TrustServerCertificate=True";

        // Método para abrir uma conexão com o banco
        private static SqlConnection AbrirConexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);
            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir conexão: " + ex.Message);
            }
            return conexao;
        }

        // Método genérico para executar uma query SELECT que retorna um DataTable
        public static DataTable ExecutarSelect(string query, List<SqlParameter> parametros = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conexao = AbrirConexao())
            {
                if (conexao == null)
                    return null;

                try
                {
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        if (parametros != null)
                        {
                            comando.Parameters.AddRange(parametros.ToArray());
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao executar SELECT: " + ex.Message);
                }
            }

            return dataTable;
        }

        // Método estático para buscar os produtos de um pedido específico
        public static List<Produto> BuscarProdutosPorPedido(int numeroPedido)
        {
            List<Produto> produtos = new List<Produto>();

            string query = "SELECT NomeProduto, Quantidade, Preco FROM Produtos WHERE NumeroPedido = @NumeroPedido";
            List<SqlParameter> parametros = new List<SqlParameter>
        {
            new SqlParameter("@NumeroPedido", numeroPedido)
        };

            DataTable resultado = ExecutarSelect(query, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                Produto produto = new Produto
                {
                    NomeProduto = row["NomeProduto"].ToString(),
                    Quantidade = Convert.ToInt32(row["Quantidade"]),
                    Preco = Convert.ToDecimal(row["Preco"])
                };

                produtos.Add(produto);
            }

            return produtos;
        }

        // Função BuscarPedidos (semelhante à BuscarClientes)
        public static List<Pedido> BuscarPedidos(string filtro)
        {
            List<Pedido> pedidos = new List<Pedido>();

            string query = "SELECT NumeroPedido, NomeCliente, EmailCliente, Telefone FROM Pedidos WHERE NomeCliente LIKE @Filtro";

            List<SqlParameter> parametros = new List<SqlParameter>
        {
            new SqlParameter("@Filtro", "%" + filtro + "%") // Parâmetro com filtro (like para busca parcial)
        };

            using (SqlConnection conexao = AbrirConexao())
            {
                if (conexao == null)
                    return null;

                try
                {
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddRange(parametros.ToArray());

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Pedido pedido = new Pedido
                                {
                                    NumeroPedido = Convert.ToInt32(reader["NumeroPedido"]),
                                    NomeCliente = reader["NomeCliente"].ToString(),
                                    EmailCliente = reader["EmailCliente"].ToString(),
                                    Telefone = reader["Telefone"].ToString()
                                };

                                pedidos.Add(pedido);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao buscar pedidos: " + ex.Message);
                }
            }

            return pedidos;
        }
    }

}
