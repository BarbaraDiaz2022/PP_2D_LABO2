using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Vendedor : Usuario
    {
        //atributos 
        int codigoVendedor;
        //constructor
        public Vendedor(string mail, string password,int codigoVendedor)
        : base(mail, password)
        {
            this.codigoVendedor = codigoVendedor;
        }
        //propiedades
        public int GetCodigo
        {
            get { return codigoVendedor; }
        }
        //metodos 
        public static float CalcularMonto(List<Producto> productos)
        {
            float montoTotal = 0;
            foreach (Producto producto in productos)
            {
                montoTotal += producto.GetPrecio * producto.GetCantidadSeleccionada;
            }
            return montoTotal;
        }
    }
}
