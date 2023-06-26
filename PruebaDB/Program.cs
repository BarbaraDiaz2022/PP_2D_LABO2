using BibliotecaDeClases;

namespace PruebaDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Negocio.CargarDBProductos();

            /*List<Producto> productos = ProductosDAO.Leer();
            foreach (Producto item in productos)
            {
                Console.WriteLine(item.GetNombre +" - "+ item.GetId);
            }*/
            //Negocio.CargarDBClientes();
            /*List<Cliente> clientes = UsuariosDAO.LeerClientes();
            foreach (Cliente item in clientes)
            {
                Console.WriteLine(item.GetMetodoDePago+" - "+item.GetMail+" - "+item.GetNombre);
            }*/
            //Negocio.CargarDBVendedores();
            List<Vendedor> vendedores = UsuariosDAO.LeerVendedores();
            foreach (Vendedor item in vendedores)
            {
                Console.WriteLine(item.GetCodigo+" - "+item.GetNombreVendedor+" - "+item.GetMail);
            }
           


        }
    }
}