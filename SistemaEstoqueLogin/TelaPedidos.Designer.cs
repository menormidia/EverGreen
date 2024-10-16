namespace SistemaEstoqueLogin
{
    partial class TelaPedidos
    {
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPedidos = new System.Windows.Forms.Label();
            this.btnPesquisarPedido = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.dtpAtePedidos = new System.Windows.Forms.DateTimePicker();
            this.dtpDePedidos = new System.Windows.Forms.DateTimePicker();
            this.lblAtePedidos = new System.Windows.Forms.Label();
            this.lblDePedidos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.NomeCliente,
            this.EmailCliente,
            this.TelefoneCliente});
            this.dgvPedidos.Location = new System.Drawing.Point(332, 215);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPedidos.Size = new System.Drawing.Size(623, 374);
            this.dgvPedidos.TabIndex = 1;
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
            // btnPesquisarPedido
            // 
            this.btnPesquisarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarPedido.Location = new System.Drawing.Point(701, 169);
            this.btnPesquisarPedido.Name = "btnPesquisarPedido";
            this.btnPesquisarPedido.Size = new System.Drawing.Size(112, 23);
            this.btnPesquisarPedido.TabIndex = 13;
            this.btnPesquisarPedido.Text = "Pesquisar Pedido";
            this.btnPesquisarPedido.UseVisualStyleBackColor = true;
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNovoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoPedido.Location = new System.Drawing.Point(823, 168);
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
            // TelaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.txtPedidos);
            this.Controls.Add(this.btnPesquisarPedido);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.dtpAtePedidos);
            this.Controls.Add(this.dtpDePedidos);
            this.Controls.Add(this.lblAtePedidos);
            this.Controls.Add(this.lblDePedidos);
            this.Controls.Add(this.dgvPedidos);
            this.Name = "TelaPedidos";
            this.Text = "TelaPedidos";
            this.Load += new System.EventHandler(this.TelaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneCliente;
        private System.Windows.Forms.Label txtPedidos;
        private System.Windows.Forms.Button btnPesquisarPedido;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.DateTimePicker dtpAtePedidos;
        private System.Windows.Forms.DateTimePicker dtpDePedidos;
        private System.Windows.Forms.Label lblAtePedidos;
        private System.Windows.Forms.Label lblDePedidos;
    }
}