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
//        private const string ususarioClienteReal = "cliente@gmail.com";
//       private const string passwordClienteReal = "cliente123";
        public Frm_LoginVendedor()
        {
            //cargo en los textbox los valores hardcodeados
            InitializeComponent();
            textBox1.Text = usuarioVendedorReal;
            textBox2.Text = passwordVendedorReal;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = this.textBox1.Text;
            string password = this.textBox2.Text;

            if (usuario == usuarioVendedorReal && password == passwordVendedorReal)
            {
                MessageBox.Show("entro el vendedor");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }


}
