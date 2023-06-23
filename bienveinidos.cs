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
    public partial class bienveinidos : Form
    {
        public bienveinidos()
        {
            InitializeComponent();
        }

        private void cmd_comenzar_Click(object sender, EventArgs e)
        {
            frmRegistrar registrar = new frmRegistrar();
            registrar.ShowDialog(); 
        }

        private void cmd_Volver_Click(object sender, EventArgs e)
        {
            frmMain volver = new frmMain();
            volver.ShowDialog();    
        }
    }
}
