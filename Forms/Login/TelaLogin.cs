using SistemaApresentacao;
using System;
using System.Data.SqlClient; // Para o SQL Server
using System.Windows.Forms;

namespace SistemaEstoqueLogin
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            // Chame o método de autenticação aqui
            bool loginValido = Autenticacao.Login(email, senha);

            if (loginValido)
            {
                // Se o login for bem-sucedido, abra a tela principal (FormHome)
                TelaHome home = new TelaHome();
                home.Show();

                // Feche a tela de login após o login bem-sucedido
                this.Hide();
            }
            else
            {
                // Exiba uma mensagem de erro se o login falhar
                MessageBox.Show("Credenciais inválidas! Tente novamente.", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool AutenticarUsuario(string email, string senha)
        {
            bool isAutenticado = false;
            // Connection string para autenticação Windows
            string connectionString = @"Data Source=SEU_SERVIDOR;Initial Catalog=SistemaEstoque;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(1) FROM Usuarios WHERE Email=@Email AND Senha=@Senha";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);  // Em um ambiente real, as senhas devem ser criptografadas

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        isAutenticado = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar no banco de dados: " + ex.Message);
                }
            }
            return isAutenticado;
        }

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            // Alterna a visibilidade da senha
            txtSenha.UseSystemPasswordChar = !chkMostrarSenha.Checked;
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
