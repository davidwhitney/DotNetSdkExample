using System;
using System.Net.Http;

namespace DotNetSdk.Interception
{
    public class MethodTimingInterceptor : IInterceptRequests
    {
        public void BeforeHttpRequest(HttpRequestMessage request)
        {
            throw new NotImplementedException();
        }

        public void AfterHttpRequest(HttpRequestMessage request, HttpResponseMessage response)
        {
            throw new NotImplementedException();
        }
    }
}
