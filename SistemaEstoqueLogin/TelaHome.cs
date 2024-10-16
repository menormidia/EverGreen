using SistemaEstoqueLogin;
using System;
using System.Windows.Forms;

namespace SistemaApresentacao
{
    public partial class TelaHome : Form
    {
        public TelaHome()
        {
            InitializeComponent();

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            // Ajusta o título do formulário
            this.Text = "Página Inicial - Sistema Evergreen";
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância da TelaClientes e a exibe
            TelaClientes telaClientes = new TelaClientes();
            telaClientes.Show();

            // Esconder a Home
            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância da TelaPedidos e a exibe
            TelaPedidos telaPedidos = new TelaPedidos();
            telaPedidos.Show();

            // Esconder a Home
            this.Hide();
        }

        private void btnCronograma_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância da TelaCronograma e a exibe
            TelaCronograma telaCronograma = new TelaCronograma();
            telaCronograma.Show();

            //Esconder a home
            this.Hide();
        }

        // Método de fechamento
        protected override void OnFormClosing(FormClosingEventArgs e)
        { 
            Application.Exit(); 
        }
    }
}

