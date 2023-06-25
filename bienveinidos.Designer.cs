namespace pryGestion
{
    partial class bienveinidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_Volver = new System.Windows.Forms.Button();
            this.cmd_comenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "bienvenidos ";
            // 
            // cmd_Volver
            // 
            this.cmd_Volver.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Volver.Location = new System.Drawing.Point(189, 170);
            this.cmd_Volver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmd_Volver.Name = "cmd_Volver";
            this.cmd_Volver.Size = new System.Drawing.Size(144, 42);
            this.cmd_Volver.TabIndex = 2;
            this.cmd_Volver.Text = "volver";
            this.cmd_Volver.UseVisualStyleBackColor = true;
            this.cmd_Volver.Click += new System.EventHandler(this.cmd_Volver_Click);
            // 
            // cmd_comenzar
            // 
            this.cmd_comenzar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_comenzar.Location = new System.Drawing.Point(37, 170);
            this.cmd_comenzar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmd_comenzar.Name = "cmd_comenzar";
            this.cmd_comenzar.Size = new System.Drawing.Size(144, 42);
            this.cmd_comenzar.TabIndex = 3;
            this.cmd_comenzar.Text = "comenzar";
            this.cmd_comenzar.UseVisualStyleBackColor = true;
            this.cmd_comenzar.Click += new System.EventHandler(this.cmd_comenzar_Click);
            // 
            // bienveinidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 338);
            this.Controls.Add(this.cmd_comenzar);
            this.Controls.Add(this.cmd_Volver);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "bienveinidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "bienveinidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_Volver;
        private System.Windows.Forms.Button cmd_comenzar;
    }
}