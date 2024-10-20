using SistemaApresentacao;
using System;

namespace SistemaEstoqueLogin
{
    partial class TelaDetalhesPedidos
    {
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.ToolStripMenuItem menuPedidos;
        private System.Windows.Forms.ToolStripMenuItem menuCronograma;

        private System.Windows.Forms.TextBox txtNomeClientePedido;
        private System.Windows.Forms.Label lblNomeClientePedido;
        private System.Windows.Forms.TextBox txtNumeroPedidoCliente;
        private System.Windows.Forms.Label lblNumeroPedidoCliente;
        private System.Windows.Forms.Label lblDataPedidoCliente;
        private System.Windows.Forms.TextBox txtEmailPedidoCliente;
        private System.Windows.Forms.DataGridView dgvDetalhesPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoProduto;

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

        private void InitializeComponent()
        {
            this.txtNomeClientePedido = new System.Windows.Forms.TextBox();
            this.lblNomeClientePedido = new System.Windows.Forms.Label();
            this.txtNumeroPedidoCliente = new System.Windows.Forms.TextBox();
            this.lblNumeroPedidoCliente = new System.Windows.Forms.Label();
            this.lblDataPedidoCliente = new System.Windows.Forms.Label();
            this.txtEmailPedidoCliente = new System.Windows.Forms.TextBox();
            this.dgvDetalhesPedidos = new System.Windows.Forms.DataGridView();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCronograma = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhesPedidos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeClientePedido
            // 
            this.txtNomeClientePedido.BackColor = System.Drawing.Color.Honeydew;
            this.txtNomeClientePedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeClientePedido.Enabled = false;
            this.txtNomeClientePedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeClientePedido.Location = new System.Drawing.Point(380, 116);
            this.txtNomeClientePedido.Name = "txtNomeClientePedido";
            this.txtNomeClientePedido.Size = new System.Drawing.Size(508, 15);
            this.txtNomeClientePedido.TabIndex = 0;
            this.txtNomeClientePedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNomeClientePedido
            // 
            this.lblNomeClientePedido.AutoSize = true;
            this.lblNomeClientePedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeClientePedido.Location = new System.Drawing.Point(587, 91);
            this.lblNomeClientePedido.Name = "lblNomeClientePedido";
            this.lblNomeClientePedido.Size = new System.Drawing.Size(105, 16);
            this.lblNomeClientePedido.TabIndex = 1;
            this.lblNomeClientePedido.Text = "Nome do cliente";
            // 
            // txtNumeroPedidoCliente
            // 
            this.txtNumeroPedidoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumeroPedidoCliente.BackColor = System.Drawing.Color.Honeydew;
            this.txtNumeroPedidoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroPedidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPedidoCliente.Location = new System.Drawing.Point(380, 163);
            this.txtNumeroPedidoCliente.Margin = new System.Windows.Forms.Padding(10);
            this.txtNumeroPedidoCliente.Name = "txtNumeroPedidoCliente";
            this.txtNumeroPedidoCliente.ReadOnly = true;
            this.txtNumeroPedidoCliente.Size = new System.Drawing.Size(248, 15);
            this.txtNumeroPedidoCliente.TabIndex = 2;
            this.txtNumeroPedidoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroPedidoCliente.TextChanged += new System.EventHandler(this.txtNumeroPedidoCliente_TextChanged);
            // 
            // lblNumeroPedidoCliente
            // 
            this.lblNumeroPedidoCliente.AutoSize = true;
            this.lblNumeroPedidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPedidoCliente.Location = new System.Drawing.Point(456, 147);
            this.lblNumeroPedidoCliente.Name = "lblNumeroPedidoCliente";
            this.lblNumeroPedidoCliente.Size = new System.Drawing.Size(121, 16);
            this.lblNumeroPedidoCliente.TabIndex = 3;
            this.lblNumeroPedidoCliente.Text = "Número do Pedido";
            // 
            // lblDataPedidoCliente
            // 
            this.lblDataPedidoCliente.AutoSize = true;
            this.lblDataPedidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPedidoCliente.Location = new System.Drawing.Point(751, 147);
            this.lblDataPedidoCliente.Name = "lblDataPedidoCliente";
            this.lblDataPedidoCliente.Size = new System.Drawing.Size(48, 16);
            this.lblDataPedidoCliente.TabIndex = 5;
            this.lblDataPedidoCliente.Text = "E-mail ";
            // 
            // txtEmailPedidoCliente
            // 
            this.txtEmailPedidoCliente.BackColor = System.Drawing.Color.Honeydew;
            this.txtEmailPedidoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailPedidoCliente.Enabled = false;
            this.txtEmailPedidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailPedidoCliente.Location = new System.Drawing.Point(640, 163);
            this.txtEmailPedidoCliente.Name = "txtEmailPedidoCliente";
            this.txtEmailPedidoCliente.Size = new System.Drawing.Size(248, 15);
            this.txtEmailPedidoCliente.TabIndex = 4;
            this.txtEmailPedidoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvDetalhesPedidos
            // 
            this.dgvDetalhesPedidos.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgvDetalhesPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalhesPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeProduto,
            this.QuantidadeProduto,
            this.PrecoProduto});
            this.dgvDetalhesPedidos.Location = new System.Drawing.Point(438, 208);
            this.dgvDetalhesPedidos.Name = "dgvDetalhesPedidos";
            this.dgvDetalhesPedidos.Size = new System.Drawing.Size(393, 365);
            this.dgvDetalhesPedidos.TabIndex = 6;
            this.dgvDetalhesPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Nome do Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.Width = 200;
            // 
            // QuantidadeProduto
            // 
            this.QuantidadeProduto.HeaderText = "Quantidade";
            this.QuantidadeProduto.Name = "QuantidadeProduto";
            this.QuantidadeProduto.ReadOnly = true;
            this.QuantidadeProduto.Width = 80;
            // 
            // PrecoProduto
            // 
            this.PrecoProduto.HeaderText = "Preço";
            this.PrecoProduto.Name = "PrecoProduto";
            this.PrecoProduto.ReadOnly = true;
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
            // TelaDetalhesPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvDetalhesPedidos);
            this.Controls.Add(this.lblDataPedidoCliente);
            this.Controls.Add(this.txtEmailPedidoCliente);
            this.Controls.Add(this.lblNumeroPedidoCliente);
            this.Controls.Add(this.txtNumeroPedidoCliente);
            this.Controls.Add(this.lblNomeClientePedido);
            this.Controls.Add(this.txtNomeClientePedido);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaDetalhesPedidos";
            this.Text = "Detalhes do Pedido";
            this.Load += new System.EventHandler(this.TelaDetalhesPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhesPedidos)).EndInit();
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
            this.Close();  // Fecha a TelaDetalhesPedidos
        }

        private void menuPedidos_Click(object sender, EventArgs e)
        {
            // Navegar para a TelaPedidos
            TelaPedidos telaPedidos = new TelaPedidos();
            telaPedidos.Show();
            this.Close();  // Fecha a TelaDetalhesPedidos
        }

        private void menuCronograma_Click(object sender, EventArgs e)
        {
            // Navegar para a TelaCronograma
            TelaCronograma telaCronograma = new TelaCronograma();
            telaCronograma.Show();
            this.Close();  // Fecha a TelaDetalhesPedidos
        }
    }
}