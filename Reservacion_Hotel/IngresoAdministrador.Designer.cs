namespace Reservacion_Hotel
{
    partial class IngresoAdministrador
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
            this.ContrasenaAdministrador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdentificacionAdministrador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IngresarBtn = new System.Windows.Forms.Button();
            this.RegresoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContrasenaAdministrador
            // 
            this.ContrasenaAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ContrasenaAdministrador.Location = new System.Drawing.Point(392, 466);
            this.ContrasenaAdministrador.Name = "ContrasenaAdministrador";
            this.ContrasenaAdministrador.Size = new System.Drawing.Size(390, 28);
            this.ContrasenaAdministrador.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Contraseña";
            // 
            // IdentificacionAdministrador
            // 
            this.IdentificacionAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.IdentificacionAdministrador.Location = new System.Drawing.Point(392, 365);
            this.IdentificacionAdministrador.Name = "IdentificacionAdministrador";
            this.IdentificacionAdministrador.Size = new System.Drawing.Size(390, 28);
            this.IdentificacionAdministrador.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Identificación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "Administrador";
            // 
            // IngresarBtn
            // 
            this.IngresarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(218)))), ((int)(((byte)(206)))));
            this.IngresarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarBtn.Location = new System.Drawing.Point(508, 672);
            this.IngresarBtn.Name = "IngresarBtn";
            this.IngresarBtn.Size = new System.Drawing.Size(186, 48);
            this.IngresarBtn.TabIndex = 30;
            this.IngresarBtn.Text = "Ingresar";
            this.IngresarBtn.UseVisualStyleBackColor = false;
            // 
            // RegresoBtn
            // 
            this.RegresoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(107)))), ((int)(((byte)(71)))));
            this.RegresoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegresoBtn.ForeColor = System.Drawing.Color.White;
            this.RegresoBtn.Location = new System.Drawing.Point(40, 40);
            this.RegresoBtn.Name = "RegresoBtn";
            this.RegresoBtn.Size = new System.Drawing.Size(153, 65);
            this.RegresoBtn.TabIndex = 31;
            this.RegresoBtn.Text = "Regresar";
            this.RegresoBtn.UseVisualStyleBackColor = false;
            this.RegresoBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // IngresoAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1209, 946);
            this.Controls.Add(this.RegresoBtn);
            this.Controls.Add(this.IngresarBtn);
            this.Controls.Add(this.ContrasenaAdministrador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdentificacionAdministrador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IngresoAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ContrasenaAdministrador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdentificacionAdministrador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IngresarBtn;
        private System.Windows.Forms.Button RegresoBtn;
    }
}