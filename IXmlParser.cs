using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleAdapterCSharp
{
    // Adaptee -> The interface that is incompatible with the target interface
    public interface IXmlParser<T>
    {
        T Parse(string data);
        String ConvertToXml(T obj);
    }
}