using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Venta
    {
        //atributo
        public string GetCliente { get; set; }
        public List<Producto> Productos { get; set; }
        //constructor
        public Venta(List<Producto> productos, string cliente)
        {
            this.GetCliente = cliente;
            Productos = productos;
        }
        //propiedad
        public static List<Venta> VentasRealizadas { get; set; } = new List<Venta>();
        public bool ContieneProducto(Producto producto)
        {
            foreach (Producto p in Productos)
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
