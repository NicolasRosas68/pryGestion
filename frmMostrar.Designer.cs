namespace pryGestion
{
    partial class frmMostrar
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvGrillaActividades = new System.Windows.Forms.DataGridView();
            this.clumnafecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvGrillaActividades
            // 
            this.dgvGrillaActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clumnafecha,
            this.Actividad,
            this.Detalle});
            this.dgvGrillaActividades.Location = new System.Drawing.Point(27, 36);
            this.dgvGrillaActividades.Name = "dgvGrillaActividades";
            this.dgvGrillaActividades.RowHeadersWidth = 51;
            this.dgvGrillaActividades.RowTemplate.Height = 24;
            this.dgvGrillaActividades.Size = new System.Drawing.Size(426, 174);
            this.dgvGrillaActividades.TabIndex = 4;
            this.dgvGrillaActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrillaActividades_CellContentClick);
            // 
            // clumnafecha
            // 
            this.clumnafecha.HeaderText = "Fecha";
            this.clumnafecha.MinimumWidth = 6;
            this.clumnafecha.Name = "clumnafecha";
            this.clumnafecha.Width = 125;
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "Tipo de Actividad";
            this.Actividad.MinimumWidth = 6;
            this.Actividad.Name = "Actividad";
            this.Actividad.Width = 125;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Descripcion";
            this.Detalle.MinimumWidth = 6;
            this.Detalle.Name = "Detalle";
            this.Detalle.Width = 125;
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 317);
            this.Controls.Add(this.dgvGrillaActividades);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMostrar";
            this.Load += new System.EventHandler(this.frmMostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaActividades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvGrillaActividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn clumnafecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
    }
}