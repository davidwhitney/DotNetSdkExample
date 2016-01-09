using System;
using System.Net.Http;

namespace DotNetSdk.Http
{
    public class InterceptingHttpTransport : IHttpTransport
    {
        private readonly IHttpTransport _actual;

        public InterceptingHttpTransport(IHttpTransport actual)
        {
            _actual = actual;
        }

        public HttpResponseMessage MakeRequest(HttpRequestMessage request)
        {
            throw new NotImplementedException();
        }
    }
}