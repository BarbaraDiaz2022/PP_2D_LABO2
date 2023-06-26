using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    public class Venta: ISerializable<Venta>
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
        public Venta(string nombre, string cliente, float monto, string vendedor)
        {
            this.GetNombre = nombre;
            this.GetCliente = cliente;
            this.GetMonto = monto;
            this.GetVendedor = vendedor; 
        }
        public Venta()
        { 
        }
        //propiedad
        public string GetNombre { get; set; }
        public string GetCliente { get; set; }
        public float GetMonto { get; set; }
        public List<Producto> listaProductos { get; set; }
        public string GetVendedor { get; set; }
        public eMetodoPago GetMetodoDePago { get; set; }

        public void SerializeJson(List<Venta> listaASerializar)
        {
            using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ventasSerializadasJSON.json"))
            {
                string jsonString = JsonSerializer.Serialize(listaASerializar);
                sw.WriteLine(jsonString);
            }
        }
        public void SerializeXml(List<Venta> listaASerializar)
        {
            using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ventasSerializadasXML.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Venta>));
                xmlSerializer.Serialize(sw, listaASerializar);
            }
        }

        public string DeserializeJson()
        {
            using (StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ventasSerializadasJSON.json"))
            {
                string jsonString = sr.ReadToEnd();

                List<Venta> ventas = JsonSerializer.Deserialize<List<Venta>>(jsonString) as List<Venta>;

                StringBuilder sb = new StringBuilder();

                foreach (Venta item in ventas)
                {
                    sb.AppendLine($"**********");
                    sb.AppendLine($"Vendedor que realizó la venta: {item.GetVendedor}");
                    sb.AppendLine($"Cliente al que se le vendió: {item.GetCliente}");
                    sb.AppendLine($"Método de pago de la venta: {item.GetMetodoDePago}");
                    sb.AppendLine($"Monto vendido: {item.GetMonto}");
                    sb.AppendLine("");

                }
                return sb.ToString();
            }
        }
        public string DeserializeXml()
        {
            using (StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ventasSerializadasXML.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Venta>));

                List<Venta> ventas = xmlSerializer.Deserialize(sr) as List<Venta>;

                StringBuilder sb = new StringBuilder();
                foreach (Venta item in ventas)
                {
                    sb.AppendLine($"**********");
                    sb.AppendLine($"Vendedor que realizó la venta: {item.GetVendedor}");
                    sb.AppendLine($"Cliente al que se le vendió: {item.GetCliente}");
                    sb.AppendLine($"Método de pago de la venta: {item.GetMetodoDePago}");
                    sb.AppendLine($"Monto vendido: {item.GetMonto}");
                    sb.AppendLine("");
                }

                return sb.ToString();

            }
        }
        public static void CargarDB(List<Venta> listaVentas)
        {
            VentaDAO.Guardar(listaVentas);
        }
    }
}
