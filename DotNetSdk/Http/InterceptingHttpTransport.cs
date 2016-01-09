using System;
using System.Net.Http;

namespace DotNetSdk.Http
{
    public class InterceptingHttpTransport : IHttpTransport
    {
        private readonly IHttpTransport _actual;
        private readonly SdkConfiguration _configuration;

        public InterceptingHttpTransport(IHttpTransport actual, SdkConfiguration configuration)
        {
            _actual = actual;
            _configuration = configuration;
        }

        public HttpResponseMessage MakeRequest(HttpRequestMessage request)
        {
            foreach (var interceptor in _configuration.Interceptors)
            {
                interceptor.BeforeHttpRequest(request);
            }

            var response = _actual.MakeRequest(request);

            foreach (var interceptor in _configuration.Interceptors)
            {
                interceptor.AfterHttpRequest(request, response);
            }

            return response;
        }
    }
}