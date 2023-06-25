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
    public partial class frmMostrar : Form

    {
        public string[,] matriztarea = new string[5, 5];
        int indiceFila, indiceColumna;

        public frmMostrar()
        {
            InitializeComponent();
        }

        private void dgvGrillaActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistrar frmRegistrar = new frmRegistrar();
            frmRegistrar.ShowDialog();
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {
            indiceColumna = 0;
            indiceFila = 0;

            while (indiceFila < matriztarea.GetLength(0))    
            {
                dgvGrillaActividades.Rows.Add(matriztarea[indiceFila, 0],
                matriztarea[indiceFila, 1],
                matriztarea[indiceFila, 2],
                matriztarea[indiceFila, 3],
                matriztarea[indiceFila, 4]);


                indiceFila++; 

            }      
          
        }

    }
}
