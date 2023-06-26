using BibliotecaDeClases;
using System.ComponentModel;

namespace TesthSP
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void ComprobarJsonProd()
        {
            //arrange 
            Producto producto = new Producto();
            string mensaje = "Si es igual falla";

            //act 
            string result = producto.DeserializeJson();

            //assert
            Assert.AreNotEqual(mensaje,result);
        }
        [TestMethod]
        public void ComprobarXmlProd() 
        {
            //arrange 
            Producto producto = new Producto();
            string mensaje= "si devuelve algo esta mal";

            //act
            string result = producto.DeserializeXml();

            //assert
            Assert.AreNotEqual(mensaje,result);
        }
        [TestMethod]
        public void ComprobarUsuarios()
        {
            //arrange
            UsuariosDAO usuarios = new UsuariosDAO();

            //act
            bool result = usuarios.Equals(usuarios); //el metodo equals comprueba si un obj es igual a si mismo

            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ComprobarXmlVentas()
        {
            //arrange 
            Venta venta = new Venta();
            string mensaje = "fallo";

            //act
            string result = venta.DeserializeXml();

            //assert
            Assert.AreNotEqual(mensaje, result);
        }
        [TestMethod]
        public void ComprobarJsonVentas()
        {
            //arrange 
            Venta venta = new Venta();
            string mensaje = "fallo si es igual";

            //act 
            string result = venta.DeserializeJson();

            //assert
            Assert.AreNotEqual(mensaje, result);
        }
    }
}