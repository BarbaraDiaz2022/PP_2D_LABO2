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
    public partial class Frm_RealizarVenta : Form
    {
        List<Producto> listaDeProductos;
        List<Producto> productosSeleccionados;
        public Frm_RealizarVenta()
        {
            InitializeComponent();
            this.listaDeProductos = Negocio.RetornarProductos();//productos disponibles en la tienda 
            this.productosSeleccionados = new List<Producto>();//productos que el vendedor selecciona para vender
            cbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void CargarDataGridView()
        {
            foreach (Producto producto in listaDeProductos)
            {
                dgv.Rows.Add(producto.GetNombre, producto.GetStock, producto.GetPrecio, producto.GetDetalle, producto.GetTipoDeCorte, 0);
            }
        }
        private void Frm_RealizarVenta_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                //primero cargo la lista 
                List<Cliente> clientes = Negocio.RetornarClientes();
                //verifico si el cmb esta vacio 
                if (cbClientes.Items.Count == 0)
                {
                    //agrego los clientes al combobox 
                    foreach (Cliente cliente in clientes)
                    {
                        cbClientes.Items.Add(cliente.GetNombre);
                    }
                }

                CargarDataGridView();
            }
        }
        private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewColumn columnaActual = dgv.Columns[e.ColumnIndex];
            //solo permite editar la columna de la cantidad 
            if (columnaActual.Name == "cantidadComprada")
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //verifico si se editó la columna "cantidadComprada"
            if (e.ColumnIndex == dgv.Columns["cantidadComprada"].Index)
            {   //obtengo el valor de la celda como cadena de texto 
                int rowIndex = e.RowIndex;
                string nuevoValorString = dgv.Rows[rowIndex].Cells["cantidadComprada"].Value.ToString();
                if (float.TryParse(nuevoValorString, out float nuevoValor) && nuevoValor > 0)
                {   //actualiza el valor de la lista de productos correspondientes
                    listaDeProductos[rowIndex].SetCantidadSeleccionada = nuevoValor;
                    //busca el producto en productosSeleccionados por su nombre
                    Producto productoSeleccionado = productosSeleccionados.Find(p => p.GetNombre == dgv.Rows[rowIndex].Cells["nombre"].Value.ToString());
                    //actualiza la cantidad seleccionada del producto correspondiente
                    if (productoSeleccionado != null)
                    {
                        productoSeleccionado.SetCantidadSeleccionada = nuevoValor;

                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad válida.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                    Cliente.ObtenerCeldaAValidar(row.Cells["cantidadComprada"].Value));
                //verifico si fue la celda cantidad
                if (dgv.CurrentCell != null && dgv.CurrentCell.ColumnIndex == dgv.Columns["cantidadComprada"].Index)
                {   //si estoy editando la celda que salga y no haga nada
                    if (dgv.IsCurrentCellInEditMode)
                    {
                        return;
                    }
                }
                //agregar el producto seleccionado a la lista
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
        private void btnVender_Click(object sender, EventArgs e)
        {
            List<Producto> listaCompra = new List<Producto>();
            Vendedor vendedor = Negocio.RetornarVendedor();
            float precioTotalConRecargo = 0;
            DialogResult confirmarVenta;

            foreach (Producto producto in productosSeleccionados)
            {
                if (producto.GetCantidadSeleccionada > 0 && producto.GetCantidadSeleccionada != null)
                {
                    listaCompra.Add(producto);
                }
            }
            //si selecciono un cliente
            if (cbClientes.SelectedIndex != -1)
            {
                Cliente clienteSeleccionado = Negocio.RetornarClientes()[cbClientes.SelectedIndex];
                string clienteSelecString = clienteSeleccionado.GetNombre;
                float precioTotal = Vendedor.CalcularMonto(listaCompra);
                confirmarVenta = MessageBox.Show("¿Desea confirmar la venta?", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmarVenta == DialogResult.Yes)
                {
                    foreach (Producto producto in listaCompra)
                    {   //verifico si hay stock 
                        if (producto.GetStock > 0 && producto.GetCantidadSeleccionada < producto.GetStock)
                        {
                            //verifico si el cliente tiene el dinero suficiente
                            if (ExtensionCliente.PuedeComprar(clienteSeleccionado, precioTotal) && precioTotal > 0)
                            {
                                if (clienteSeleccionado.GetMetodoPago == eMetodoPago.Tarjeta_de_credito)
                                {
                                    precioTotalConRecargo = precioTotal * 1.05f;
                                    clienteSeleccionado.SetMontoDisponible = clienteSeleccionado.GetMontoDisponible - precioTotalConRecargo;
                                    //actualizo el monto en txtInfoMonto
                                    txtInfoMonto.Text = clienteSeleccionado.GetMontoDisponible.ToString();
                                    Frm_VenderProducto frmVentas = new Frm_VenderProducto(listaCompra, clienteSelecString, precioTotal, precioTotalConRecargo, vendedor.GetCodigo, vendedor.GetNombreVendedor, clienteSeleccionado.GetMetodoPago);
                                    frmVentas.ShowDialog();
                                    Venta venta = new Venta(listaCompra, clienteSelecString, precioTotal, vendedor.GetNombreVendedor, clienteSeleccionado.GetMetodoPago);
                                    Negocio.CargarVentas(venta);
                                }
                                else
                                {
                                    clienteSeleccionado.SetMontoDisponible = clienteSeleccionado.GetMontoDisponible - precioTotal;
                                    //actualizo el monto en txtInfoMonto
                                    txtInfoMonto.Text = clienteSeleccionado.GetMontoDisponible.ToString();
                                    Frm_VenderProducto frmVentas = new Frm_VenderProducto(listaCompra, clienteSelecString, precioTotal, precioTotal, vendedor.GetCodigo, vendedor.GetNombreVendedor, clienteSeleccionado.GetMetodoPago);
                                    frmVentas.ShowDialog();
                                    Venta venta = new Venta(listaCompra, clienteSelecString, precioTotal, vendedor.GetNombreVendedor, clienteSeleccionado.GetMetodoPago);
                                    Negocio.CargarVentas(venta);
                                }
                                //actualizo el stock
                                Producto productoEnLista = listaDeProductos.Find(p => p.GetNombre == producto.GetNombre && p.GetCantidadSeleccionada == producto.GetCantidadSeleccionada);
                                productoEnLista.SetStock -= producto.GetCantidadSeleccionada;
                                int rowIndex = listaDeProductos.IndexOf(productoEnLista);
                                dgv.Rows[rowIndex].Cells["stock"].Value = productoEnLista.GetStock;
                                dgv.Refresh();
                                //guardo el stock nuevo en la base de datos 
                                ProductosDAO.ActualizarListaComprada(productoEnLista);
                                Negocio.CargarDBHistorial();
                            }
                            else
                            {
                                MessageBox.Show("El valor total de los productos seleccionados supera el monto a gastar del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No hay suficiente stock para realizar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    foreach (Producto producto in listaCompra)
                    {
                        producto.SetCantidadSeleccionada = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un clientes antes de realizar una venta.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Frm_SelecVendedor frmMenuSelec = new Frm_SelecVendedor();
            frmMenuSelec.Show();
            this.Close();
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClientes.SelectedIndex != -1)
            {
                Cliente clienteSeleccionado = Negocio.RetornarClientes()[cbClientes.SelectedIndex];
                txtInfoMonto.Text = clienteSeleccionado.GetMontoDisponible.ToString();
            }
        }

        private void dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "cantidadComprada") 
            {
                string cant = e.FormattedValue.ToString();
                float cantidadComprada;
                if (!float.TryParse(cant, out cantidadComprada) || cantidadComprada < 0) 
                {
                    MessageBox.Show("No puede dejar la celda vacía","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
    }
}
