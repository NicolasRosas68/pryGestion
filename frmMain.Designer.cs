namespace pryGestion
{
    partial class frmMain
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
            this.label2 = new System.Windows.Forms.Label();
            this.mrcCrea_una_cuenta = new System.Windows.Forms.GroupBox();
            this.lblGmail = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombre_de_Usuario = new System.Windows.Forms.Label();
            this.lblConfirmar_contrasena = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.chkCondicional = new System.Windows.Forms.CheckBox();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.mrcCrea_una_cuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // mrcCrea_una_cuenta
            // 
            this.mrcCrea_una_cuenta.Controls.Add(this.textBox6);
            this.mrcCrea_una_cuenta.Controls.Add(this.textBox5);
            this.mrcCrea_una_cuenta.Controls.Add(this.textBox4);
            this.mrcCrea_una_cuenta.Controls.Add(this.textBox3);
            this.mrcCrea_una_cuenta.Controls.Add(this.textBox2);
            this.mrcCrea_una_cuenta.Controls.Add(this.textBox1);
            this.mrcCrea_una_cuenta.Controls.Add(this.lblConfirmar_contrasena);
            this.mrcCrea_una_cuenta.Controls.Add(this.lblNombre_de_Usuario);
            this.mrcCrea_una_cuenta.Controls.Add(this.label3);
            this.mrcCrea_una_cuenta.Controls.Add(this.lblNombre);
            this.mrcCrea_una_cuenta.Controls.Add(this.lblApellido);
            this.mrcCrea_una_cuenta.Controls.Add(this.lblGmail);
            this.mrcCrea_una_cuenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcCrea_una_cuenta.Location = new System.Drawing.Point(24, 33);
            this.mrcCrea_una_cuenta.Name = "mrcCrea_una_cuenta";
            this.mrcCrea_una_cuenta.Size = new System.Drawing.Size(347, 385);
            this.mrcCrea_una_cuenta.TabIndex = 2;
            this.mrcCrea_una_cuenta.TabStop = false;
            this.mrcCrea_una_cuenta.Text = "Crea Una Cuenta";
            this.mrcCrea_una_cuenta.Enter += new System.EventHandler(this.mrcLogin_Enter);
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Location = new System.Drawing.Point(26, 47);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(60, 22);
            this.lblGmail.TabIndex = 0;
            this.lblGmail.Text = "Gmail";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(26, 158);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(78, 22);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 104);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 22);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contrasena";
            // 
            // lblNombre_de_Usuario
            // 
            this.lblNombre_de_Usuario.AutoSize = true;
            this.lblNombre_de_Usuario.Location = new System.Drawing.Point(26, 212);
            this.lblNombre_de_Usuario.Name = "lblNombre_de_Usuario";
            this.lblNombre_de_Usuario.Size = new System.Drawing.Size(168, 22);
            this.lblNombre_de_Usuario.TabIndex = 4;
            this.lblNombre_de_Usuario.Text = "Nombre de Usuario";
            // 
            // lblConfirmar_contrasena
            // 
            this.lblConfirmar_contrasena.AutoSize = true;
            this.lblConfirmar_contrasena.Location = new System.Drawing.Point(26, 336);
            this.lblConfirmar_contrasena.Name = "lblConfirmar_contrasena";
            this.lblConfirmar_contrasena.Size = new System.Drawing.Size(190, 22);
            this.lblConfirmar_contrasena.TabIndex = 5;
            this.lblConfirmar_contrasena.Text = "Confirmar contrasena";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(233, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 30);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(233, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 30);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(233, 268);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 30);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(233, 209);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 30);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(233, 328);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 30);
            this.textBox6.TabIndex = 11;
            // 
            // chkCondicional
            // 
            this.chkCondicional.AutoSize = true;
            this.chkCondicional.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCondicional.Location = new System.Drawing.Point(24, 433);
            this.chkCondicional.Name = "chkCondicional";
            this.chkCondicional.Size = new System.Drawing.Size(304, 23);
            this.chkCondicional.TabIndex = 3;
            this.chkCondicional.Text = " Si Ya Tienes Una Cuenta Haz Click Aqui";
            this.chkCondicional.UseVisualStyleBackColor = true;
            this.chkCondicional.CheckedChanged += new System.EventHandler(this.chkCondicional_CheckedChanged);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(139, 486);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(79, 32);
            this.cmdRegistrar.TabIndex = 4;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(278, 486);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(79, 32);
            this.cmdCancelar.TabIndex = 5;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 622);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.chkCondicional);
            this.Controls.Add(this.mrcCrea_una_cuenta);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Registro de actividades - Desarrollo de Software";
            this.mrcCrea_una_cuenta.ResumeLayout(false);
            this.mrcCrea_una_cuenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox mrcCrea_una_cuenta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblConfirmar_contrasena;
        private System.Windows.Forms.Label lblNombre_de_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox chkCondicional;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button cmdCancelar;
    }
}

