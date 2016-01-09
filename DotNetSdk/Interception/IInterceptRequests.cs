using System.Net.Http;

namespace DotNetSdk.Interception
{
    public interface IInterceptRequests
    {
        void BeforeHttpRequest(HttpRequestMessage request);
        void AfterHttpRequest(HttpRequestMessage request, HttpResponseMessage response);
    }
}
