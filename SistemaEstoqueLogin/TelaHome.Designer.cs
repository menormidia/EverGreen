namespace SistemaApresentacao
{
    partial class TelaHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaHome));
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCronograma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPedidos
            // 
            this.btnPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPedidos.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPedidos.Location = new System.Drawing.Point(300, 290);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(143, 53);
            this.btnPedidos.TabIndex = 0;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClientes.BackColor = System.Drawing.Color.YellowGreen;
            this.btnClientes.Location = new System.Drawing.Point(488, 290);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(143, 53);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnCronograma
            // 
            this.btnCronograma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCronograma.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCronograma.Location = new System.Drawing.Point(669, 290);
            this.btnCronograma.Name = "btnCronograma";
            this.btnCronograma.Size = new System.Drawing.Size(143, 53);
            this.btnCronograma.TabIndex = 2;
            this.btnCronograma.Text = "Cronograma";
            this.btnCronograma.UseVisualStyleBackColor = false;
            this.btnCronograma.Click += new System.EventHandler(this.btnCronograma_Click);
            // 
            // Home
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1098, 648);
            this.Controls.Add(this.btnCronograma);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnPedidos);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCronograma;
    }
}