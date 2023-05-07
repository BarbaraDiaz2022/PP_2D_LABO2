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
    public partial class Frm_RealizarVenta : Form
    {
        List<Producto> listaDeProductos;
        List<Producto> productosSeleccionados;
        public Frm_RealizarVenta()
        {
            InitializeComponent();
            this.listaDeProductos = Negocio.RetornarProductos();//productos disponibles en la tienda 
            this.productosSeleccionados = new List<Producto>();//productos que el cliente selecciona para comprar
        }
        public void CargarDataGridView(List<Producto> listaDeProductos)
        {
            foreach (Producto producto in listaDeProductos)
            {
                dgv.Rows.Add(producto.GetNombre, producto.GetStock, producto.GetPrecio, producto.GetDetalle, producto.GetTipoDeCorte, producto.GetCantidadSeleccionada);
            }
        }
        private void Frm_RealizarVenta_Load(object sender, EventArgs e)
        {
            // Cargar la lista de clientes
            Negocio.CargarClientes();
            // Obtener la lista de clientes
            List<Cliente> clientes = Negocio.RetornarClientes();
            // Agregar los nombres de los clientes al ComboBox
            foreach (Cliente cliente in clientes)
            {
                cbClientes.Items.Add(cliente.GetNombre);
            }
            CargarDataGridView(Negocio.RetornarProductos());
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                // obtener el producto seleccionado
                Producto producto = new Producto(row.Cells["nombre"].Value.ToString(),
                    Convert.ToInt32(row.Cells["stock"].Value),
                    Convert.ToSingle(row.Cells["precio"].Value),
                    row.Cells["detalle"].Value.ToString(),
                    row.Cells["tipoCorte"].Value.ToString(),
                    Convert.ToSingle(row.Cells["cantidadComprada"].Value));
                // agregar el producto seleccionado a la lista
                if (row.Selected)
                {
                    if (productosSeleccionados.Contains(producto))
                    {
                        productosSeleccionados.Remove(producto);
                    }
                    else
                    {
                        productosSeleccionados.Add(producto);
                    }
                }
            }
        }
        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {   //verifica si se edito la columna cantidad 
            if (e.ColumnIndex == dgv.Columns["cantidadComprada"].Index)
            {
                int rowIndex = e.RowIndex;
                float nuevoValor = Convert.ToSingle(dgv.Rows[rowIndex].Cells["cantidadComprada"].Value); // obtiene el nuevo valor de la celda
                if (nuevoValor > 0)
                {   //actualiza el valor de lista de productos
                    listaDeProductos[rowIndex].SetCantidadSeleccionada = nuevoValor;
                    // busca el producto en productosSeleccionados por su nombre
                    Producto productoSeleccionado = productosSeleccionados.Find(p => p.GetNombre == dgv.Rows[rowIndex].Cells["nombre"].Value.ToString());
                    // actualiza la propiedad CantidadSeleccionada del producto correspondiente
                    if (productoSeleccionado != null)
                    {
                        productoSeleccionado.SetCantidadSeleccionada = nuevoValor;
                    }
                }
            }
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            string clienteSeleccionado = cbClientes.Text.ToString();
            DialogResult confirmarVenta;
            List<Producto> listaCompra = new List<Producto>();
            List<Cliente> auxCliente = new List<Cliente>();

            foreach (Producto producto in productosSeleccionados)
            {
                if (producto.GetCantidadSeleccionada > 0 && producto.GetCantidadSeleccionada != null)
                {
                    listaCompra.Add(producto);
                }
            }

            confirmarVenta = MessageBox.Show("¿Desea confirmar la venta?", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            foreach (Producto producto in listaCompra)
            {
                if (producto.GetStock > 0 && producto.GetCantidadSeleccionada < producto.GetStock)
                {
                    if (confirmarVenta == DialogResult.Yes)
                    {
                        //actualizo el stock 
                        Producto productoEnLista = listaDeProductos.Find(p => p.GetNombre == producto.GetNombre);
                        productoEnLista.SetStock -= producto.GetCantidadSeleccionada;
                        int rowIndex = listaDeProductos.IndexOf(productoEnLista);
                        dgv.Rows[rowIndex].Cells["stock"].Value = productoEnLista.GetStock;
                        dgv.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock para realizar la venta.");
                }
            }
            Venta venta = new Venta(listaCompra, clienteSeleccionado);//añade la venta a la lista para el historrial
            Negocio.CargarVentas(venta);
            Frm_VenderProducto frmVentas = new Frm_VenderProducto(listaCompra, clienteSeleccionado);
            frmVentas.Show();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Frm_SelecVendedor frmMenuSelec = new Frm_SelecVendedor();
            frmMenuSelec.Show();
            this.Close();
        }
    }
}
