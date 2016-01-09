using System;
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
        public IList<Type> Interceptors { get; set; }

        public SdkConfiguration()
        {
            BaseUrl = "http://some-site.com/";
            Interceptors = new List<Type>
            {
                typeof (MethodTimingInterceptor)
            };
            Transport = new InterceptingHttpTransport(new SystemNetTransport(), this);
            Serializer = new JsonDotNetSerializer();
        }

        public SdkConfiguration WithInterceptor<T>()
        {
            Interceptors.Add(typeof(T));
            return this;
        }
    }
}
