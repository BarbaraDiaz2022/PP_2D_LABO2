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
        public static void CargarDgv() 
        {
            //nombre stock precioxkilo detalle tipodecorte
            listaDeProductos.Add(new Producto("Milanesas.01",15,2500,"Milanesas de carne vacuna","Peceto",0));
            listaDeProductos.Add(new Producto("Milanesas.02", 15, 1800, "Milanesas de carne avicola", "Pechuga",0));
            listaDeProductos.Add(new Producto("Milanesas.03", 12, 1900, "Milanesas de carne porcina", "Bondiola",0));
            listaDeProductos.Add(new Producto("Milanesas.04", 15, 2000, "Milanesas de carne vacuna", "Bola de lomo",0));
            listaDeProductos.Add(new Producto("Hamburguesas.01", 20, 1500, "Hamburguesas de carne avicola", "Pechuga",0));
            listaDeProductos.Add(new Producto("Bife",25,2800,"Bifes de carne vacuna","Bife de chorizo",0));
            listaDeProductos.Add(new Producto("Hamburguesas.02", 25, 1850, "Hamburguesas de carne vacuna", "Peceto",0));
        }
        public static List<Producto> RetornarProductos()
        {
            return listaDeProductos;
        }
        public static void CargarProducto(string nombre,float stock,float precio, string detalle, string tipoDeCorte,float cantidadComprada) 
        {
            listaDeProductos.Add(new Producto(nombre,stock,precio,detalle,tipoDeCorte,cantidadComprada));
        }
        public static void CargarProducto(float stock,float precio,string tipoDeCorte)
        {
            listaDeProductos.Add(new Producto(stock, precio,tipoDeCorte));
        }
        public static void CargarVentas(Venta venta)
        {
            listaVentas.Add(venta);
        }
        public static List<Venta> RetornarVentas()
        {
            return listaVentas;
        }
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
        public static void CargarClientes()
        {
            listaCliente.Add(new Cliente("Leo Messi","leomessi@gmail.com","contraseña123",25000,eMetodoPago.Tarjeta_de_credito));
            listaCliente.Add(new Cliente("Angel DiMaria", "angelito@gmail.com", "contraseña456", 20000, eMetodoPago.Tarjeta_de_debito));
            listaCliente.Add(new Cliente("Julian Alvarez", "julialvarez@gmail.com", "contraseña789", 23000, eMetodoPago.Efectivo));
        }
        public static List<Cliente> RetornarClientes()
        {
            return listaCliente;
        }
    }
}
