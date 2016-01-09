using System;
using System.Linq;
using System.Net.Http;
using DotNetSdk.Interception;

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
            var interceptors = _configuration.Interceptors.Select(Activator.CreateInstance).Cast<IInterceptRequests>().ToList();
            foreach (var interceptor in interceptors)
            {
                interceptor.BeforeHttpRequest(request);
            }

            var response = _actual.MakeRequest(request);

            interceptors.Reverse();
            foreach (var interceptor in interceptors)
            {
                interceptor.AfterHttpRequest(request, response);
            }

            return response;
        }
    }
}