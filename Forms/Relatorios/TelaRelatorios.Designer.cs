using SistemaApresentacao;
using System;

namespace SistemaEstoqueLogin
{
    partial class TelaRelatorios
    {
        private System.Windows.Forms.Label txtRelatorios;
        private System.Windows.Forms.Label txtRelatorioEntrada;
        private System.Windows.Forms.Button btnRelatorioEntradas;
        private System.Windows.Forms.Button btnRelatorioSaidas;
        private System.Windows.Forms.Label txtRelatorioSaidas;
        private System.Windows.Forms.Button btnRelatorioEstoque;
        private System.Windows.Forms.Label txtRelatorioEstoque;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.ToolStripMenuItem menuPedidos;
        private System.Windows.Forms.ToolStripMenuItem menuCronograma;


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRelatorios));
            this.txtRelatorios = new System.Windows.Forms.Label();
            this.txtRelatorioEntrada = new System.Windows.Forms.Label();
            this.btnRelatorioEntradas = new System.Windows.Forms.Button();
            this.btnRelatorioSaidas = new System.Windows.Forms.Button();
            this.txtRelatorioSaidas = new System.Windows.Forms.Label();
            this.btnRelatorioEstoque = new System.Windows.Forms.Button();
            this.txtRelatorioEstoque = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCronograma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRelatorios
            // 
            this.txtRelatorios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRelatorios.AutoSize = true;
            this.txtRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.txtRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelatorios.ForeColor = System.Drawing.Color.YellowGreen;
            this.txtRelatorios.Location = new System.Drawing.Point(557, 82);
            this.txtRelatorios.Name = "txtRelatorios";
            this.txtRelatorios.Size = new System.Drawing.Size(157, 33);
            this.txtRelatorios.TabIndex = 8;
            this.txtRelatorios.Text = "Relatórios";
            // 
            // txtRelatorioEntrada
            // 
            this.txtRelatorioEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRelatorioEntrada.AutoSize = true;
            this.txtRelatorioEntrada.BackColor = System.Drawing.Color.Transparent;
            this.txtRelatorioEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelatorioEntrada.Location = new System.Drawing.Point(482, 164);
            this.txtRelatorioEntrada.Name = "txtRelatorioEntrada";
            this.txtRelatorioEntrada.Size = new System.Drawing.Size(318, 32);
            this.txtRelatorioEntrada.TabIndex = 9;
            this.txtRelatorioEntrada.Text = "Clique no botão abaixo para realizar o download do \r\nrelatório de entradas da Eve" +
    "rgreen.";
            this.txtRelatorioEntrada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRelatorioEntradas
            // 
            this.btnRelatorioEntradas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRelatorioEntradas.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorioEntradas.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnRelatorioEntradas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRelatorioEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnRelatorioEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioEntradas.Location = new System.Drawing.Point(560, 208);
            this.btnRelatorioEntradas.Name = "btnRelatorioEntradas";
            this.btnRelatorioEntradas.Size = new System.Drawing.Size(154, 42);
            this.btnRelatorioEntradas.TabIndex = 10;
            this.btnRelatorioEntradas.Text = "Relatório Entradas";
            this.btnRelatorioEntradas.UseVisualStyleBackColor = false;
            this.btnRelatorioEntradas.Click += new System.EventHandler(this.btnRelatorioEntradas_Click);
            // 
            // btnRelatorioSaidas
            // 
            this.btnRelatorioSaidas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRelatorioSaidas.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorioSaidas.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnRelatorioSaidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRelatorioSaidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnRelatorioSaidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioSaidas.Location = new System.Drawing.Point(560, 338);
            this.btnRelatorioSaidas.Name = "btnRelatorioSaidas";
            this.btnRelatorioSaidas.Size = new System.Drawing.Size(154, 42);
            this.btnRelatorioSaidas.TabIndex = 12;
            this.btnRelatorioSaidas.Text = "Relatório Saídas";
            this.btnRelatorioSaidas.UseVisualStyleBackColor = false;
            this.btnRelatorioSaidas.Click += new System.EventHandler(this.btnRelatorioSaidas_Click);
            // 
            // txtRelatorioSaidas
            // 
            this.txtRelatorioSaidas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRelatorioSaidas.AutoSize = true;
            this.txtRelatorioSaidas.BackColor = System.Drawing.Color.Transparent;
            this.txtRelatorioSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelatorioSaidas.Location = new System.Drawing.Point(482, 294);
            this.txtRelatorioSaidas.Name = "txtRelatorioSaidas";
            this.txtRelatorioSaidas.Size = new System.Drawing.Size(318, 32);
            this.txtRelatorioSaidas.TabIndex = 11;
            this.txtRelatorioSaidas.Text = "Clique no botão abaixo para realizar o download do \r\nrelatório de saídas da Everg" +
    "reen.";
            this.txtRelatorioSaidas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRelatorioEstoque
            // 
            this.btnRelatorioEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRelatorioEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorioEstoque.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnRelatorioEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRelatorioEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnRelatorioEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioEstoque.Location = new System.Drawing.Point(560, 471);
            this.btnRelatorioEstoque.Name = "btnRelatorioEstoque";
            this.btnRelatorioEstoque.Size = new System.Drawing.Size(154, 42);
            this.btnRelatorioEstoque.TabIndex = 14;
            this.btnRelatorioEstoque.Text = "Relatório Estoque";
            this.btnRelatorioEstoque.UseVisualStyleBackColor = false;
            this.btnRelatorioEstoque.Click += new System.EventHandler(this.btnRelatorioEstoque_Click);
            // 
            // txtRelatorioEstoque
            // 
            this.txtRelatorioEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRelatorioEstoque.AutoSize = true;
            this.txtRelatorioEstoque.BackColor = System.Drawing.Color.Transparent;
            this.txtRelatorioEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelatorioEstoque.Location = new System.Drawing.Point(482, 427);
            this.txtRelatorioEstoque.Name = "txtRelatorioEstoque";
            this.txtRelatorioEstoque.Size = new System.Drawing.Size(318, 32);
            this.txtRelatorioEstoque.TabIndex = 13;
            this.txtRelatorioEstoque.Text = "Clique no botão abaixo para realizar o download do \r\nrelatório de estoque da Ever" +
    "green.";
            this.txtRelatorioEstoque.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome,
            this.menuPedidos,
            this.menuCronograma});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(52, 20);
            this.menuHome.Text = "Home";
            this.menuHome.Click += new System.EventHandler(this.menuHome_Click);
            // 
            // menuPedidos
            // 
            this.menuPedidos.Name = "menuPedidos";
            this.menuPedidos.Size = new System.Drawing.Size(61, 20);
            this.menuPedidos.Text = "Pedidos";
            this.menuPedidos.Click += new System.EventHandler(this.menuPedidos_Click);
            // 
            // menuCronograma
            // 
            this.menuCronograma.Name = "menuCronograma";
            this.menuCronograma.Size = new System.Drawing.Size(86, 20);
            this.menuCronograma.Text = "Cronograma";
            this.menuCronograma.Click += new System.EventHandler(this.menuCronograma_Click);
            // 
            // TelaRelatorios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnRelatorioEstoque);
            this.Controls.Add(this.txtRelatorioEstoque);
            this.Controls.Add(this.btnRelatorioSaidas);
            this.Controls.Add(this.txtRelatorioSaidas);
            this.Controls.Add(this.btnRelatorioEntradas);
            this.Controls.Add(this.txtRelatorioEntrada);
            this.Controls.Add(this.txtRelatorios);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaRelatorios";
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.TelaRelatorios_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void menuHome_Click(object sender, EventArgs e)
        {
            // Voltar para a TelaHome
            TelaHome telaHome = new TelaHome();
            telaHome.Show();
            this.Close();  // Fecha a TelaClientes
        }

        private void menuPedidos_Click(object sender, EventArgs e)
        {
            // Navegar para a TelaPedidos
            TelaPedidos telaPedidos = new TelaPedidos();
            telaPedidos.Show();
            this.Close();  // Fecha a TelaClientes
        }

        private void menuCronograma_Click(object sender, EventArgs e)
        {
            // Navegar para a TelaCronograma
            TelaCronograma telaCronograma = new TelaCronograma();
            telaCronograma.Show();
            this.Close();  // Fecha a TelaClientes
        }

    
    }
}