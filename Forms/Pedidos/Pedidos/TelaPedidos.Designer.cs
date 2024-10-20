using SistemaApresentacao;
using System;

namespace SistemaEstoqueLogin
{
    partial class TelaPedidos
    {
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label txtPedidos;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.DateTimePicker dtpAtePedidos;
        private System.Windows.Forms.DateTimePicker dtpDePedidos;
        private System.Windows.Forms.Label lblAtePedidos;
        private System.Windows.Forms.Label lblDePedidos;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPedidos));
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.NumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaEstoqueDataSet = new SistemaEstoqueLogin.SistemaEstoqueDataSet();
            this.txtPedidos = new System.Windows.Forms.Label();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.dtpAtePedidos = new System.Windows.Forms.DateTimePicker();
            this.dtpDePedidos = new System.Windows.Forms.DateTimePicker();
            this.lblAtePedidos = new System.Windows.Forms.Label();
            this.lblDePedidos = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCronograma = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesTableAdapter = new SistemaEstoqueLogin.SistemaEstoqueDataSetTableAdapters.ClientesTableAdapter();
            this.btnDetalhesPedido = new System.Windows.Forms.Button();
            this.txtPesquisarPedido = new System.Windows.Forms.TextBox();
            this.btnPesquisarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaEstoqueDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroPedido,
            this.NomeCliente,
            this.emailCliente});
            this.dgvPedidos.Location = new System.Drawing.Point(332, 215);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPedidos.Size = new System.Drawing.Size(624, 374);
            this.dgvPedidos.TabIndex = 1;
            // 
            // NumeroPedido
            // 
            this.NumeroPedido.DataPropertyName = "numeroPedido";
            this.NumeroPedido.HeaderText = "Pedido";
            this.NumeroPedido.Name = "NumeroPedido";
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "nomeCliente";
            this.NomeCliente.HeaderText = "Nome do Cliente";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            this.NomeCliente.Width = 300;
            // 
            // emailCliente
            // 
            this.emailCliente.DataPropertyName = "emailCliente";
            this.emailCliente.HeaderText = "E-mail";
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.ReadOnly = true;
            this.emailCliente.Width = 183;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.sistemaEstoqueDataSet;
            // 
            // sistemaEstoqueDataSet
            // 
            this.sistemaEstoqueDataSet.DataSetName = "SistemaEstoqueDataSet";
            this.sistemaEstoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPedidos
            // 
            this.txtPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedidos.AutoSize = true;
            this.txtPedidos.BackColor = System.Drawing.Color.Transparent;
            this.txtPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidos.ForeColor = System.Drawing.Color.YellowGreen;
            this.txtPedidos.Location = new System.Drawing.Point(574, 96);
            this.txtPedidos.Name = "txtPedidos";
            this.txtPedidos.Size = new System.Drawing.Size(127, 33);
            this.txtPedidos.TabIndex = 14;
            this.txtPedidos.Text = "Pedidos";
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoPedido.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNovoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoPedido.Location = new System.Drawing.Point(823, 173);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(133, 25);
            this.btnNovoPedido.TabIndex = 12;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = false;
            // 
            // dtpAtePedidos
            // 
            this.dtpAtePedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpAtePedidos.CalendarTitleBackColor = System.Drawing.Color.YellowGreen;
            this.dtpAtePedidos.Location = new System.Drawing.Point(486, 173);
            this.dtpAtePedidos.Name = "dtpAtePedidos";
            this.dtpAtePedidos.Size = new System.Drawing.Size(85, 20);
            this.dtpAtePedidos.TabIndex = 11;
            // 
            // dtpDePedidos
            // 
            this.dtpDePedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDePedidos.CalendarTitleBackColor = System.Drawing.Color.YellowGreen;
            this.dtpDePedidos.Location = new System.Drawing.Point(360, 173);
            this.dtpDePedidos.Name = "dtpDePedidos";
            this.dtpDePedidos.Size = new System.Drawing.Size(85, 20);
            this.dtpDePedidos.TabIndex = 10;
            // 
            // lblAtePedidos
            // 
            this.lblAtePedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAtePedidos.AutoSize = true;
            this.lblAtePedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtePedidos.Location = new System.Drawing.Point(451, 177);
            this.lblAtePedidos.Name = "lblAtePedidos";
            this.lblAtePedidos.Size = new System.Drawing.Size(34, 16);
            this.lblAtePedidos.TabIndex = 9;
            this.lblAtePedidos.Text = "Até:";
            // 
            // lblDePedidos
            // 
            this.lblDePedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDePedidos.AutoSize = true;
            this.lblDePedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDePedidos.Location = new System.Drawing.Point(330, 177);
            this.lblDePedidos.Name = "lblDePedidos";
            this.lblDePedidos.Size = new System.Drawing.Size(31, 16);
            this.lblDePedidos.TabIndex = 8;
            this.lblDePedidos.Text = "De:";
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
            this.menuPedidos.Text = "Clientes";
            this.menuPedidos.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuCronograma
            // 
            this.menuCronograma.Name = "menuCronograma";
            this.menuCronograma.Size = new System.Drawing.Size(86, 20);
            this.menuCronograma.Text = "Cronograma";
            this.menuCronograma.Click += new System.EventHandler(this.menuCronograma_Click);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // btnDetalhesPedido
            // 
            this.btnDetalhesPedido.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDetalhesPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetalhesPedido.Location = new System.Drawing.Point(785, 607);
            this.btnDetalhesPedido.Name = "btnDetalhesPedido";
            this.btnDetalhesPedido.Size = new System.Drawing.Size(171, 34);
            this.btnDetalhesPedido.TabIndex = 15;
            this.btnDetalhesPedido.Text = "Ver detalhes";
            this.btnDetalhesPedido.UseVisualStyleBackColor = false;
            this.btnDetalhesPedido.Click += new System.EventHandler(this.btnDetalhesPedido_Click);
            // 
            // txtPesquisarPedido
            // 
            this.txtPesquisarPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarPedido.Location = new System.Drawing.Point(600, 173);
            this.txtPesquisarPedido.Name = "txtPesquisarPedido";
            this.txtPesquisarPedido.Size = new System.Drawing.Size(182, 24);
            this.txtPesquisarPedido.TabIndex = 16;
            this.txtPesquisarPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPesquisarPedido
            // 
            this.btnPesquisarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarPedido.FlatAppearance.BorderSize = 0;
            this.btnPesquisarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarPedido.Image")));
            this.btnPesquisarPedido.Location = new System.Drawing.Point(785, 173);
            this.btnPesquisarPedido.Name = "btnPesquisarPedido";
            this.btnPesquisarPedido.Size = new System.Drawing.Size(31, 24);
            this.btnPesquisarPedido.TabIndex = 17;
            this.btnPesquisarPedido.UseVisualStyleBackColor = false;
            this.btnPesquisarPedido.Click += new System.EventHandler(this.btnPesquisarPedido_Click);
            // 
            // TelaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnPesquisarPedido);
            this.Controls.Add(this.txtPesquisarPedido);
            this.Controls.Add(this.btnDetalhesPedido);
            this.Controls.Add(this.txtPedidos);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.dtpAtePedidos);
            this.Controls.Add(this.dtpDePedidos);
            this.Controls.Add(this.lblAtePedidos);
            this.Controls.Add(this.lblDePedidos);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TelaPedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.TelaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaEstoqueDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Event handlers to switch between forms
        private void menuHome_Click(object sender, EventArgs e)
        {
            // Voltar para a TelaHome
            TelaHome telaHome = new TelaHome();
            telaHome.Show();
            this.Close();  // Fecha a TelaClientes
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            // Navegar para a TelaClientes
            TelaClientes telaClientes = new TelaClientes();
            telaClientes.Show();
            this.Close();  // Fecha a TelaClientes
        }

        private void menuCronograma_Click(object sender, EventArgs e)
        {
            // Navegar para a TelaCronograma
            TelaCronograma telaCronograma = new TelaCronograma();
            telaCronograma.Show();
            this.Close();  // Fecha a TelaClientes

        }

        #endregion

        private SistemaEstoqueDataSet sistemaEstoqueDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private SistemaEstoqueDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Button btnDetalhesPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCliente;
        private System.Windows.Forms.TextBox txtPesquisarPedido;
        private System.Windows.Forms.Button btnPesquisarPedido;
    }
}