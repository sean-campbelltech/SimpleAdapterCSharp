using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleAdapterCSharp
{
    // Target -> The interface the client wants to use
    public interface IJsonParser<T>
    {
        T Parse(string data);
        String ConvertToJson(T obj);
    }
}