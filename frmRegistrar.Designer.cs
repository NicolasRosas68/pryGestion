namespace pryGestion
{
    partial class frmRegistrar
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtDetalle_de_Actividad = new System.Windows.Forms.TextBox();
            this.lblTipo_Actividad = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lstTipo_de_Actividad = new System.Windows.Forms.ComboBox();
            this.lblDetalle_Actividad = new System.Windows.Forms.Label();
            this.mrcReunion = new System.Windows.Forms.GroupBox();
            this.optno = new System.Windows.Forms.RadioButton();
            this.optsi = new System.Windows.Forms.RadioButton();
            this.mrcTareas = new System.Windows.Forms.GroupBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkNotas_reuniones = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkRepositorio = new System.Windows.Forms.CheckBox();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.mrcReunion.SuspendLayout();
            this.mrcTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(2, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(39, 15);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // txtDetalle_de_Actividad
            // 
            this.txtDetalle_de_Actividad.Location = new System.Drawing.Point(135, 102);
            this.txtDetalle_de_Actividad.Name = "txtDetalle_de_Actividad";
            this.txtDetalle_de_Actividad.Size = new System.Drawing.Size(121, 20);
            this.txtDetalle_de_Actividad.TabIndex = 1;
            // 
            // lblTipo_Actividad
            // 
            this.lblTipo_Actividad.AutoSize = true;
            this.lblTipo_Actividad.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo_Actividad.Location = new System.Drawing.Point(2, 56);
            this.lblTipo_Actividad.Name = "lblTipo_Actividad";
            this.lblTipo_Actividad.Size = new System.Drawing.Size(83, 15);
            this.lblTipo_Actividad.TabIndex = 2;
            this.lblTipo_Actividad.Text = "Tipo Actividad";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(56, 11);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // lstTipo_de_Actividad
            // 
            this.lstTipo_de_Actividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipo_de_Actividad.FormattingEnabled = true;
            this.lstTipo_de_Actividad.Items.AddRange(new object[] {
            "Relevamiento",
            "Propuesta ",
            "Diagnostico ",
            "Analisis ",
            "Diagrama de Bases de Datos ",
            "Programacion "});
            this.lstTipo_de_Actividad.Location = new System.Drawing.Point(135, 57);
            this.lstTipo_de_Actividad.Name = "lstTipo_de_Actividad";
            this.lstTipo_de_Actividad.Size = new System.Drawing.Size(121, 21);
            this.lstTipo_de_Actividad.TabIndex = 5;
            this.lstTipo_de_Actividad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDetalle_Actividad
            // 
            this.lblDetalle_Actividad.AutoSize = true;
            this.lblDetalle_Actividad.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle_Actividad.Location = new System.Drawing.Point(2, 105);
            this.lblDetalle_Actividad.Name = "lblDetalle_Actividad";
            this.lblDetalle_Actividad.Size = new System.Drawing.Size(96, 15);
            this.lblDetalle_Actividad.TabIndex = 6;
            this.lblDetalle_Actividad.Text = "Detalle actividad";
            // 
            // mrcReunion
            // 
            this.mrcReunion.Controls.Add(this.optno);
            this.mrcReunion.Controls.Add(this.optsi);
            this.mrcReunion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcReunion.Location = new System.Drawing.Point(5, 140);
            this.mrcReunion.Name = "mrcReunion";
            this.mrcReunion.Size = new System.Drawing.Size(250, 58);
            this.mrcReunion.TabIndex = 7;
            this.mrcReunion.TabStop = false;
            this.mrcReunion.Text = "Reunion";
            // 
            // optno
            // 
            this.optno.AutoSize = true;
            this.optno.Location = new System.Drawing.Point(144, 29);
            this.optno.Name = "optno";
            this.optno.Size = new System.Drawing.Size(40, 19);
            this.optno.TabIndex = 1;
            this.optno.TabStop = true;
            this.optno.Text = "No";
            this.optno.UseVisualStyleBackColor = true;
            // 
            // optsi
            // 
            this.optsi.AutoSize = true;
            this.optsi.Location = new System.Drawing.Point(41, 29);
            this.optsi.Name = "optsi";
            this.optsi.Size = new System.Drawing.Size(37, 19);
            this.optsi.TabIndex = 0;
            this.optsi.TabStop = true;
            this.optsi.Text = "Si";
            this.optsi.UseVisualStyleBackColor = true;
            // 
            // mrcTareas
            // 
            this.mrcTareas.Controls.Add(this.chkDebate);
            this.mrcTareas.Controls.Add(this.chkNotas_reuniones);
            this.mrcTareas.Controls.Add(this.chkInvestigacion);
            this.mrcTareas.Controls.Add(this.chkRepositorio);
            this.mrcTareas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcTareas.Location = new System.Drawing.Point(5, 215);
            this.mrcTareas.Name = "mrcTareas";
            this.mrcTareas.Size = new System.Drawing.Size(250, 100);
            this.mrcTareas.TabIndex = 8;
            this.mrcTareas.TabStop = false;
            this.mrcTareas.Text = "Tareas";
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Location = new System.Drawing.Point(135, 58);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(63, 19);
            this.chkDebate.TabIndex = 3;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkNotas_reuniones
            // 
            this.chkNotas_reuniones.AutoSize = true;
            this.chkNotas_reuniones.Location = new System.Drawing.Point(6, 56);
            this.chkNotas_reuniones.Name = "chkNotas_reuniones";
            this.chkNotas_reuniones.Size = new System.Drawing.Size(103, 19);
            this.chkNotas_reuniones.TabIndex = 2;
            this.chkNotas_reuniones.Text = "Notas reuniòn";
            this.chkNotas_reuniones.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Location = new System.Drawing.Point(135, 33);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(98, 19);
            this.chkInvestigacion.TabIndex = 1;
            this.chkInvestigacion.Text = "Investigación";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkRepositorio
            // 
            this.chkRepositorio.AutoSize = true;
            this.chkRepositorio.Location = new System.Drawing.Point(6, 33);
            this.chkRepositorio.Name = "chkRepositorio";
            this.chkRepositorio.Size = new System.Drawing.Size(89, 19);
            this.chkRepositorio.TabIndex = 0;
            this.chkRepositorio.Text = "Repositorio";
            this.chkRepositorio.UseVisualStyleBackColor = true;
            this.chkRepositorio.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabar.Location = new System.Drawing.Point(140, 339);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(84, 32);
            this.cmdGrabar.TabIndex = 9;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(23, 339);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(78, 32);
            this.cmdCancelar.TabIndex = 10;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 450);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.mrcTareas);
            this.Controls.Add(this.mrcReunion);
            this.Controls.Add(this.lblDetalle_Actividad);
            this.Controls.Add(this.lstTipo_de_Actividad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblTipo_Actividad);
            this.Controls.Add(this.txtDetalle_de_Actividad);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmRegistrar";
            this.Text = "frmRegistrar";
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.mrcReunion.ResumeLayout(false);
            this.mrcReunion.PerformLayout();
            this.mrcTareas.ResumeLayout(false);
            this.mrcTareas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtDetalle_de_Actividad;
        private System.Windows.Forms.Label lblTipo_Actividad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox lstTipo_de_Actividad;
        private System.Windows.Forms.Label lblDetalle_Actividad;
        private System.Windows.Forms.GroupBox mrcReunion;
        private System.Windows.Forms.RadioButton optno;
        private System.Windows.Forms.RadioButton optsi;
        private System.Windows.Forms.GroupBox mrcTareas;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkNotas_reuniones;
        private System.Windows.Forms.CheckBox chkInvestigacion;
        private System.Windows.Forms.CheckBox chkRepositorio;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Button cmdCancelar;
    }
}