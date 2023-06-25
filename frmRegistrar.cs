using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestion
{
    public partial class frmRegistrar : Form

    {
        //zona de declaracion de variables globales 
        string datoconcatenar;
        string[] vectorActividad = new string[5];
        string[] VectorRegistroActividad = new string[4];
        readonly int indiceRegistro = 0;
        frmMostrar ventanaMostrar = new frmMostrar();
        int indiceFilaRegistro;
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
           
                
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string varTareas = "";
            string varReuniones = "";
            if (dtpFecha.Value >= DateTime.Today)
            {
                if (lstTipo_de_Actividad.SelectedIndex != -1 )

                {
                    if (txtDetalle_de_Actividad.Text != "")
                    {
                        MessageBox.Show("vamos a grabar");

                        if (optsi.Checked == true)
                        {
                            varReuniones = "si";
                        }
                        else
                        {
                            varReuniones = "no";
                        }
                        if (chkDebate.Checked)
                        {
                            varTareas = "debate, ";
                        }
                        if (chkInvestigacion.Checked)
                        {
                            varTareas = varTareas + "investigacion, ";
                        }
                        if (chkNotas_reuniones.Checked)
                            varTareas = varTareas + "notas, ";
                        if (chkRepositorio.Checked)
                            varTareas = varTareas + "repositorio , ";
                    }

                    ventanaMostrar.matriztarea[indiceFilaRegistro, 0] = dtpFecha.Value.ToString();
                    ventanaMostrar.matriztarea[indiceFilaRegistro, 1] = lstTipo_de_Actividad.Text;
                    ventanaMostrar.matriztarea[indiceFilaRegistro, 2] = txtDetalle_de_Actividad.Text;
                    ventanaMostrar.matriztarea[indiceFilaRegistro, 3] = varReuniones;
                    ventanaMostrar.matriztarea[indiceFilaRegistro, 4] = varTareas;



                    indiceFilaRegistro++;

                    if (indiceFilaRegistro == ventanaMostrar.matriztarea.GetLength(0))
                    {
                        cmdGrabar.Enabled = false;
                    }

                    else
                    {
                        MessageBox.Show("te falta completar el detalle");
                        txtDetalle_de_Actividad.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("te falta completar tipo de actividad");
                    txtDetalle_de_Actividad.Focus();
                }
            }
            else
            {
                MessageBox.Show("seleccione una fecha posterior a la actual","carga de tareas",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            ventanaMostrar.ShowDialog();
            this.Hide();
        }
    }
}
