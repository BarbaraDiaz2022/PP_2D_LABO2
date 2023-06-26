using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class ExtensionProducto
    {
        public static List<Producto> FiltrarPorNombreCorte(this List<Producto> productos, string nombreCorte)
        {
            return productos.Where(p => p.GetTipoDeCorte.Equals(nombreCorte)).ToList();
        }
        public static Producto ActualizarStock(this List<Producto> listaProductos, Producto productoCompra)
        {
            Producto productoEnLista = listaProductos.Find(p => p.GetNombre == productoCompra.GetNombre && p.GetCantidadSeleccionada == productoCompra.GetCantidadSeleccionada);
            productoEnLista.SetStock -= productoCompra.GetCantidadSeleccionada;

            return productoEnLista;
        }
    }
}
