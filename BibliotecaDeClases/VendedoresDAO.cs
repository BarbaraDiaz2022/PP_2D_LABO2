using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class VendedoresDAO : IUsuariosDAO<Vendedor>
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        public VendedoresDAO()
        {
            connectionString = @"Data Source=DESKTOP-PQ6P88T;Initial Catalog=SP_LABO2;Integrated Security = True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public void GuardarUsuarios(List<Vendedor> listaDeVendedores)
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
        public List<Vendedor> LeerUsuarios()
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
        public bool ValidarUsuarios(string mail, string password)
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
    }
}
