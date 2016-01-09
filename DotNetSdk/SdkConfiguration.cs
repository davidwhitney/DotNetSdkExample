using System.Collections;
using System.Collections.Generic;
using DotNetSdk.Http;
using DotNetSdk.Http.SystemNetHttp;
using DotNetSdk.Interception;
using DotNetSdk.Serialization;
using DotNetSdk.Serialization.JsonDotNet;

namespace DotNetSdk
{
    public class SdkConfiguration
    {
        public string ApiKey { get; set; }
        public string BaseUrl { get; set; }

        public IHttpTransport Transport { get; set; }
        public ISerializeMessages Serializer { get; set; }
        public IList<IInterceptRequests> Interceptors { get; set; }

        public SdkConfiguration()
        {
            BaseUrl = "http://some-site.com/";
            Transport = new InterceptingHttpTransport(new SystemNetTransport(), this);
            Serializer = new JsonDotNetSerializer();
        }
    }
}
