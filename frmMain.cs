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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mrcLogin_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkCondicional_CheckedChanged(object sender, EventArgs e)
        {
            frmUsuariosRegistrados frmUsuariosRegistrados = new frmUsuariosRegistrados();
            frmUsuariosRegistrados.ShowDialog();
            
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar frmRegistrar = new frmRegistrar();
            frmRegistrar.ShowDialog();
        }
    }
}
