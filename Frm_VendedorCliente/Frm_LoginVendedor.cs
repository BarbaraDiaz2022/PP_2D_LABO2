using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_VendedorCliente
{
    public partial class Frm_LoginVendedor : Form
    {
        public Frm_LoginVendedor()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            SoundPlayer sonidoLogueo = new SoundPlayer();
            sonidoLogueo.SoundLocation = "C:/Users/GAMER ASUS/Downloads/logueo_1.wav";
            sonidoLogueo.Play();
            string mail = this.txtMail.Text;
            string password = this.txtPassword.Text;
            bool vendedorReal = UsuariosDAO.ValidarVendedores(mail,password);

            if (vendedorReal)
            {
                Frm_SelecVendedor frmSeleccionarOpcion = new Frm_SelecVendedor();
                frmSeleccionarOpcion.Show();
                //string mensaje = Vendedor.RetornarSaludo();
                //MessageBox.Show(mensaje, "Bienvenido", MessageBoxButtons.OK);
                this.Hide();
            }
            else
            {
                MessageBox.Show("El correo o la contraseña no son correctos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Frm_LoginVendedor frm = new Frm_LoginVendedor();
                frm.Show();
                if (rdbAcceder.Checked)
                {
                    txtMail.Text = mail;
                    txtPassword.Text = password;
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
            txtMail.Text = "vendedor1@gmail.com";
            txtPassword.Text = "contraseñaVendedor1";
        }
    }


}
