
namespace FastPay
{
    partial class Menu
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
            this.PnlArriba = new System.Windows.Forms.Panel();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDinero = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComprarProducto = new FastPay.RJButtom();
            this.btnTransferir = new FastPay.RJButtom();
            this.btnCerrarSesion = new FastPay.RJButtom();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnCuentaAhorro = new FastPay.RJButtom();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlArriba
            // 
            this.PnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlArriba.Location = new System.Drawing.Point(0, 0);
            this.PnlArriba.Margin = new System.Windows.Forms.Padding(0);
            this.PnlArriba.Name = "PnlArriba";
            this.PnlArriba.Size = new System.Drawing.Size(637, 40);
            this.PnlArriba.TabIndex = 8;
            this.PnlArriba.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlArriba_MouseMove);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombre.Location = new System.Drawing.Point(22, 107);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 20);
            this.lbNombre.TabIndex = 38;
            this.lbNombre.Text = "Hola, ";
            // 
            // lbDinero
            // 
            this.lbDinero.AutoSize = true;
            this.lbDinero.BackColor = System.Drawing.Color.White;
            this.lbDinero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDinero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDinero.Location = new System.Drawing.Point(51, 216);
            this.lbDinero.Name = "lbDinero";
            this.lbDinero.Size = new System.Drawing.Size(40, 19);
            this.lbDinero.TabIndex = 41;
            this.lbDinero.Text = "0.00";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnComprarProducto);
            this.panel1.Controls.Add(this.btnTransferir);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Location = new System.Drawing.Point(0, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 202);
            this.panel1.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(363, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Comprar productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(163, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Transferir";
            // 
            // btnComprarProducto
            // 
            this.btnComprarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnComprarProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnComprarProducto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnComprarProducto.BorderRadius = 29;
            this.btnComprarProducto.BorderSize = 0;
            this.btnComprarProducto.FlatAppearance.BorderSize = 0;
            this.btnComprarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprarProducto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarProducto.ForeColor = System.Drawing.Color.White;
            this.btnComprarProducto.Image = global::FastPay.Properties.Resources.Mapa;
            this.btnComprarProducto.Location = new System.Drawing.Point(361, 36);
            this.btnComprarProducto.Name = "btnComprarProducto";
            this.btnComprarProducto.Size = new System.Drawing.Size(143, 64);
            this.btnComprarProducto.TabIndex = 50;
            this.btnComprarProducto.TextColor = System.Drawing.Color.White;
            this.btnComprarProducto.UseVisualStyleBackColor = false;
            this.btnComprarProducto.Click += new System.EventHandler(this.btnComprarProducto_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTransferir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTransferir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTransferir.BorderRadius = 22;
            this.btnTransferir.BorderSize = 0;
            this.btnTransferir.FlatAppearance.BorderSize = 0;
            this.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.ForeColor = System.Drawing.Color.White;
            this.btnTransferir.Image = global::FastPay.Properties.Resources.Transferir;
            this.btnTransferir.Location = new System.Drawing.Point(132, 36);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(143, 64);
            this.btnTransferir.TabIndex = 48;
            this.btnTransferir.TextColor = System.Drawing.Color.White;
            this.btnTransferir.UseVisualStyleBackColor = false;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Gray;
            this.btnCerrarSesion.BackgroundColor = System.Drawing.Color.Gray;
            this.btnCerrarSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCerrarSesion.BorderRadius = 10;
            this.btnCerrarSesion.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(489, 146);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(129, 43);
            this.btnCerrarSesion.TabIndex = 47;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextColor = System.Drawing.Color.White;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click_1);
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.AllowUserToAddRows = false;
            this.dgvMovimientos.AllowUserToDeleteRows = false;
            this.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMovimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvMovimientos.EnableHeadersVisualStyles = false;
            this.dgvMovimientos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMovimientos.Location = new System.Drawing.Point(233, 58);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.ReadOnly = true;
            this.dgvMovimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMovimientos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMovimientos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimientos.Size = new System.Drawing.Size(385, 288);
            this.dgvMovimientos.TabIndex = 44;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Movimientos Recientes";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Monto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FastPay.Properties.Resources.f;
            this.pictureBox1.Location = new System.Drawing.Point(37, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FastPay.Properties.Resources.logo_Negro;
            this.pictureBox5.Location = new System.Drawing.Point(50, 43);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(121, 61);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // btnCuentaAhorro
            // 
            this.btnCuentaAhorro.BackColor = System.Drawing.Color.White;
            this.btnCuentaAhorro.BackgroundColor = System.Drawing.Color.White;
            this.btnCuentaAhorro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCuentaAhorro.BorderRadius = 17;
            this.btnCuentaAhorro.BorderSize = 0;
            this.btnCuentaAhorro.FlatAppearance.BorderSize = 0;
            this.btnCuentaAhorro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentaAhorro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentaAhorro.ForeColor = System.Drawing.Color.Black;
            this.btnCuentaAhorro.Location = new System.Drawing.Point(26, 143);
            this.btnCuentaAhorro.Name = "btnCuentaAhorro";
            this.btnCuentaAhorro.Size = new System.Drawing.Size(182, 146);
            this.btnCuentaAhorro.TabIndex = 39;
            this.btnCuentaAhorro.Text = "Cuenta De Ahorro\r\nS/";
            this.btnCuentaAhorro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuentaAhorro.TextColor = System.Drawing.Color.Black;
            this.btnCuentaAhorro.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(637, 566);
            this.Controls.Add(this.dgvMovimientos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbDinero);
            this.Controls.Add(this.btnCuentaAhorro);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.PnlArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlArriba;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbNombre;
        private RJButtom btnCuentaAhorro;
        private System.Windows.Forms.Label lbDinero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private RJButtom btnComprarProducto;
        private RJButtom btnTransferir;
        private RJButtom btnCerrarSesion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}