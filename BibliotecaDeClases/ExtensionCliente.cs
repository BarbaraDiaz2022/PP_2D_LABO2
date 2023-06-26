using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class ExtensionCliente
    {
        public static bool PuedeComprar(this Cliente cliente, float montoTotal)
        {
            return cliente.GetMontoDisponible >= montoTotal;
        }
    }
}
