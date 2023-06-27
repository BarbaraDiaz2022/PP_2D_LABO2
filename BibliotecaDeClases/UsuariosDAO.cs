using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class UsuariosDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static UsuariosDAO() 
        {
            connectionString = @"Data Source=DESKTOP-PQ6P88T;Initial Catalog=SP_LABO2;Integrated Security = True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static void GuardarClientes(List<Cliente> listaDeClientes)
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
        public static List<Cliente> LeerClientes()
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

        public static bool ValidarClientes(string mail, string password) 
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM CLIENTES WHERE  mail = @mail AND password = @password",connection);
                command.Parameters.AddWithValue("@mail",mail);
                command.Parameters.AddWithValue("@password",password);

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
        //para los vendedores 
        public static void GuardarVendedores(List<Vendedor> listaDeVendedores)
        {
            try
            {
                connection.Open();
                foreach (Vendedor vendedor in listaDeVendedores)
                {
                    command.Parameters.Clear();//limpio el buffer de los parametros
                    command.CommandText = $"INSERT INTO VENDEDORES (mail,password,codigoVendedor,nombreVendedor) VALUES (@mail,@password,@codigoVendedor,@nombreVendedor)";
                    command.Parameters.AddWithValue("@mail", vendedor.GetMail);
                    command.Parameters.AddWithValue("@password", vendedor.GetPassword);
                    command.Parameters.AddWithValue("@codigoVendedor", vendedor.GetCodigo);
                    command.Parameters.AddWithValue("@nombreVendedor", vendedor.GetNombreVendedor);

                    command.ExecuteNonQuery();
                }
            }
            catch (MiExcepcion ex) 
            {  
                throw new MiExcepcion($"Error en el metodo guardar vendedores:{ex.Message}"); 
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Vendedor> LeerVendedores()
        {
            List<Vendedor> vendedores = new List<Vendedor>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM VENDEDORES";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    vendedores.Add(new Vendedor(dataReader["mail"].ToString(), dataReader["password"].ToString(), Convert.ToInt32(dataReader["codigoVendedor"]), dataReader["nombreVendedor"].ToString()));
                }
                return vendedores;
            }
            catch (MiExcepcion ex)
            {
                throw new MiExcepcion($"Error en el metodo leer vendedores:{ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool ValidarVendedores(string mail, string password)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM VENDEDORES WHERE  mail = @mail AND password = @password", connection);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
            catch (MiExcepcion ex) 
            { 
                throw new MiExcepcion($"Error en el metodo validar vendedores:{ex.Message}"); 
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
                SqlCommand command = new SqlCommand("SELECT nombre FROM CLIENTES WHERE mail = @mail",connection);
                command.Parameters.AddWithValue("@mail",mail);

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
