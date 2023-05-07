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
        private List<Producto> productos;
        private Queue<Cliente> clientes;
        private float dineroMax;
        //constructor
        public Vendedor(string mail, string password, List<Producto> productos, Queue<Cliente> clientes, float dineroMax)
        : base(mail, password)
        {
            this.productos = productos;
            this.clientes = clientes;
            this.dineroMax = dineroMax;
        }
        //propiedades
        public List<Producto> GetProductos
        {
            get { return productos; }
        }
        public float GetDineroMax
        {
            get { return dineroMax; }
        }
        //metodos 
    }
}
