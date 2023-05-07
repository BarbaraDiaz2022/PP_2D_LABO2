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
    public partial class Frm_Ventas : Form
    {
        List<Producto> listaDeProductos;
        List<Producto> productosSeleccionados;

        public Frm_Ventas()
        {
            InitializeComponent();
            this.listaDeProductos = Negocio.RetornarProductos();//productos disponibles en la tienda 
            this.productosSeleccionados = new List<Producto>();//productos que el cliente selecciona para comprar
        }
        public void CargarDataGridView(List<Producto> listaDeProductos)
        {
            foreach (Producto producto in listaDeProductos)
            {
                dgv.Rows.Add(producto.GetNombre, producto.GetStock, producto.GetPrecio, producto.GetDetalle, producto.GetTipoDeCorte);
            }
        }
        private void Frm_Ventas_Load(object sender, EventArgs e)
        {
            CargarDataGridView(Negocio.RetornarProductos());
        }
        public float CalcularMonto()
        {
            float montoTotal = 0;
            foreach (Producto producto in productosSeleccionados)
            {
                montoTotal += producto.GetPrecio * producto.GetCantidadSeleccionada;
            }
            return montoTotal;
        }
        private bool listaCargada = false;
        private void rbBuscar_CheckedChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text;
            List<Producto> productosEncontrados = Negocio.BuscarPorCorte(textoBusqueda);
            if (string.IsNullOrEmpty(textoBusqueda) || productosEncontrados.Count == 0)
            {   //si la lista no fue cargada, la cargo 
                if (!listaCargada)
                {
                    CargarDataGridView(productosEncontrados);
                    listaCargada = true;
                }
            }
            else
            {
                dgv.Rows.Clear();
                CargarDataGridView(productosEncontrados);
                //indico que la lista ya no esta cargada
                listaCargada = false;
            }
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                // obtener el producto seleccionado
                Producto producto = new Producto(row.Cells["nombreProducto"].Value.ToString(),
                    Convert.ToInt32(row.Cells["stockProducto"].Value),
                    Convert.ToSingle(row.Cells["precio"].Value),
                    row.Cells["detalle"].Value.ToString(),
                    row.Cells["tipoDeCorte"].Value.ToString(),
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
        {
            if (e.ColumnIndex == dgv.Columns["cantidadComprada"].Index) // verifica si se editó la columna "cantidadComprada"
            {
                int rowIndex = e.RowIndex;
                float nuevoValor = Convert.ToSingle(dgv.Rows[rowIndex].Cells["cantidadComprada"].Value); // obtiene el nuevo valor de la celda
                if (nuevoValor > 0)
                {   //actualiza el valor de la lista de productos correspondientes
                    listaDeProductos[rowIndex].SetCantidadSeleccionada = nuevoValor;
                    // busca el producto en productosSeleccionados por su nombre
                    Producto productoSeleccionado = productosSeleccionados.Find(p => p.GetNombre == dgv.Rows[rowIndex].Cells["nombreProducto"].Value.ToString());
                    // actualiza la propiedad CantidadSeleccionada del producto correspondiente
                    if (productoSeleccionado != null)
                    {
                        productoSeleccionado.SetCantidadSeleccionada = nuevoValor;
                    }
                }
            }
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            float montoTotal = CalcularMonto();
            float montoMax = float.Parse(txtMonto.Text);
            DialogResult confirmarVenta;
            List<Producto> listaCompra = new List<Producto>();
            foreach (Producto producto in productosSeleccionados)
            {
                if (producto.GetCantidadSeleccionada > 0 && producto.GetCantidadSeleccionada != null)
                {
                    listaCompra.Add(producto);
                }
            }
            foreach (Producto productoCompra in listaCompra)
            {
                if (productoCompra.GetStock > 0)
                {
                    if (montoMax >= productoCompra.GetPrecio)
                    {
                        confirmarVenta = MessageBox.Show("¿Desea confirmar la compra?", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmarVenta == DialogResult.Yes)
                        {
                            if (cbMetodoPago.SelectedItem.ToString() == "Tarjeta de crédito")
                            {
                                float montoConRecargo = montoTotal * 1.05f;
                                montoTotal = montoConRecargo;
                            }
                            Frm_Factura frmFactura = new Frm_Factura(listaCompra, montoTotal, cbMetodoPago.SelectedItem.ToString());
                            frmFactura.ShowDialog();
                            //actualizo el stock 
                            Producto productoEnLista = listaDeProductos.Find(p => p.GetNombre == productoCompra.GetNombre);
                            productoEnLista.SetStock -= productoCompra.GetCantidadSeleccionada;
                            int rowIndex = listaDeProductos.IndexOf(productoEnLista);
                            dgv.Rows[rowIndex].Cells["stockProducto"].Value = productoEnLista.GetStock;
                            dgv.Refresh();
                            //añado la venta a la lista para el historial 
                            Venta venta = new Venta(listaCompra, "Venta realizada por un cliente");
                            Negocio.CargarVentas(venta);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente dinero para realizar esta compra.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No hay stock disponible.");
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Frm_LoginCliente frm = new Frm_LoginCliente();
            frm.Show();
            this.Close();
        }
    }
}
