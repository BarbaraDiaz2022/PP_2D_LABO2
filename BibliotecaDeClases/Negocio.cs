using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Negocio
    {
        //atributos 
        private static List<Producto> listaDeProductos;
        private static List<Venta> listaVentas;
        private static List<Cliente> listaCliente;
        //constructor
        static Negocio()
        {
            listaDeProductos = new List<Producto>();
            listaVentas = new List<Venta>();
            listaCliente = new List<Cliente>();
            CargarDgv();
        }
        //metodos
        /// <summary>
        /// metodo que carga a la lista los productos (hardcodeados)
        /// </summary>
        public static void CargarDgv()
        {
            //nombre stock precioxkilo detalle tipodecorte
            listaDeProductos.Add(new Producto("Milanesas.01", 15, 2500, "Milanesas de carne vacuna", "Peceto", 0));
            listaDeProductos.Add(new Producto("Milanesas.02", 15, 1800, "Milanesas de carne avicola", "Pechuga", 0));
            listaDeProductos.Add(new Producto("Milanesas.03", 12, 1900, "Milanesas de carne porcina", "Bondiola", 0));
            listaDeProductos.Add(new Producto("Milanesas.04", 15, 2000, "Milanesas de carne vacuna", "Bola de lomo", 0));
            listaDeProductos.Add(new Producto("Hamburguesas.01", 20, 1500, "Hamburguesas de carne avicola", "Pechuga", 0));
            listaDeProductos.Add(new Producto("Bife", 25, 2800, "Bifes de carne vacuna", "Bife de chorizo", 0));
            listaDeProductos.Add(new Producto("Hamburguesas.02", 25, 1850, "Hamburguesas de carne vacuna", "Peceto", 0));
        }
        /// <summary>
        /// metodo que se encarga de retorna la lista con los productos ya cargados 
        /// </summary>
        /// <returns>retorna una lista de tipo producto</returns>
        public static List<Producto> RetornarProductos()
        {
            return listaDeProductos;
        }
        /// <summary>
        /// metodo que añade una venta que recibe por parametro a la lista de ventas
        /// </summary>
        /// <param name="venta">recibe un objeto de tipo venta</param>
        public static void CargarVentas(Venta venta)
        {
            listaVentas.Add(venta);
        }
        /// <summary>
        /// metodo que retorna la lista de ventas con los productos cargados 
        /// </summary>
        /// <returns>retorna una lista de tipo venta</returns>
        public static List<Venta> RetornarVentas()
        {
            return listaVentas;
        }
        /// <summary>
        /// metodo que permite buscar un corte que recibe por parametro en la lista de productos y retorna solo los
        /// productos filtrados 
        /// </summary>
        /// <param name="corteBusqueda">parametro de tipo string que sirve para filtrar la lista</param>
        /// <returns>retorna una lista de tipo producto con los productos que coincidan con el tipo buscado</returns>
        public static List<Producto> BuscarPorCorte(string corteBusqueda)
        {
            List<Producto> listaFiltrada = new List<Producto>();

            foreach (Producto producto in listaDeProductos)
            {
                if (producto.GetTipoDeCorte.ToLower().Contains(corteBusqueda.ToLower()))
                {
                    listaFiltrada.Add(producto);
                }
            }
            return listaFiltrada;
        }
        /// <summary>
        /// metodo que agrega clientes a la lista de clientes
        /// </summary>
        public static void CargarClientes()
        {
            listaCliente.Add(new Cliente("Leo Messi", "leomessi@gmail.com", "contraseña123", 25000, eMetodoPago.Tarjeta_de_credito));
            listaCliente.Add(new Cliente("Angel DiMaria", "angelito@gmail.com", "contraseña456", 20000, eMetodoPago.Tarjeta_de_debito));
            listaCliente.Add(new Cliente("Julian Alvarez", "julialvarez@gmail.com", "contraseña789", 23000, eMetodoPago.Efectivo));
        }
        /// <summary>
        /// metodo que retorna la lista de clientes con los clientes cargados
        /// </summary>
        /// <returns>retorna una lista de tipo cliente</returns>
        public static List<Cliente> RetornarClientes()
        {
            return listaCliente;
        }
    }
}
