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
    public partial class Frm_Historial : Form
    {
        List<Venta> ventas = VentaDAO.Leer();
        public Frm_Historial()
        {
            InitializeComponent();
        }

        private void Frm_Historial_Load(object sender, EventArgs e)
        {
            //recorro la lista de ventas y agrego una nueva fila al dgv para cada venta
            foreach (Venta venta in ventas)
            {
                dgv.Rows.Add(venta.GetNombre, venta.GetVendedor, venta.GetCliente, venta.GetMonto);
            }
            btnDeserializarJson.Enabled = false;
            btnDeserializarXml.Enabled = false;
            btnDeserializarVentaJson.Enabled = false;
            btnDeserializarVentaXml.Enabled = false; 
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            //Negocio.CargarDBHistorial();
            Frm_SelecVendedor frmSelecVendedor = new Frm_SelecVendedor();
            frmSelecVendedor.Show();
            this.Close();
        }

        private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewColumn columnaActual = dgv.Columns[e.ColumnIndex];
            e.Cancel = true;
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            //string ruta = "algo";
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //ruta al escritorio
            string nombreArchivo = @"/Historial.txt";
            string rutaCompleta = ruta + nombreArchivo;

            try
            {
                if (!Directory.Exists(ruta)) //si la ruta no existe 
                {
                    throw new MiExcepcion("Se produjo una excepción en la ruta del archivo.");
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(rutaCompleta, true)) //el parametro true indica q se tiene que agregar al final
                    {
                        foreach (Venta venta in ventas)
                        {
                            //foreach (Producto producto in venta.listaProductos)
                            //{
                                sw.WriteLine($"Fecha: {DateTime.Now.ToString()}");
                                sw.WriteLine($"Producto: {venta.GetNombre} | Cliente: {venta.GetCliente} | Vendedor: {venta.GetVendedor}");
                                sw.WriteLine("********************************************************************************************************************************************");
                            //}
                        }
                    }
                    MessageBox.Show("Archivo generado con éxito", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MiExcepcion ex)
            {
                MessageBox.Show($"Error en el archivo: {rutaCompleta} | Excepción generada:  {ex.Message}", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnSerializarProductos_Click(object sender, EventArgs e)
        {
            List<Producto> listaDeProductos = Negocio.RetornarProductos();
            Producto serializer = new Producto();
            serializer.SerializeJson(listaDeProductos);
            btnDeserializarJson.Enabled = true;
            MessageBox.Show("La lista de productos se ha serializado correctamente (en json).", "Serialización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSerializarProdXml_Click(object sender, EventArgs e)
        {
            List<Producto> listaDeProductos = Negocio.RetornarProductos();
            Producto serializer = new Producto();
            serializer.SerializeXml(listaDeProductos);
            MessageBox.Show("La lista de productos se ha serializado correctamente (en xml).", "Serialización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDeserializarXml.Enabled = true;
        }

        private void btnDeserializarJson_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(); //creo una instancia de la clase producto para llamarlo ya q
            string resultado = producto.DeserializeJson(); //este metodo no es estatico 

            MessageBox.Show(resultado, "JSON Deserializado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeserializarXml_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            string resultado = producto.DeserializeXml();

            MessageBox.Show(resultado, "XML Deserializado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSerializarVentasJson_Click(object sender, EventArgs e)
        {
            List<Venta> listaDeVentas = Negocio.RetornarVentas();
            Venta serializer = new Venta();
            serializer.SerializeJson(listaDeVentas);
            btnDeserializarVentaJson.Enabled = true;
            MessageBox.Show("La lista de ventas se ha serializado correctamente (en json).", "Serialización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnSerializarVentasXml_Click(object sender, EventArgs e)
        {
            List<Venta> listaDeVentas = Negocio.RetornarVentas();
            Venta serializer = new Venta();
            serializer.SerializeXml(listaDeVentas);
            btnDeserializarVentaXml.Enabled = true;
            MessageBox.Show("La lista de ventas se ha serializado correctamente (en xml).", "Serialización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeserializarVentaJson_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta(); //creo una instancia de la clase producto para llamarlo ya q
            string resultado = venta.DeserializeJson(); //este metodo no es estatico 

            MessageBox.Show(resultado, "JSON Deserializado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeserializarVentaXml_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            string resultado = venta.DeserializeXml();

            MessageBox.Show(resultado, "XML Deserializado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

