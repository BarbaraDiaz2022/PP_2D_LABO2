using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Serializaciones<T>
    {
        public abstract void SerializeJson(List<T> listaASerializar);

        public abstract void SerializeXml(List<T> listaASerializar);

        public abstract string DeserializeJson();

        public abstract string DeserializeXml();
    }
}
