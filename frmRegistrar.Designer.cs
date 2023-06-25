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
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.mrcReunion.SuspendLayout();
            this.mrcTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(3, 18);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 19);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // txtDetalle_de_Actividad
            // 
            this.txtDetalle_de_Actividad.Location = new System.Drawing.Point(180, 126);
            this.txtDetalle_de_Actividad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDetalle_de_Actividad.Name = "txtDetalle_de_Actividad";
            this.txtDetalle_de_Actividad.Size = new System.Drawing.Size(160, 22);
            this.txtDetalle_de_Actividad.TabIndex = 1;
            // 
            // lblTipo_Actividad
            // 
            this.lblTipo_Actividad.AutoSize = true;
            this.lblTipo_Actividad.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo_Actividad.Location = new System.Drawing.Point(3, 69);
            this.lblTipo_Actividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo_Actividad.Name = "lblTipo_Actividad";
            this.lblTipo_Actividad.Size = new System.Drawing.Size(117, 19);
            this.lblTipo_Actividad.TabIndex = 2;
            this.lblTipo_Actividad.Text = "Tipo Actividad";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(75, 14);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(265, 22);
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
            this.lstTipo_de_Actividad.Location = new System.Drawing.Point(180, 70);
            this.lstTipo_de_Actividad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTipo_de_Actividad.Name = "lstTipo_de_Actividad";
            this.lstTipo_de_Actividad.Size = new System.Drawing.Size(160, 24);
            this.lstTipo_de_Actividad.TabIndex = 5;
            this.lstTipo_de_Actividad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDetalle_Actividad
            // 
            this.lblDetalle_Actividad.AutoSize = true;
            this.lblDetalle_Actividad.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle_Actividad.Location = new System.Drawing.Point(3, 129);
            this.lblDetalle_Actividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalle_Actividad.Name = "lblDetalle_Actividad";
            this.lblDetalle_Actividad.Size = new System.Drawing.Size(135, 19);
            this.lblDetalle_Actividad.TabIndex = 6;
            this.lblDetalle_Actividad.Text = "Detalle actividad";
            // 
            // mrcReunion
            // 
            this.mrcReunion.Controls.Add(this.optno);
            this.mrcReunion.Controls.Add(this.optsi);
            this.mrcReunion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcReunion.Location = new System.Drawing.Point(7, 172);
            this.mrcReunion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcReunion.Name = "mrcReunion";
            this.mrcReunion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcReunion.Size = new System.Drawing.Size(333, 71);
            this.mrcReunion.TabIndex = 7;
            this.mrcReunion.TabStop = false;
            this.mrcReunion.Text = "Reunion";
            // 
            // optno
            // 
            this.optno.AutoSize = true;
            this.optno.Location = new System.Drawing.Point(192, 36);
            this.optno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optno.Name = "optno";
            this.optno.Size = new System.Drawing.Size(51, 23);
            this.optno.TabIndex = 1;
            this.optno.TabStop = true;
            this.optno.Text = "No";
            this.optno.UseVisualStyleBackColor = true;
            // 
            // optsi
            // 
            this.optsi.AutoSize = true;
            this.optsi.Location = new System.Drawing.Point(55, 36);
            this.optsi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optsi.Name = "optsi";
            this.optsi.Size = new System.Drawing.Size(45, 23);
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
            this.mrcTareas.Location = new System.Drawing.Point(7, 265);
            this.mrcTareas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcTareas.Name = "mrcTareas";
            this.mrcTareas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcTareas.Size = new System.Drawing.Size(333, 123);
            this.mrcTareas.TabIndex = 8;
            this.mrcTareas.TabStop = false;
            this.mrcTareas.Text = "Tareas";
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Location = new System.Drawing.Point(180, 71);
            this.chkDebate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(82, 23);
            this.chkDebate.TabIndex = 3;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkNotas_reuniones
            // 
            this.chkNotas_reuniones.AutoSize = true;
            this.chkNotas_reuniones.Location = new System.Drawing.Point(8, 69);
            this.chkNotas_reuniones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNotas_reuniones.Name = "chkNotas_reuniones";
            this.chkNotas_reuniones.Size = new System.Drawing.Size(135, 23);
            this.chkNotas_reuniones.TabIndex = 2;
            this.chkNotas_reuniones.Text = "Notas reuniòn";
            this.chkNotas_reuniones.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Location = new System.Drawing.Point(180, 41);
            this.chkInvestigacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(130, 23);
            this.chkInvestigacion.TabIndex = 1;
            this.chkInvestigacion.Text = "Investigación";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkRepositorio
            // 
            this.chkRepositorio.AutoSize = true;
            this.chkRepositorio.Location = new System.Drawing.Point(8, 41);
            this.chkRepositorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRepositorio.Name = "chkRepositorio";
            this.chkRepositorio.Size = new System.Drawing.Size(120, 23);
            this.chkRepositorio.TabIndex = 0;
            this.chkRepositorio.Text = "Repositorio";
            this.chkRepositorio.UseVisualStyleBackColor = true;
            this.chkRepositorio.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabar.Location = new System.Drawing.Point(187, 417);
            this.cmdGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(112, 39);
            this.cmdGrabar.TabIndex = 9;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(31, 417);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(104, 39);
            this.cmdCancelar.TabIndex = 10;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMostrar.Location = new System.Drawing.Point(99, 477);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(133, 33);
            this.cmdMostrar.TabIndex = 12;
            this.cmdMostrar.Text = "Ver Grilla";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 554);
            this.Controls.Add(this.cmdMostrar);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Button cmdMostrar;
    }
}