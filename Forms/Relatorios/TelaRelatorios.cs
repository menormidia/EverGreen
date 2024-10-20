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
    public partial class TelaRelatorios : Form
    {
        public TelaRelatorios()
        {
            InitializeComponent();
        }

        private void TelaRelatorios_Load(object sender, EventArgs e)
        {

        }

        private void btnRelatorioEntradas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Relatório em PDF baixado, verifique sua pasta Downloads.");
        }

        private void btnRelatorioSaidas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Relatório em PDF baixado, verifique sua pasta Downloads");
        }

        private void btnRelatorioEstoque_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Relatório em PDF baixado, verifique sua pasta Downloads");
        }

    }
}
