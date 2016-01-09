using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSdk.Http
{
    public interface IHttpTransport
    {
        HttpResponseMessage MakeRequest(HttpRequestMessage request);
    }
}
