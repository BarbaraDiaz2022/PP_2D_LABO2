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
        public string GetNombreVendedor
        {
            get { return nombreVendedor; }
        }
        public string SetNombreVendedor
        {
            set { this.nombreVendedor = value; }
        }
        public int GetCodigo
        {
            get { return codigoVendedor; }
        }
        public int SetCodigo
        {
            set { this.codigoVendedor = value; }
        }
        //metodos 
        /// <summary>
        /// metodo que calcula el monto total de productos seleccionados en una lista 
        /// </summary>
        /// <param name="productos">lista de tipo producto que contiene los productos a calcular </param>
        /// <returns>retorna un dato de tipo float con el precio total de los productos de acuerdo a su cantidad comprada</returns>
        public static float CalcularMonto(List<Producto> productos)
        {
            float montoTotal = 0;
            foreach (Producto producto in productos)
            {
                montoTotal += producto.GetPrecio * producto.GetCantidadSeleccionada;
            }
            return montoTotal;
        }
        public override string Saludar(string nombre) 
        { 
            return "Usted ingresó como: Vendedor" + base.Saludar(nombre); 
        }
        public static void CargarDBVendedor(List<Vendedor> listaVendedores)
        {
            VendedoresDAO vendedoresDAO = new VendedoresDAO();
            vendedoresDAO.GuardarUsuarios(listaVendedores);
        }
    }
}
