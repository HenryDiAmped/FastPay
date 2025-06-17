
namespace FastPay
{
    partial class Mapa
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCrearCamino = new FastPay.RJButtom();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDibujar = new FastPay.RJButtom();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAtras = new FastPay.RJButtom();
            this.btnSeguir = new FastPay.RJButtom();
            this.PnlArriba = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 441);
            this.panel1.TabIndex = 3;
            // 
            // btnCrearCamino
            // 
            this.btnCrearCamino.BackColor = System.Drawing.Color.Gray;
            this.btnCrearCamino.BackgroundColor = System.Drawing.Color.Gray;
            this.btnCrearCamino.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCrearCamino.BorderRadius = 10;
            this.btnCrearCamino.BorderSize = 0;
            this.btnCrearCamino.FlatAppearance.BorderSize = 0;
            this.btnCrearCamino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCamino.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCamino.ForeColor = System.Drawing.Color.White;
            this.btnCrearCamino.Location = new System.Drawing.Point(648, 507);
            this.btnCrearCamino.Name = "btnCrearCamino";
            this.btnCrearCamino.Size = new System.Drawing.Size(136, 51);
            this.btnCrearCamino.TabIndex = 48;
            this.btnCrearCamino.Text = "Crear Camino";
            this.btnCrearCamino.TextColor = System.Drawing.Color.White;
            this.btnCrearCamino.UseVisualStyleBackColor = false;
            this.btnCrearCamino.Click += new System.EventHandler(this.btnCrearCamino_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDibujar
            // 
            this.btnDibujar.BackColor = System.Drawing.Color.Gray;
            this.btnDibujar.BackgroundColor = System.Drawing.Color.Gray;
            this.btnDibujar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDibujar.BorderRadius = 10;
            this.btnDibujar.BorderSize = 0;
            this.btnDibujar.FlatAppearance.BorderSize = 0;
            this.btnDibujar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDibujar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.ForeColor = System.Drawing.Color.White;
            this.btnDibujar.Location = new System.Drawing.Point(84, 507);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(136, 51);
            this.btnDibujar.TabIndex = 49;
            this.btnDibujar.Text = "Generar Ruta";
            this.btnDibujar.TextColor = System.Drawing.Color.White;
            this.btnDibujar.UseVisualStyleBackColor = false;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FastPay.Properties.Resources.MapaCiudad2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(475, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 441);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 39);
            this.label1.TabIndex = 50;
            this.label1.Text = "Se genera un trafico estimado\r\nSi lo considera puede modificar\r\nhaciendo click\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(470, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(903, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Final";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAtras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAtras.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAtras.BorderRadius = 7;
            this.btnAtras.BorderSize = 0;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Location = new System.Drawing.Point(871, 528);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(27, 29);
            this.btnAtras.TabIndex = 53;
            this.btnAtras.Text = "↩";
            this.btnAtras.TextColor = System.Drawing.Color.White;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSeguir
            // 
            this.btnSeguir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSeguir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSeguir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSeguir.BorderRadius = 7;
            this.btnSeguir.BorderSize = 0;
            this.btnSeguir.Enabled = false;
            this.btnSeguir.FlatAppearance.BorderSize = 0;
            this.btnSeguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguir.ForeColor = System.Drawing.Color.White;
            this.btnSeguir.Location = new System.Drawing.Point(902, 528);
            this.btnSeguir.Name = "btnSeguir";
            this.btnSeguir.Size = new System.Drawing.Size(27, 29);
            this.btnSeguir.TabIndex = 54;
            this.btnSeguir.Text = "↪";
            this.btnSeguir.TextColor = System.Drawing.Color.White;
            this.btnSeguir.UseVisualStyleBackColor = false;
            this.btnSeguir.Click += new System.EventHandler(this.btnSeguir_Click);
            // 
            // PnlArriba
            // 
            this.PnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlArriba.Location = new System.Drawing.Point(0, 0);
            this.PnlArriba.Margin = new System.Windows.Forms.Padding(0);
            this.PnlArriba.Name = "PnlArriba";
            this.PnlArriba.Size = new System.Drawing.Size(941, 28);
            this.PnlArriba.TabIndex = 55;
            this.PnlArriba.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlArriba_MouseMove);
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(941, 571);
            this.Controls.Add(this.PnlArriba);
            this.Controls.Add(this.btnSeguir);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.btnCrearCamino);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapa";
            this.Load += new System.EventHandler(this.Mapa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private RJButtom btnCrearCamino;
        private System.Windows.Forms.Timer timer1;
        private RJButtom btnDibujar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RJButtom btnAtras;
        private RJButtom btnSeguir;
        private System.Windows.Forms.Panel PnlArriba;
    }
}