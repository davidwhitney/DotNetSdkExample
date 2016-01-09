using Newtonsoft.Json;

namespace DotNetSdk.Serialization.JsonDotNet
{
    public class JsonDotNetSerializer : ISerializeMessages
    {
        public string Serialize<T>(T type)
        {
            return JsonConvert.SerializeObject(type);
        }

        public T Deserialize<T>(string stringData)
        {
            return JsonConvert.DeserializeObject<T>(stringData);
        }
    }
}