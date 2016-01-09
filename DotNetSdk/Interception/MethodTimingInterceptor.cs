using System;
using System.Diagnostics;
using System.Net.Http;

namespace DotNetSdk.Interception
{
    public class MethodTimingInterceptor : IInterceptRequests
    {
        private Stopwatch _timer;

        public void BeforeHttpRequest(HttpRequestMessage request)
        {
            _timer = Stopwatch.StartNew();
        }

        public void AfterHttpRequest(HttpRequestMessage request, HttpResponseMessage response)
        {
            _timer.Stop();
        }
    }
}
