using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Usuario //polimorfismo 
    {
        protected string mail;
        protected string password;

        protected Usuario(string mail, string password)
        {
            this.mail = mail;
            this.password = password;
        }

        public string GetMail
        {
            get { return this.mail; }
        } 
    }
}
