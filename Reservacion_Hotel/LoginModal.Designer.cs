namespace Reservacion_Hotel
{
    partial class LoginModal
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
            this.DesplegableOpciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ContinuarBtn = new System.Windows.Forms.Button();
            this.RegresoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DesplegableOpciones
            // 
            this.DesplegableOpciones.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DesplegableOpciones.FormattingEnabled = true;
            this.DesplegableOpciones.Items.AddRange(new object[] {
            "Administrador",
            "Cliente",
            "Recepcionista"});
            this.DesplegableOpciones.Location = new System.Drawing.Point(48, 177);
            this.DesplegableOpciones.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DesplegableOpciones.Name = "DesplegableOpciones";
            this.DesplegableOpciones.Size = new System.Drawing.Size(465, 31);
            this.DesplegableOpciones.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(182, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iniciar sesión como";
            // 
            // ContinuarBtn
            // 
            this.ContinuarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(158)))), ((int)(((byte)(71)))));
            this.ContinuarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinuarBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ContinuarBtn.Location = new System.Drawing.Point(232, 329);
            this.ContinuarBtn.Name = "ContinuarBtn";
            this.ContinuarBtn.Size = new System.Drawing.Size(137, 40);
            this.ContinuarBtn.TabIndex = 4;
            this.ContinuarBtn.Text = "Continuar";
            this.ContinuarBtn.UseVisualStyleBackColor = false;
            this.ContinuarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegresoBtn
            // 
            this.RegresoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(127)))), ((int)(((byte)(71)))));
            this.RegresoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegresoBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RegresoBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegresoBtn.Location = new System.Drawing.Point(16, 16);
            this.RegresoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RegresoBtn.Name = "RegresoBtn";
            this.RegresoBtn.Size = new System.Drawing.Size(152, 36);
            this.RegresoBtn.TabIndex = 33;
            this.RegresoBtn.Text = "Regresar al home";
            this.RegresoBtn.UseVisualStyleBackColor = false;
            this.RegresoBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(556, 381);
            this.Controls.Add(this.RegresoBtn);
            this.Controls.Add(this.ContinuarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DesplegableOpciones);
            this.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "LoginModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox DesplegableOpciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ContinuarBtn;
        private System.Windows.Forms.Button RegresoBtn;
    }
}