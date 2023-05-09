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
        private int codigoVendedor;
        private string nombreVendedor;
        //constructor
        public Vendedor(string mail, string password,int codigoVendedor,string nombreVendedor)
        : base(mail, password)
        {
            this.codigoVendedor = codigoVendedor;
            this.nombreVendedor = nombreVendedor;
        }
        //propiedades
        public int GetCodigo
        {
            get { return codigoVendedor; }
        }
        public string GetNombreVendedor
        {
            get { return nombreVendedor; }
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
