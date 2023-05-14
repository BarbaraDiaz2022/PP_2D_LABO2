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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            //valido que no modifiquen los combobox
            cbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBuscarCorte.DropDownStyle = ComboBoxStyle.DropDownList;
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
                if(float.TryParse(nuevoValorString, out float nuevoValor) && nuevoValor >= 0)
                {   //actualiza el valor de la lista de productos correspondientes
                    listaDeProductos[rowIndex].SetCantidadSeleccionada = nuevoValor;
                    //busca el producto en productosSeleccionados por su nombre
                    Producto productoSeleccionado = productosSeleccionados.Find(p => p.GetNombre == dgv.Rows[rowIndex].Cells["nombreProducto"].Value.ToString());
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
        private void dgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                //obtengo el producto seleccionado
                Producto producto = new Producto(row.Cells["nombreProducto"].Value.ToString(),
                    Convert.ToInt32(row.Cells["stockProducto"].Value),
                    Convert.ToSingle(row.Cells["precio"].Value),
                    row.Cells["detalle"].Value.ToString(),
                    row.Cells["tipoDeCorte"].Value.ToString(),
                    Cliente.ObtenerCeldaAValidar(row.Cells["cantidadComprada"].Value));        
                //verifico si fue la celda cantidad comprada la q se selecciono y edito
                if (dgv.CurrentCell != null && dgv.CurrentCell.ColumnIndex == dgv.Columns["cantidadComprada"].Index)
                {
                    //si estoy editando la celda que salga y no haga nada
                    if (dgv.IsCurrentCellInEditMode)
                    {
                        return;
                    }
                }
                //agrego el producto si no esta en la lista o lo elimino si ya esta para q no se duplique 
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
        private void btnComprar_Click(object sender, EventArgs e)
        {
            float montoConRecargo = 0;
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
            //si elige un metodo de pago
            if (cbMetodoPago.SelectedIndex != -1)
            {   //si ingresa un monto valido 
                if (float.TryParse(txtMonto.Text, out float montoMax))
                {
                    float montoTotal = Vendedor.CalcularMonto(listaCompra);

                    foreach (Producto productoCompra in listaCompra)
                    {   //si hay stock
                        if (productoCompra.GetStock > 0)
                        {   //si el monto que ingreso el cliente alcanza 
                            if (montoMax >= montoTotal)
                            {
                                confirmarVenta = MessageBox.Show("¿Desea confirmar la compra?", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (confirmarVenta == DialogResult.Yes)
                                {
                                    if (cbMetodoPago.SelectedItem.ToString() == "Tarjeta de crédito")
                                    {
                                        montoConRecargo = montoTotal * 1.05f;
                                        if (montoMax >= montoConRecargo)
                                        {
                                            Frm_Factura frmFactura = new Frm_Factura(listaCompra, montoConRecargo, cbMetodoPago.SelectedItem.ToString(), montoTotal);
                                            frmFactura.ShowDialog();
                                        }
                                        else
                                        {
                                            MessageBox.Show("No tiene suficiente dinero para realizar esta compra", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
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
                            MessageBox.Show("No hay stock disponible.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //añado la venta a la lista para el historial 
                    Venta venta = new Venta(listaCompra, nombre, montoTotal, "Venta online");
                    Negocio.CargarVentas(venta);
                    //edito el valor de los txt solo si se pudo comprar 
                    if (cbMetodoPago.SelectedItem.ToString() == "Tarjeta de crédito" && compraRealizada)
                    {
                        if ((montoMax - montoConRecargo) > 0)
                        {
                            txtMonto.Text = (montoMax - montoConRecargo).ToString("N2");
                        }
                        else
                        {
                            txtMonto.Text = montoTotal.ToString("N2");
                        }
                    }
                    else
                    {
                        if (compraRealizada && (montoMax - montoTotal > 0))
                        {
                            txtMonto.Text = (montoMax - montoTotal).ToString("N2");
                        }
                        else
                        {
                            txtMonto.Text =montoTotal.ToString("N2");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un monto valido.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Indique un método de pago.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
