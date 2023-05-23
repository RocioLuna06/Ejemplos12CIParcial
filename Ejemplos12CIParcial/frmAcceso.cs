using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplos12CIParcial
{
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombreUser.Text == "Supervisor" & txtPassword.Text == "456")
            {
                MessageBox.Show("Bienvenido", "Medikalsystem23");
                //comentarios aqui explique
                // usamos codigo de C# instrucciones If
                this.Hide();
                frmMenuPrincipal frm = new frmMenuPrincipal();
                frm.Show();
                txtNombreUser.BackColor = Color.White;
                txtPassword.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrectos", "Medykalsystem23");
                txtNombreUser.Text = "";
                txtPassword.Text = "";
                txtNombreUser.Focus();
                txtNombreUser.BackColor = Color.Violet;
                txtPassword.BackColor = Color.Violet;

            }
        }
     

    }
}
