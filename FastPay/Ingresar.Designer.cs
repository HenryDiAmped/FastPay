
namespace FastPay
{
    partial class Ingresar
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
            this.PnlArriba = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnVisualizarContra2 = new FastPay.RJButtom();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroDNI2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRetroceder2 = new FastPay.RJButtom();
            this.btnIngresar = new FastPay.RJButtom();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlArriba
            // 
            this.PnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlArriba.Location = new System.Drawing.Point(0, 0);
            this.PnlArriba.Margin = new System.Windows.Forms.Padding(0);
            this.PnlArriba.Name = "PnlArriba";
            this.PnlArriba.Size = new System.Drawing.Size(542, 40);
            this.PnlArriba.TabIndex = 8;
            this.PnlArriba.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlArriba_MouseMove);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FastPay.Properties.Resources.logo_Negro;
            this.pictureBox5.Location = new System.Drawing.Point(155, 43);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(239, 143);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // btnVisualizarContra2
            // 
            this.btnVisualizarContra2.BackColor = System.Drawing.Color.Blue;
            this.btnVisualizarContra2.BackgroundColor = System.Drawing.Color.Blue;
            this.btnVisualizarContra2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVisualizarContra2.BorderRadius = 10;
            this.btnVisualizarContra2.BorderSize = 0;
            this.btnVisualizarContra2.FlatAppearance.BorderSize = 0;
            this.btnVisualizarContra2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarContra2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarContra2.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarContra2.Location = new System.Drawing.Point(171, 361);
            this.btnVisualizarContra2.Name = "btnVisualizarContra2";
            this.btnVisualizarContra2.Size = new System.Drawing.Size(57, 31);
            this.btnVisualizarContra2.TabIndex = 33;
            this.btnVisualizarContra2.Text = "Ver";
            this.btnVisualizarContra2.TextColor = System.Drawing.Color.White;
            this.btnVisualizarContra2.UseVisualStyleBackColor = false;
            this.btnVisualizarContra2.Click += new System.EventHandler(this.btnVisualizarContra2_Click);
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtContraseña2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña2.Location = new System.Drawing.Point(71, 361);
            this.txtContraseña2.MaxLength = 6;
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.Size = new System.Drawing.Size(85, 22);
            this.txtContraseña2.TabIndex = 31;
            this.txtContraseña2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña2_KeyPress);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::FastPay.Properties.Resources.Line;
            this.pictureBox6.Location = new System.Drawing.Point(62, 347);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(103, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 32;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(67, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Contraseña: (6 dígitos)";
            // 
            // txtNumeroDNI2
            // 
            this.txtNumeroDNI2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtNumeroDNI2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroDNI2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDNI2.Location = new System.Drawing.Point(71, 270);
            this.txtNumeroDNI2.MaxLength = 8;
            this.txtNumeroDNI2.Name = "txtNumeroDNI2";
            this.txtNumeroDNI2.Size = new System.Drawing.Size(85, 22);
            this.txtNumeroDNI2.TabIndex = 28;
            this.txtNumeroDNI2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDNI2_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FastPay.Properties.Resources.Line;
            this.pictureBox2.Location = new System.Drawing.Point(62, 256);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(67, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Número de DNI:";
            // 
            // btnRetroceder2
            // 
            this.btnRetroceder2.BackColor = System.Drawing.Color.Gray;
            this.btnRetroceder2.BackgroundColor = System.Drawing.Color.Gray;
            this.btnRetroceder2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRetroceder2.BorderRadius = 10;
            this.btnRetroceder2.BorderSize = 0;
            this.btnRetroceder2.FlatAppearance.BorderSize = 0;
            this.btnRetroceder2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetroceder2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceder2.ForeColor = System.Drawing.Color.White;
            this.btnRetroceder2.Location = new System.Drawing.Point(352, 336);
            this.btnRetroceder2.Name = "btnRetroceder2";
            this.btnRetroceder2.Size = new System.Drawing.Size(129, 43);
            this.btnRetroceder2.TabIndex = 35;
            this.btnRetroceder2.Text = "Retroceder";
            this.btnRetroceder2.TextColor = System.Drawing.Color.White;
            this.btnRetroceder2.UseVisualStyleBackColor = false;
            this.btnRetroceder2.Click += new System.EventHandler(this.btnRetroceder2_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIngresar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIngresar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnIngresar.BorderRadius = 10;
            this.btnIngresar.BorderSize = 0;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(352, 270);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(129, 43);
            this.btnIngresar.TabIndex = 34;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextColor = System.Drawing.Color.White;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Ingresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(542, 482);
            this.Controls.Add(this.btnRetroceder2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnVisualizarContra2);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumeroDNI2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.PnlArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingresar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar";
            this.Load += new System.EventHandler(this.Ingresar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlArriba;
        private System.Windows.Forms.PictureBox pictureBox5;
        private RJButtom btnVisualizarContra2;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroDNI2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private RJButtom btnRetroceder2;
        private RJButtom btnIngresar;
    }
}