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
            this.DesplegableOpciones.FormattingEnabled = true;
            this.DesplegableOpciones.Items.AddRange(new object[] {
            "Administrador",
            "Cliente",
            "Recepcionista"});
            this.DesplegableOpciones.Location = new System.Drawing.Point(50, 201);
            this.DesplegableOpciones.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DesplegableOpciones.Name = "DesplegableOpciones";
            this.DesplegableOpciones.Size = new System.Drawing.Size(531, 46);
            this.DesplegableOpciones.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iniciar sesión como";
            // 
            // ContinuarBtn
            // 
            this.ContinuarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(218)))), ((int)(((byte)(206)))));
            this.ContinuarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ContinuarBtn.Location = new System.Drawing.Point(218, 315);
            this.ContinuarBtn.Name = "ContinuarBtn";
            this.ContinuarBtn.Size = new System.Drawing.Size(166, 42);
            this.ContinuarBtn.TabIndex = 4;
            this.ContinuarBtn.Text = "Continuar";
            this.ContinuarBtn.UseVisualStyleBackColor = false;
            this.ContinuarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegresoBtn
            // 
            this.RegresoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(107)))), ((int)(((byte)(71)))));
            this.RegresoBtn.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Bold);
            this.RegresoBtn.ForeColor = System.Drawing.Color.White;
            this.RegresoBtn.Location = new System.Drawing.Point(11, 11);
            this.RegresoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RegresoBtn.Name = "RegresoBtn";
            this.RegresoBtn.Size = new System.Drawing.Size(246, 39);
            this.RegresoBtn.TabIndex = 33;
            this.RegresoBtn.Text = "Regresar al home";
            this.RegresoBtn.UseVisualStyleBackColor = false;
            this.RegresoBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(597, 443);
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