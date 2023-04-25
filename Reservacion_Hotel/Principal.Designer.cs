namespace Reservacion_Hotel
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.IniciarSesionBtn = new System.Windows.Forms.Button();
            this.CrearCuentaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IniciarSesionBtn
            // 
            this.IniciarSesionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(158)))), ((int)(((byte)(71)))));
            this.IniciarSesionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarSesionBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.IniciarSesionBtn.Location = new System.Drawing.Point(658, 32);
            this.IniciarSesionBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IniciarSesionBtn.Name = "IniciarSesionBtn";
            this.IniciarSesionBtn.Size = new System.Drawing.Size(137, 40);
            this.IniciarSesionBtn.TabIndex = 2;
            this.IniciarSesionBtn.Text = "Iniciar sesión";
            this.IniciarSesionBtn.UseVisualStyleBackColor = false;
            this.IniciarSesionBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // CrearCuentaBtn
            // 
            this.CrearCuentaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(158)))), ((int)(((byte)(71)))));
            this.CrearCuentaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearCuentaBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CrearCuentaBtn.ForeColor = System.Drawing.Color.Black;
            this.CrearCuentaBtn.Location = new System.Drawing.Point(488, 32);
            this.CrearCuentaBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CrearCuentaBtn.Name = "CrearCuentaBtn";
            this.CrearCuentaBtn.Size = new System.Drawing.Size(137, 40);
            this.CrearCuentaBtn.TabIndex = 3;
            this.CrearCuentaBtn.Text = "Crear cuenta";
            this.CrearCuentaBtn.UseVisualStyleBackColor = false;
            this.CrearCuentaBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(197, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ven a conocer nuestro hotel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reservacion_Hotel.Properties.Resources.HotelPrincipal;
            this.pictureBox2.Location = new System.Drawing.Point(13, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(782, 427);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(206)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(806, 623);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CrearCuentaBtn);
            this.Controls.Add(this.IniciarSesionBtn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button IniciarSesionBtn;
        private System.Windows.Forms.Button CrearCuentaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

