using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_VendedorCliente
{
    public partial class Frm_LoginVendedor : Form
    {
        //hardcodeo el ingreso del vendedor
        private const string usuarioVendedorReal = "vendedor@gmail.com";
        private const string passwordVendedorReal = "vendedor123";
        public Frm_LoginVendedor()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = this.txtMail.Text;
            string password = this.txtPassword.Text;

            this.Hide();

            if (usuario == usuarioVendedorReal && password == passwordVendedorReal)
            {
                Frm_SelecVendedor frmSeleccionarOpcion = new Frm_SelecVendedor();
                frmSeleccionarOpcion.Show();
            }
            else
            {
                MessageBox.Show("El correo o la contraseña no son correctos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Frm_LoginVendedor frm = new Frm_LoginVendedor();
                frm.Show();
                if (rdbAcceder.Checked)
                {
                    txtMail.Text = usuarioVendedorReal;
                    txtPassword.Text = passwordVendedorReal;
                }
                else
                {
                    txtMail.Text = "";
                    txtPassword.Text = "";
                }
                txtMail.Focus();
            }
        }
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //cargo en los textbox los valores hardcodeados
            txtMail.Text = usuarioVendedorReal;
            txtPassword.Text = passwordVendedorReal;
        }
    }


}
