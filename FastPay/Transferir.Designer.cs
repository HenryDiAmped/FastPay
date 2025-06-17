
namespace FastPay
{
    partial class Transferir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsuariosRecientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNumeroTelefonico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.btnConfirmarTransferencia = new FastPay.RJButtom();
            this.btnRetroceder2 = new FastPay.RJButtom();
            this.btnSoloRetroceder = new FastPay.RJButtom();
            this.PnlArriba = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosRecientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuariosRecientes
            // 
            this.dgvUsuariosRecientes.AllowUserToAddRows = false;
            this.dgvUsuariosRecientes.AllowUserToDeleteRows = false;
            this.dgvUsuariosRecientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuariosRecientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuariosRecientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvUsuariosRecientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuariosRecientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuariosRecientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuariosRecientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuariosRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosRecientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvUsuariosRecientes.EnableHeadersVisualStyles = false;
            this.dgvUsuariosRecientes.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvUsuariosRecientes.Location = new System.Drawing.Point(12, 50);
            this.dgvUsuariosRecientes.Name = "dgvUsuariosRecientes";
            this.dgvUsuariosRecientes.ReadOnly = true;
            this.dgvUsuariosRecientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuariosRecientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuariosRecientes.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsuariosRecientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuariosRecientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuariosRecientes.Size = new System.Drawing.Size(286, 172);
            this.dgvUsuariosRecientes.TabIndex = 45;
            this.dgvUsuariosRecientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosRecientes_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Usuarios recientes";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Celular";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // tbNumeroTelefonico
            // 
            this.tbNumeroTelefonico.Location = new System.Drawing.Point(313, 80);
            this.tbNumeroTelefonico.MaxLength = 9;
            this.tbNumeroTelefonico.Name = "tbNumeroTelefonico";
            this.tbNumeroTelefonico.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroTelefonico.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(310, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Número Telefónico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(310, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Monto";
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(313, 146);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(100, 20);
            this.tbMonto.TabIndex = 48;
            // 
            // btnConfirmarTransferencia
            // 
            this.btnConfirmarTransferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConfirmarTransferencia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConfirmarTransferencia.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirmarTransferencia.BorderRadius = 10;
            this.btnConfirmarTransferencia.BorderSize = 0;
            this.btnConfirmarTransferencia.FlatAppearance.BorderSize = 0;
            this.btnConfirmarTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarTransferencia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarTransferencia.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarTransferencia.Location = new System.Drawing.Point(312, 183);
            this.btnConfirmarTransferencia.Name = "btnConfirmarTransferencia";
            this.btnConfirmarTransferencia.Size = new System.Drawing.Size(109, 46);
            this.btnConfirmarTransferencia.TabIndex = 50;
            this.btnConfirmarTransferencia.Text = "Confirmar Transferencia";
            this.btnConfirmarTransferencia.TextColor = System.Drawing.Color.Black;
            this.btnConfirmarTransferencia.UseVisualStyleBackColor = false;
            this.btnConfirmarTransferencia.Click += new System.EventHandler(this.btnConfirmarTransferencia_Click);
            // 
            // btnRetroceder2
            // 
            this.btnRetroceder2.BackColor = System.Drawing.Color.Gray;
            this.btnRetroceder2.BackgroundColor = System.Drawing.Color.Gray;
            this.btnRetroceder2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRetroceder2.BorderRadius = 10;
            this.btnRetroceder2.BorderSize = 0;
            this.btnRetroceder2.Enabled = false;
            this.btnRetroceder2.FlatAppearance.BorderSize = 0;
            this.btnRetroceder2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetroceder2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceder2.ForeColor = System.Drawing.Color.Black;
            this.btnRetroceder2.Location = new System.Drawing.Point(312, 241);
            this.btnRetroceder2.Name = "btnRetroceder2";
            this.btnRetroceder2.Size = new System.Drawing.Size(109, 43);
            this.btnRetroceder2.TabIndex = 51;
            this.btnRetroceder2.Text = "Retroceder y guardar";
            this.btnRetroceder2.TextColor = System.Drawing.Color.Black;
            this.btnRetroceder2.UseVisualStyleBackColor = false;
            this.btnRetroceder2.Click += new System.EventHandler(this.btnRetroceder2_Click);
            // 
            // btnSoloRetroceder
            // 
            this.btnSoloRetroceder.BackColor = System.Drawing.Color.Gray;
            this.btnSoloRetroceder.BackgroundColor = System.Drawing.Color.Gray;
            this.btnSoloRetroceder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSoloRetroceder.BorderRadius = 10;
            this.btnSoloRetroceder.BorderSize = 0;
            this.btnSoloRetroceder.FlatAppearance.BorderSize = 0;
            this.btnSoloRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoloRetroceder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoloRetroceder.ForeColor = System.Drawing.Color.Black;
            this.btnSoloRetroceder.Location = new System.Drawing.Point(312, 291);
            this.btnSoloRetroceder.Name = "btnSoloRetroceder";
            this.btnSoloRetroceder.Size = new System.Drawing.Size(109, 43);
            this.btnSoloRetroceder.TabIndex = 52;
            this.btnSoloRetroceder.Text = "Solo Retroceder";
            this.btnSoloRetroceder.TextColor = System.Drawing.Color.Black;
            this.btnSoloRetroceder.UseVisualStyleBackColor = false;
            this.btnSoloRetroceder.Click += new System.EventHandler(this.btnSoloRetroceder_Click);
            // 
            // PnlArriba
            // 
            this.PnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlArriba.Location = new System.Drawing.Point(0, 0);
            this.PnlArriba.Margin = new System.Windows.Forms.Padding(0);
            this.PnlArriba.Name = "PnlArriba";
            this.PnlArriba.Size = new System.Drawing.Size(439, 40);
            this.PnlArriba.TabIndex = 53;
            this.PnlArriba.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlArriba_MouseMove);
            // 
            // Transferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(439, 354);
            this.Controls.Add(this.PnlArriba);
            this.Controls.Add(this.btnSoloRetroceder);
            this.Controls.Add(this.btnRetroceder2);
            this.Controls.Add(this.btnConfirmarTransferencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumeroTelefonico);
            this.Controls.Add(this.dgvUsuariosRecientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transferir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferir";
            this.Load += new System.EventHandler(this.Transferir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosRecientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuariosRecientes;
        private System.Windows.Forms.TextBox tbNumeroTelefonico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private RJButtom btnConfirmarTransferencia;
        private RJButtom btnRetroceder2;
        private RJButtom btnSoloRetroceder;
        private System.Windows.Forms.Panel PnlArriba;
    }
}