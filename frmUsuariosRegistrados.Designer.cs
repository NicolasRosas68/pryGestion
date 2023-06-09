namespace pryGestion
{
    partial class frmUsuariosRegistrados
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
            this.lblNombre_de_usuario_registrado = new System.Windows.Forms.Label();
            this.lblcontraseña_Usuario_Registrado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre_de_usuario_registrado
            // 
            this.lblNombre_de_usuario_registrado.AutoSize = true;
            this.lblNombre_de_usuario_registrado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre_de_usuario_registrado.Location = new System.Drawing.Point(11, 50);
            this.lblNombre_de_usuario_registrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre_de_usuario_registrado.Name = "lblNombre_de_usuario_registrado";
            this.lblNombre_de_usuario_registrado.Size = new System.Drawing.Size(141, 18);
            this.lblNombre_de_usuario_registrado.TabIndex = 0;
            this.lblNombre_de_usuario_registrado.Text = "Nombre de usuario";
            this.lblNombre_de_usuario_registrado.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblcontraseña_Usuario_Registrado
            // 
            this.lblcontraseña_Usuario_Registrado.AutoSize = true;
            this.lblcontraseña_Usuario_Registrado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontraseña_Usuario_Registrado.Location = new System.Drawing.Point(11, 90);
            this.lblcontraseña_Usuario_Registrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcontraseña_Usuario_Registrado.Name = "lblcontraseña_Usuario_Registrado";
            this.lblcontraseña_Usuario_Registrado.Size = new System.Drawing.Size(85, 18);
            this.lblcontraseña_Usuario_Registrado.TabIndex = 1;
            this.lblcontraseña_Usuario_Registrado.Text = "contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // frmUsuariosRegistrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 233);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblcontraseña_Usuario_Registrado);
            this.Controls.Add(this.lblNombre_de_usuario_registrado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUsuariosRegistrados";
            this.Text = "frmUsuariosRegistrados";
            this.Load += new System.EventHandler(this.frmUsuariosRegistrados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre_de_usuario_registrado;
        private System.Windows.Forms.Label lblcontraseña_Usuario_Registrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}