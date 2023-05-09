using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Venta
    {
        public Venta(List<Producto> productos,string cliente,float montoTotal) 
        {
            listaProductos = productos;
            this.GetCliente = cliente;
            this.GetMonto = montoTotal;
        }
        //propiedad
        public string GetCliente { get; set; }
        public float GetMonto { get; set; }
        public List<Producto> listaProductos { get; set; }
        //metodo
        public bool ContieneProducto(Producto producto)
        {   
            foreach (Producto p in listaProductos)
            {
                if (p.GetNombre == producto.GetNombre)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
