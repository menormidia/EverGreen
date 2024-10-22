namespace SistemaEstoqueLogin.Forms.Pedidos.Adicionar_Pedidos
{
    partial class NovoPedido
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
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.lbldigiteId = new System.Windows.Forms.Label();
            this.lbldigiteIdProduto = new System.Windows.Forms.Label();
            this.txtidProduto = new System.Windows.Forms.TextBox();
            this.dgvNovoPedido = new System.Windows.Forms.DataGridView();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblItens = new System.Windows.Forms.Label();
            this.btnadicionarProduto = new System.Windows.Forms.Button();
            this.btnAdicionarPedido = new System.Windows.Forms.Button();
            this.txttotalPedido = new System.Windows.Forms.TextBox();
            this.lbltotalPedido = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovoPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidCliente
            // 
            this.txtidCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidCliente.Location = new System.Drawing.Point(384, 65);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(497, 22);
            this.txtidCliente.TabIndex = 0;
            // 
            // lbldigiteId
            // 
            this.lbldigiteId.AutoSize = true;
            this.lbldigiteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldigiteId.Location = new System.Drawing.Point(381, 46);
            this.lbldigiteId.Name = "lbldigiteId";
            this.lbldigiteId.Size = new System.Drawing.Size(133, 16);
            this.lbldigiteId.TabIndex = 1;
            this.lbldigiteId.Text = "Digite o Id do Cliente:";
            // 
            // lbldigiteIdProduto
            // 
            this.lbldigiteIdProduto.AutoSize = true;
            this.lbldigiteIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldigiteIdProduto.Location = new System.Drawing.Point(381, 118);
            this.lbldigiteIdProduto.Name = "lbldigiteIdProduto";
            this.lbldigiteIdProduto.Size = new System.Drawing.Size(139, 16);
            this.lbldigiteIdProduto.TabIndex = 3;
            this.lbldigiteIdProduto.Text = "Digite o Id do Produto:";
            // 
            // txtidProduto
            // 
            this.txtidProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidProduto.Location = new System.Drawing.Point(384, 137);
            this.txtidProduto.Name = "txtidProduto";
            this.txtidProduto.Size = new System.Drawing.Size(377, 22);
            this.txtidProduto.TabIndex = 2;
            // 
            // dgvNovoPedido
            // 
            this.dgvNovoPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvNovoPedido.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgvNovoPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNovoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNovoPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.Quantidade,
            this.valorUnitario});
            this.dgvNovoPedido.Location = new System.Drawing.Point(385, 253);
            this.dgvNovoPedido.Name = "dgvNovoPedido";
            this.dgvNovoPedido.Size = new System.Drawing.Size(496, 324);
            this.dgvNovoPedido.TabIndex = 4;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ToolTipText = "String";
            this.Descricao.Width = 260;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ToolTipText = "Integer";
            // 
            // valorUnitario
            // 
            this.valorUnitario.HeaderText = "Valor Unitário";
            this.valorUnitario.Name = "valorUnitario";
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItens.Location = new System.Drawing.Point(381, 234);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(38, 16);
            this.lblItens.TabIndex = 5;
            this.lblItens.Text = "Itens:";
            // 
            // btnadicionarProduto
            // 
            this.btnadicionarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnadicionarProduto.BackColor = System.Drawing.Color.YellowGreen;
            this.btnadicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadicionarProduto.Location = new System.Drawing.Point(772, 133);
            this.btnadicionarProduto.Name = "btnadicionarProduto";
            this.btnadicionarProduto.Size = new System.Drawing.Size(109, 26);
            this.btnadicionarProduto.TabIndex = 6;
            this.btnadicionarProduto.Text = "Adicionar Produto";
            this.btnadicionarProduto.UseVisualStyleBackColor = false;
            this.btnadicionarProduto.Click += new System.EventHandler(this.btnadicionarProduto_Click);
            // 
            // btnAdicionarPedido
            // 
            this.btnAdicionarPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionarPedido.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAdicionarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarPedido.Location = new System.Drawing.Point(772, 616);
            this.btnAdicionarPedido.Name = "btnAdicionarPedido";
            this.btnAdicionarPedido.Size = new System.Drawing.Size(109, 26);
            this.btnAdicionarPedido.TabIndex = 8;
            this.btnAdicionarPedido.Text = "Adicionar Pedido";
            this.btnAdicionarPedido.UseVisualStyleBackColor = false;
            this.btnAdicionarPedido.Click += new System.EventHandler(this.btnAdicionarPedido_Click);
            // 
            // txttotalPedido
            // 
            this.txttotalPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalPedido.Location = new System.Drawing.Point(384, 616);
            this.txttotalPedido.Name = "txttotalPedido";
            this.txttotalPedido.Size = new System.Drawing.Size(109, 26);
            this.txttotalPedido.TabIndex = 9;
            this.txttotalPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbltotalPedido
            // 
            this.lbltotalPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltotalPedido.AutoSize = true;
            this.lbltotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalPedido.Location = new System.Drawing.Point(382, 597);
            this.lbltotalPedido.Name = "lbltotalPedido";
            this.lbltotalPedido.Size = new System.Drawing.Size(106, 16);
            this.lbltotalPedido.TabIndex = 10;
            this.lbltotalPedido.Text = "Total do pedido:";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProduto.Location = new System.Drawing.Point(385, 193);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(229, 19);
            this.txtDescricaoProduto.TabIndex = 11;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnitario.Location = new System.Drawing.Point(753, 193);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(127, 19);
            this.txtValorUnitario.TabIndex = 12;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(620, 193);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(127, 19);
            this.txtQuantidade.TabIndex = 13;
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(385, 179);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(95, 13);
            this.lblDescricaoProduto.TabIndex = 14;
            this.lblDescricaoProduto.Text = "Digite a descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Digite a quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(750, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Digite o valor unitário:";
            // 
            // NovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescricaoProduto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.lbltotalPedido);
            this.Controls.Add(this.txttotalPedido);
            this.Controls.Add(this.btnAdicionarPedido);
            this.Controls.Add(this.btnadicionarProduto);
            this.Controls.Add(this.lblItens);
            this.Controls.Add(this.dgvNovoPedido);
            this.Controls.Add(this.lbldigiteIdProduto);
            this.Controls.Add(this.txtidProduto);
            this.Controls.Add(this.lbldigiteId);
            this.Controls.Add(this.txtidCliente);
            this.Name = "NovoPedido";
            this.Text = "Novo Pedido";
            this.Load += new System.EventHandler(this.NovoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovoPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.Label lbldigiteId;
        private System.Windows.Forms.Label lbldigiteIdProduto;
        private System.Windows.Forms.TextBox txtidProduto;
        private System.Windows.Forms.DataGridView dgvNovoPedido;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.Button btnadicionarProduto;
        private System.Windows.Forms.Button btnAdicionarPedido;
        private System.Windows.Forms.TextBox txttotalPedido;
        private System.Windows.Forms.Label lbltotalPedido;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitario;
    }
}