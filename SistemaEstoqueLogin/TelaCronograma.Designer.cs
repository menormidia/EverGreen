namespace SistemaEstoqueLogin
{
    partial class TelaCronograma
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
            this.clbCronograma = new System.Windows.Forms.CheckedListBox();
            this.txtCronograma = new System.Windows.Forms.Label();
            this.dtpAteCronograma = new System.Windows.Forms.DateTimePicker();
            this.dtpDeCronograma = new System.Windows.Forms.DateTimePicker();
            this.lblAteCronograma = new System.Windows.Forms.Label();
            this.lblDeCronograma = new System.Windows.Forms.Label();
            this.btnPesquisarTarefa = new System.Windows.Forms.Button();
            this.btnNovaTarefa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbCronograma
            // 
            this.clbCronograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clbCronograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clbCronograma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbCronograma.CheckOnClick = true;
            this.clbCronograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clbCronograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCronograma.FormattingEnabled = true;
            this.clbCronograma.HorizontalScrollbar = true;
            this.clbCronograma.Items.AddRange(new object[] {
            "Plantar o arroz",
            "Colher o feijão",
            "Verificar o estoque de Abóbora",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            ".",
            "."});
            this.clbCronograma.Location = new System.Drawing.Point(403, 272);
            this.clbCronograma.Name = "clbCronograma";
            this.clbCronograma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clbCronograma.Size = new System.Drawing.Size(398, 336);
            this.clbCronograma.TabIndex = 0;
            // 
            // txtCronograma
            // 
            this.txtCronograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCronograma.AutoSize = true;
            this.txtCronograma.BackColor = System.Drawing.Color.Transparent;
            this.txtCronograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCronograma.ForeColor = System.Drawing.Color.YellowGreen;
            this.txtCronograma.Location = new System.Drawing.Point(509, 117);
            this.txtCronograma.Name = "txtCronograma";
            this.txtCronograma.Size = new System.Drawing.Size(187, 33);
            this.txtCronograma.TabIndex = 15;
            this.txtCronograma.Text = "Cronograma";
            // 
            // dtpAteCronograma
            // 
            this.dtpAteCronograma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpAteCronograma.CalendarTitleBackColor = System.Drawing.Color.YellowGreen;
            this.dtpAteCronograma.Location = new System.Drawing.Point(628, 178);
            this.dtpAteCronograma.Name = "dtpAteCronograma";
            this.dtpAteCronograma.Size = new System.Drawing.Size(85, 20);
            this.dtpAteCronograma.TabIndex = 19;
            // 
            // dtpDeCronograma
            // 
            this.dtpDeCronograma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDeCronograma.CalendarTitleBackColor = System.Drawing.Color.YellowGreen;
            this.dtpDeCronograma.Location = new System.Drawing.Point(502, 178);
            this.dtpDeCronograma.Name = "dtpDeCronograma";
            this.dtpDeCronograma.Size = new System.Drawing.Size(85, 20);
            this.dtpDeCronograma.TabIndex = 18;
            // 
            // lblAteCronograma
            // 
            this.lblAteCronograma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAteCronograma.AutoSize = true;
            this.lblAteCronograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAteCronograma.Location = new System.Drawing.Point(593, 182);
            this.lblAteCronograma.Name = "lblAteCronograma";
            this.lblAteCronograma.Size = new System.Drawing.Size(34, 16);
            this.lblAteCronograma.TabIndex = 17;
            this.lblAteCronograma.Text = "Até:";
            // 
            // lblDeCronograma
            // 
            this.lblDeCronograma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeCronograma.AutoSize = true;
            this.lblDeCronograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeCronograma.Location = new System.Drawing.Point(472, 182);
            this.lblDeCronograma.Name = "lblDeCronograma";
            this.lblDeCronograma.Size = new System.Drawing.Size(31, 16);
            this.lblDeCronograma.TabIndex = 16;
            this.lblDeCronograma.Text = "De:";
            // 
            // btnPesquisarTarefa
            // 
            this.btnPesquisarTarefa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarTarefa.Location = new System.Drawing.Point(474, 225);
            this.btnPesquisarTarefa.Name = "btnPesquisarTarefa";
            this.btnPesquisarTarefa.Size = new System.Drawing.Size(112, 23);
            this.btnPesquisarTarefa.TabIndex = 21;
            this.btnPesquisarTarefa.Text = "Pesquisar Tarefa";
            this.btnPesquisarTarefa.UseVisualStyleBackColor = true;
            // 
            // btnNovaTarefa
            // 
            this.btnNovaTarefa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovaTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNovaTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovaTarefa.Location = new System.Drawing.Point(596, 224);
            this.btnNovaTarefa.Name = "btnNovaTarefa";
            this.btnNovaTarefa.Size = new System.Drawing.Size(133, 25);
            this.btnNovaTarefa.TabIndex = 20;
            this.btnNovaTarefa.Text = "Nova Tarefa";
            this.btnNovaTarefa.UseVisualStyleBackColor = false;
            // 
            // TelaCronograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnPesquisarTarefa);
            this.Controls.Add(this.btnNovaTarefa);
            this.Controls.Add(this.dtpAteCronograma);
            this.Controls.Add(this.dtpDeCronograma);
            this.Controls.Add(this.lblAteCronograma);
            this.Controls.Add(this.lblDeCronograma);
            this.Controls.Add(this.txtCronograma);
            this.Controls.Add(this.clbCronograma);
            this.Name = "TelaCronograma";
            this.Text = "TelaCronograma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbCronograma;
        private System.Windows.Forms.Label txtCronograma;
        private System.Windows.Forms.DateTimePicker dtpAteCronograma;
        private System.Windows.Forms.DateTimePicker dtpDeCronograma;
        private System.Windows.Forms.Label lblAteCronograma;
        private System.Windows.Forms.Label lblDeCronograma;
        private System.Windows.Forms.Button btnPesquisarTarefa;
        private System.Windows.Forms.Button btnNovaTarefa;
    }
}