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
        //List<Producto> productosSeleccionados;
        public Frm_Heladera()
        {
            InitializeComponent();
            this.listaDeProductos = Negocio.RetornarProductos();
            //this.productosSeleccionados = new List<Producto>();
        }
        public void CargarDataGridView(List<Producto> listaDeProductos)
        {
            foreach (Producto producto in listaDeProductos)
            {
                dgv.Rows.Add(producto.GetNombre, producto.GetStock, producto.GetPrecio, producto.GetDetalle, producto.GetTipoDeCorte);
            }
        }
        private void Frm_Heladera_Load(object sender, EventArgs e)
        {
            CargarDataGridView(Negocio.RetornarProductos());
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
        {
            //obtengo los valores que ingresa el usuario
            float precioModificado;
            if (!float.TryParse(txtPrecio.Text, out precioModificado) && precioModificado > 0)
            {
                MessageBox.Show("Ingrese un valor numérico válido para el precio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float stockModificado;
            if (!float.TryParse(txtStock.Text, out stockModificado) && stockModificado > 0)
            {
                MessageBox.Show("Ingrese un valor numérico válido para el stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string corteModificado = txtCorte.Text;
            //obtengo la fila seleccionada en el indice que corresponde 
            DataGridViewRow filaSelec = dgv.CurrentRow;
            int indiceFilaSeleccionada = filaSelec.Index;
            //cargo los nuevos datos que se ingresaron en el producto
            Producto productoSeleccionado = listaDeProductos[indiceFilaSeleccionada];
            productoSeleccionado.SetPrecio = precioModificado;
            productoSeleccionado.SetTipoDeCorte = corteModificado;
            productoSeleccionado.SetStock = stockModificado;

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
        }
    }
}
