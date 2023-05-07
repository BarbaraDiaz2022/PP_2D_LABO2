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
    public partial class Frm_SelecVendedor : Form
    {
        public Frm_SelecVendedor()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Frm_LoginVendedor frmLogin = new Frm_LoginVendedor();
            frmLogin.Show();
            this.Close();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Frm_Historial frmHistorial = new Frm_Historial();
            frmHistorial.Show();
            this.Close();
        }

        private void btnHeladera_Click(object sender, EventArgs e)
        {
            Frm_Heladera frmHeladera = new Frm_Heladera();
            frmHeladera.Show();
            this.Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Frm_RealizarVenta frmVender = new Frm_RealizarVenta();
            frmVender.Show();
            this.Close();
        }
    }
}
