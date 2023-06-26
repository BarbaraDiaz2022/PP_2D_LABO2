using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class ProductosDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        //es estatica para q sirva la conexion para cada metodo del crud
        static ProductosDAO() 
        {
            connectionString = @"Data Source=DESKTOP-PQ6P88T;Initial Catalog=SP_LABO2;Integrated Security = True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }
        public static void Guardar(List<Producto> listaDeProductos)
        {
            try
            { 
                connection.Open();
                foreach (Producto productos in listaDeProductos)
                {
                    command.Parameters.Clear();//limpio el buffer de los parametros
                    command.CommandText = $"INSERT INTO PRODUCTOS (nombre,precio,detalle,tipoDeCorte,cantidadSeleccionada,stock) VALUES (@nombre,@precio,@detalle,@tipoDeCorte,@cantidadSeleccionada,@stock)";
                    command.Parameters.AddWithValue("@nombre", productos.GetNombre);
                    command.Parameters.AddWithValue("@precio", productos.GetPrecio);
                    command.Parameters.AddWithValue("@detalle", productos.GetDetalle);
                    command.Parameters.AddWithValue("@tipoDeCorte", productos.GetTipoDeCorte);
                    command.Parameters.AddWithValue("@cantidadSeleccionada", productos.GetCantidadSeleccionada);
                    command.Parameters.AddWithValue("@stock", productos.GetStock);
                    command.ExecuteNonQuery();
                }
            }
            catch (MiExcepcion ex)
            {
                throw new MiExcepcion($"Error en el metodo guardar:{ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        public static List<Producto> Leer() 
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM PRODUCTOS";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    productos.Add(new Producto(Convert.ToInt32(dataReader["id"]),dataReader["nombre"].ToString(),dataReader["detalle"].ToString(), Convert.ToSingle(dataReader["precio"]), Convert.ToSingle(dataReader["cantidadSeleccionada"]), Convert.ToSingle(dataReader["stock"]), dataReader["tipoDeCorte"].ToString()));
                }
                return productos;
            }
            catch (MiExcepcion ex)
            {
                throw new MiExcepcion($"Error en el metodo leer:{ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        public static void Eliminar(int id) 
        {
            try 
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM PRODUCTOS WHERE ID = @id";
                command.Parameters.AddWithValue("@id",id);
                command.ExecuteNonQuery();
            }
            catch (MiExcepcion ex)
            {
                throw new MiExcepcion($"Error en el metodo eliminar:{ex.Message}");
            }
            finally 
            {
                connection.Close();
            }
        }
        public static void Modificar(Producto productos) 
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE PRODUCTOS SET nombre = @nombre, precio = @precio, detalle = @detalle, tipoDeCorte = @tipoDeCorte, cantidadSeleccionada = @cantidadSeleccionada, stock = @stock WHERE id = @id";
                command.Parameters.AddWithValue("@nombre", productos.GetNombre);
                command.Parameters.AddWithValue("@precio", productos.GetPrecio);
                command.Parameters.AddWithValue("@detalle", productos.GetDetalle);
                command.Parameters.AddWithValue("@tipoDeCorte", productos.GetTipoDeCorte);
                command.Parameters.AddWithValue("@cantidadSeleccionada", productos.GetCantidadSeleccionada);
                command.Parameters.AddWithValue("@stock", productos.GetStock);
                command.Parameters.AddWithValue("@id", productos.GetId);
                command.ExecuteNonQuery();
            }
            catch (MiExcepcion ex)
            {
                throw new MiExcepcion($"Error en el metodo modificar:{ex.Message}");
            }
            finally 
            {
                connection.Close();
            }
        }
        public static void GuardarNuevoProducto(Producto producto) 
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO PRODUCTOS (nombre,precio,detalle,tipoDeCorte,cantidadSeleccionada,stock) VALUES (@nombre,@precio,@detalle,@tipoDeCorte,@cantidadSeleccionada,@stock); SELECT SCOPE_IDENTITY(); ";
                command.Parameters.AddWithValue("@nombre", producto.GetNombre);
                command.Parameters.AddWithValue("@precio", producto.GetPrecio);
                command.Parameters.AddWithValue("@detalle", producto.GetDetalle);
                command.Parameters.AddWithValue("@tipoDeCorte", producto.GetTipoDeCorte);
                command.Parameters.AddWithValue("@cantidadSeleccionada", producto.GetCantidadSeleccionada);
                command.Parameters.AddWithValue("@stock", producto.GetStock);
                command.ExecuteNonQuery();

                //obtengo el nuevo id que se genero en la base
                int idNuevo = Convert.ToInt32(command.ExecuteScalar());
                //asignar el nuevo id
                producto.SetId = idNuevo;
            }
            catch (MiExcepcion ex) 
            {
                throw new MiExcepcion($"Error en el metodo guardar:{ex.Message}"); 
            }
            finally 
            {
                connection.Close();
            }
        }
        public static void ActualizarListaComprada(Producto producto)
        {
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = "UPDATE PRODUCTOS SET stock = @stock WHERE id = @id";
                command.Parameters.AddWithValue("@stock", producto.GetStock);
                command.Parameters.AddWithValue("@id", producto.GetId);
                command.ExecuteNonQuery();
            }
            catch (MiExcepcion ex) 
            { 
                throw new MiExcepcion($"Error en el metodo actualizar:{ex.Message}");
            }
            finally 
            {
                connection.Close();
            }
        }
    }
}
