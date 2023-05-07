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
    public partial class Frm_Historial : Form
    {
        List<Producto> productosObtenidos = new List<Producto>();
        public Frm_Historial()
        {
            InitializeComponent();
        }

        private void Frm_Historial_Load(object sender, EventArgs e)
        {
            // Crear una lista de ventas y obtener todas las ventas realizadas desde los formularios Frm_VenderProducto y Frm_Factura
            List<Venta> ventas = new List<Venta>();
            productosObtenidos = Negocio.RetornarProductos();
            ventas.AddRange(Negocio.RetornarVentas());

            // Recorrer la lista de ventas y agregar una nueva fila al DataGridView para cada venta
            foreach (Venta venta in ventas)
            {
                foreach (Producto producto in productosObtenidos)
                {
                    // Establecer el valor de las celdas con la información correspondiente a cada venta
                    if (venta.ContieneProducto(producto) && producto.GetCantidadSeleccionada > 0)
                    {
                        dgv.Rows.Add(producto.GetNombre, venta.GetCliente, producto.GetPrecio, producto.GetDetalle,
                        producto.GetTipoDeCorte, producto.GetCantidadSeleccionada);
                    }
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Frm_SelecVendedor frmSelecVendedor = new Frm_SelecVendedor();
            frmSelecVendedor.Show();
            this.Close();
        }
    }
}

