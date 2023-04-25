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
            this.ContrasenaAdministrador.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ContrasenaAdministrador.Location = new System.Drawing.Point(272, 343);
            this.ContrasenaAdministrador.Margin = new System.Windows.Forms.Padding(2);
            this.ContrasenaAdministrador.Name = "ContrasenaAdministrador";
            this.ContrasenaAdministrador.Size = new System.Drawing.Size(261, 27);
            this.ContrasenaAdministrador.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(268, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Contraseña";
            // 
            // IdentificacionAdministrador
            // 
            this.IdentificacionAdministrador.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.IdentificacionAdministrador.Location = new System.Drawing.Point(272, 261);
            this.IdentificacionAdministrador.Margin = new System.Windows.Forms.Padding(2);
            this.IdentificacionAdministrador.Name = "IdentificacionAdministrador";
            this.IdentificacionAdministrador.Size = new System.Drawing.Size(261, 27);
            this.IdentificacionAdministrador.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(268, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Identificación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(312, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Administrador";
            // 
            // IngresarBtn
            // 
            this.IngresarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(158)))), ((int)(((byte)(71)))));
            this.IngresarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IngresarBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.IngresarBtn.Location = new System.Drawing.Point(352, 443);
            this.IngresarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.IngresarBtn.Name = "IngresarBtn";
            this.IngresarBtn.Size = new System.Drawing.Size(137, 40);
            this.IngresarBtn.TabIndex = 30;
            this.IngresarBtn.Text = "Ingresar";
            this.IngresarBtn.UseVisualStyleBackColor = false;
            // 
            // RegresoBtn
            // 
            this.RegresoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(127)))), ((int)(((byte)(71)))));
            this.RegresoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegresoBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RegresoBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegresoBtn.Location = new System.Drawing.Point(32, 32);
            this.RegresoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RegresoBtn.Name = "RegresoBtn";
            this.RegresoBtn.Size = new System.Drawing.Size(102, 36);
            this.RegresoBtn.TabIndex = 31;
            this.RegresoBtn.Text = "Regresar";
            this.RegresoBtn.UseVisualStyleBackColor = false;
            this.RegresoBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // IngresoAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(206)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(806, 623);
            this.Controls.Add(this.RegresoBtn);
            this.Controls.Add(this.IngresarBtn);
            this.Controls.Add(this.ContrasenaAdministrador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdentificacionAdministrador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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