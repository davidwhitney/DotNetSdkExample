using System;
using System.Net.Http;

namespace DotNetSdk.Http.SystemNetHttp
{
    public class SystemNetTransport : IHttpTransport
    {
        public HttpResponseMessage MakeRequest(HttpRequestMessage request)
        {
            throw new NotImplementedException();
        }
    }
}