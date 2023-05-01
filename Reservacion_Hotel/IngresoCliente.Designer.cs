namespace Reservacion_Hotel
{
    partial class IngresoCliente
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
            this.ContrasenaCliente = new System.Windows.Forms.TextBox();
            this.CorreoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IngresarBtn = new System.Windows.Forms.Button();
            this.RegresoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContrasenaCliente
            // 
            this.ContrasenaCliente.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ContrasenaCliente.Location = new System.Drawing.Point(408, 528);
            this.ContrasenaCliente.Name = "ContrasenaCliente";
            this.ContrasenaCliente.Size = new System.Drawing.Size(390, 27);
            this.ContrasenaCliente.TabIndex = 16;
            // 
            // CorreoCliente
            // 
            this.CorreoCliente.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CorreoCliente.Location = new System.Drawing.Point(408, 402);
            this.CorreoCliente.Name = "CorreoCliente";
            this.CorreoCliente.Size = new System.Drawing.Size(390, 27);
            this.CorreoCliente.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(528, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(402, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(402, 495);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Contraseña";
            // 
            // IngresarBtn
            // 
            this.IngresarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(158)))), ((int)(((byte)(71)))));
            this.IngresarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IngresarBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.IngresarBtn.Location = new System.Drawing.Point(528, 682);
            this.IngresarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IngresarBtn.Name = "IngresarBtn";
            this.IngresarBtn.Size = new System.Drawing.Size(206, 62);
            this.IngresarBtn.TabIndex = 20;
            this.IngresarBtn.Text = "Ingresar";
            this.IngresarBtn.UseVisualStyleBackColor = false;
            // 
            // RegresoBtn
            // 
            this.RegresoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(127)))), ((int)(((byte)(71)))));
            this.RegresoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegresoBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RegresoBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegresoBtn.Location = new System.Drawing.Point(48, 49);
            this.RegresoBtn.Name = "RegresoBtn";
            this.RegresoBtn.Size = new System.Drawing.Size(153, 55);
            this.RegresoBtn.TabIndex = 32;
            this.RegresoBtn.Text = "Regresar";
            this.RegresoBtn.UseVisualStyleBackColor = false;
            this.RegresoBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // IngresoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(206)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1209, 958);
            this.Controls.Add(this.RegresoBtn);
            this.Controls.Add(this.IngresarBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContrasenaCliente);
            this.Controls.Add(this.CorreoCliente);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IngresoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ContrasenaCliente;
        private System.Windows.Forms.TextBox CorreoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button IngresarBtn;
        private System.Windows.Forms.Button RegresoBtn;
    }
}