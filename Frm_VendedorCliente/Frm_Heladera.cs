using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace Frm_VendedorCliente
{
    public partial class Frm_Heladera : Form
    {
        int posicion;
        List<Producto> listaDeProductos;
        List<Producto> productosSeleccionados;
        public Frm_Heladera()
        {
            InitializeComponent();
            this.listaDeProductos = Negocio.RetornarProductos();
            this.productosSeleccionados = new List<Producto>();
        }
        public void CargarDataGridView(List<Producto> listaDeProductos)
        {
            foreach (Producto producto in listaDeProductos)
            {
                dgv.Rows.Add(producto.GetNombre, producto.GetStock, producto.GetPrecio, producto.GetDetalle, producto.GetTipoDeCorte);
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Frm_SelecVendedor frmSelec = new Frm_SelecVendedor();
            frmSelec.Show();
            this.Close();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre;
            string stock;
            string precio;
            string detalle;
            string tipoCorte;

            nombre = txtNombre.Text;
            stock = txtStock.Text;
            precio = txtPrecio.Text;
            detalle = txtDetalle.Text;
            tipoCorte = txtCorte.Text;
            dgv.Rows.Add(nombre, stock, precio, detalle, tipoCorte);

            Negocio.CargarProducto(nombre, float.Parse(stock), float.Parse(precio), detalle, tipoCorte);
            limpiarTxt();
            txtNombre.Focus();
        }
        void limpiarTxt()
        {
            txtNombre.Text = "";
            txtStock.Text = "";
            txtPrecio.Text = "";
            txtDetalle.Text = "";
            txtCorte.Text = "";
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //obtengo los nuevos valores q ingresa el ususario 
            string nombreModificado = txtNombre.Text;
            float precioModificado = float.Parse(txtPrecio.Text);
            string detalleModificado = txtDetalle.Text;
            string corteModificado = txtCorte.Text;
            float stockModificado = float.Parse(txtStock.Text);
            //obtengo la fila seleccionada en el indice que corresponde 
            DataGridViewRow filaSelec = dgv.CurrentRow;
            int indiceFilaSeleccionada = filaSelec.Index;
            //cargo los nuevos datos que se ingresaron 
            Producto productoSeleccionado = listaDeProductos[indiceFilaSeleccionada];
            productoSeleccionado.SetNombre = nombreModificado;
            productoSeleccionado.SetPrecio = precioModificado;
            productoSeleccionado.SetDetalle = detalleModificado;
            productoSeleccionado.SetTipoDeCorte = corteModificado;
            productoSeleccionado.SetStock = stockModificado;
            // Restar la cantidad modificada del valor actual del stock para obtener el nuevo valor del stock
            listaDeProductos[indiceFilaSeleccionada] = productoSeleccionado;
            //actualizo el dgv
            filaSelec.Cells["nombre"].Value = nombreModificado;
            filaSelec.Cells["stock"].Value = stockModificado;
            filaSelec.Cells["precio"].Value = precioModificado;
            filaSelec.Cells["detalle"].Value = detalleModificado;
            filaSelec.Cells["tipoCorte"].Value = corteModificado;
            limpiarTxt();
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //guardo la posicion de la fila en donde se hace click 
            posicion = dgv.CurrentRow.Index;
            //obtengo los valores de las celdas y los pongo en los txt
            txtNombre.Text = dgv[0, posicion].Value.ToString();
            txtStock.Text = dgv[1, posicion].Value.ToString();
            txtPrecio.Text = dgv[2, posicion].Value.ToString();
            txtDetalle.Text = dgv[3, posicion].Value.ToString();
            txtCorte.Text = dgv[4, posicion].Value.ToString();
            //habilito los botones
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
            btnAgregar.Enabled = true;
            txtNombre.Focus();

            int n = e.RowIndex;
            if (n != -1)
            {
                //obtener el producto seleccionado
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                //crear el producto y agregarlo a la lista de los seleccionados 
                Producto producto = new Producto(row.Cells["nombre"].Value.ToString(),
                    Convert.ToSingle(row.Cells["stock"].Value),
                    Convert.ToSingle(row.Cells["precio"].Value),
                    row.Cells["detalle"].Value.ToString(),
                    row.Cells["tipoCorte"].Value.ToString());
                if (row.Selected)
                {
                    productosSeleccionados.Add(producto);
                }
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dgv.Rows.RemoveAt(posicion);
            txtNombre.Focus();
        }
        private void Frm_Heladera_Load(object sender, EventArgs e)
        {
            CargarDataGridView(Negocio.RetornarProductos());
        }
    }
}
