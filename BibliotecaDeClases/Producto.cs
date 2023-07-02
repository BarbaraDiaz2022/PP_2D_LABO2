using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    public class Producto : Serializaciones<Producto>
    {
        //atributos
        private string nombre;
        private float stock;
        private float precio;
        private string detalle;
        private string tipoDeCorte;
        private float cantidadSeleccionada;
        private int id;

        public Producto()
        {
        }

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
        //sobrecarga del constructor 
        public Producto(int id, string nombre,string detalle,float precio,float cantidadSeleccionada,float stock,string tipoDeCorte)
        {
            this.id = id;
            this.nombre = nombre;
            this.detalle = detalle;
            this.precio = precio;
            this.cantidadSeleccionada = cantidadSeleccionada;
            this.stock = stock;
            this.tipoDeCorte = tipoDeCorte;
        }
        //propiedades 
        public int GetId { get { return id; } }
        public int SetId
        {
            get { return id; }
            set { id = value; } 
        }
        public string GetNombre { get { return nombre; } }
        public string SetNombre 
        {
            get { return nombre; }
            set { nombre = value; } 
        }
        public float GetStock { get { return stock; } }
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
            get { return precio; }
            set { this.precio = value; }
        }
        public string GetDetalle
        {
            get { return this.detalle; }
        }
        public string SetDetalle
        {
            get { return detalle; }
            set { this.detalle = value; }
        }
        public string GetTipoDeCorte
        {
            get { return this.tipoDeCorte; }
        }
        public string SetTipoDeCorte
        {
            get { return tipoDeCorte; }
            set { this.tipoDeCorte = value; }
        }
        public float GetCantidadSeleccionada
        {
            get { return this.cantidadSeleccionada; }
        }
        public float SetCantidadSeleccionada
        {
            get { return cantidadSeleccionada; }
            set { this.cantidadSeleccionada = value; }
        }

        public static void CargarDB(List<Producto> listaDeProductos) 
        {
            ProductosDAO.Guardar(listaDeProductos);
        }

        public override void SerializeJson(List<Producto> listaASerializar) 
        {
            using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\productosSerializados.json")) 
            {
                string jsonString = JsonSerializer.Serialize(listaASerializar);
                sw.WriteLine(jsonString);
            }
        }
        public override void SerializeXml(List<Producto> listaASerializar) 
        {
            using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\productosSerializadosXml.xml")) 
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Producto>));
                xmlSerializer.Serialize(sw, listaASerializar);
            }
        }

        public override string DeserializeJson() 
        {
            using (StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\productosSerializados.json")) 
            { 
                string jsonString = sr.ReadToEnd();

                List<Producto> producto = JsonSerializer.Deserialize<List<Producto>>(jsonString) as List<Producto>;
                
                StringBuilder sb = new StringBuilder();

                foreach (Producto item in producto) 
                {
                    sb.AppendLine($"**********");
                    sb.AppendLine($"Codigo del producto: {item.GetId}");
                    sb.AppendLine($"Nombre: {item.GetNombre}");
                    sb.AppendLine($"Precio: {item.GetPrecio}");
                    sb.AppendLine($"Stock: {item.GetStock}");
                    sb.AppendLine($"Detalle: {item.GetDetalle}");
                    sb.AppendLine("");

                }
                return sb.ToString();
            }
        }
        public override string DeserializeXml()
        {
            using (StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\productosSerializadosXml.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Producto>));

                List<Producto> producto = xmlSerializer.Deserialize(sr) as List<Producto>;

                StringBuilder sb = new StringBuilder();
                foreach (Producto item in producto)
                {
                    sb.AppendLine($"**********");
                    sb.AppendLine($"Codigo del producto: {item.GetId}");
                    sb.AppendLine($"Nombre: {item.GetNombre}");
                    sb.AppendLine($"Precio: {item.GetPrecio}");
                    sb.AppendLine($"Stock: {item.GetStock}");
                    sb.AppendLine($"Detalle: {item.GetDetalle}");
                    sb.AppendLine("");
                }

                return sb.ToString();

            }
        }
    }
}