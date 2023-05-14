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
        private static List<Producto> listaOriginal;
        private static List<Producto> listaCopia;
        private static List<Venta> listaVentas;
        private static List<Cliente> listaCliente;
        //constructor
        static Negocio()
        {
            listaOriginal = new List<Producto>();
            listaVentas = new List<Venta>();
            listaCliente = new List<Cliente>();
            listaCopia = new List<Producto>();
            CargarDgv();
            CargarCopiaProductos();
        }
        //metodos
        /// <summary>
        /// metodo que carga a la lista los productos (hardcodeados)
        /// </summary>
        private static void CargarDgv()
        {
            //nombre stock precioxkilo detalle tipodecorte
            listaOriginal.Add(new Producto("Milanesas.01", 15, 2500, "Milanesas de carne vacuna", "Peceto", 0));
            listaOriginal.Add(new Producto("Milanesas.02", 15, 1800, "Milanesas de carne avicola", "Pechuga", 0));
            listaOriginal.Add(new Producto("Milanesas.03", 12, 1900, "Milanesas de carne porcina", "Bondiola", 0));
            listaOriginal.Add(new Producto("Milanesas.04", 15, 2000, "Milanesas de carne vacuna", "Bola de lomo", 0));
            listaOriginal.Add(new Producto("Hamburguesas.01", 20, 1500, "Hamburguesas de carne avicola", "Pechuga", 0));
            listaOriginal.Add(new Producto("Bife", 25, 2800, "Bifes de carne vacuna", "Bife de chorizo", 0));
            listaOriginal.Add(new Producto("Hamburguesas.02", 25, 1850, "Hamburguesas de carne vacuna", "Peceto", 0));
            listaOriginal.Add(new Producto("Bife.02", 30, 1950, "Bifes de carne porcina", "Bife de bondiola", 0));
        }
        private static void CargarCopiaProductos()
        {
            foreach (Producto producto in listaOriginal)
            {
                listaCopia = listaOriginal;
            }
        }
        /// <summary>
        /// metodo que se encarga de retorna la lista con los productos ya cargados 
        /// </summary>
        /// <returns>retorna una lista de tipo producto</returns>
        public static List<Producto> RetornarProductos()
        {

            return listaCopia;
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

            foreach (Producto producto in listaCopia)
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
            listaCliente.Add(new Cliente("Leo Messi","leomessi@gmail.com","contraseña123", 25000, eMetodoPago.Tarjeta_de_credito));
            listaCliente.Add(new Cliente("Angel DiMaria", "angelito@gmail.com", "contraseña456", 20000, eMetodoPago.Tarjeta_de_debito));
            listaCliente.Add(new Cliente("Maria Lopez", "marilopez@gmail.com", "contraseña496", 10000, eMetodoPago.Mercado_pago));
            listaCliente.Add(new Cliente("Julian Alvarez", "julialvarez@gmail.com", "contraseña789", 23000, eMetodoPago.Efectivo));
            listaCliente.Add(new Cliente("Juana Fernandez", "juana@gmail.com", "contraseña636", 13000, eMetodoPago.Efectivo));
            listaCliente.Add(new Cliente("Susana Gimenez", "susanita@gmail.com", "contraseña937", 15500, eMetodoPago.Tarjeta_de_credito));
        }
        /// <summary>
        /// metodo que retorna la lista de clientes con los clientes cargados
        /// </summary>
        /// <returns>retorna una lista de tipo cliente</returns>
        public static List<Cliente> RetornarClientes()
        {
            List<Cliente> clientesDatosSeguros = new List<Cliente>();

            foreach (Cliente cliente in listaCliente)
            {
                Cliente datosSeguros = new Cliente(cliente.GetNombre,"","",cliente.GetMontoDisponible,cliente.GetMetodoPago);
                clientesDatosSeguros.Add(datosSeguros);
            }
            return clientesDatosSeguros;
        }
        public static List<Vendedor> CargarVendedores() 
        {
            List<Vendedor> listaVendedores = new List<Vendedor>()
            { 
                new Vendedor("vendedor1@gmail.com", "contraseñaVendedor1", 123456, "Juan Perez"),
                new Vendedor("vendedor2@gmail.com", "contraseñaVendedor2", 789012, "Adriana Davalos"),
                new Vendedor("vendedor3@gmail.com", "contraseñaVendedor3", 345678, "Jorge Fernandez ")
            };
            return listaVendedores;
        }
        public static Vendedor RetornarVendedor()
        {
            List <Vendedor> listaVendedores = CargarVendedores();
            Random random = new Random();
            int indiceRandom = random.Next(0, listaVendedores.Count);

            Vendedor vendedorAleatorio = listaVendedores[indiceRandom];

            return vendedorAleatorio;
        }
    }
}
