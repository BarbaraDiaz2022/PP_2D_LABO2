using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string? message) : base(message)
        {
        }

        public MiExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MiExcepcion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
