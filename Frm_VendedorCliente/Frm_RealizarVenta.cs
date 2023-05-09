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
                dgv.Rows.Add(producto.GetNombre, producto.GetStock, producto.GetPrecio, producto.GetDetalle, producto.GetTipoDeCorte, 0);
            }
        }
        private void Frm_RealizarVenta_Load(object sender, EventArgs e)
        {
            //primero cargo la lista 
            Negocio.CargarClientes();
            List<Cliente> clientes = Negocio.RetornarClientes();
            //agrego los clientes al combobox 
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
        {
            //verifica si se edito la columna cantidad 
            if (e.ColumnIndex == dgv.Columns["cantidadComprada"].Index)
            {
                int rowIndex = e.RowIndex;
                float nuevoValor = Convert.ToSingle(dgv.Rows[rowIndex].Cells["cantidadComprada"].Value);

                if (nuevoValor > 0)
                {
                    // buscar el producto correspondiente a la fila editada
                    string nombreProducto = dgv.Rows[rowIndex].Cells["nombre"].Value.ToString();
                    Producto productoEnLista = listaDeProductos.Find(p => p.GetNombre == nombreProducto);
                    Producto productoSeleccionado = productosSeleccionados.Find(p => p.GetNombre == nombreProducto);

                    // actualizar la cantidad seleccionada y el stock del producto correspondiente
                    productoEnLista.SetCantidadSeleccionada = nuevoValor;
                    productoSeleccionado.SetCantidadSeleccionada = nuevoValor;
                    productoEnLista.SetStock = productoEnLista.GetStock - nuevoValor;

                    // buscar la fila correspondiente al producto utilizando el objeto Producto
                    int rowIndexStock = dgv.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells["nombre"].Value.ToString() == nombreProducto)?.Index ?? -1;
                    if (rowIndexStock >= 0)
                    {
                        dgv.Rows[rowIndexStock].Cells["stock"].Value = productoEnLista.GetStock;
                        dgv.Refresh();
                    }
                }
            }
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            List<Producto> listaCompra = new List<Producto>();
            Cliente clienteSeleccionado = Negocio.RetornarClientes()[cbClientes.SelectedIndex];
            Vendedor vendedor = new Vendedor("vendedor@gmail.com","contraseñaVendedor1",2042684,"Juan Perez");
            string clienteSelecString = clienteSeleccionado.GetNombre;
            float precioTotalConRecargo = 0;
            DialogResult confirmarVenta;

            foreach (Producto producto in productosSeleccionados)
            {
                if (producto.GetCantidadSeleccionada > 0 && producto.GetCantidadSeleccionada != null)
                {
                    listaCompra.Add(producto);
                }
            }
            float precioTotal = Vendedor.CalcularMonto(listaCompra); ;
            confirmarVenta = MessageBox.Show("¿Desea confirmar la venta?", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            foreach (Producto producto in listaCompra)
            {
                if (producto.GetStock > 0 && producto.GetCantidadSeleccionada < producto.GetStock)
                {
                    if (confirmarVenta == DialogResult.Yes)
                    {
                        if (clienteSeleccionado.GetMetodoPago == eMetodoPago.Tarjeta_de_credito)
                        {
                            precioTotalConRecargo = precioTotal * 1.05f;
                            Frm_VenderProducto frmVentas = new Frm_VenderProducto(listaCompra, clienteSelecString, precioTotal, precioTotalConRecargo,vendedor.GetCodigo,vendedor.GetNombreVendedor);
                            frmVentas.ShowDialog();
                        }
                        else
                        {
                            Frm_VenderProducto frmVentas = new Frm_VenderProducto(listaCompra, clienteSelecString, precioTotal, precioTotal,vendedor.GetCodigo,vendedor.GetNombreVendedor);
                            frmVentas.ShowDialog();
                        }
                        //verifico si el cliente tiene monto para comprar 
                        if (precioTotal > clienteSeleccionado.GetMontoDisponible)
                        {
                            MessageBox.Show("El valor total de los productos seleccionados supera el monto a gastar del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            clienteSeleccionado.SetMontoDisponible = clienteSeleccionado.GetMontoDisponible - producto.GetPrecio;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock para realizar la venta.");
                }
            }
            
            txtInfoMonto.Text = clienteSeleccionado.GetMontoDisponible.ToString();
            Venta venta = new Venta(listaCompra, clienteSelecString, precioTotal);
            Negocio.CargarVentas(venta);
            foreach (Producto producto in listaCompra)
            {
                producto.SetCantidadSeleccionada = 0;
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Frm_SelecVendedor frmMenuSelec = new Frm_SelecVendedor();
            frmMenuSelec.Show();
            this.Close();
        }
    }
}
