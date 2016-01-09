using System.Net.Http;
using DotNetSdk.Models.Resource1;

namespace DotNetSdk.Resources
{
    public class Resource1 : Resource, IResource1
    {
        public Resource1(SdkConfiguration configuration) : base(configuration)
        {
        }

        /// <summary>
        /// Explicit implementation, you can check error codes, all sorts here.
        /// </summary>
        public SomeGetModel Get()
        {
            const string uri = "/resource1";
            var msg = new HttpRequestMessage(HttpMethod.Get, Configuration.BaseUrl + uri);
            var response = Configuration.Transport.MakeRequest(msg);
            return Configuration.Serializer.Deserialize<SomeGetModel>(response.Content.ReadAsStringAsync().Result);
        }
    }
}
