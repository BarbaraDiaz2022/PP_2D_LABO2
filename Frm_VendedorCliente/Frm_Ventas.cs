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
    //declaro el delegado para actualizar el cartel
    public delegate void ActualizarCartelDelegate(string mensaje);
    public partial class Frm_Ventas : Form
    {
        //declaro el evento para actualizar el cartel
        public event ActualizarCartelDelegate ActualizarCartelEvent;
        List<Producto> listaDeProductos;
        List<Producto> productosSeleccionados;
        private string nombreCliente;
        public Frm_Ventas(string nombre)
        {
            InitializeComponent();
            this.listaDeProductos = Negocio.RetornarProductos();//productos disponibles en la tienda 
            this.productosSeleccionados = new List<Producto>();//productos que el cliente selecciona para comprar
            this.nombreCliente = nombre;
            txtNombreCliente.Text = nombre;
        }
        public void CargarDataGridView(List<Producto> listaDeProductos)
        {
            foreach (Producto producto in listaDeProductos)
            {
                dgv.Rows.Add(producto.GetNombre, producto.GetStock, producto.GetPrecio, producto.GetDetalle, producto.GetTipoDeCorte, producto.GetCantidadSeleccionada);
            }
        }
        private void Frm_Ventas_Load(object sender, EventArgs e)
        {
            CargarDataGridView(Negocio.RetornarProductos());
            //valido que no modifiquen los combobox
            cbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBuscarCorte.DropDownStyle = ComboBoxStyle.DropDownList;
            DateTime fecha = DateTime.Now;
            lblInfo.Text = fecha.ToShortDateString();
            // suscribo el metodo al evento 
            ActualizarCartelEvent += ActualizarCartelEventHandler;

            //inicio el hilo que actualiza el cartel
            Thread cartelThread = new Thread(ActualizarCartel);
            cartelThread.IsBackground = true;
            cartelThread.Start();
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
            //verifico si se edito la columna "cantidadComprada"
            if (e.ColumnIndex == dgv.Columns["cantidadComprada"].Index)
            {   //obtengo el valor de la celda como cadena de texto 
                int rowIndex = e.RowIndex;
                string nuevoValorString = dgv.Rows[rowIndex].Cells["cantidadComprada"].Value.ToString();
                if (float.TryParse(nuevoValorString, out float nuevoValor) && nuevoValor >= 0)
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
                    MessageBox.Show("Ingrese una cantidad válida.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1 && e.ColumnIndex != -1)
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
                if (dgv.CurrentCell.ColumnIndex == dgv.Columns["cantidadComprada"].Index)
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
                    productosSeleccionados.Add(producto);
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
            List<Producto> productosEncontrados = ExtensionProducto.FiltrarPorNombreCorte(listaDeProductos, textoBusqueda);
            dgv.Rows.Clear();
            CargarDataGridView(productosEncontrados);

            if (cbBuscarCorte.SelectedItem.ToString() == "Mostrar todos los cortes")
            {
                //devuelve el control al codigo que lo llamo asi no carga el dgv 2 veces 
                CargarDataGridView(listaDeProductos);
                return;
            }
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            float montoConRecargo = 0;
            float montoMax = 0;
            string nombre = txtNombreCliente.Text.ToString();
            DialogResult confirmarVenta;
            List<Producto> listaCompra = new List<Producto>();

            foreach (Producto producto in listaDeProductos)
            {
                if (producto.GetCantidadSeleccionada > 0 && producto.GetCantidadSeleccionada != null)
                {
                    listaCompra.Add(producto);
                }
            }
            if (nombre == null || nombre == "")
            {
                MessageBox.Show("Ingrese su nombre.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {   //si ingresa un monto valido 
                if (float.TryParse(txtMonto.Text, out montoMax) && montoMax > 0)
                {   //si elige un metodo de pago
                    if (cbMetodoPago.SelectedIndex != -1)
                    {
                        float montoTotal = Vendedor.CalcularMonto(listaCompra);
                        foreach (Producto productoCompra in listaCompra)
                        {   //si hay stock
                            if (productoCompra.GetStock > 0)
                            {   //si el monto que ingreso el cliente no alcanza
                                if (montoMax < montoTotal)
                                {
                                    MessageBox.Show("No tiene suficiente dinero para realizar esta compra.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; //salgo sin comprar nada 
                                }
                                else
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
                                                //añado la venta a la lista para el historial 
                                                Venta venta = new Venta(listaCompra, nombre, montoConRecargo, "Venta realizada por el cliente");
                                                Negocio.CargarVentas(venta);
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
                                            Venta venta = new Venta(listaCompra, nombre, montoTotal, "Venta realizada por cliente");
                                            Negocio.CargarVentas(venta);
                                        }
                                        //actualizo el stock
                                        Producto productoEnLista = ExtensionProducto.ActualizarStock(listaDeProductos, productoCompra);
                                        int rowIndex = listaDeProductos.IndexOf(productoEnLista);
                                        dgv.Rows[rowIndex].Cells["stockProducto"].Value = productoEnLista.GetStock;
                                        dgv.Refresh();

                                        //calculo y actualizo el txt con el nuevo monto 
                                        montoMax -= montoTotal;
                                        txtMonto.Text = montoMax.ToString("N2");
                                        //guardo el nuevo stock en la base de datos 
                                        ProductosDAO.ActualizarListaComprada(productoEnLista);
                                        Negocio.CargarDBHistorial();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No hay stock disponible.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        foreach (Producto producto in listaCompra)
                        {
                            producto.SetCantidadSeleccionada = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Indique un método de pago.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el monto a gastar(número válido).", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //suscribo el metodo al evento
        private void ActualizarCartelEventHandler(string mensaje)
        {
            //actualizo el cartel con el mensaje recibido
            if (lblInfo.InvokeRequired)
            {
                lblInfo.Invoke(new Action(() => lblInfo.Text = mensaje));
            }
            else
            {
                lblInfo.Text = mensaje;
            }
        }
        //metodo que ejecuto en segundo plano y muestra la info 
        private void ActualizarCartel()
        {
            while (true)
            {
                Thread.Sleep(5000); //espera 5 segundos
                ActualizarCartelEvent?.Invoke("¡¡¡Recordar!!!:si paga con 'Tarjeta de crédito' tiene un 5% de recargo");
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
                    MessageBox.Show("No puede dejar la celda vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
    }
}
