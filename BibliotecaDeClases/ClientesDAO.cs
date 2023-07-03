using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class ClientesDAO : IUsuariosDAO<Cliente>
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        public ClientesDAO()
        {
            connectionString = @"Data Source=DESKTOP-PQ6P88T;Initial Catalog=SP_LABO2;Integrated Security = True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }
        public void GuardarUsuarios(List<Cliente> listaDeClientes)
        {
            try
            {
                connection.Open();
                foreach (Cliente clientes in listaDeClientes)
                {
                    command.Parameters.Clear();//limpio el buffer de los parametros
                    command.CommandText = $"INSERT INTO CLIENTES (nombre,mail,password,montoDisponible,metodoPago) VALUES (@nombre,@mail,@password,@montoDisponible,@metodoPago)";
                    command.Parameters.AddWithValue("@nombre", clientes.GetNombre);
                    command.Parameters.AddWithValue("@mail", clientes.GetMail);
                    command.Parameters.AddWithValue("@password", clientes.GetPassword);
                    command.Parameters.AddWithValue("@montoDisponible", clientes.GetMontoDisponible);
                    command.Parameters.AddWithValue("@metodoPago", clientes.GetMetodoPago);

                    command.ExecuteNonQuery();
                }
            }
            catch (MiExcepcion ex)
            {
                throw new MiExcepcion($"Error en el metodo guardar clientes:{ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        public List<Cliente> LeerUsuarios()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM CLIENTES";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    clientes.Add(new Cliente(dataReader["nombre"].ToString(), dataReader["mail"].ToString(), dataReader["password"].ToString(), Convert.ToSingle(dataReader["montoDisponible"]), dataReader["metodoPago"].ToString()));
                }
                return clientes;
            }
            catch (MiExcepcion ex)
            {
                throw new MiExcepcion($"Error en el metodo leer clientes:{ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        public bool ValidarUsuarios(string mail, string password)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM CLIENTES WHERE  mail = @mail AND password = @password", connection);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@password", password);

                int cantClientes = Convert.ToInt32(command.ExecuteScalar());

                return cantClientes > 0;
            }
            catch (MiExcepcion ex)
            {
                throw new MiExcepcion($"Error en el metodo validar clientes:{ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        public static string RetornarNombre(string mail)
        {
            try
            {
                string nombreCliente = null;
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT nombre FROM CLIENTES WHERE mail = @mail", connection);
                command.Parameters.AddWithValue("@mail", mail);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nombreCliente = reader.GetString(0);
                    }
                }

                return nombreCliente;
            }
            catch (MiExcepcion ex)
            {
                throw new MiExcepcion($"Error en el metodo retornar nombre:{ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
