using System.Xml.Serialization;

// Adapter -> Converts the IXmlParser interface to the IJsonParser interface
namespace SimpleAdapterCSharp
{
    public class XmlToJsonAdapter<T> : IJsonParser<T>
    {
        public T Parse(string data)
        {
            IXmlParser<T> xmlParser = new XmlParser<T>();
            return xmlParser.Parse(data);
        }
        
        public string ConvertToJson(T obj)
        {
            IJsonParser<T> jsonParser = new JsonParser<T>();
            return jsonParser.ConvertToJson(obj);
        }

    }
}