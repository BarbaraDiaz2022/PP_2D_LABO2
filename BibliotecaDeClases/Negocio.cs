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
        private static List<Venta> listaVentas;
        private static List<Cliente> listaCliente;
        private static List<Vendedor> listaVendedores;
        //constructor
        static Negocio()
        {
            listaOriginal = new List<Producto>();
            listaVentas = new List<Venta>();
            listaCliente = new List<Cliente>();
            listaVendedores = new List<Vendedor>();
            CargarDgv();
            CargarClientes();
            CargarVendedores();
        }
        //metodos
        /// <summary>
        /// metodo que carga a la lista los productos (hardcodeados)
        /// </summary>
        private static void CargarDgv()
        {
            listaOriginal = ProductosDAO.Leer();
        }
        /// <summary>
        /// metodo que se encarga de retorna la lista con los productos ya cargados 
        /// </summary>
        /// <returns>retorna una lista de tipo producto</returns>
        public static List<Producto> RetornarProductos()
        {
            return listaOriginal;
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
        /// metodo que agrega clientes a la lista de clientes
        /// </summary>
        private static void CargarClientes()
        {
            ClientesDAO clientesDAO = new ClientesDAO();
            listaCliente = clientesDAO.LeerUsuarios();
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
        public static void CargarVendedores() 
        {
            VendedoresDAO vendedoresDAO = new VendedoresDAO();
            listaVendedores = vendedoresDAO.LeerUsuarios();
        }
        public static Vendedor RetornarVendedor()
        {

            Random random = new Random();
            int indiceRandom = random.Next(0, listaVendedores.Count);

            Vendedor vendedorAleatorio = listaVendedores[indiceRandom];

            return vendedorAleatorio;
        }

        public static void CargarDBProductos() 
        {
            Producto.CargarDB(listaOriginal);
        }
        public static void CargarDBClientes() 
        {
            Cliente.CargarDBCliente(listaCliente);
        }
        public static void CargarDBVendedores() 
        {
            Vendedor.CargarDBVendedor(listaVendedores);
        }
        public static void CargarDBHistorial()
        {
            Venta.CargarDB(listaVentas);
        }
    }
}
