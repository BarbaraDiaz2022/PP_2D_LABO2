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
                if (nuevoValor > 0 && nuevoValor != null)
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
            float montoConRecargo = 0;
            float montoMax = float.Parse(txtMonto.Text);
            string nombre = txtNombreCliente.Text.ToString();
            bool compraRealizada = false;
            DialogResult confirmarVenta;
            List<Producto> listaCompra = new List<Producto>();
            foreach (Producto producto in productosSeleccionados)
            {
                if (producto.GetCantidadSeleccionada > 0 && producto.GetCantidadSeleccionada != null)
                {
                    listaCompra.Add(producto);
                }
            }
            float montoTotal = Vendedor.CalcularMonto(listaCompra);
            foreach (Producto productoCompra in listaCompra)
            {
                if (productoCompra.GetStock > 0)
                {
                    if (montoMax >= montoTotal)
                    {
                        confirmarVenta = MessageBox.Show("¿Desea confirmar la compra?", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmarVenta == DialogResult.Yes)
                        {
                            if (cbMetodoPago.SelectedItem.ToString() == "Tarjeta de crédito")
                            {
                                montoConRecargo = montoTotal * 1.05f;
                                Frm_Factura frmFactura = new Frm_Factura(listaCompra, montoConRecargo, cbMetodoPago.SelectedItem.ToString(),montoTotal);
                                frmFactura.ShowDialog();
                            }
                            else 
                            {
                                Frm_Factura frmFactura = new Frm_Factura(listaCompra, montoTotal, cbMetodoPago.SelectedItem.ToString(), montoTotal);
                                frmFactura.ShowDialog();
                            }
                            //actualizo el stock
                            Producto productoEnLista = listaDeProductos.Find(p => p.GetNombre == productoCompra.GetNombre && p.GetCantidadSeleccionada == productoCompra.GetCantidadSeleccionada);
                            productoEnLista.SetStock -= productoCompra.GetCantidadSeleccionada;
                            int rowIndex = listaDeProductos.IndexOf(productoEnLista);
                            dgv.Rows[rowIndex].Cells["stockProducto"].Value = productoEnLista.GetStock;
                            dgv.Refresh();
                        }
                        compraRealizada = true;
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
            //añado la venta a la lista para el historial 
            Venta venta = new Venta(listaCompra, nombre, montoTotal);
            Negocio.CargarVentas(venta);
            if (cbMetodoPago.SelectedItem.ToString() == "Tarjeta de crédito" && compraRealizada)
            {
                txtMonto.Text = (montoMax - montoConRecargo).ToString();
            }
            else 
            {
                if (compraRealizada)
                {
                    txtMonto.Text = (montoMax - montoTotal).ToString();
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Frm_LoginCliente frm = new Frm_LoginCliente();
            frm.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = cbBuscarCorte.SelectedItem.ToString();
            List<Producto> productosEncontrados = Negocio.BuscarPorCorte(textoBusqueda);
            dgv.Rows.Clear();
            CargarDataGridView(productosEncontrados);

            if (cbBuscarCorte.SelectedItem.ToString() == "Mostrar todos los cortes")
            {
                CargarDataGridView(listaDeProductos);
                //devuelve el control al codigo que lo llamo asi no carga el dgv 2 veces 
                return;
            }
        }
    }
}
