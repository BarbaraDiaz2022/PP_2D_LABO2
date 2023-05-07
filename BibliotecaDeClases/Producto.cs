using System.Drawing;

namespace BibliotecaDeClases
{
    public class Producto
    {
        //atributos
        private string nombre;
        private float stock;
        private float precio;
        private string detalle;
        private string tipoDeCorte;
        private float cantidadSeleccionada;
        //constructor 
        public Producto(string nombre, float stock, float precio, string detalle,string tipoDeCorte, float cantidadSeleccionada) 
        {
            this.nombre = nombre;
            this.stock = stock;
            this.precio = precio;
            this.detalle = detalle;
            this.tipoDeCorte = tipoDeCorte;
            this.cantidadSeleccionada = 0;
        }
        //sobrecarga del constructor pero sin el stock visible
        public Producto(string nombre, float precio, string detalle, string tipoDeCorte, float cantidadSeleccionada)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.detalle = detalle;
            this.tipoDeCorte = tipoDeCorte;
            this.cantidadSeleccionada = 0;
        }
        //sobrecarga del constructor pero sin la cantidad visible REVISARR
        public Producto(string nombre, float stock, float precio, string detalle, string tipoDeCorte)
        {
            this.nombre = nombre;
            this.stock = stock;
            this.precio = precio;
            this.detalle = detalle;
            this.tipoDeCorte = tipoDeCorte;
        }

        //propiedades 
        public string GetNombre
        {
            get { return this.nombre; }
        }
        public string SetNombre
        {
            set { this.nombre = value; }
        }
        public float GetStock
        { 
            get { return this.stock; }
        }
        public float SetStock
        {
            get { return stock; }
            set { this.stock = value; }
        }
        public float GetPrecio
        {
            get { return this.precio; }
        }
        public float SetPrecio
        {
            set { this.precio = value; }
        }
        public string GetDetalle
        {
            get { return this.detalle; }
        }
        public string SetDetalle
        {
            set { this.detalle = value; }
        }
        public string GetTipoDeCorte
        {
            get { return this.tipoDeCorte; }
        }
        public string SetTipoDeCorte
        {
            set { this.tipoDeCorte = value; }
        }
        public float GetCantidadSeleccionada
        {
            get { return this.cantidadSeleccionada; }
        }
        public float SetCantidadSeleccionada
        {
            set { this.cantidadSeleccionada = value; }
        }
        //metodos 

    }
}