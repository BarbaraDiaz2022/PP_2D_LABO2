using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public interface ISerializable<T>
    {
        public void SerializeJson(List<T> listaASerializar);

        public void SerializeXml(List<T> listaASerializar);

        public string DeserializeJson();

        public string DeserializeXml();
    }
}
