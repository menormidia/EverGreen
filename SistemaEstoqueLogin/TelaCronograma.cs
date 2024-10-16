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
    public partial class TelaCronograma : Form
    {
        public TelaCronograma()
        {
            InitializeComponent();
        }

        private void TelaCronograma_Load(object sender, EventArgs e)
        {

        }
        private void btnPesquisarTarefas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisar tarefas de " + dtpDeCronograma.Value.ToShortDateString() + " até " + dtpAteCronograma.Value.ToShortDateString());
        }

        private void btnNovaTarefa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicione uma nova tarefa.");
        }
    }
}
