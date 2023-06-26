using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class VentaDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static VentaDAO()
        {
            connectionString = @"Data Source=DESKTOP-PQ6P88T;Initial Catalog=SP_LABO2;Integrated Security = True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

        }
        public static void Guardar(List<Venta> listaDeVentas)
        {
            try
            {
                connection.Open();
                foreach (Venta venta in listaDeVentas)
                {
                    foreach (Producto producto in venta.listaProductos) 
                    {
                        command.Parameters.Clear();//limpio el buffer de los parametros
                        command.CommandText = $"INSERT INTO HISTORIAL (productos,cliente,montoTotal,vendedor) VALUES (@productos,@cliente,@montoTotal,@vendedor)";
                        command.Parameters.AddWithValue("@productos", producto.GetNombre);
                        command.Parameters.AddWithValue("@cliente", venta.GetCliente);
                        command.Parameters.AddWithValue("@montoTotal", venta.GetMonto);
                        command.Parameters.AddWithValue("@vendedor", venta.GetVendedor);
                    }
                    command.ExecuteNonQuery();
                }
            }
            catch (MiExcepcion ex)
            {
                throw new MiExcepcion($"Error en el guardado de base de datos: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        public static List<Venta> Leer()
        {
            List<Venta> ventas = new List<Venta>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM HISTORIAL";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    ventas.Add(new Venta(dataReader["productos"].ToString(), dataReader["cliente"].ToString(), Convert.ToSingle(dataReader["montoTotal"]), dataReader["vendedor"].ToString()));
                }
                return ventas;
            }
            catch (MiExcepcion ex)
            {
                throw new MiExcepcion($"Error en la lectura de base de datos: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
