using System.Net.Http;
using DotNetSdk.Interception;

namespace DotNetSdk.Test.Unit
{
    public class MyRandomInterceptor : IInterceptRequests
    {
        public void BeforeHttpRequest(HttpRequestMessage request)
        {
        }

        public void AfterHttpRequest(HttpRequestMessage request, HttpResponseMessage response)
        {
        }
    }
}