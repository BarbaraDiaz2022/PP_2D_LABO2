﻿using BibliotecaDeClases;
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
    public partial class Frm_VenderProducto : Form
    {
        List<Producto> productoSeleccionado;
        string clienteSeleccionado;

        public Frm_VenderProducto(List<Producto> productoSeleccionado, string clienteSeleccionado)
        {
            InitializeComponent();
            this.productoSeleccionado = productoSeleccionado;
            this.clienteSeleccionado = clienteSeleccionado;
        }
        private void Frm_VenderProducto_Load(object sender, EventArgs e)
        {
            lblCliente.Text = clienteSeleccionado;
            foreach (Producto producto in productoSeleccionado)
            {
                if (producto.GetCantidadSeleccionada > 0)
                {
                    int rowIndex = dgv.Rows.Add();
                    DataGridViewRow row = dgv.Rows[rowIndex];
                    row.Cells["nombre"].Value = producto.GetNombre;
                    row.Cells["stock"].Value = producto.GetStock;
                    row.Cells["precio"].Value = producto.GetPrecio;
                    row.Cells["detalle"].Value = producto.GetDetalle;
                    row.Cells["tipoCorte"].Value = producto.GetTipoDeCorte;
                    row.Cells["cantidadComprada"].Value = producto.GetCantidadSeleccionada;
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
