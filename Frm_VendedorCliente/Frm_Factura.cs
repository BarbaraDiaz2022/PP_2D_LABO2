using BibliotecaDeClases;
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
    public partial class Frm_Factura : Form
    {
        List<Producto> listaDeProductosSeleccionados;
        float montoTotal;
        string metodoDePago;
        public Frm_Factura(List<Producto> listaDeProductosSeleccionados, float montoTotal, string metodoDePago)
        {
            InitializeComponent();
            this.listaDeProductosSeleccionados = listaDeProductosSeleccionados;
            this.montoTotal = montoTotal;
            this.metodoDePago = metodoDePago;
        }
        private void Frm_Factura_Load(object sender, EventArgs e)
        {
            lblInfoPago.Text = metodoDePago;
            lblTotal.Text = montoTotal.ToString("C2");//"C2" formatea el valor como moneda con dos decimales
            //recorrer la lista de productos seleccionados
            foreach (Producto producto in listaDeProductosSeleccionados)
            {  //solo agrego al dgv los productos seleccionados que recibi
                int rowIndex = dgv.Rows.Add();
                DataGridViewRow row = dgv.Rows[rowIndex];

                row.Cells["nombre"].Value = producto.GetNombre;
                row.Cells["precio"].Value = producto.GetPrecio.ToString("C2");
                row.Cells["detalle"].Value = producto.GetDetalle;
                row.Cells["tipoDeCorte"].Value = producto.GetTipoDeCorte;
                row.Cells["cantidadComprada"].Value = producto.GetCantidadSeleccionada;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
