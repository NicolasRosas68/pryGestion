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
            if (dateTimePicker1.Value >= DateTime.Today)

            {
                if (comboBox1.SelectedIndex != -1 )

                {
                    if (txtDetalle_de_Actividad.Text != "")
                    {
                        MessageBox.Show("te falta completar el detalle");
                        txtDetalle_de_Actividad.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("te falta completar detalle");
                    txtDetalle_de_Actividad.Focus();
                }
            }
            else
            {
                MessageBox.Show("seleccione una fecha posterior a la actual","carga de tareas",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                dateTimePicker1.Value = DateTime.Today;
                dateTimePicker1.Focus();
            }
        }
    }
}
