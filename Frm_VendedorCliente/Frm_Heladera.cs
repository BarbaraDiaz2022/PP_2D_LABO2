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
        void limpiarTxt()
        {

            txtStock.Text = "";
            txtPrecio.Text = "";
            txtCorte.Text = "";
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {//revisar validaciones 
            //obtengo los nuevos valores q ingresa el ususario 
            float precioModificado = float.Parse(txtPrecio.Text);
            string corteModificado = txtCorte.Text;
            float stockModificado = float.Parse(txtStock.Text);
            //obtengo la fila seleccionada en el indice que corresponde 
            DataGridViewRow filaSelec = dgv.CurrentRow;
            int indiceFilaSeleccionada = filaSelec.Index;
            //cargo los nuevos datos que se ingresaron 
            Producto productoSeleccionado = listaDeProductos[indiceFilaSeleccionada];

            productoSeleccionado.SetPrecio = precioModificado;
            productoSeleccionado.SetTipoDeCorte = corteModificado;
            productoSeleccionado.SetStock = stockModificado;
            // Restar la cantidad modificada del valor actual del stock para obtener el nuevo valor del stock
            listaDeProductos[indiceFilaSeleccionada] = productoSeleccionado;
            //actualizo el dgv
            filaSelec.Cells["stock"].Value = stockModificado;
            filaSelec.Cells["precio"].Value = precioModificado;
            filaSelec.Cells["tipoCorte"].Value = corteModificado;
            limpiarTxt();
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //guardo la posicion de la fila en donde se hace click 
            posicion = dgv.CurrentRow.Index;
            //obtengo los valores de las celdas y los pongo en los txt
            txtStock.Text = dgv[1, posicion].Value.ToString();
            txtPrecio.Text = dgv[2, posicion].Value.ToString();
            txtCorte.Text = dgv[4, posicion].Value.ToString();
            //habilito los botones
            btnModificar.Enabled = true;
            txtStock.Focus();

            int n = e.RowIndex;
            if (n != -1)
            {
                //obtener el producto seleccionado
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                //crear el producto y agregarlo a la lista de los seleccionados 
                Producto producto = new Producto(
                    Convert.ToSingle(row.Cells["stock"].Value),
                    Convert.ToSingle(row.Cells["precio"].Value),
                    row.Cells["tipoCorte"].Value.ToString());
                if (row.Selected)
                {
                    productosSeleccionados.Add(producto);
                }
            }
        }
        private void Frm_Heladera_Load(object sender, EventArgs e)
        {
            CargarDataGridView(Negocio.RetornarProductos());
        }
    }
}
