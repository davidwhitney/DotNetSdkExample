using DotNetSdk.Http;
using DotNetSdk.Http.SystemNetHttp;
using DotNetSdk.Serialization;
using DotNetSdk.Serialization.JsonDotNet;

namespace DotNetSdk
{
    public class SdkConfiguration
    {
        public string ApiKey { get; set; }
        public string Environment { get; set; }

        public IHttpTransport Transport { get; set; }
        public ISerializeMessages Serializer { get; set; }

        public SdkConfiguration()
        {
            Transport = new InterceptingHttpTransport(new SystemNetTransport());
            Serializer = new JsonDotNetSerializer();
        }
    }
}
