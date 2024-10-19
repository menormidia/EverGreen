using SistemaApresentacao;
using System;

namespace SistemaEstoqueLogin
{
    partial class TelaClientes
    {
        // Todos os componentes visuais são declarados aqui
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.ToolStripMenuItem menuPedidos;
        private System.Windows.Forms.ToolStripMenuItem menuCronograma;


        /// <summary>
        /// Método responsável por configurar a interface (gerado automaticamente)
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaClientes));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblAte = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCronograma = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLupa = new System.Windows.Forms.Button();
            this.txtPesquisarCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.NomeCliente,
            this.EmailCliente,
            this.TelefoneCliente,
            this.enderecoCliente,
            this.bairroCliente,
            this.cidadeCliente,
            this.cepCliente});
            this.dgvClientes.Location = new System.Drawing.Point(29, 238);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvClientes.Size = new System.Drawing.Size(1207, 374);
            this.dgvClientes.TabIndex = 0;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Id do Cliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 90;
            // 
            // NomeCliente
            // 
            this.NomeCliente.HeaderText = "Nome do Cliente";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            this.NomeCliente.Width = 250;
            // 
            // EmailCliente
            // 
            this.EmailCliente.HeaderText = "E-mail";
            this.EmailCliente.Name = "EmailCliente";
            this.EmailCliente.ReadOnly = true;
            this.EmailCliente.Width = 150;
            // 
            // TelefoneCliente
            // 
            this.TelefoneCliente.HeaderText = "Telefone";
            this.TelefoneCliente.Name = "TelefoneCliente";
            this.TelefoneCliente.ReadOnly = true;
            this.TelefoneCliente.Width = 92;
            // 
            // enderecoCliente
            // 
            this.enderecoCliente.HeaderText = "Endereço";
            this.enderecoCliente.Name = "enderecoCliente";
            this.enderecoCliente.ReadOnly = true;
            this.enderecoCliente.Width = 255;
            // 
            // bairroCliente
            // 
            this.bairroCliente.HeaderText = "Bairro";
            this.bairroCliente.Name = "bairroCliente";
            this.bairroCliente.ReadOnly = true;
            this.bairroCliente.Width = 125;
            // 
            // cidadeCliente
            // 
            this.cidadeCliente.HeaderText = "Cidade";
            this.cidadeCliente.Name = "cidadeCliente";
            this.cidadeCliente.ReadOnly = true;
            this.cidadeCliente.Width = 105;
            // 
            // cepCliente
            // 
            this.cepCliente.HeaderText = "CEP";
            this.cepCliente.Name = "cepCliente";
            this.cepCliente.ReadOnly = true;
            // 
            // lblDe
            // 
            this.lblDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(273, 194);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(31, 16);
            this.lblDe.TabIndex = 1;
            this.lblDe.Text = "De:";
            // 
            // lblAte
            // 
            this.lblAte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAte.AutoSize = true;
            this.lblAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAte.Location = new System.Drawing.Point(394, 194);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(34, 16);
            this.lblAte.TabIndex = 2;
            this.lblAte.Text = "Até:";
            // 
            // dtpDe
            // 
            this.dtpDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDe.CalendarTitleBackColor = System.Drawing.Color.YellowGreen;
            this.dtpDe.Location = new System.Drawing.Point(303, 190);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(69, 20);
            this.dtpDe.TabIndex = 3;
            // 
            // dtpAte
            // 
            this.dtpAte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpAte.CalendarTitleBackColor = System.Drawing.Color.YellowGreen;
            this.dtpAte.Location = new System.Drawing.Point(429, 190);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(69, 20);
            this.dtpAte.TabIndex = 4;
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoCliente.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.Location = new System.Drawing.Point(899, 185);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(133, 25);
            this.btnNovoCliente.TabIndex = 5;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(560, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clientes";
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
            // btnLupa
            // 
            this.btnLupa.BackColor = System.Drawing.Color.Transparent;
            this.btnLupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLupa.FlatAppearance.BorderSize = 0;
            this.btnLupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLupa.Image = ((System.Drawing.Image)(resources.GetObject("btnLupa.Image")));
            this.btnLupa.Location = new System.Drawing.Point(827, 187);
            this.btnLupa.Name = "btnLupa";
            this.btnLupa.Size = new System.Drawing.Size(31, 24);
            this.btnLupa.TabIndex = 8;
            this.btnLupa.UseVisualStyleBackColor = false;
            this.btnLupa.Click += new System.EventHandler(this.btnLupa_Click);
            // 
            // txtPesquisarCliente
            // 
            this.txtPesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarCliente.Location = new System.Drawing.Point(563, 188);
            this.txtPesquisarCliente.Name = "txtPesquisarCliente";
            this.txtPesquisarCliente.Size = new System.Drawing.Size(258, 22);
            this.txtPesquisarCliente.TabIndex = 9;
            this.txtPesquisarCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TelaClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.txtPesquisarCliente);
            this.Controls.Add(this.btnLupa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.dtpAte);
            this.Controls.Add(this.dtpDe);
            this.Controls.Add(this.lblAte);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TelaClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.TelaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
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
        private System.Windows.Forms.Button btnLupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepCliente;
        private System.Windows.Forms.TextBox txtPesquisarCliente;
    }
}