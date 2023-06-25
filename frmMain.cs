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
            
            
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (txtGmail.Text != "1")
            {
                MessageBox.Show("Gmail incorrecto");
            }
            if (txtNombre.Text != "2")
            {
                MessageBox.Show("Nombre Incorrecto");
            }
            if (txtApellido.Text != "3")
            {
                MessageBox.Show("Apellido incorrecto");
            }
            if (txtContraseña.Text != "5")
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
            if (txtConfirmarContraseña.Text != ("4") )
            {
                MessageBox.Show("La contraseña debe ser igual");
            }
            if (txtNombreDeUsuario.Text != "6")
            {
                MessageBox.Show("el nombre de usuario es incorrecto");
            }
            else
            {
                bienveinidos bienveinidos = new bienveinidos();
                bienveinidos.ShowDialog();
            }
           ;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            {

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
            
                
                
        }

        private void lblNombre_de_Usuario_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
