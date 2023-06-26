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
        public Frm_Heladera()
        {
            InitializeComponent();
            this.listaDeProductos = Negocio.RetornarProductos();
        }
        public void CargarDataGridView(List<Producto> listaDeProductos)
        {
            foreach (Producto producto in listaDeProductos)
            {
                dgv.Rows.Add(producto.GetId, producto.GetNombre, producto.GetStock, producto.GetPrecio, producto.GetDetalle, producto.GetTipoDeCorte); ;
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
            txtNombre.Text = "";
            txtDetalle.Text = "";
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult confirmarOp;
            //obtengo los valores que ingresa el usuario
            float precioModificado;
            if (!float.TryParse(txtPrecio.Text, out precioModificado) || (precioModificado < 0))
            {
                MessageBox.Show("Ingrese un valor numérico válido para el precio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float stockModificado;
            if (!float.TryParse(txtStock.Text, out stockModificado) || (stockModificado < 0))
            {
                MessageBox.Show("Ingrese un valor numérico válido para el stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string corteModificado = txtCorte.Text;
            if (string.IsNullOrEmpty(corteModificado))
            {
                MessageBox.Show("Ingrese un tipo de corte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string nombreModificado = txtNombre.Text;
            if (string.IsNullOrEmpty(nombreModificado))
            {
                MessageBox.Show("Ingrese un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string detalleModificado = txtDetalle.Text;
            if (string.IsNullOrEmpty(detalleModificado))
            {
                MessageBox.Show("Ingrese un detalle para el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //obtengo la fila seleccionada en el indice que corresponde 
            DataGridViewRow filaSelec = dgv.CurrentRow;
            int indiceFilaSeleccionada = filaSelec.Index;
            confirmarOp = MessageBox.Show("¿Desea modificar el producto de forma permanente?", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmarOp == DialogResult.Yes)
            {
                //cargo los nuevos datos que se ingresaron en el producto
                Producto productoSeleccionado = listaDeProductos[indiceFilaSeleccionada];
                productoSeleccionado.SetPrecio = precioModificado;
                productoSeleccionado.SetTipoDeCorte = corteModificado;
                productoSeleccionado.SetStock = stockModificado;
                productoSeleccionado.SetNombre = nombreModificado;
                productoSeleccionado.SetDetalle = detalleModificado;
                //actualizo el dgv
                filaSelec.Cells["stock"].Value = stockModificado;
                filaSelec.Cells["precio"].Value = precioModificado;
                filaSelec.Cells["tipoCorte"].Value = corteModificado;
                filaSelec.Cells["nombre"].Value = nombreModificado;
                filaSelec.Cells["detalle"].Value = detalleModificado;

                //lo cargo en la base de datos
                ProductosDAO.Modificar(productoSeleccionado);
            }
            else
            {
                MessageBox.Show("No se modificó el producto", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            limpiarTxt();
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //guardo la posicion de la fila en donde se hace click 
            posicion = dgv.CurrentRow.Index;
            //obtengo los valores de las celdas y los pongo en los txt
            txtStock.Text = dgv[2, posicion].Value.ToString();
            txtPrecio.Text = dgv[3, posicion].Value.ToString();
            txtCorte.Text = dgv[5, posicion].Value.ToString();
            txtNombre.Text = dgv[1, posicion].Value.ToString();
            txtDetalle.Text = dgv[4, posicion].Value.ToString();
            //habilito los botones
            btnModificar.Enabled = true;
            txtStock.Focus();
        }

        private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //DataGridViewColumn columnaActual = dgv.Columns[e.ColumnIndex];
            //que no se edite nada
            e.Cancel = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult confirmarOp;
            //obtengo los valores que ingresa el usuario
            float precioNuevo;
            if (!float.TryParse(txtPrecio.Text, out precioNuevo) || (precioNuevo < 0))
            {
                MessageBox.Show("Ingrese un valor numérico válido para el precio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float stockNuevo;
            if (!float.TryParse(txtStock.Text, out stockNuevo) || (stockNuevo < 0))
            {
                MessageBox.Show("Ingrese un valor numérico válido para el stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string corteNuevo = txtCorte.Text;
            if (string.IsNullOrEmpty(corteNuevo))
            {
                MessageBox.Show("Ingrese un tipo de corte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string nombreNuevo = txtNombre.Text;
            if (string.IsNullOrEmpty(nombreNuevo))
            {
                MessageBox.Show("Ingrese un nombre para el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string detalleNuevo = txtNombre.Text;
            if (string.IsNullOrEmpty(detalleNuevo))
            {
                MessageBox.Show("Ingrese un detalle para el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //obtengo la fila seleccionada en el indice que corresponde 
            DataGridViewRow filaSelec = dgv.CurrentRow;
            int indiceFilaSeleccionada = filaSelec.Index;
            confirmarOp = MessageBox.Show("¿Desea agregar el nuevo producto?", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmarOp == DialogResult.Yes)
            {
                //cargo los nuevos datos que se ingresaron en el producto
                Producto productoSeleccionado = listaDeProductos[indiceFilaSeleccionada];
                productoSeleccionado.SetPrecio = precioNuevo;
                productoSeleccionado.SetTipoDeCorte = corteNuevo;
                productoSeleccionado.SetStock = stockNuevo;
                productoSeleccionado.SetNombre = nombreNuevo;
                productoSeleccionado.SetDetalle = detalleNuevo;
                //actualizo el dgv
                filaSelec.Cells["stock"].Value = stockNuevo;
                filaSelec.Cells["precio"].Value = precioNuevo;
                filaSelec.Cells["tipoCorte"].Value = corteNuevo;
                filaSelec.Cells["nombre"].Value = nombreNuevo;
                filaSelec.Cells["detalle"].Value = detalleNuevo;
                listaDeProductos.Add(productoSeleccionado);
                //lo cargo en la base de datos 
                ProductosDAO.GuardarNuevoProducto(productoSeleccionado);
            }
            else
            {
                MessageBox.Show("No se agregó el producto", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            limpiarTxt();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                //valores de las celdas en la fila seleccionada
                DialogResult confirmarOp;
                int id = Convert.ToInt32(selectedRow.Cells["idProducto"].Value);


                confirmarOp = MessageBox.Show("¿Desea eliminar el producto de forma permanente?", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmarOp == DialogResult.Yes)
                {
                    ProductosDAO.Eliminar(id);
                    //actualizo la lista de productos eliminando el producto correspondiente
                    Producto productoAEliminar = listaDeProductos.FirstOrDefault(p => p.GetId == id);
                    listaDeProductos.Remove(productoAEliminar);
                    //elimino la fila seleccionada del DataGridView
                    dgv.Rows.Remove(dgv.CurrentRow);
                }
                else
                {
                    MessageBox.Show("No se eliminó el producto", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el producto que desea eliminar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
