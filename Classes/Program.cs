using System;
using System.Windows.Forms;

namespace SistemaEstoqueLogin
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaLogin());  // Tela inicial do seu sistema
        }
    }
}

