using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Venta
    {
        public Venta(List<Producto> productos,string cliente,float montoTotal,string vendedor) 
        {
            listaProductos = productos;
            this.GetCliente = cliente;
            this.GetMonto = montoTotal;
            this.GetVendedor = vendedor;
        }
        public Venta(List<Producto> productos,string cliente,float montoTotal,string vendedor,eMetodoPago pago) 
        {
            listaProductos = productos;
            this.GetCliente = cliente;
            this.GetMonto = montoTotal;
            this.GetVendedor = vendedor;
            this.GetMetodoDePago = pago;
        }
        //propiedad
        public string GetCliente { get; set; }
        public float GetMonto { get; set; }
        public List<Producto> listaProductos { get; set; }
        public string GetVendedor { get; set; }
        public eMetodoPago GetMetodoDePago { get; set; }
        //metodo
        /// <summary>
        /// metodo que busca y verifica si un producto pasado por parametro esta contenido en la lista original 
        /// </summary>
        /// <param name="producto">parametro de tipo producto</param>
        /// <returns>retorna un bool que indica si el producto esta en la lista(true) o si no (false)</returns>
        public bool ContieneProducto(Producto producto)
        {   
            foreach (Producto prod in listaProductos)
            {
                if (prod.GetNombre == producto.GetNombre)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
