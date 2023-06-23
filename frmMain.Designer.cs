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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mrcCrea_una_cuenta = new System.Windows.Forms.GroupBox();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.txtNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.lblConfirmar_contrasena = new System.Windows.Forms.Label();
            this.lblNombre_de_Usuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblGmail = new System.Windows.Forms.Label();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.mrcCrea_una_cuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcCrea_una_cuenta
            // 
            this.mrcCrea_una_cuenta.Controls.Add(this.txtConfirmarContraseña);
            this.mrcCrea_una_cuenta.Controls.Add(this.txtNombreDeUsuario);
            this.mrcCrea_una_cuenta.Controls.Add(this.txtContraseña);
            this.mrcCrea_una_cuenta.Controls.Add(this.txtNombre);
            this.mrcCrea_una_cuenta.Controls.Add(this.txtApellido);
            this.mrcCrea_una_cuenta.Controls.Add(this.lblNombre_de_Usuario);
            this.mrcCrea_una_cuenta.Controls.Add(this.txtGmail);
            this.mrcCrea_una_cuenta.Controls.Add(this.lblConfirmar_contrasena);
            this.mrcCrea_una_cuenta.Controls.Add(this.lblContraseña);
            this.mrcCrea_una_cuenta.Controls.Add(this.lblNombre);
            this.mrcCrea_una_cuenta.Controls.Add(this.lblApellido);
            this.mrcCrea_una_cuenta.Controls.Add(this.lblGmail);
            this.mrcCrea_una_cuenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcCrea_una_cuenta.Location = new System.Drawing.Point(18, 27);
            this.mrcCrea_una_cuenta.Margin = new System.Windows.Forms.Padding(2);
            this.mrcCrea_una_cuenta.Name = "mrcCrea_una_cuenta";
            this.mrcCrea_una_cuenta.Padding = new System.Windows.Forms.Padding(2);
            this.mrcCrea_una_cuenta.Size = new System.Drawing.Size(339, 313);
            this.mrcCrea_una_cuenta.TabIndex = 2;
            this.mrcCrea_una_cuenta.TabStop = false;
            this.mrcCrea_una_cuenta.Text = "Crea Una Cuenta";
            this.mrcCrea_una_cuenta.Enter += new System.EventHandler(this.mrcLogin_Enter);
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(175, 174);
            this.txtConfirmarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '#';
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(150, 26);
            this.txtConfirmarContraseña.TabIndex = 3;
            // 
            // txtNombreDeUsuario
            // 
            this.txtNombreDeUsuario.Location = new System.Drawing.Point(175, 265);
            this.txtNombreDeUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreDeUsuario.Name = "txtNombreDeUsuario";
            this.txtNombreDeUsuario.Size = new System.Drawing.Size(150, 26);
            this.txtNombreDeUsuario.TabIndex = 5;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(175, 218);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '#';
            this.txtContraseña.Size = new System.Drawing.Size(150, 26);
            this.txtContraseña.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(175, 79);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(175, 123);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(150, 26);
            this.txtApellido.TabIndex = 2;
            // 
            // txtGmail
            // 
            this.txtGmail.Location = new System.Drawing.Point(175, 32);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(150, 26);
            this.txtGmail.TabIndex = 0;
            this.txtGmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblConfirmar_contrasena
            // 
            this.lblConfirmar_contrasena.AutoSize = true;
            this.lblConfirmar_contrasena.Location = new System.Drawing.Point(2, 177);
            this.lblConfirmar_contrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmar_contrasena.Name = "lblConfirmar_contrasena";
            this.lblConfirmar_contrasena.Size = new System.Drawing.Size(158, 18);
            this.lblConfirmar_contrasena.TabIndex = 5;
            this.lblConfirmar_contrasena.Text = "Confirmar contraseña";
            // 
            // lblNombre_de_Usuario
            // 
            this.lblNombre_de_Usuario.AutoSize = true;
            this.lblNombre_de_Usuario.Location = new System.Drawing.Point(7, 268);
            this.lblNombre_de_Usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre_de_Usuario.Name = "lblNombre_de_Usuario";
            this.lblNombre_de_Usuario.Size = new System.Drawing.Size(144, 18);
            this.lblNombre_de_Usuario.TabIndex = 4;
            this.lblNombre_de_Usuario.Text = "Nombre de Usuario";
            this.lblNombre_de_Usuario.Click += new System.EventHandler(this.lblNombre_de_Usuario_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(4, 221);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(89, 18);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(4, 82);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(3, 126);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 18);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Location = new System.Drawing.Point(4, 40);
            this.lblGmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(49, 18);
            this.lblGmail.TabIndex = 0;
            this.lblGmail.Text = "Gmail";
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrar.Location = new System.Drawing.Point(69, 376);
            this.cmdRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(81, 37);
            this.cmdRegistrar.TabIndex = 0;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(230, 376);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(87, 37);
            this.cmdCancelar.TabIndex = 1;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 436);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.mrcCrea_una_cuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesion ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mrcCrea_una_cuenta.ResumeLayout(false);
            this.mrcCrea_una_cuenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox mrcCrea_una_cuenta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.Label lblConfirmar_contrasena;
        private System.Windows.Forms.Label lblNombre_de_Usuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.TextBox txtNombreDeUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button cmdCancelar;
    }
}

