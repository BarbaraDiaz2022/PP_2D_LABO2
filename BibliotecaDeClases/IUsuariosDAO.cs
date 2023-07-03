using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public interface IUsuariosDAO<T>
    {
        public void GuardarUsuarios(List<T> lista);
        public List<T> LeerUsuarios();
        public bool ValidarUsuarios(string mail, string password);
    }
}
